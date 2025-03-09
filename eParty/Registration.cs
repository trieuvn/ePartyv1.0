using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace eParty
{
    public partial class Registration : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
       
        public Registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void btnstarted_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirmPassword = txtConfirmPass.Text.Trim();

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "INSERT INTO Manager (UserName, Email, Password) VALUES (@UserName, @Email, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ẩn form đăng ký và mở LoginShortcut
                        this.Hide();
                        LoginShortcut shortcutForm = new LoginShortcut(username, email);
                        shortcutForm.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
