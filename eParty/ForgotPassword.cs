using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
                MessageBox.Show("Vui lòng nhập email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Manager WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        SendVerificationCode(userEmail);  // Gửi mã xác nhận qua email
                    }
                    else
                    {
                        MessageBox.Show("Email không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SendVerificationCode(string email)
        {
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString(); // Tạo mã ngẫu nhiên 6 số

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ongngoai2513@gmail.com");  // Thay bằng email của bạn
                mail.To.Add(email);
                mail.Subject = "Mã xác nhận đổi mật khẩu";
                mail.Body = $"Mã xác nhận của bạn là: {verificationCode}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,  // Cổng SMTP của Gmail
                    Credentials = new NetworkCredential("epartyuef@gmail.com", "uyvn ibkq dlos jsnb"), // Thay bằng email & App Password
                    EnableSsl = true
                };

                smtp.Send(mail); // 🟢 Quan trọng: Thêm dòng này để gửi email thực sự

                MessageBox.Show("Mã xác nhận đã được gửi tới email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtVerifyCode.Text.Trim() == verificationCode)
            {
                MessageBox.Show("Xác nhận thành công! Hãy nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnConfirm.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelcode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "UPDATE Manager SET Password = @Password WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mật khẩu đã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btncancelpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
