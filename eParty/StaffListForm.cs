using System;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class StaffListForm : Form
    {
        private ePartyDbDbContext _context;
        private Staff _selectedStaff;
        public string username;
        public StaffListForm(string username)
        {
            InitializeComponent();
            _context = new ePartyDbDbContext();
            ConfigureDataGridView();
            AttachEventHandlers(); // Gắn các sự kiện
            this.username = username;
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            ClearForm();
        }

        private void ConfigureDataGridView()
        {
            dataGridStaff.Columns["Order"].HeaderText = "Name";
            dataGridStaff.Columns["Role"].HeaderText = "Role";
            dataGridStaff.Columns["Phone"].HeaderText = "Phone";
            dataGridStaff.Columns["Location"].HeaderText = "Location";
            dataGridStaff.Columns["Cost"].HeaderText = "Cost";

            dataGridStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridStaff.RowTemplate.Height = 30;
            dataGridStaff.AllowUserToResizeRows = false;
        }

        private void AttachEventHandlers()
        {
            // Gắn sự kiện cho các nút và ô tìm kiếm
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridStaff.SelectionChanged += DataGridStaff_SelectionChanged;

            // Xử lý khi người dùng nhấp vào ô tìm kiếm để xóa placeholder
            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == "Search by staff name...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search by staff name...";
                    txtSearch.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void LoadStaffData(string searchText = "")
        {
            try
            {
                dataGridStaff.Rows.Clear();

                var staffQuery = _context.Staff.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Search by staff name...")
                {
                    staffQuery = staffQuery.Where(s => s.FullName.Contains(searchText)).Where(f => f.Manager == username);
                }

                var staffList = staffQuery
                    .Select(s => new
                    {
                        s.Id,
                        s.FullName,
                        s.Role,
                        s.PhoneNumber,
                        s.Location,
                        s.Cost,
                        s.Manager
                    })
                    .ToList().Where(f => f.Manager == username);

                foreach (var staff in staffList)
                {
                    dataGridStaff.Rows.Add(
                        staff.FullName,
                        staff.Role,
                        staff.PhoneNumber,
                        staff.Location,
                        staff.Cost
                    );
                }

                dataGridStaff.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridStaff.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridStaff.SelectedRows[0];
                string fullName = selectedRow.Cells["Order"].Value?.ToString();

                _selectedStaff = _context.Staff.FirstOrDefault(s => s.FullName == fullName);

                if (_selectedStaff != null)
                {
                    txtFullname.Text = _selectedStaff.FullName ?? "";
                    txtRole.Text = _selectedStaff.Role ?? "";
                    txtPhoneNumber.Text = _selectedStaff.PhoneNumber ?? "";
                    txtLocation.Text = _selectedStaff.Location ?? "";
                    txtCost.Text = _selectedStaff.Cost?.ToString() ?? "";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStaffData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var newStaff = new Staff
                {
                    FullName = txtFullname.Text.Trim(),
                    Role = txtRole.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Location = txtLocation.Text.Trim(),
                    Cost = int.Parse(txtCost.Text.Trim()),
                    Manager = username
                };

                _context.Staff.Add(newStaff);
                _context.SaveChanges();

                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedStaff == null)
                {
                    MessageBox.Show("Please select a staff to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                _selectedStaff.FullName = txtFullname.Text.Trim();
                _selectedStaff.Role = txtRole.Text.Trim();
                _selectedStaff.PhoneNumber = txtPhoneNumber.Text.Trim();
                _selectedStaff.Location = txtLocation.Text.Trim();
                _selectedStaff.Cost = int.Parse(txtCost.Text.Trim());
                _selectedStaff.Manager = username;

                _context.SaveChanges();

                MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedStaff == null)
                {
                    MessageBox.Show("Please select a staff to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this staff? This will also delete related records.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                var orderHaveStaffs = _context.OrderHaveStaffs
                    .Where(ohs => ohs.StaffId == _selectedStaff.Id)
                    .ToList();
                if (orderHaveStaffs.Any())
                {
                    _context.OrderHaveStaffs.RemoveRange(orderHaveStaffs);
                }

                var staticStaffs = _context.StaticStaffs
                    .Where(ss => ss.StaffId == _selectedStaff.Id)
                    .ToList();
                if (staticStaffs.Any())
                {
                    _context.StaticStaffs.RemoveRange(staticStaffs);
                }

                _context.Staff.Remove(_selectedStaff);
                _context.SaveChanges();

                MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullname.Text) || txtFullname.Text == "Full name")
            {
                MessageBox.Show("Please enter a full name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text) || txtRole.Text == "Role")
            {
                MessageBox.Show("Please enter a role!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string phoneNumber = txtPhoneNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(phoneNumber) || txtPhoneNumber.Text == "Phone number")
            {
                MessageBox.Show("Please enter a phone number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(phoneNumber.Length == 10 && phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{10}$")) &&
                !(phoneNumber.Length == 9 && !phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{9}$")))
            {
                MessageBox.Show("Phone number must be 10 digits starting with 0, or 9 digits not starting with 0!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text == "Location")
            {
                MessageBox.Show("Please enter a location!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text) || txtCost.Text == "Cost" || !int.TryParse(txtCost.Text, out int cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid cost (non-negative number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtFullname.Text = "Full name";
            txtRole.Text = "Role";
            txtPhoneNumber.Text = "Phone number";
            txtLocation.Text = "Location";
            txtCost.Text = "Cost";
            _selectedStaff = null;
            dataGridStaff.ClearSelection();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}