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
using System.Configuration;
using eParty.Properties;


namespace eParty
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        public void pass_color()
        {
            txtPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtLogin.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

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

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "SELECT UserName, Email FROM Manager WHERE UserName = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string user = reader["UserName"].ToString();
                            string email = reader["Email"].ToString();

                            // ✅ Lưu thông tin tài khoản vào Settings
                            Properties.Settings.Default.LastUsername = user;
                            Properties.Settings.Default.LastEmail = email;
                            Properties.Settings.Default.Save();

                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Chuyển sang FormOrderList
                            this.Hide();
                            FormOrderList orderList = new FormOrderList(user, new List<string>());
                            orderList.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            string lastUsername = Properties.Settings.Default.LastUsername;
            string lastEmail = Properties.Settings.Default.LastEmail;

            if (!string.IsNullOrEmpty(lastUsername) && !string.IsNullOrEmpty(lastEmail) && Application.OpenForms["LoginShortcut"] == null)
            {
                // ✅ Hiển thị LoginShortcut nếu có tài khoản trước đó
                LoginShortcut shortcutForm = new LoginShortcut(lastUsername, lastEmail);
                shortcutForm.Show();
            }
        }
    }
}
