using System;
using System.Windows.Forms;
using BOLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        public void pass_color()
        {
            txtPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtLogin.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        public void login_color()
        {
            txtLogin.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtPass.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            login_color();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            pass_color();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pass_color();
                txtPass.Focus();
            }
        }

        private void lLforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all login information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 3 || username.Length > 32)
            {
                MessageBox.Show("Username must be between 6 and 32 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 2 || password.Length > 32)
            {
                MessageBox.Show("Password must be between 8 and 32 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    var manager = context.Managers
                        .AsNoTracking()
                        .FirstOrDefault(m => m.UserName == username && m.Password == password);

                    if (manager != null)
                    {
                        Properties.Settings.Default.LastUsername = manager.UserName;
                        Properties.Settings.Default.LastEmail = manager.Email;
                        Properties.Settings.Default.Save();

                        MessageBox.Show("Login successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        MenuForm m = new MenuForm(manager.UserName);
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
