using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class FormSchedule : Form
    {
        private DateTime currentWeek;
        private TableLayoutPanel tableLayout;
        private Label lblWeekTitle;
        private Panel detailPanel;
        private TextBox txtDescription, txtManager, txtAddress, txtPhoneNumber, txtFeedback;
        private NumericUpDown numTables;
        private DateTimePicker dtpStartTime, dtpEndTime;
        private Button btnSave;
        private Order currentSelectedOrder;
        private DateTime currentSlotBegin, currentSlotEnd;

        public FormSchedule(DateTime weekStart)
        {
            InitializeComponent();
            currentWeek = weekStart;

            // Mặc định Fullscreen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeUI();
            LoadSchedule(currentWeek);

            // Initialize detail panel controls
            InitializeDetailPanel();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
        }

        private void InitializeUI()
        {
            // Thiết lập fullscreen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Panel điều hướng trên cùng
            Panel topPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 45,
                Padding = new Padding(10)
            };

            Button btnBack = new Button()
            {
                Text = "⬅ Quay lại",
                Size = new Size(90, 30),
                Location = new Point(10, 7),
            };
            btnBack.Click += (s, e) =>
            {
                this.Hide();
                new FormOrderList().ShowDialog();
                this.Close();
            };

            Button btnExit = new Button()
            {
                Text = "❌ Thoát",
                Size = new Size(80, 30),
                Location = new Point(btnBack.Right + 10, 7),
            };
            btnExit.Click += (s, e) => Application.Exit();

            Button btnPreviousWeek = new Button()
            {
                Text = "< Tuần trước",
                Size = new Size(100, 30),
                Location = new Point(btnExit.Right + 20, 7),
            };

            Button btnNextWeek = new Button()
            {
                Text = "Tuần sau >",
                Size = new Size(100, 30),
                Location = new Point(btnPreviousWeek.Right + 10, 7),
            };

            lblWeekTitle = new Label()
            {
                Text = $"Tuần ({currentWeek:dd/MM} - {currentWeek.AddDays(6):dd/MM})",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(btnNextWeek.Right + 20, 12),
                AutoSize = true
            };

            topPanel.Controls.AddRange(new Control[] { btnBack, btnExit, btnPreviousWeek, btnNextWeek, lblWeekTitle });

            // Kích thước và margin
            int margin = 10;
            int tableWidth = (int)(this.ClientSize.Width * 0.65);
            int detailWidth = this.ClientSize.Width - tableWidth - (3 * margin);

            // Tạo panel chứa lịch với scroll để tránh mất nội dung
            Panel schedulePanel = new Panel()
            {
                Location = new Point(margin, topPanel.Bottom + margin),
                Size = new Size(tableWidth, this.ClientSize.Height - topPanel.Height - (2 * margin)),
                AutoScroll = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // TableLayoutPanel (lịch tuần)
            tableLayout = new TableLayoutPanel()
            {
                Location = new Point(0, 0),
                AutoSize = true,
                ColumnCount = 8,
                RowCount = 6,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            };

            string[] headers = { "Buổi/Thứ", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
            string[] timeSlots = { "Sáng", "Trưa", "Chiều", "Tối", "Khuya" };

            // Thiết lập rõ ràng Column và Row Style
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 1; i <= 7; i++)
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            for (int i = 1; i <= 5; i++)
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));

            for (int i = 0; i < headers.Length; i++)
                tableLayout.Controls.Add(new Label()
                {
                    Text = headers[i],
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                }, i, 0);

            for (int i = 0; i < timeSlots.Length; i++)
                tableLayout.Controls.Add(new Label()
                {
                    Text = timeSlots[i],
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                }, 0, i + 1);

            schedulePanel.Controls.Add(tableLayout);

            // Panel PartyDetail
            detailPanel = new Panel()
            {
                Location = new Point(schedulePanel.Right + margin, schedulePanel.Top),
                Size = new Size(detailWidth, schedulePanel.Height),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15),
                AutoScroll = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right
            };

            Controls.AddRange(new Control[] { topPanel, schedulePanel, detailPanel });

            // Xử lý nút chuyển tuần
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
        }

        private void InitializeDetailPanel()
        {
            int lblWidth = 100, ctrlWidth = detailPanel.Width - lblWidth - 40;
            int y = 20, spacing = 40;

            txtDescription = new TextBox { Location = new Point(lblWidth + 20, y), Width = ctrlWidth };
            numTables = new NumericUpDown { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth, Minimum = 1 };
            dtpStartTime = new DateTimePicker { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth, Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm" };
            dtpEndTime = new DateTimePicker { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth, Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm" };
            txtManager = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
            txtAddress = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
            txtPhoneNumber = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
            txtFeedback = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };

            // Khởi tạo btnSave trước
            btnSave = new Button { Text = "Save", Location = new Point(lblWidth + 20, y += spacing), Size = new Size(100, 35) };
            btnSave.Click += btnSave_Click;

            // Khởi tạo btnDelete sau btnSave
            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new Point(btnSave.Right + 20, btnSave.Top),
                Size = new Size(100, 35),
                BackColor = Color.LightCoral
            };
            btnDelete.Click += btnDelete_Click;

            detailPanel.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mô tả:", Location = new Point(10, 20) }, txtDescription,
                new Label { Text = "Số bàn:", Location = new Point(10, 60) }, numTables,
                new Label { Text = "Bắt đầu:", Location = new Point(10, 100) }, dtpStartTime,
                new Label { Text = "Kết thúc:", Location = new Point(10, 140) }, dtpEndTime,
                new Label { Text = "Quản lý:", Location = new Point(10, 180) }, txtManager,
                new Label { Text = "Địa chỉ:", Location = new Point(10, 220) }, txtAddress,
                new Label { Text = "Điện thoại:", Location = new Point(10, 260) }, txtPhoneNumber,
                new Label { Text = "Feedback:", Location = new Point(10, 300) }, txtFeedback,
                btnSave, btnDelete
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentSelectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa sự kiện này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new ePartyDbDbContext())
                {
                    var orderToDelete = context.Orders.FirstOrDefault(o => o.Id == currentSelectedOrder.Id);

                    if (orderToDelete != null)
                    {
                        // Xóa các bản ghi liên quan trong bảng OrderHaveFood (nếu có)
                        var relatedOrderHaveFoods = context.OrderHaveFoods.Where(ohf => ohf.OrderId == orderToDelete.Id);
                        context.OrderHaveFoods.RemoveRange(relatedOrderHaveFoods);

                        // Xóa các bản ghi liên quan trong bảng OrderHaveStaff (nếu có)
                        var relatedOrderHaveStaffs = context.OrderHaveStaffs.Where(ohs => ohs.OrderId == orderToDelete.Id);
                        context.OrderHaveStaffs.RemoveRange(relatedOrderHaveStaffs);

                        // Xóa order
                        context.Orders.Remove(orderToDelete);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới giao diện
                        LoadSchedule(currentWeek);

                        // Đặt lại form chi tiết
                        LoadEmptyOrderForm(DateTime.Now, DateTime.Now.AddHours(1));

                        // Đặt lại currentSelectedOrder
                        currentSelectedOrder = null;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sự kiện cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ePartyDbDbContext())
            {
                Order order;
                if (currentSelectedOrder != null)
                {
                    order = context.Orders.FirstOrDefault(o => o.Id == currentSelectedOrder.Id) ?? new Order();
                }
                else
                {
                    order = new Order();
                    context.Orders.Add(order);
                }

                string enteredPhoneNumber = txtPhoneNumber.Text.Trim();

                // Kiểm tra customer đã tồn tại chưa
                var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == enteredPhoneNumber);

                if (customer == null)
                {
                    // Tạo mới customer nếu chưa tồn tại
                    customer = new Customer
                    {
                        PhoneNumber = enteredPhoneNumber,
                        Name = "Chưa cập nhật"
                    };
                    context.Customers.Add(customer);
                }

                // Gán thông tin Order
                order.Description = txtDescription.Text;
                order.NoTables = (int)numTables.Value;
                order.BeginTime = dtpStartTime.Value;
                order.EndTime = dtpEndTime.Value;
                order.Manager = txtManager.Text;
                order.Address = txtAddress.Text;
                order.PhoneNumber = customer.PhoneNumber;
                order.Feedback = txtFeedback.Text;

                context.SaveChanges();

                // Debug: Verify the phone number was saved
                MessageBox.Show($"Saved Order with PhoneNumber: {order.PhoneNumber}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSchedule(currentWeek);
        }

        private void LoadOrderDetailsToPanel(Order order)
        {
            txtDescription.Text = order.Description ?? "";
            numTables.Value = order.NoTables ?? 1;
            dtpStartTime.Value = order.BeginTime ?? DateTime.Now;
            dtpEndTime.Value = order.EndTime ?? DateTime.Now;
            txtManager.Text = order.Manager ?? "";
            txtAddress.Text = order.Address ?? "";
            txtPhoneNumber.Text = order.PhoneNumber ?? "";

            // Debug: Verify the phone number being loaded
            MessageBox.Show($"Loaded Order with PhoneNumber: {order.PhoneNumber}, Customer: {order.Customer?.PhoneNumber ?? "null"}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFeedback.Text = order.Feedback ?? "";
        }

        private void LoadEmptyOrderForm(DateTime begin, DateTime end)
        {
            txtDescription.Text = "";
            numTables.Value = 1;
            dtpStartTime.Value = begin;
            dtpEndTime.Value = end;
            txtManager.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtFeedback.Text = "";
        }

        private void SlotButton_Click(object sender, EventArgs e)
        {
            Button btnSlot = sender as Button;
            dynamic tag = btnSlot.Tag;

            if (tag.Order != null)
            {
                currentSelectedOrder = tag.Order;
                LoadOrderDetailsToPanel(currentSelectedOrder);
            }
            else
            {
                currentSelectedOrder = null;
                currentSlotBegin = tag.DateTimeSlot[0];
                currentSlotEnd = tag.DateTimeSlot[1];
                LoadEmptyOrderForm(currentSlotBegin, currentSlotEnd);
            }
        }

        private void LoadSchedule(DateTime weekStart)
        {
            for (int col = 1; col <= 7; col++)
            {
                for (int row = 1; row <= 5; row++)
                {
                    Control existingControl = tableLayout.GetControlFromPosition(col, row);
                    if (existingControl != null)
                    {
                        tableLayout.Controls.Remove(existingControl);
                        existingControl.Dispose();
                    }
                }
            }

            using (var context = new ePartyDbDbContext())
            {
                var startOfWeek = weekStart.Date;
                var endOfWeek = startOfWeek.AddDays(6).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                var orders = context.Orders
                    .Where(o => o.BeginTime >= startOfWeek && o.BeginTime <= endOfWeek)
                    .OrderBy(o => o.BeginTime)
                    .ToList();

                // Rest of the method remains the same
                Dictionary<(int, int), Order> orderMapping = new Dictionary<(int, int), Order>();

                foreach (var order in orders)
                {
                    if (!order.BeginTime.HasValue || !order.EndTime.HasValue) continue;

                    DateTime begin = order.BeginTime.Value;
                    DateTime end = order.EndTime.Value;
                    int startDay = ((int)begin.DayOfWeek == 0) ? 7 : (int)begin.DayOfWeek;
                    int endDay = ((int)end.DayOfWeek == 0) ? 7 : (int)end.DayOfWeek;

                    if (begin.Date == end.Date)
                    {
                        int col = startDay;
                        int startRow = GetRowIndex(order.BeginTime);
                        int endRow = GetRowIndex(order.EndTime);

                        for (int row = startRow; row <= endRow; row++)
                        {
                            orderMapping[(col, row)] = order;
                        }
                    }
                    else
                    {
                        DateTime currentDay = begin.Date;
                        while (currentDay <= end.Date)
                        {
                            int col = ((int)currentDay.DayOfWeek == 0) ? 7 : (int)currentDay.DayOfWeek;
                            int startRow = (currentDay == begin.Date) ? GetRowIndex(begin) : 1;
                            int endRow = (currentDay == end.Date) ? GetRowIndex(end) : 5;

                            for (int row = startRow; row <= endRow; row++)
                            {
                                orderMapping[(col, row)] = order;
                            }

                            currentDay = currentDay.AddDays(1);
                        }
                    }
                }

                for (int col = 1; col <= 7; col++)
                {
                    for (int row = 1; row <= 5; row++)
                    {
                        bool hasOrder = orderMapping.ContainsKey((col, row));

                        Button btnSlot = new Button()
                        {
                            Dock = DockStyle.Fill,
                            Margin = new Padding(0),
                            BackColor = hasOrder ? Color.Green : Color.Red,
                            Tag = new
                            {
                                Order = hasOrder ? orderMapping[(col, row)] : null,
                                DateTimeSlot = GetDateTimeSlot(weekStart, col, row)
                            }
                        };

                        btnSlot.Click += SlotButton_Click;

                        tableLayout.Controls.Add(btnSlot, col, row);
                    }
                }
            }
        }

        private DateTime[] GetDateTimeSlot(DateTime weekStart, int col, int row)
        {
            DateTime date = weekStart.AddDays(col - 1);
            switch (row)
            {
                case 1: return new[] { date.AddHours(6), date.AddHours(9).AddMinutes(59) };    // Sáng
                case 2: return new[] { date.AddHours(10), date.AddHours(13).AddMinutes(59) };  // Trưa
                case 3: return new[] { date.AddHours(14), date.AddHours(17).AddMinutes(59) };  // Chiều
                case 4: return new[] { date.AddHours(18), date.AddHours(21).AddMinutes(59) };  // Tối
                default: return new[] { date.AddHours(22), date.AddDays(1).AddHours(5).AddMinutes(59) }; // Khuya
            }
        }

        private int GetRowIndex(DateTime? time)
        {
            if (!time.HasValue) return 5;
            if (time.Value.Hour >= 6 && time.Value.Hour < 10) return 1;  // Sáng: 6h - 9h59
            if (time.Value.Hour >= 10 && time.Value.Hour < 14) return 2; // Trưa: 10h - 13h59
            if (time.Value.Hour >= 14 && time.Value.Hour < 18) return 3; // Chiều: 14h - 17h59
            if (time.Value.Hour >= 18 && time.Value.Hour < 22) return 4; // Tối: 18h - 21h59
            return 5; // Khuya: 22h - 5h59
        }
    }
}