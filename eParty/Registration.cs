using System;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnstarted_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string fullName = txtFullname.Text.Trim();
            string phoneNumber = txtphone.Text.Trim();
            string location = txtAddress.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirmPassword = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(location) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username.Length < 6 || username.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-z0-9]+$"))
            {
                MessageBox.Show("Username must be 6-50 characters and contain only lowercase letters and numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8 || password.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,32}$"))
            {
                MessageBox.Show("Password must be 8-50 characters with at least 1 lowercase, 1 uppercase, 1 number, and 1 special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[\w\.-]+@([\w\-]+\.)?(gmail\.com|yahoo\.com|uef.edu.vn)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email must be from gmail.com, yahoo.com, or uef.edu.vn domains!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(phoneNumber.Length == 10 && phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{10}$")) &&
                !(phoneNumber.Length == 9 && !phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{9}$")))
            {
                MessageBox.Show("Phone number must be 10 digits starting with 0, or 9 digits not starting with 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    if (context.Managers.Any(m => m.UserName == username))
                    {
                        MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (context.Managers.Any(m => m.Email == email))
                    {
                        MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (context.Managers.Any(m => m.PhoneNumber == phoneNumber))
                    {
                        MessageBox.Show("Phone number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newManager = new Manager
                    {
                        UserName = username,
                        Email = email,
                        FullName = fullName,
                        PhoneNumber = phoneNumber,
                        Location = location,
                        Password = password
                    };

                    context.Managers.Add(newManager);
                    context.SaveChanges();

                    MessageBox.Show("Registration successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login loginForm= new Login();
                    loginForm.Show();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
