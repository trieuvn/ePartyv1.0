using System;
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
        private ePartyDbDbContext _context;
        public string username;
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
            int totalOrders = _context.Orders.Count();
            lbTotalNumber.Text = totalOrders.ToString();

            // Tổng số nhân viên (Total Staff)
            int totalStaff = _context.Staff.Count();
            lbTotalStaff.Text = totalStaff.ToString();

            // Số lượng phản hồi (Feedback - đếm số Order có Feedback không null)
            int feedbackCount = _context.Orders.Count(o => !string.IsNullOrEmpty(o.Feedback));
            lbFeedBack.Text = feedbackCount.ToString();

            // Tổng lợi nhuận (Total Profit - tính từ Order và OrderHaveFood)
            decimal totalProfit = _context.OrderHaveFoods
                .Where(ohf => ohf.Order.Status == true) // Chỉ tính đơn hàng đã hoàn thành
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
                // Xóa dữ liệu cũ
                chartAnnual.Series.Clear();
                chartAnnual.ChartAreas[0].AxisX.Title = "Month/Year";
                chartAnnual.ChartAreas[0].AxisY.Title = "Total Profit (VND)";
                chartAnnual.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0 VND";

                // Tạo series cho Total Profit
                Series profitSeries = new Series("Total Profit")
                {
                    ChartType = SeriesChartType.Column, // Sử dụng cột để dễ nhìn hơn
                    Color = Color.DodgerBlue,
                    IsValueShownAsLabel = true, // Hiển thị giá trị trên cột
                    LabelFormat = "#,##0 VND"
                };

                // Tạo series cho số lượng đơn hàng (để so sánh)
                Series orderCountSeries = new Series("Order Count")
                {
                    ChartType = SeriesChartType.Line, // Dùng đường để phân biệt với cột
                    Color = Color.Orange,
                    YAxisType = AxisType.Secondary, // Sử dụng trục Y phụ
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8
                };

                // Thêm các series vào chart
                chartAnnual.Series.Add(profitSeries);
                chartAnnual.Series.Add(orderCountSeries);

                // Tạo trục Y phụ cho số lượng đơn hàng
                chartAnnual.ChartAreas[0].AxisY2.Title = "Number of Orders";
                chartAnnual.ChartAreas[0].AxisY2.LabelStyle.Format = "0";
                chartAnnual.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

                // Lấy dữ liệu tổng giá trị đơn hàng và số lượng đơn hàng theo tháng từ Order và OrderHaveFood
                var profitByMonth = _context.OrderHaveFoods
                    .Where(ohf => ohf.Order.Status == true && ohf.Order.BeginTime.HasValue)
                    .Join(_context.Foods,
                        ohf => ohf.FoodId,
                        f => f.Id,
                        (ohf, f) => new { ohf, f })
                    .GroupBy(x => new { x.ohf.Order.BeginTime.Value.Year, x.ohf.Order.BeginTime.Value.Month })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        Year = g.Key.Year,
                        TotalProfit = g.Sum(x => x.ohf.Amount * x.f.Cost),
                        OrderCount = g.Select(x => x.ohf.OrderId).Distinct().Count(), // Đếm số đơn hàng duy nhất
                        OrderIds = g.Select(x => x.ohf.OrderId).Distinct().ToList() // Lưu danh sách OrderId để tooltip
                    })
                    .OrderBy(g => g.Year).ThenBy(g => g.Month)
                    .ToList();

                // Thêm dữ liệu vào chart
                foreach (var item in profitByMonth)
                {
                    string monthYearLabel = $"{item.Month}/{item.Year}";

                    // Thêm điểm cho Total Profit
                    int profitPointIndex = profitSeries.Points.AddXY(monthYearLabel, item.TotalProfit);
                    DataPoint profitPoint = profitSeries.Points[profitPointIndex];

                    // Thêm điểm cho Order Count
                    int orderPointIndex = orderCountSeries.Points.AddXY(monthYearLabel, item.OrderCount);
                    DataPoint orderPoint = orderCountSeries.Points[orderPointIndex];

                    // Tính lợi nhuận trung bình mỗi đơn hàng
                    decimal avgProfitPerOrder = (decimal)(item.OrderCount > 0 ? item.TotalProfit / item.OrderCount : 0);

                    // Thêm tooltip chi tiết cho điểm Total Profit
                    profitPoint.ToolTip = $"Month/Year: {monthYearLabel}\n" +
                                          $"Total Profit: {item.TotalProfit:#,##0 VND}\n" +
                                          $"Number of Orders: {item.OrderCount}\n" +
                                          $"Average Profit per Order: {avgProfitPerOrder:#,##0 VND}\n" +
                                          $"Order IDs: {string.Join(", ", item.OrderIds)}";

                    // Thêm tooltip cho điểm Order Count
                    orderPoint.ToolTip = $"Month/Year: {monthYearLabel}\n" +
                                         $"Number of Orders: {item.OrderCount}\n" +
                                         $"Total Profit: {item.TotalProfit:#,##0 VND}\n" +
                                         $"Average Profit per Order: {avgProfitPerOrder:#,##0 VND}";
                }

                // Tùy chỉnh giao diện chart
                chartAnnual.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo hiển thị tất cả các nhãn
                chartAnnual.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn để dễ đọc
                chartAnnual.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới trục X
                chartAnnual.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Lưới trục Y nhẹ hơn
                chartAnnual.ChartAreas[0].AxisY2.MajorGrid.Enabled = false; // Tắt lưới trục Y phụ

                // Thêm legend (chú thích)
                chartAnnual.Legends.Clear();
                Legend legend = new Legend
                {
                    Docking = Docking.Top,
                    Alignment = StringAlignment.Center
                };
                chartAnnual.Legends.Add(legend);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Annual Growth chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartTotalOrder()
        {
            // Xóa dữ liệu cũ
            chartTotalOrder.Series["Series1"].Points.Clear();

            // Đếm số đơn hàng theo trạng thái (Status: true/false)
            var ordersByStatus = _context.Orders
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

            // Lấy dữ liệu tổng giá trị đơn hàng theo tháng từ Order và OrderHaveFood
            var profitByMonth = _context.OrderHaveFoods
                .Where(ohf => ohf.Order.Status == true && ohf.Order.BeginTime.HasValue)
                .Join(_context.Foods,
                    ohf => ohf.FoodId,
                    f => f.Id,
                    (ohf, f) => new { ohf, f })
                .GroupBy(x => x.ohf.Order.BeginTime.Value.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalProfit = g.Sum(x => x.ohf.Amount * x.f.Cost)
                })
                .OrderBy(g => g.Month)
                .ToList();

            // Thêm dữ liệu vào chart
            foreach (var item in profitByMonth)
            {
                chartTotalProfit.Series["Series1"].Points.AddXY(item.Month, item.TotalProfit);
            }
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
    }
}