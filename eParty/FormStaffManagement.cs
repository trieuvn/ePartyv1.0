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
    public partial class FormStaffManagement : Form
    {
        private ListView? listViewStaff; // Marked as nullable
        private TextBox? txtFullName, txtRole, txtPhoneNumber, txtLocation, txtCost, txtPassword, txtManager; // Marked as nullable
        private Button? btnAdd, btnUpdate, btnDelete, btnBack; // Marked as nullable
        private Staff? selectedStaff; // Marked as nullable
        private Panel? detailPanel; // Marked as nullable

        public FormStaffManagement()
        {
            InitializeComponent();
            // Set form to full-screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeUI();
            LoadStaffList();
        }

        private void InitializeUI()
        {
            // Top panel for navigation
            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(10)
            };

            btnBack = new Button
            {
                Text = "⬅ Back",
                Size = new Size(90, 30),
                Location = new Point(10, 10)
            };
            btnBack.Click += (s, e) =>
            {
                this.Hide();
                new FormOrderList().ShowDialog();
                this.Close();
            };

            Button btnExit = new Button
            {
                Text = "❌ Exit",
                Size = new Size(80, 30),
                Location = new Point(btnBack.Right + 10, 10),
            };
            btnExit.Click += (s, e) => Application.Exit();

            topPanel.Controls.AddRange(new Control[] { btnBack, btnExit });
            this.Controls.Add(topPanel);

            // Kích thước và margin
            int margin = 10;
            // Adjust the proportions: ListView takes 55% of the width (previously 60%) to give more space to detail panel
            int listViewWidth = (int)(this.ClientSize.Width * 0.55);
            int detailWidth = this.ClientSize.Width - listViewWidth - (3 * margin);

            // Panel chứa danh sách nhân viên với scroll
            Panel listViewPanel = new Panel
            {
                Location = new Point(margin, topPanel.Bottom + margin),
                Size = new Size(listViewWidth, this.ClientSize.Height - topPanel.Height - (2 * margin)),
                AutoScroll = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // ListView to display staff
            listViewStaff = new ListView
            {
                Location = new Point(0, 0),
                Size = new Size(listViewWidth - 20, listViewPanel.Height - 20), // Adjust for scroll bar
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            listViewStaff.Columns.Add("ID", 50);
            listViewStaff.Columns.Add("Full Name", 100);
            listViewStaff.Columns.Add("Role", 80);
            listViewStaff.Columns.Add("Phone Number", 100);
            listViewStaff.Columns.Add("Location", 100);
            listViewStaff.Columns.Add("Cost", 60);
            listViewStaff.Columns.Add("Manager", 100);
            listViewStaff.SelectedIndexChanged += ListViewStaff_SelectedIndexChanged;

            listViewPanel.Controls.Add(listViewStaff);

            // Detail panel for staff information
    detailPanel = new Panel
    {
        Location = new Point(listViewPanel.Right + margin, topPanel.Bottom + margin),
        Size = new Size(detailWidth, listViewPanel.Height),
        BorderStyle = BorderStyle.FixedSingle,
        Padding = new Padding(15),
        AutoScroll = true,
        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right
    };

    int lblWidth = 120, ctrlWidth = detailPanel.Width - lblWidth - 70; // Adjusted for more space to accommodate buttons
    int y = 20, spacing = 40;

    txtFullName = new TextBox { Location = new Point(lblWidth + 20, y), Width = ctrlWidth };
    txtRole = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
    txtPhoneNumber = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
    txtLocation = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
    txtCost = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };
    txtPassword = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth, PasswordChar = '*' };
    txtManager = new TextBox { Location = new Point(lblWidth + 20, y += spacing), Width = ctrlWidth };

    // Create a FlowLayoutPanel to place buttons vertically
    FlowLayoutPanel buttonPanel = new FlowLayoutPanel
    {
        FlowDirection = FlowDirection.TopDown,
        Location = new Point(lblWidth + 20, y += spacing),
        Width = ctrlWidth,
        AutoSize = true,
        AutoSizeMode = AutoSizeMode.GrowAndShrink,
        Padding = new Padding(0)
    };

    // Buttons inside the panel
    btnAdd = new Button { Text = "Add", Size = new Size(100, 35) };
    btnAdd.Click += BtnAdd_Click;

    btnUpdate = new Button { Text = "Update", Size = new Size(100, 35) };
    btnUpdate.Click += BtnUpdate_Click;

    btnDelete = new Button { Text = "Delete", Size = new Size(100, 35), BackColor = Color.LightCoral };
    btnDelete.Click += BtnDelete_Click;

    buttonPanel.Controls.AddRange(new Control[] { btnAdd, btnUpdate, btnDelete });

    detailPanel.Controls.AddRange(new Control[]
    {
        new Label { Text = "Full Name:", Location = new Point(10, 20) }, txtFullName,
        new Label { Text = "Role:", Location = new Point(10, 60) }, txtRole,
        new Label { Text = "Phone Number:", Location = new Point(10, 100) }, txtPhoneNumber,
        new Label { Text = "Location:", Location = new Point(10, 140) }, txtLocation,
        new Label { Text = "Cost:", Location = new Point(10, 180) }, txtCost,
        new Label { Text = "Password:", Location = new Point(10, 220) }, txtPassword,
        new Label { Text = "Manager:", Location = new Point(10, 260) }, txtManager,
        buttonPanel // Add the button panel here
    });

    this.Controls.AddRange(new Control[] { listViewPanel, detailPanel });
        }

        private void LoadStaffList()
        {
            listViewStaff?.Items.Clear(); // Use null-conditional operator

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    var staffs = context.Staff
                        .AsNoTracking()
                        .ToList();

                    foreach (var staff in staffs)
                    {
                        ListViewItem item = new ListViewItem(staff.Id.ToString());
                        item.SubItems.Add(staff.FullName ?? "N/A");
                        item.SubItems.Add(staff.Role ?? "N/A");
                        item.SubItems.Add(staff.PhoneNumber ?? "N/A");
                        item.SubItems.Add(staff.Location ?? "N/A");
                        item.SubItems.Add(staff.Cost?.ToString() ?? "0");
                        item.SubItems.Add(staff.Manager ?? "N/A");
                        item.Tag = staff; // Store the staff object in the Tag for easy access
                        listViewStaff?.Items.Add(item); // Use null-conditional operator
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff?.SelectedItems.Count > 0) // Use null-conditional operator
            {
                selectedStaff = (Staff)listViewStaff.SelectedItems[0].Tag;
                LoadStaffDetails(selectedStaff);
            }
            else
            {
                ClearForm();
            }
        }

        private void LoadStaffDetails(Staff staff)
        {
            txtFullName!.Text = staff.FullName ?? ""; // Use null-forgiving operator
            txtRole!.Text = staff.Role ?? "";
            txtPhoneNumber!.Text = staff.PhoneNumber ?? "";
            txtLocation!.Text = staff.Location ?? "";
            txtCost!.Text = staff.Cost?.ToString() ?? "";
            txtPassword!.Text = staff.Password ?? "";
            txtManager!.Text = staff.Manager ?? "";
        }

        private void ClearForm()
        {
            txtFullName!.Text = ""; // Use null-forgiving operator
            txtRole!.Text = "";
            txtPhoneNumber!.Text = "";
            txtLocation!.Text = "";
            txtCost!.Text = "";
            txtPassword!.Text = "";
            txtManager!.Text = "";
            selectedStaff = null;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new ePartyDbDbContext())
            {
                var newStaff = new Staff
                {
                    FullName = txtFullName!.Text.Trim(), // Use null-forgiving operator
                    Role = txtRole!.Text.Trim(),
                    PhoneNumber = txtPhoneNumber!.Text.Trim(),
                    Location = txtLocation!.Text.Trim(),
                    Cost = string.IsNullOrEmpty(txtCost!.Text) ? null : (int?)int.Parse(txtCost.Text.Trim()),
                    Password = txtPassword!.Text.Trim(),
                    Manager = txtManager!.Text.Trim()
                };

                // Validate Manager exists
                if (!string.IsNullOrEmpty(newStaff.Manager))
                {
                    var managerExists = context.Managers.Any(m => m.UserName == newStaff.Manager);
                    if (!managerExists)
                    {
                        MessageBox.Show("Manager does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                context.Staff.Add(newStaff);
                context.SaveChanges();

                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffList();
                ClearForm();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaff == null)
            {
                MessageBox.Show("Please select a staff to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ePartyDbDbContext())
            {
                var staffToUpdate = context.Staff.FirstOrDefault(s => s.Id == selectedStaff.Id);
                if (staffToUpdate == null)
                {
                    MessageBox.Show("Staff not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if staff has orders
                var hasOrders = context.OrderHaveStaffs.Any(ohs => ohs.StaffId == staffToUpdate.Id);
                if (hasOrders)
                {
                    MessageBox.Show("This staff has associated orders. Please remove the orders before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                staffToUpdate.FullName = txtFullName!.Text.Trim(); // Use null-forgiving operator
                staffToUpdate.Role = txtRole!.Text.Trim();
                staffToUpdate.PhoneNumber = txtPhoneNumber!.Text.Trim();
                staffToUpdate.Location = txtLocation!.Text.Trim();
                staffToUpdate.Cost = string.IsNullOrEmpty(txtCost!.Text) ? null : (int?)int.Parse(txtCost.Text.Trim());
                staffToUpdate.Password = txtPassword!.Text.Trim();
                staffToUpdate.Manager = txtManager!.Text.Trim();

                // Validate Manager exists
                if (!string.IsNullOrEmpty(staffToUpdate.Manager))
                {
                    var managerExists = context.Managers.Any(m => m.UserName == staffToUpdate.Manager);
                    if (!managerExists)
                    {
                        MessageBox.Show("Manager does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffList();
                ClearForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaff == null)
            {
                MessageBox.Show("Please select a staff to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            using (var context = new ePartyDbDbContext())
            {
                var staffToDelete = context.Staff.FirstOrDefault(s => s.Id == selectedStaff.Id);
                if (staffToDelete == null)
                {
                    MessageBox.Show("Staff not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if staff has orders
                var hasOrders = context.OrderHaveStaffs.Any(ohs => ohs.StaffId == staffToDelete.Id);
                if (hasOrders)
                {
                    MessageBox.Show("This staff has associated orders. Please remove the orders before deleting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Remove the staff directly (removed OutdatedStaffs logic)
                context.Staff.Remove(staffToDelete);
                context.SaveChanges();

                MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffList();
                ClearForm();
            }
        }
    }
}