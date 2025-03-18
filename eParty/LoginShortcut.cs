using System;
using System.Windows.Forms;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderList orderList = new FormOrderList(username, new List<string>());
            orderList.ShowDialog();
            this.Close();
        }

        private void LoginShortcut_Load(object sender, EventArgs e)
        {
            string lastUsername = Properties.Settings.Default.LastUsername;
            string lastEmail = Properties.Settings.Default.LastEmail;

            if (!string.IsNullOrEmpty(lastUsername) && !string.IsNullOrEmpty(lastEmail))
            {
                lbUsername.Text = lastUsername;
                lbGmail.Text = lastEmail;
            }
        }
    }
}
