using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;

namespace eParty
{
    public partial class OrderListForm : Form
    {
        private ePartyDbDbContext context;
        private DateTime currentWeek;
        private TableLayoutPanel tableLayout;
        private TextBox txtOrderName;
        private DateTimePicker dtpBeginTime;
        private DateTimePicker dtpEndTime;
        private NumericUpDown nudNoTables; // Thêm NumericUpDown cho số bàn
        private Button btnCreateOrder;
        private Label lblWeekTitle;

        public OrderListForm(DateTime weekStart)
        {
            InitializeComponent();
            context = new ePartyDbDbContext();
            currentWeek = weekStart;
            InitializeUI();
            LoadSchedule(currentWeek);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Name = "OrderListForm";
            Text = "Danh Sách Đơn Hàng";
            Load += OrderListForm_Load;
            ResumeLayout(false);
        }

        private void InitializeUI()
        {
            this.Text = "Lịch Trình Đơn Hàng";
            this.Size = new Size(1000, 600);

            // Tiêu đề tuần
            lblWeekTitle = new Label()
            {
                Text = $"Tuần ({currentWeek:dd/MM} - {currentWeek.AddDays(6):dd/MM})",
                AutoSize = true,
                Location = new Point(450, 25),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            // Điều hướng tuần
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

            // Form nhập đơn hàng
            Label lblOrderName = new Label() { Text = "Tên Đơn Hàng:", Location = new Point(20, 60), AutoSize = true };
            txtOrderName = new TextBox() { Location = new Point(150, 60), Size = new Size(200, 20) };

            Label lblBeginTime = new Label() { Text = "Thời Gian Bắt Đầu:", Location = new Point(20, 90), AutoSize = true };
            dtpBeginTime = new DateTimePicker()
            {
                Location = new Point(150, 90),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                ShowUpDown = true,
                Size = new Size(200, 20)
            };

            Label lblEndTime = new Label() { Text = "Thời Gian Kết Thúc:", Location = new Point(20, 120), AutoSize = true };
            dtpEndTime = new DateTimePicker()
            {
                Location = new Point(150, 120),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                ShowUpDown = true,
                Size = new Size(200, 20)
            };

            Label lblNoTables = new Label() { Text = "Số Bàn:", Location = new Point(20, 150), AutoSize = true };
            nudNoTables = new NumericUpDown()
            {
                Location = new Point(150, 150), // Vị trí dưới dtpEndTime
                Size = new Size(200, 20),
                Minimum = 1, // Giá trị tối thiểu
                Maximum = 100, // Giá trị tối đa (có thể điều chỉnh)
                Value = 1 // Giá trị mặc định
            };

            btnCreateOrder = new Button() { Text = "Tạo Đơn Hàng", Location = new Point(150, 180), Size = new Size(100, 30) };
            btnCreateOrder.Click += BtnCreateOrder_Click;

            // Tạo bảng lịch trình
            tableLayout = new TableLayoutPanel()
            {
                Location = new Point(20, 220), // Điều chỉnh vị trí xuống dưới để tránh chồng lấn
                Size = new Size(950, 350),
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
                    Size = new Size(120, 50),
                    BorderStyle = BorderStyle.FixedSingle
                };
                tableLayout.Controls.Add(lblTimeSlot, 0, i + 1);
            }

            this.Controls.Add(lblWeekTitle);
            this.Controls.Add(btnPreviousWeek);
            this.Controls.Add(btnNextWeek);
            this.Controls.Add(lblOrderName);
            this.Controls.Add(txtOrderName);
            this.Controls.Add(lblBeginTime);
            this.Controls.Add(dtpBeginTime);
            this.Controls.Add(lblEndTime);
            this.Controls.Add(dtpEndTime);
            this.Controls.Add(lblNoTables);
            this.Controls.Add(nudNoTables); // Thêm NumericUpDown vào form
            this.Controls.Add(btnCreateOrder);
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
                    if (!order.BeginTime.HasValue || !order.EndTime.HasValue)
                    {
                        continue;
                    }

                    string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);
                    schedule[timeSlot].Add(order);
                }

                for (int col = 1; col <= 7; col++)
                {
                    for (int row = 1; row <= 4; row++)
                    {
                        Control existingControl = tableLayout.GetControlFromPosition(col, row);
                        if (existingControl != null)
                            tableLayout.Controls.Remove(existingControl);
                    }
                }

                for (int col = 1; col <= 7; col++)
                {
                    DateTime day = weekStart.AddDays(col - 1);
                    HashSet<int> displayedEvents = new HashSet<int>();

                    List<Order> ordersOnDay = schedule.Values.SelectMany(list => list)
                        .Where(o => o.BeginTime.HasValue && o.BeginTime.Value.Date == day.Date)
                        .ToList();

                    foreach (var order in ordersOnDay)
                    {
                        if (!order.BeginTime.HasValue || !order.EndTime.HasValue)
                        {
                            continue;
                        }

                        string timeSlot = GetTimeSlot(order.BeginTime, order.EndTime);

                        if (displayedEvents.Contains(order.Id))
                        {
                            timeSlot = "Khác";
                        }

                        int rowIndex = timeSlot == "Sáng" ? 1 :
                                       timeSlot == "Chiều" ? 2 :
                                       timeSlot == "Tối" ? 3 : 4;

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

                        displayedEvents.Add(order.Id);
                    }
                }
            }
        }

        private string GetTimeSlot(DateTime? startTime, DateTime? endTime)
        {
            if (!startTime.HasValue || !endTime.HasValue)
            {
                return "Khác";
            }

            DateTime start = startTime.Value;
            DateTime end = endTime.Value;

            bool isMorning = start.Hour >= 6 && end.Hour < 12 || (end.Hour == 12 && end.Minute <= 30);
            bool isAfternoon = start.Hour >= 13 && end.Hour < 18 || (end.Hour == 18 && end.Minute <= 30);
            bool isEvening = start.Hour >= 19 && end.Hour < 24;

            if (isMorning) return "Sáng";
            if (isAfternoon) return "Chiều";
            if (isEvening) return "Tối";

            return "Khác";
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            string orderName = txtOrderName.Text;
            DateTime beginTime = dtpBeginTime.Value;
            DateTime endTime = dtpEndTime.Value;
            int noTables = (int)nudNoTables.Value; // Lấy số bàn từ NumericUpDown

            if (endTime <= beginTime)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckOverlap(beginTime, endTime))
            {
                MessageBox.Show("Xung đột thời gian! Vui lòng chọn lại lịch trình.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateOrder(orderName, beginTime, endTime, noTables);
            LoadSchedule(currentWeek);
            MessageBox.Show("Tạo đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckOverlap(DateTime beginTime, DateTime endTime)
        {
            using (var context = new ePartyDbDbContext())
            {
                var existingOrders = context.Orders
                    .Where(o => o.BeginTime.HasValue && o.EndTime.HasValue &&
                               ((beginTime < o.EndTime.Value && endTime > o.BeginTime.Value) ||
                                (beginTime == o.BeginTime.Value && endTime == o.EndTime.Value)))
                    .ToList();
                return existingOrders.Count > 0;
            }
        }

        private void CreateOrder(string name, DateTime beginTime, DateTime endTime, int noTables)
        {
            using (var context = new ePartyDbDbContext())
            {
                var order = new Order
                {
                    Description = name,
                    BeginTime = beginTime,
                    EndTime = endTime,
                    Manager = "admin",
                    NoTables = noTables, // Sử dụng giá trị số bàn từ NumericUpDown
                    //CustomerName = "Customer1",
                    //CustomerPhoneNumber = "1234567890"
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }
    }
}