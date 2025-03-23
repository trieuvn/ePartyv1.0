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

            // Tải danh sách Manager vào cboManager
            LoadManagersIntoComboBox();

            LoadSchedule();
            RegisterButtonEvents();
            this.username = username;
        }

        private void LoadManagersIntoComboBox()
        {
            // Thêm một mục "None" để cho phép không chọn Manager
            cboManager.Items.Add("None");

            // Tải danh sách UserName từ bảng dbo.Manager
            var managers = _context.Managers
                .Select(m => m.UserName)
                .ToList();

            // Thêm các UserName vào cboManager
            cboManager.Items.AddRange(managers.ToArray());

            // Chọn mục đầu tiên ("None") làm mặc định
            cboManager.SelectedIndex = 0;
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
                .Where(o => o.BeginTime >= _startOfWeek && o.BeginTime <= _startOfWeek.AddDays(6).AddHours(23).AddMinutes(59))
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
                .FirstOrDefault(o => o.BeginTime >= startTime && o.BeginTime < endTime);

            if (_selectedOrder != null)
            {
                txtDescription.Text = _selectedOrder.Description ?? "";
                txtTableNumber.Text = _selectedOrder.NoTables?.ToString() ?? "";
                timeStart.Value = _selectedOrder.BeginTime ?? startTime;
                TimeEnd.Value = _selectedOrder.EndTime ?? endTime;
                // Chọn Manager từ danh sách
                cboManager.SelectedItem = _selectedOrder.Manager ?? "None";
                txtAddress.Text = _selectedOrder.Address ?? "";
                txtPhone.Text = _selectedOrder.PhoneNumber ?? "";
                txtFeedBack.Text = _selectedOrder.Feedback ?? "";
            }
            else
            {
                txtDescription.Text = "";
                txtTableNumber.Text = "";
                timeStart.Value = startTime;
                TimeEnd.Value = endTime;
                cboManager.SelectedItem = "None";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtFeedBack.Text = "";
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
                string manager = cboManager.SelectedItem?.ToString() == "None" ? null : cboManager.SelectedItem?.ToString();

                if (_selectedOrder == null)
                {
                    _selectedOrder = new Order
                    {
                        BeginTime = beginTime,
                        EndTime = endTime,
                        Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text,
                        NoTables = noTables,
                        Manager = manager,
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
                    _selectedOrder.Manager = manager;
                    _selectedOrder.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
                    _selectedOrder.PhoneNumber = phoneNumber;
                    _selectedOrder.Feedback = string.IsNullOrWhiteSpace(txtFeedBack.Text) ? null : txtFeedBack.Text;
                }

                _context.SaveChanges();
                MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchedule();
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
            cboManager.SelectedItem = "None";
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
    }
}