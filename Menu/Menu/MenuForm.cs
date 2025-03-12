using Menu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Menu
{
    public partial class MenuForm: Form
    {
        DashboardForm db = new DashboardForm();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void artanButton2_Click(object sender, EventArgs e)
        {

        }

        private void artanButton4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PnlNavbar.Width = PnlNavbar.Width - 5;
            
            
            if (PnlNavbar.Width <= 65)
            {
                BtnNavbar.Image = ByteArrayToImage(Resources.Next);
                timer1.Stop();

                pbTitle.Visible = false;
                BtnDashboard.Text = "";
                BtnResource.Text = "";
                BtnReport.Text = "";
                BtnSchedule.Text = "";
                lb1.Visible = false;
                lb2.Visible = false;
                BtnOut.Visible = false;
                db.chart3.Visible = true;
                db.chart4.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BtnDashboard.Text = "Dashboard";
            BtnResource.Text = "Resource";
            BtnReport.Text = "Report";
            BtnSchedule.Text = "Schedule";
            lb1.Visible = true;
            lb2.Visible = true;

            PnlNavbar.Width = PnlNavbar.Width + 5;
            if (PnlNavbar.Width >= 230)
            {
                BtnNavbar.Image = ByteArrayToImage(Resources.previous);
                timer2.Stop();
                
                
            }
            pbTitle.Visible = true;
            BtnOut.Visible = true;
            db.chart3.Visible = false;
            db.chart4.Visible = false;
        }

        private void BtnNavbar_Click(object sender, EventArgs e)
        {
            if (PnlNavbar.Width == 230)
                timer1.Start();
                
            else
                timer2.Start();
        }

        private void BtnDark_MouseHover(object sender, EventArgs e)
        {

        }
         
        private void PnlNavbar_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            ArtanButton button = (ArtanButton)sender;
            button.ForeColor = Color.FromArgb(42,128,182);
            switch(button.Name)
            {
                case "BtnDashboard":
                    button.Image = ByteArrayToImage(Resources.Dashboard2);
                    break;
                case "BtnResource":
                    button.Image = ByteArrayToImage(Resources.Resource2);
                    break;
                case "BtnSchedule":
                    button.Image = ByteArrayToImage(Resources.Schedule2);
                    break;
                case "BtnReport":
                    button.Image = ByteArrayToImage(Resources.Report2);
                    break;
                case "BtnOut":
                    button.Image=ByteArrayToImage(Resources.Out2);
                    break;
            }
        }

        private void BtnReport_MouseLeave(object sender, EventArgs e)
        {
            
            foreach (var item in PnlNavbar.Controls.OfType<ArtanButton>())
            {
                item.ForeColor = Color.FromArgb(69,69,74);
                switch (item.Name)
                {
                    case "BtnDashboard":
                        item.Image = ByteArrayToImage(Resources.Dashboard1);
                        break;
                    case "BtnResource":
                        item.Image = ByteArrayToImage(Resources.Resource1);
                        break;
                    case "BtnSchedule":
                        item.Image = ByteArrayToImage(Resources.Schedule1);
                        break;
                    case "BtnReport":
                        item.Image = ByteArrayToImage(Resources.Report1);
                        break;
                    
                }
            }
                
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {
            if(pBDefault.Image==null)
           pBDefault.Image = ByteArrayToImage(Resources.Default);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            

            DialogResult dr=MessageBox.Show("Do you want to exit this application ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Process currentProcess = Process.GetCurrentProcess();

                var parentProcess = Process.GetProcesses()
                                           .FirstOrDefault(p => p.ProcessName.Contains("eParty"));

                if (parentProcess != null)
                {
                    parentProcess.Kill();
                }

                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnOut_MouseLeave(object sender, EventArgs e)
        {
            BtnOut.Image = ByteArrayToImage(Resources.Out1);
        }

        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            panelContainer.Controls.Clear();
            panelContainer.AutoSize = true;

            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.Padding = new Padding(0);
            childForm.Margin = new Padding(0);

            panelContainer.AutoScroll = false;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.Show();
            childForm.BringToFront();

            panelContainer.Refresh();
        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(db);
        }
    }
}
