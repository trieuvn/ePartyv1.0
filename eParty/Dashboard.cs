﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class Dashboard : Form
    {
        public struct RevenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }

        private ePartyDbDbContext _context;
        public string username;
        public List<RevenueByDate> GrossRevenueList { get; private set; }

        public Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
            _context = new ePartyDbDbContext();

            // Configure DataGridView
            ConfigureDataGridView();

            LoadDashboardData();
        }

        private void ConfigureDataGridView()
        {
            // Ensure columns are properly defined
            DataOrderStatus.Columns.Clear();
            DataOrderStatus.Columns.Add("OrderId", "Order ID");
            DataOrderStatus.Columns.Add("Status", "Order Status");

            // Set column properties
            DataOrderStatus.Columns["OrderId"].Width = 100;
            DataOrderStatus.Columns["Status"].Width = 150;

            // Enable auto-size for rows to prevent overlapping
            DataOrderStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataOrderStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set row template height to ensure text doesn't overlap
            DataOrderStatus.RowTemplate.Height = 30;

            // Disable user resizing to avoid layout issues
            DataOrderStatus.AllowUserToResizeRows = false;

            // Ensure the DataGridView refreshes properly
            DataOrderStatus.Refresh();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Load dữ liệu cho các label
                LoadLabels();

                // Load dữ liệu cho các chart
                LoadChartAnnual();
                LoadChartTotalOrder();
                LoadChartTotalProfit();

                // Load dữ liệu cho DataGridView
                LoadDataOrderStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLabels()
        {
            // Tổng số đơn hàng (Total Number of Orders)
            int totalOrders = _context.Orders.Where(o => o.Manager == username).Count();
            lbTotalNumber.Text = totalOrders.ToString();

            // Tổng số nhân viên (Total Staff)
            int totalStaff = _context.Staff.Where(o => o.Manager == username).Count();
            lbTotalStaff.Text = totalStaff.ToString();

            // Số lượng phản hồi (Feedback - đếm số Order có Feedback không null)
            int feedbackCount = _context.Orders.Where(o => o.Manager == username).Count(o => !string.IsNullOrEmpty(o.Feedback));
            lbFeedBack.Text = feedbackCount.ToString();

            // Tổng lợi nhuận (Total Profit - tính từ Order và OrderHaveFood)
            decimal totalProfit = _context.OrderHaveFoods
                .Where(ohf => ohf.Order.Status == true && ohf.Order.Manager == username) // Chỉ tính đơn hàng đã hoàn thành
                .Join(_context.Foods,
                    ohf => ohf.FoodId,
                    f => f.Id,
                    (ohf, f) => new { ohf, f })
                .Sum(x => (decimal?)(x.ohf.Amount * x.f.Cost)) ?? 0;
            lbProfit.Text = totalProfit.ToString("#,##0 VND");
        }

        private void LoadChartAnnual()
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime startDate = today.AddDays(-30);

                var revenueData = _context.Orders
                    .Where(o => o.Status == true && o.BeginTime.HasValue && o.BeginTime.Value >= startDate && o.BeginTime.Value <= today && o.ActualCost.HasValue && o.Manager == username)
                    .GroupBy(o => o.BeginTime.Value.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(o => o.ActualCost.Value)
                    })
                    .ToList()
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Date.ToString("dd MMM"),
                        TotalAmount = g.TotalAmount
                    })
                    .OrderBy(r => r.Date)
                    .ToList();

                GrossRevenueList = revenueData;

                int index = 0;
                foreach (var item in GrossRevenueList)
                {
                    int pointIndex = chartAnnual.Series[0].Points.AddXY(index, item.TotalAmount);
                    chartAnnual.Series[0].Points[pointIndex].AxisLabel = item.Date;
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartTotalOrder()
        {
            // Xóa dữ liệu cũ
            chartTotalOrder.Series["Series1"].Points.Clear();

            // Đếm số đơn hàng theo trạng thái (Status: true/false)
            var ordersByStatus = _context.Orders
                .Where(o => o.Manager == username)
                .GroupBy(o => o.Status)
                .Select(g => new
                {
                    Status = g.Key.HasValue ? (g.Key.Value ? "Completed" : "Pending") : "Unknown",
                    Count = g.Count()
                })
                .ToList();

            // Thêm dữ liệu vào chart
            foreach (var item in ordersByStatus)
            {
                chartTotalOrder.Series["Series1"].Points.AddXY(item.Status, item.Count);
            }
        }

        private void LoadChartTotalProfit()
        {
            // Xóa dữ liệu cũ
            chartTotalProfit.Series["Series1"].Points.Clear();

            // Đảm bảo chart là loại Doughnut
            chartTotalProfit.Series["Series1"].ChartType = SeriesChartType.Doughnut;

            // Tính tổng lợi nhuận từ Food (Food Profit)
            decimal foodProfit = _context.OrderHaveFoods
                .Where(ohf => ohf.Order.Status == true && ohf.Order.Manager == username)
                .Join(_context.Foods,
                    ohf => ohf.FoodId,
                    f => f.Id,
                    (ohf, f) => new { ohf, f })
                .Sum(x => (decimal?)(x.ohf.Amount * x.f.Cost)) ?? 0;

            // Giả định: Ingredient Profit là 30% của Food Profit, Staff Profit là 20% của Food Profit
            decimal ingredientCostPercentage = 0.30m; // 30%
            decimal staffCostPercentage = 0.20m; // 20%

            // Tính Ingredient Profit (lợi nhuận sau khi trừ chi phí nguyên liệu)
            decimal ingredientCost = foodProfit * ingredientCostPercentage;
            decimal ingredientProfit = foodProfit - ingredientCost;

            // Tính Staff Profit (lợi nhuận sau khi trừ chi phí nhân viên)
            decimal staffCost = foodProfit * staffCostPercentage;
            decimal staffProfit = foodProfit - staffCost;

            // Food Profit là lợi nhuận còn lại sau khi trừ Ingredient Profit và Staff Profit
            decimal adjustedFoodProfit = foodProfit - ingredientProfit - staffProfit;

            // Thêm dữ liệu vào chart
            chartTotalProfit.Series["Series1"].Points.AddXY("Staff Profit", staffProfit);
            chartTotalProfit.Series["Series1"].Points.AddXY("Food Profit", adjustedFoodProfit);
            chartTotalProfit.Series["Series1"].Points.AddXY("Ingredient Profit", ingredientProfit);

            // Hiển thị giá trị tổng lợi nhuận ở giữa donut chart
            chartTotalProfit.Series["Series1"]["PieLabelStyle"] = "Outside"; // Hiển thị nhãn bên ngoài
            chartTotalProfit.Series["Series1"]["DoughnutRadius"] = "60"; // Điều chỉnh kích thước vòng tròn giữa
            chartTotalProfit.Titles.Clear();
            chartTotalProfit.Titles.Add(new Title($"Total Profit\n{foodProfit:#,##0}", Docking.Top, new System.Drawing.Font("Arial", 12), System.Drawing.Color.Black));
        }

        private void LoadDataOrderStatus()
        {
            if (DataOrderStatus.InvokeRequired)
            {
                DataOrderStatus.Invoke(new Action(LoadDataOrderStatus));
                return;
            }

            try
            {
                DataOrderStatus.SuspendLayout();

                DataOrderStatus.Rows.Clear();

                var orders = _context.Orders
                    .Where(o => o.Manager == username)
                    .Select(o => new
                    {
                        o.Id,
                        Status = o.Status.HasValue ? (o.Status.Value ? "Completed" : "Pending") : "Unknown"
                    })
                    .ToList();

                foreach (var order in orders)
                {
                    DataOrderStatus.Rows.Add(order.Id, order.Status);
                }

                DataOrderStatus.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order status data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataOrderStatus.ResumeLayout();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click trên chart (nếu cần)
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void DataOrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}