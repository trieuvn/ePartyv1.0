using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class FormOrderList : Form
    {
        private string eventName;
        private List<string> foodList;
        public FormOrderList(string name, List<string> foods)
        {
            InitializeComponent();
            this.eventName = name;
            this.foodList = foods;
            LoadOrders(null, null);
        }

        public FormOrderList()
        {
            InitializeComponent();
            LoadOrders(null, null);
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            radio7Days.CheckedChanged += radioButton_CheckedChanged;
            radio1Month.CheckedChanged += radioButton_CheckedChanged;
            radioAll.CheckedChanged += radioButton_CheckedChanged;

            radioAll.Checked = true; // Mặc định hiển thị tất cả đơn hàng
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio7Days.Checked)
            {
                LoadOrders(DateTime.Now, DateTime.Now.AddDays(7)); // Lọc 7 ngày kế tiếp
            }
            else if (radio1Month.Checked)
            {
                LoadOrders(DateTime.Now, DateTime.Now.AddMonths(1)); // Lọc 1 tháng kế tiếp
            }
            else // Mặc định là hiển thị tất cả
            {
                LoadOrders(null, null);
            }
        }

        private void LoadOrders(DateTime? startDate, DateTime? endDate)
        {
            listViewOrders.Items.Clear();

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    var query = context.Orders
                        .AsNoTracking()
                        .AsQueryable();

                    if (startDate.HasValue && endDate.HasValue)
                    {
                        query = query.Where(o => o.BeginTime >= startDate && o.EndTime <= endDate);
                    }

                    var orders = query.ToList();

                    foreach (var order in orders)
                    {
                        ListViewItem item = new ListViewItem(order.Id.ToString());
                        item.SubItems.Add(order.Description ?? "N/A");
                        item.SubItems.Add(order.NoTables?.ToString() ?? "0");
                        item.SubItems.Add(order.BeginTime?.ToString("dd/MM/yyyy HH:mm") ?? "N/A");
                        item.SubItems.Add(order.EndTime?.ToString("dd/MM/yyyy HH:mm") ?? "N/A");
                        item.SubItems.Add(order.Feedback ?? "N/A");
                        listViewOrders.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio1Month_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi radio button 1 tháng được chọn
        }

        private void btnOpenSchedule_Click(object sender, EventArgs e)
        {
            DateTime currentWeekStart = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
            FormSchedule scheduleForm = new FormSchedule(currentWeekStart);
            scheduleForm.Show();
        }

        public void LoadSchedule(DateTime weekStart)
        {
            MessageBox.Show($"Tuần bắt đầu từ: {weekStart:dd/MM/yyyy} (Thứ {(int)weekStart.DayOfWeek})");

            using (var context = new ePartyDbDbContext())
            {
                var startOfWeek = weekStart.Date;
                var endOfWeek = startOfWeek.AddDays(6).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                var orders = context.Orders
                    .Where(o => o.BeginTime >= startOfWeek && o.BeginTime <= endOfWeek)
                    .OrderBy(o => o.BeginTime)
                    .ToList();

                Dictionary<string, List<Order>> schedule = new Dictionary<string, List<Order>>
                {
                    { "Sáng", new List<Order>() },
                    { "Chiều", new List<Order>() },
                    { "Tối", new List<Order>() }
                };

                foreach (var order in orders)
                {
                    string timeSlot = GetTimeSlot(order.BeginTime);
                    schedule[timeSlot].Add(order);
                }

                // Hiển thị thông báo hoặc xử lý dữ liệu schedule
                MessageBox.Show($"Lấy được {orders.Count} sự kiện từ database!\nTuần bắt đầu: {startOfWeek:dd/MM/yyyy}");
            }
        }

        private string GetTimeSlot(DateTime? time)
        {
            if (!time.HasValue) return "Không xác định";

            if (time.Value.Hour >= 6 && time.Value.Hour < 11) return "Sáng";
            else if (time.Value.Hour >= 13 && time.Value.Hour < 18) return "Chiều";
            else return "Tối";
        }

        
    }
}