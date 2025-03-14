using BOLayer.Repository.Models;
using eParty.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eParty
{
    public partial class MenuForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        public void btnChange(object sender, EventArgs e)
        {
            ArtanButton button = (ArtanButton)sender;
            button.ForeColor = Color.FromArgb(42, 128, 182);
            switch (button.Name)
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
                    button.Image = ByteArrayToImage(Resources.Out2);
                    break;
            }
        }
        public void Origion(object sender, EventArgs e)
        {
            ArtanButton clickedButton = sender as ArtanButton;

            foreach (var item in PnlNavbar.Controls.OfType<ArtanButton>())
            {
                item.ForeColor = Color.FromArgb(69, 69, 74);
                item.BackColor = Color.White;

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

            if (clickedButton != null)
            {
                btnChange(sender, e);
                clickedButton.BackColor = Color.FromArgb(255, 207, 235, 255);
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }


        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
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
            }
        }
        Dashboard db = new Dashboard();
        private void timer2_Tick(object sender, EventArgs e)
        {
            BtnDashboard.Text = "Dashboard";
            BtnResource.Text = "Resource";
            BtnReport.Text = "Report";
            BtnSchedule.Text = "Schedule";
            lb1.Visible = true;
            lb2.Visible = true;

            PnlNavbar.Width = PnlNavbar.Width + 5;
            if (PnlNavbar.Width >= 275)
            {
                BtnNavbar.Image = ByteArrayToImage(Resources.previous);
                timer2.Stop();


            }
            pbTitle.Visible = true;
            BtnOut.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this application ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
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

        private void BtnNavbar_Click(object sender, EventArgs e)
        {
            if (PnlNavbar.Width == 275)
                timer1.Start();

            else
                timer2.Start();
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
            Origion(sender, e);
            OpenChildForm(new Dashboard());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) =>
                DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrlL)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrlL.BackColor = Color.FromArgb(255, 207, 235, 255);
                else
                    ctrlL.BackColor = Color.FromArgb(255, 207, 235, 255);
            }
        }
        private void BtnResource_Click(object sender, EventArgs e)
        {
            Origion(sender, e);
            Open_DropdownMenu(rjDropdownMenu1, sender);
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffListForm());
        }
        private void ingreListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IngredientListForm());
        }

        private void foodListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodListForm());
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            Origion(sender, e);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Origion(sender, e);
        }
    }
}
