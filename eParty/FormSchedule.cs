using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;

namespace eParty
{
    public partial class FormSchedule : Form
    {
        private void FormSchedule_Load(object sender, EventArgs e)
        {

        }
        private DateTime currentWeek;
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
            { "Tối", new List<Order>() },
            { "Khác", new List<Order>() }
        };

                foreach (var order in orders)
                {
                    if (!order.BeginTime.HasValue || !order.EndTime.HasValue) continue;

                    string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);
                    schedule[timeSlot].Add(order);
                }

                // Xóa dữ liệu cũ trước khi cập nhật
                for (int col = 1; col <= 7; col++)
                {
                    for (int row = 1; row <= 4; row++)
                    {
                        Control existingControl = tableLayout.GetControlFromPosition(col, row);
                        if (existingControl != null)
                            tableLayout.Controls.Remove(existingControl);
                    }
                }

                // Hiển thị dữ liệu mới
                for (int col = 1; col <= 7; col++)
                {
                    DateTime day = weekStart.AddDays(col - 1);
                    HashSet<int> displayedEvents = new HashSet<int>();

                    List<Order> ordersOnDay = schedule.Values.SelectMany(list => list)
                        .Where(o => o.BeginTime.HasValue && o.BeginTime.Value.Date == day.Date)
                        .ToList();

                    foreach (var order in ordersOnDay)
                    {
                        if (!order.BeginTime.HasValue || !order.EndTime.HasValue) continue;

                        string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);
                        if (displayedEvents.Contains(order.Id)) timeSlot = "Khác";

                        int rowIndex = timeSlot == "Sáng" ? 1 :
                                       timeSlot == "Chiều" ? 2 :
                                       timeSlot == "Tối" ? 3 : 4;

                        Label lblData = new Label()
                        {
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleLeft,
                            ForeColor = Color.Blue, // Làm nổi bật để thấy rõ
                            Cursor = Cursors.Hand,  // Biến thành hình bàn tay khi hover
                            Text = $"{order.Description}\n{order.NoTables} bàn\n{order.BeginTime:HH:mm} - {order.EndTime:HH:mm}\n{order.Manager}"
                        };

                        // 🟢 Thêm sự kiện Click để mở chi tiết tiệc
                        lblData.Click += (s, e) => OpenPartyDetails(order);

                        tableLayout.Controls.Add(lblData, col, rowIndex);
                        displayedEvents.Add(order.Id);
                    }
                }
            }
        }
        private void OpenPartyDetails(Order order)
        {
            PartyDetails partyDetailsForm = new PartyDetails(
        order.Id,
        order.Description ?? "Không có mô tả", // Nếu null, thay thế bằng chuỗi mặc định
        order.NoTables ?? 0,  // ✅ Chuyển nullable int thành int, nếu null thì mặc định là 0
        order.BeginTime?.ToString("dd/MM/yyyy HH:mm") ?? "Chưa xác định", // Xử lý null
        order.EndTime?.ToString("dd/MM/yyyy HH:mm") ?? "Chưa xác định",   // Xử lý null
        order.Manager ?? "Không có quản lý", // Nếu null, thay thế bằng chuỗi mặc định
        order.Feedback ?? "Không có feedback" // Nếu null, thay thế bằng chuỗi mặc định
    );

            partyDetailsForm.ShowDialog();
        }


        private string GetTimeSlot(DateTime? startTime, DateTime? endTime)
        {
            // Kiểm tra nếu startTime hoặc endTime là null
            if (!startTime.HasValue || !endTime.HasValue)
            {
                return "Khác"; // Trả về "Khác" nếu thời gian không hợp lệ
            }

            // Ép kiểu về DateTime (non-nullable) sau khi đã kiểm tra null
            DateTime start = startTime.Value;
            DateTime end = endTime.Value;

            bool isMorning = start.Hour >= 6 && end.Hour < 12
                             || (end.Hour == 12 && end.Minute <= 30);
            bool isAfternoon = start.Hour >= 13 && end.Hour < 18
                               || (end.Hour == 18 && end.Minute <= 30);
            bool isEvening = start.Hour >= 19 && end.Hour < 24;

            if (isMorning) return "Sáng";
            if (isAfternoon) return "Chiều";
            if (isEvening) return "Tối";

            return "Khác"; // Nếu sự kiện trải dài qua nhiều khung giờ, đưa vào "Khác"
        }

    }
}