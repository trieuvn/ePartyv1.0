using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using eParty.Properties;


namespace eParty
{
    public partial class LoginShortcut : Form
    {
        private string username;
        private string email;
        public LoginShortcut(string username, string email)
        {
            InitializeComponent();
            this.username = username;
            this.email = email;

            lbUsername.Text = this.username;
            lbGmail.Text = this.email;
        }


        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void lbGmail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Hide(); // Ẩn LoginShortcut

            // ✅ Tự động đăng nhập vào FormOrderList mà không cần nhập lại mật khẩu
            FormOrderList orderList = new FormOrderList(username, new List<string>());
            orderList.ShowDialog();

            this.Close(); // Đóng LoginShortcut khi hoàn tất        
        }
        private void LoginShortcut_Load(object sender, EventArgs e)
        {
            // ✅ Lấy dữ liệu từ Properties.Settings
            string lastUsername = Properties.Settings.Default.LastUsername;
            string lastEmail = Properties.Settings.Default.LastEmail;

            // Kiểm tra nếu có tài khoản đã đăng nhập trước đó
            if (!string.IsNullOrEmpty(lastUsername) && !string.IsNullOrEmpty(lastEmail))
            {
                lbUsername.Text = lastUsername;
                lbGmail.Text = lastEmail;
            }
        }
    }
}
