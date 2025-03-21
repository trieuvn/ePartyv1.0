using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BOLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class ForgotPassword : Form
    {
        private string verificationCode;
        private string userEmail;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void lbRegistration_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please enter an email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    var manager = context.Managers
                        .AsNoTracking()
                        .FirstOrDefault(m => m.Email == userEmail);

                    if (manager != null)
                    {
                        SendVerificationCode(userEmail);
                    }
                    else
                    {
                        MessageBox.Show("Email does not exist in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendVerificationCode(string email)
        {
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ongngoai2513@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Password Reset Verification Code";
                mail.Body = $"Your verification code is: {verificationCode}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("epartyuef@gmail.com", "uyvn ibkq dlos jsnb"),
                    EnableSsl = true
                };

                smtp.Send(mail);

                MessageBox.Show("Verification code has been sent to your email!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email sending error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtVerifyCode.Text.Trim() == verificationCode)
            {
                MessageBox.Show("Verification successful! Please enter a new password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnConfirm.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid verification code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter both passwords!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    var manager = context.Managers.FirstOrDefault(m => m.Email == userEmail);
                    if (manager != null)
                    {
                        manager.Password = newPassword;
                        context.SaveChanges();

                        MessageBox.Show("Password has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password update error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Password update error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnCancelcode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
