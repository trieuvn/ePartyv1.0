using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace eParty
{
    public partial class Login: Form
    {
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
    }
}
