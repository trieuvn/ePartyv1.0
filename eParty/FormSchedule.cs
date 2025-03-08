using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Context;
using BOLayer.Repository;
using BOLayer.Repository.Models;

namespace eParty
{
    public partial class FormSchedule : Form
    {
        /*private DateTime currentWeek;
        private TableLayoutPanel tableLayout;
        private Label lblWeekTitle; // Thêm biến lưu tiêu đề tuần

        public FormSchedule(DateTime weekStart)
        {
            InitializeComponent();
            currentWeek = weekStart;

            InitializeUI();
            LoadSchedule(currentWeek);
        }

        private void InitializeUI()
        {
            this.Text = "Thời Khóa Biểu Tuần";
            this.Size = new Size(1000, 600);

            // Cập nhật tiêu đề tuần theo ngày tháng
            lblWeekTitle = new Label()
            {
                Text = $"Tuần ({currentWeek:dd/MM} - {currentWeek.AddDays(6):dd/MM})",
                AutoSize = true,
                Location = new Point(450, 25),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            Button btnPreviousWeek = new Button() { Text = "< Tuần trước", Location = new Point(20, 20) };
            Button btnNextWeek = new Button() { Text = "Tuần sau >", Location = new Point(850, 20) };

            btnPreviousWeek.Click += (s, e) =>
            {
                currentWeek = currentWeek.AddDays(-7);
                LoadSchedule(currentWeek);
                lblWeekTitle.Text = $"Tuần ({currentWeek:dd/MM} - {currentWeek.AddDays(6):dd/MM})";
            };

            btnNextWeek.Click += (s, e) =>
            {
                currentWeek = currentWeek.AddDays(7);
                LoadSchedule(currentWeek);
                lblWeekTitle.Text = $"Tuần ({currentWeek:dd/MM} - {currentWeek.AddDays(6):dd/MM})";
            };

            // Tạo bảng thời khóa biểu với 8 cột (Thứ) và 5 dòng (Sáng, Chiều, Tối, Khác)
            tableLayout = new TableLayoutPanel()
            {
                Location = new Point(20, 60),
                Size = new Size(950, 500),
                ColumnCount = 8,
                RowCount = 5,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true
            };

            string[] headers = { "Buổi/Thứ", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
            string[] timeSlots = { "Sáng (6h - 11h30)", "Chiều (13h - 18h30)", "Tối (19h - 00h)", "Khác" };

            for (int i = 0; i < headers.Length; i++)
            {
                tableLayout.Controls.Add(new Label()
                {
                    Text = headers[i],
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                }, i, 0);
            }

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Label lblTimeSlot = new Label()
                {
                    Text = timeSlots[i],
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Size = new Size(120, 50), // Tăng kích thước ngang & dọc để không bị cắt chữ
                    BorderStyle = BorderStyle.FixedSingle // Tạo đường viền giúp dễ nhìn hơn
                };
                tableLayout.Controls.Add(lblTimeSlot, 0, i + 1);
            }

            this.Controls.Add(btnPreviousWeek);
            this.Controls.Add(btnNextWeek);
            this.Controls.Add(lblWeekTitle);
            this.Controls.Add(tableLayout);
        }

        public void LoadSchedule(DateTime weekStart)
        {
            using (var context = new ApplicationDbContext())
            {
                var startOfWeek = weekStart.Date;
                var endOfWeek = startOfWeek.AddDays(6).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                // Lấy danh sách đơn hàng trong tuần
                var orders = context.orders
                    .Where(o => o.BeginTime >= startOfWeek && o.BeginTime <= endOfWeek)
                    .OrderBy(o => o.BeginTime)
                    .ToList();

                // Nhóm đơn hàng theo khung giờ
                Dictionary<string, List<Order>> schedule = new Dictionary<string, List<Order>>
                {
                    { "Sáng", new List<Order>() },
                    { "Chiều", new List<Order>() },
                    { "Tối", new List<Order>() },
                    { "Khác", new List<Order>() }
                };

                foreach (var order in orders)
                {
                    string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);
                    schedule[timeSlot].Add(order);
                }

                // Xóa dữ liệu cũ trước khi cập nhật
                for (int col = 1; col <= 7; col++)
                {
                    for (int row = 1; row <= 4; row++) // Xóa 4 dòng: Sáng, Chiều, Tối, Khác
                    {
                        Control existingControl = tableLayout.GetControlFromPosition(col, row);
                        if (existingControl != null)
                            tableLayout.Controls.Remove(existingControl);
                    }
                }

                // Hiển thị dữ liệu mới
                for (int col = 1; col <= 7; col++) // Lặp qua các cột từ Thứ 2 đến Chủ Nhật
                {
                    DateTime day = weekStart.AddDays(col - 1);
                    HashSet<int> displayedEvents = new HashSet<int>(); // Tránh hiển thị sự kiện trùng

                    List<Order> ordersOnDay = schedule.Values.SelectMany(list => list)
                        .Where(o => o.BeginTime.Date == day.Date)
                        .ToList();

                    foreach (var order in ordersOnDay)
                    {
                        string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);

                        // Nếu sự kiện đã xuất hiện ở Sáng/Chiều/Tối thì chuyển sang cột "Khác"
                        if (displayedEvents.Contains(order.Id))
                        {
                            timeSlot = "Khác";
                        }

                        int rowIndex = timeSlot == "Sáng" ? 1 :
                                       timeSlot == "Chiều" ? 2 :
                                       timeSlot == "Tối" ? 3 : 4; // Nếu không thuộc Sáng/Chiều/Tối -> Khác

                        Label lblData = (Label)tableLayout.GetControlFromPosition(col, rowIndex);
                        if (lblData == null)
                        {
                            lblData = new Label()
                            {
                                AutoSize = true,
                                Font = new Font("Arial", 9, FontStyle.Regular),
                                TextAlign = ContentAlignment.MiddleLeft,
                                Text = ""
                            };
                            tableLayout.Controls.Add(lblData, col, rowIndex);
                        }

                        lblData.Text += $"{order.Description}\n" +
                                        $"{order.NoTables} bàn\n" +
                                        $"{order.BeginTime:HH:mm} - {order.EndTime:HH:mm}\n" +
                                        $"{order.Manager}\n\n";

                        displayedEvents.Add(order.Id); // Đánh dấu sự kiện đã hiển thị
                    }
                }
            }
        }

        private string GetTimeSlot(DateTime startTime, DateTime endTime)
        {
            bool isMorning = startTime.Hour >= 6 && endTime.Hour < 12
                             || (endTime.Hour == 12 && endTime.Minute <= 30);
            bool isAfternoon = startTime.Hour >= 13 && endTime.Hour < 18
                               || (endTime.Hour == 18 && endTime.Minute <= 30);
            bool isEvening = startTime.Hour >= 19 && endTime.Hour < 24;

            if (isMorning) return "Sáng";
            if (isAfternoon) return "Chiều";
            if (isEvening) return "Tối";

            return "Khác"; // Nếu sự kiện trải dài qua nhiều khung giờ, đưa vào "Khác"
        }
        */
    }
}