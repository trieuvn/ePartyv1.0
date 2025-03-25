using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;

namespace eParty
{
    public partial class FormSchedule : Form
    {
        private ePartyDbDbContext _context;
        private DateTime _startOfWeek;
        private Order _selectedOrder;
        private ArtanButton _selectedButton;
        public string username;
        public FormSchedule(string username)
        {
            this.username = username;
            InitializeComponent();
            _context = new ePartyDbDbContext();
            _startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);

            ConfigureDataGridViews(); // Thêm dòng này
            LoadSchedule();
            RegisterButtonEvents();
            this.username = username;
        }


        private void RegisterButtonEvents()
        {
            btnPre.Click += btnPre_Click;
            btnNext.Click += btnNext_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;

            foreach (Control control in panel1.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control subControl in panel.Controls)
                    {
                        if (subControl is Panel subPanel)
                        {
                            foreach (Control button in subPanel.Controls)
                            {
                                if (button is ArtanButton artanButton)
                                {
                                    artanButton.Enabled = true;
                                    artanButton.Click += ScheduleButton_Click;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void LoadSchedule()
        {
            week.Text = $"Week: {_startOfWeek:dd/MM} - {_startOfWeek.AddDays(6):dd/MM}/{_startOfWeek.Year}";
            ClearScheduleButtons();

            var orders = _context.Orders
                .Where(o => o.BeginTime >= _startOfWeek && o.BeginTime <= _startOfWeek.AddDays(6).AddHours(23).AddMinutes(59) && o.Manager == username)
                .ToList();

            foreach (var order in orders)
            {
                MarkOrderOnSchedule(order);
            }
        }

        private void ClearScheduleButtons()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control subControl in panel.Controls)
                    {
                        if (subControl is Panel subPanel)
                        {
                            foreach (Control button in subPanel.Controls)
                            {
                                if (button is ArtanButton artanButton)
                                {
                                    artanButton.BackColor = Color.White;
                                    artanButton.BackgroundColor = Color.White;
                                    artanButton.BorderSize = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MarkOrderOnSchedule(Order order)
        {
            if (order.BeginTime == null || order.EndTime == null) return;

            DateTime orderDate = order.BeginTime.Value.Date;
            int dayIndex = (orderDate - _startOfWeek).Days;
            if (dayIndex < 0 || dayIndex > 6) return;

            int timeSlot = GetTimeSlot(order.BeginTime.Value, order.EndTime.Value);
            if (timeSlot == -1) return;

            string buttonName = $"cot{dayIndex + 1}dong{timeSlot + 1}";
            var button = Controls.Find(buttonName, true).FirstOrDefault() as ArtanButton;

            if (button != null)
            {
                button.BackColor = Color.LightGreen;
                button.BackgroundColor = Color.LightGreen;
            }
        }

        private int GetTimeSlot(DateTime start, DateTime end)
        {
            int startHour = start.Hour;
            if (startHour >= 6 && startHour < 10) return 0;
            if (startHour >= 10 && startHour < 14) return 1;
            if (startHour >= 14 && startHour < 18) return 2;
            if (startHour >= 18 && startHour < 22) return 3;
            if (startHour >= 22 || startHour < 6) return 4;
            return -1;
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            var button = sender as ArtanButton;
            if (button == null) return;

            if (_selectedButton != null)
            {
                _selectedButton.BorderSize = 0;
            }

            button.BorderSize = 2;
            _selectedButton = button;

            string buttonName = button.Name;
            int dayIndex = int.Parse(buttonName.Substring(3, 1)) - 1;
            int timeSlot = int.Parse(buttonName.Substring(8, 1)) - 1;

            DateTime selectedDate = _startOfWeek.AddDays(dayIndex);
            DateTime startTime, endTime;
            switch (timeSlot)
            {
                case 0:
                    startTime = selectedDate.AddHours(6);
                    endTime = selectedDate.AddHours(10);
                    break;
                case 1:
                    startTime = selectedDate.AddHours(10);
                    endTime = selectedDate.AddHours(14);
                    break;
                case 2:
                    startTime = selectedDate.AddHours(14);
                    endTime = selectedDate.AddHours(18);
                    break;
                case 3:
                    startTime = selectedDate.AddHours(18);
                    endTime = selectedDate.AddHours(22);
                    break;
                case 4:
                    startTime = selectedDate.AddHours(22);
                    endTime = selectedDate.AddDays(1).AddHours(6);
                    break;
                default:
                    return;
            }

            _selectedOrder = _context.Orders
                .FirstOrDefault(o => o.BeginTime >= startTime && o.BeginTime < endTime && o.Manager == username);

            if (_selectedOrder != null)
            {
                txtDescription.Text = _selectedOrder.Description ?? "";
                txtTableNumber.Text = _selectedOrder.NoTables?.ToString() ?? "";
                timeStart.Value = _selectedOrder.BeginTime ?? startTime;
                TimeEnd.Value = _selectedOrder.EndTime ?? endTime;
                txtAddress.Text = _selectedOrder.Address ?? "";
                txtPhone.Text = _selectedOrder.PhoneNumber ?? "";
                txtFeedBack.Text = _selectedOrder.Feedback ?? "";

                LoadOrderDetails(_selectedOrder.Id);
            }
            else
            {
                txtDescription.Text = "";
                txtTableNumber.Text = "";
                timeStart.Value = startTime;
                TimeEnd.Value = endTime;
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtFeedBack.Text = "";

                // Reset labels khi không có order
                lbSoLuongStaff.Text = "Staff Count: 0";
                lbSoLuongMon.Text = "Food Count: 0";
                lbTongTien.Text = "Total Cost: 0 VND";

                dataGridStaff.Rows.Clear();
                dataGridFood.Rows.Clear();
            }
        }
        private void LoadOrderDetails(int orderId)
        {
            try
            {
                // Xóa dữ liệu cũ trong DataGridView
                dataGridStaff.Rows.Clear();
                dataGridFood.Rows.Clear();

                // Truy vấn danh sách Staff từ OrderHaveStaff
                var staffList = _context.OrderHaveStaffs
                    .Where(ohs => ohs.OrderId == orderId)
                    .Join(_context.Staff,
                        ohs => ohs.StaffId,
                        s => s.Id,
                        (ohs, s) => new
                        {
                            s.FullName,
                            s.Role,
                            s.Cost
                        })
                    .ToList();

                foreach (var staff in staffList)
                {
                    dataGridStaff.Rows.Add(staff.FullName, staff.Role, staff.Cost);
                }

                // Truy vấn danh sách Food từ OrderHaveFood
                var foodList = _context.OrderHaveFoods
                    .Where(ohf => ohf.OrderId == orderId)
                    .Join(_context.Foods,
                        ohf => ohf.FoodId,
                        f => f.Id,
                        (ohf, f) => new
                        {
                            f.Name,
                            ohf.Amount,
                            f.Cost
                        })
                    .ToList();

                foreach (var food in foodList)
                {
                    dataGridFood.Rows.Add(food.Name, food.Amount, food.Cost);
                }

                // Cập nhật các label
                int staffCount = staffList.Count;
                int foodCount = foodList.Count;

                // Tính tổng chi phí với ép kiểu rõ ràng sang decimal
                decimal totalFoodCost = foodList.Sum(f => (decimal)(f.Amount ?? 0) * (f.Cost ?? 0));
                decimal totalStaffCost = staffList.Sum(s => (decimal)(s.Cost ?? 0));
                decimal totalCost = totalFoodCost + totalStaffCost;

                lbSoLuongStaff.Text = $"Staff Count: {staffCount}";
                lbSoLuongMon.Text = $"Food Count: {foodCount}";
                lbTongTien.Text = $"Total Cost: {totalCost:N0} VND";

                // Làm mới DataGridView
                dataGridStaff.Refresh();
                dataGridFood.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            _startOfWeek = _startOfWeek.AddDays(-7);
            LoadSchedule();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _startOfWeek = _startOfWeek.AddDays(7);
            LoadSchedule();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTableNumber.Text) || !int.TryParse(txtTableNumber.Text, out int noTables))
                {
                    MessageBox.Show("Please enter a valid table number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (timeStart.Value >= TimeEnd.Value)
                {
                    MessageBox.Show("End time must be greater than start time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter a phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime beginTime = timeStart.Value;
                DateTime endTime = TimeEnd.Value;

                if (!IsValidDate(endTime))
                {
                    endTime = new DateTime(endTime.Year, endTime.Month, DateTime.DaysInMonth(endTime.Year, endTime.Month), endTime.Hour, endTime.Minute, endTime.Second);
                    TimeEnd.Value = endTime;
                    MessageBox.Show($"Adjusted End Time to a valid date: {endTime:dd/MM/yyyy HH:mm}", "Date Adjusted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string phoneNumber = txtPhone.Text.Trim();
                var customer = _context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
                if (customer == null)
                {
                    customer = new Customer
                    {
                        PhoneNumber = phoneNumber,
                        Name = "Unknown",
                    };
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    MessageBox.Show($"New customer with PhoneNumber {phoneNumber} has been added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Lấy giá trị Manager từ ComboBox

                if (_selectedOrder == null)
                {
                    _selectedOrder = new Order
                    {
                        BeginTime = beginTime,
                        EndTime = endTime,
                        Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text,
                        NoTables = noTables,
                        Manager = username,
                        Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text,
                        PhoneNumber = phoneNumber,
                        Feedback = string.IsNullOrWhiteSpace(txtFeedBack.Text) ? null : txtFeedBack.Text,
                        Status = true,
                        ActualCost = 0
                    };
                    _context.Orders.Add(_selectedOrder);
                }
                else
                {
                    _selectedOrder.BeginTime = beginTime;
                    _selectedOrder.EndTime = endTime;
                    _selectedOrder.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text;
                    _selectedOrder.NoTables = noTables;
                    _selectedOrder.Manager = username;
                    _selectedOrder.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
                    _selectedOrder.PhoneNumber = phoneNumber;
                    _selectedOrder.Feedback = string.IsNullOrWhiteSpace(txtFeedBack.Text) ? null : txtFeedBack.Text;
                }

                _context.SaveChanges();
                MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchedule();

                // Làm mới danh sách Staff và Food
                LoadOrderDetails(_selectedOrder.Id);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error saving order: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidDate(DateTime date)
        {
            try
            {
                DateTime testDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    // Find the order to delete
                    var orderToDelete = context.Orders.FirstOrDefault(o => o.Id == _selectedOrder.Id);
                    if (orderToDelete == null)
                    {
                        MessageBox.Show("Order to delete not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirm deletion with the user
                    if (MessageBox.Show("Are you sure you want to delete this order? This will also delete related OrderHaveFood and OrderHaveStaff records.",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    // Delete related OrderHaveStaff entries
                    var orderHaveStaffs = context.OrderHaveStaffs
                        .Where(ohs => ohs.OrderId == _selectedOrder.Id)
                        .ToList();
                    if (orderHaveStaffs.Any())
                    {
                        context.OrderHaveStaffs.RemoveRange(orderHaveStaffs);
                    }

                    // Delete related OrderHaveFood entries
                    var orderHaveFoods = context.OrderHaveFoods
                        .Where(ohf => ohf.OrderId == _selectedOrder.Id)
                        .ToList();
                    if (orderHaveFoods.Any())
                    {
                        context.OrderHaveFoods.RemoveRange(orderHaveFoods);
                    }

                    // Delete the order
                    context.Orders.Remove(orderToDelete);

                    // Save changes
                    context.SaveChanges();

                    MessageBox.Show("Deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form and reload the schedule
                    LoadSchedule();
                    LoadEmptyOrderForm(DateTime.Now, DateTime.Now.AddHours(1));
                    _selectedOrder = null;
                    _selectedButton = null;

                    // Xóa dữ liệu trong DataGridView
                    dataGridStaff.Rows.Clear();
                    dataGridFood.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error deleting order: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmptyOrderForm(DateTime begin, DateTime end)
        {
            txtDescription.Text = "";
            txtTableNumber.Text = "";
            timeStart.Value = begin;
            TimeEnd.Value = end;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtFeedBack.Text = "";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cot2dong1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigureDataGridViews()
        {
            // Cấu hình DataGridView cho Staff
            dataGridStaff.Columns.Clear();
            dataGridStaff.Columns.Add("FullName", "Staff Name");
            dataGridStaff.Columns.Add("Role", "Role");
            dataGridStaff.Columns.Add("Cost", "Cost");
            dataGridStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridStaff.RowTemplate.Height = 30;
            dataGridStaff.AllowUserToResizeRows = false;

            // Cấu hình DataGridView cho Food
            dataGridFood.Columns.Clear();
            dataGridFood.Columns.Add("Name", "Food Name");
            dataGridFood.Columns.Add("Amount", "Amount");
            dataGridFood.Columns.Add("Cost", "Cost");
            dataGridFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFood.RowTemplate.Height = 30;
            dataGridFood.AllowUserToResizeRows = false;
        }

        private void dataGridFood_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridStaff_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var staffList = _context.Staff.ToList();
            if (!staffList.Any())
            {
                MessageBox.Show("No staff available in the database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new Form())
            {
                form.Text = "Add Staff to Order";
                form.Size = new Size(300, 200);
                form.StartPosition = FormStartPosition.CenterParent;

                Label lblStaff = new Label { Text = "Select Staff:", Location = new Point(10, 10) };
                ComboBox cboStaff = new ComboBox
                {
                    Location = new Point(10, 30),
                    Width = 250,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                // Tạo danh sách mới với thông tin hiển thị kết hợp FullName và Role
                var staffDisplayList = staffList.Select(s => new
                {
                    Id = s.Id,
                    DisplayText = $"{s.FullName} - {s.Role}" // Kết hợp FullName và Role
                }).ToList();

                cboStaff.DataSource = staffDisplayList;
                cboStaff.DisplayMember = "DisplayText"; // Hiển thị FullName - Role
                cboStaff.ValueMember = "Id"; // Giá trị vẫn là Id

                Button btnConfirm = new Button
                {
                    Text = "Add",
                    Location = new Point(10, 70),
                    Size = new Size(80, 25)
                };
                btnConfirm.Click += (s, ev) =>
                {
                    if (cboStaff.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a staff!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int staffId = (int)cboStaff.SelectedValue;
                    var existingStaff = _context.OrderHaveStaffs
                        .FirstOrDefault(ohs => ohs.OrderId == _selectedOrder.Id && ohs.StaffId == staffId);

                    if (existingStaff != null)
                    {
                        MessageBox.Show("This staff is already assigned to the order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var orderHaveStaff = new OrderHaveStaff
                    {
                        OrderId = _selectedOrder.Id,
                        StaffId = staffId
                    };
                    _context.OrderHaveStaffs.Add(orderHaveStaff);
                    _context.SaveChanges();

                    LoadOrderDetails(_selectedOrder.Id);
                    form.Close();
                };

                form.Controls.Add(lblStaff);
                form.Controls.Add(cboStaff);
                form.Controls.Add(btnConfirm);
                form.ShowDialog();
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffName = dataGridStaff.SelectedRows[0].Cells["FullName"].Value?.ToString();
            if (string.IsNullOrEmpty(staffName))
            {
                MessageBox.Show("Invalid staff name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var staff = _context.Staff.FirstOrDefault(s => s.FullName == staffName);
            if (staff == null)
            {
                MessageBox.Show("Staff not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var staffList = _context.Staff.ToList();
            if (!staffList.Any())
            {
                MessageBox.Show("No staff available in the database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new Form())
            {
                form.Text = "Edit Staff";
                form.Size = new Size(300, 200);
                form.StartPosition = FormStartPosition.CenterParent;

                Label lblStaff = new Label { Text = "Select New Staff:", Location = new Point(10, 10) };
                ComboBox cboStaff = new ComboBox
                {
                    Location = new Point(10, 30),
                    Width = 250,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                // Tạo danh sách mới với thông tin hiển thị kết hợp FullName và Role
                var staffDisplayList = staffList.Select(s => new
                {
                    Id = s.Id,
                    DisplayText = $"{s.FullName} - {s.Role}"
                }).ToList();

                cboStaff.DataSource = staffDisplayList;
                cboStaff.DisplayMember = "DisplayText";
                cboStaff.ValueMember = "Id";
                cboStaff.SelectedValue = staff.Id;

                Button btnConfirm = new Button
                {
                    Text = "Update",
                    Location = new Point(10, 70),
                    Size = new Size(80, 25)
                };
                btnConfirm.Click += (s, ev) =>
                {
                    if (cboStaff.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a staff!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int newStaffId = (int)cboStaff.SelectedValue;
                    var existingStaff = _context.OrderHaveStaffs
                        .FirstOrDefault(ohs => ohs.OrderId == _selectedOrder.Id && ohs.StaffId == staff.Id);

                    if (existingStaff != null)
                    {
                        existingStaff.StaffId = newStaffId;
                        _context.SaveChanges();
                        LoadOrderDetails(_selectedOrder.Id);
                    }

                    form.Close();
                };

                form.Controls.Add(lblStaff);
                form.Controls.Add(cboStaff);
                form.Controls.Add(btnConfirm);
                form.ShowDialog();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffName = dataGridStaff.SelectedRows[0].Cells["FullName"].Value.ToString();
            var staff = _context.Staff.FirstOrDefault(s => s.FullName == staffName);
            if (staff == null) return;

            if (MessageBox.Show($"Are you sure you want to delete {staffName} from this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var orderHaveStaff = _context.OrderHaveStaffs
                .FirstOrDefault(ohs => ohs.OrderId == _selectedOrder.Id && ohs.StaffId == staff.Id);

            if (orderHaveStaff != null)
            {
                _context.OrderHaveStaffs.Remove(orderHaveStaff);
                _context.SaveChanges();
                LoadOrderDetails(_selectedOrder.Id);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var foodList = _context.Foods.ToList();
            if (!foodList.Any())
            {
                MessageBox.Show("No food available in the database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new Form())
            {
                form.Text = "Add Food to Order";
                form.Size = new Size(300, 250);
                form.StartPosition = FormStartPosition.CenterParent;

                Label lblFood = new Label { Text = "Select Food:", Location = new Point(10, 10) };
                ComboBox cboFood = new ComboBox
                {
                    Location = new Point(10, 30),
                    Width = 250,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cboFood.DataSource = foodList;
                cboFood.DisplayMember = "Name";
                cboFood.ValueMember = "Id";

                Label lblAmount = new Label { Text = "Amount:", Location = new Point(10, 60) };
                TextBox txtAmount = new TextBox { Location = new Point(10, 80), Width = 250 };

                Button btnConfirm = new Button
                {
                    Text = "Add",
                    Location = new Point(10, 120),
                    Size = new Size(80, 25)
                };
                btnConfirm.Click += (s, ev) =>
                {
                    if (cboFood.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a food!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
                    {
                        MessageBox.Show("Please enter a valid amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int foodId = (int)cboFood.SelectedValue;
                    var existingFood = _context.OrderHaveFoods
                        .FirstOrDefault(ohf => ohf.OrderId == _selectedOrder.Id && ohf.FoodId == foodId);

                    if (existingFood != null)
                    {
                        existingFood.Amount += amount;
                    }
                    else
                    {
                        var orderHaveFood = new OrderHaveFood
                        {
                            OrderId = _selectedOrder.Id,
                            FoodId = foodId,
                            Amount = amount
                        };
                        _context.OrderHaveFoods.Add(orderHaveFood);
                    }

                    _context.SaveChanges();
                    LoadOrderDetails(_selectedOrder.Id);
                    form.Close();
                };

                form.Controls.Add(lblFood);
                form.Controls.Add(cboFood);
                form.Controls.Add(lblAmount);
                form.Controls.Add(txtAmount);
                form.Controls.Add(btnConfirm);
                form.ShowDialog();
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a food to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string foodName = dataGridFood.SelectedRows[0].Cells["Name"].Value.ToString();
            var food = _context.Foods.FirstOrDefault(f => f.Name == foodName);
            if (food == null) return;

            if (MessageBox.Show($"Are you sure you want to delete {foodName} from this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var orderHaveFood = _context.OrderHaveFoods
                .FirstOrDefault(ohf => ohf.OrderId == _selectedOrder.Id && ohf.FoodId == food.Id);

            if (orderHaveFood != null)
            {
                _context.OrderHaveFoods.Remove(orderHaveFood);
                _context.SaveChanges();
                LoadOrderDetails(_selectedOrder.Id);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select an order first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a food to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string foodName = dataGridFood.SelectedRows[0].Cells["Name"].Value.ToString();
            int currentAmount = int.Parse(dataGridFood.SelectedRows[0].Cells["Amount"].Value.ToString());
            var food = _context.Foods.FirstOrDefault(f => f.Name == foodName);
            if (food == null) return;

            using (var form = new Form())
            {
                form.Text = "Edit Food";
                form.Size = new Size(300, 200);
                form.StartPosition = FormStartPosition.CenterParent;

                Label lblAmount = new Label { Text = "Amount:", Location = new Point(10, 10) };
                TextBox txtAmount = new TextBox
                {
                    Location = new Point(10, 30),
                    Width = 250,
                    Text = currentAmount.ToString()
                };

                Button btnConfirm = new Button
                {
                    Text = "Update",
                    Location = new Point(10, 70),
                    Size = new Size(80, 25)
                };
                btnConfirm.Click += (s, ev) =>
                {
                    if (!int.TryParse(txtAmount.Text, out int newAmount) || newAmount <= 0)
                    {
                        MessageBox.Show("Please enter a valid amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var existingFood = _context.OrderHaveFoods
                        .FirstOrDefault(ohf => ohf.OrderId == _selectedOrder.Id && ohf.FoodId == food.Id);

                    if (existingFood != null)
                    {
                        existingFood.Amount = newAmount;
                        _context.SaveChanges();
                        LoadOrderDetails(_selectedOrder.Id);
                    }

                    form.Close();
                };

                form.Controls.Add(lblAmount);
                form.Controls.Add(txtAmount);
                form.Controls.Add(btnConfirm);
                form.ShowDialog();
            }
        }
    }
}