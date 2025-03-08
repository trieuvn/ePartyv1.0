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
    public partial class Registration: Form
    {
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
            sc.Hide();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sc.Left += 10;
            if (sc.Left >= 780)
            {
                timer1.Stop();
            }
        }
        LoginShortcut sc=new LoginShortcut();
        private void Registration_Load(object sender, EventArgs e)
        {
            sc.Show();
        }

        private void btnstarted_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
