using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eParty
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            PnlNavbar = new Panel();
            BtnReport = new ArtanButton();
            BtnSchedule = new ArtanButton();
            BtnResource = new ArtanButton();
            BtnDashboard = new ArtanButton();
            panel2 = new Panel();
            lblID = new Label();
            pBDefault = new PictureBox();
            lblName = new Label();
            BtnOut = new ArtanButton();
            panel1 = new Panel();
            pbTitle = new PictureBox();
            BtnNavbar = new ArtanButton();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            btnClose = new ArtanButton();
            btnExit = new ArtanButton();
            panelContainer = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            eclipseControl1 = new EclipseControl();
            rjDropdownMenu1 = new RJDropdownMenu(components);
            staffListToolStripMenuItem = new ToolStripMenuItem();
            ingreListToolStripMenuItem = new ToolStripMenuItem();
            foodListToolStripMenuItem = new ToolStripMenuItem();
            rjDropdownMenu2 = new RJDropdownMenu(components);
            createOrderToolStripMenuItem = new ToolStripMenuItem();
            orderDetailToolStripMenuItem = new ToolStripMenuItem();
            PnlNavbar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBDefault).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            panel3.SuspendLayout();
            rjDropdownMenu1.SuspendLayout();
            rjDropdownMenu2.SuspendLayout();
            SuspendLayout();
            // 
            // PnlNavbar
            // 
            PnlNavbar.Controls.Add(BtnReport);
            PnlNavbar.Controls.Add(BtnSchedule);
            PnlNavbar.Controls.Add(BtnResource);
            PnlNavbar.Controls.Add(BtnDashboard);
            PnlNavbar.Controls.Add(panel2);
            PnlNavbar.Controls.Add(panel1);
            PnlNavbar.Dock = DockStyle.Left;
            PnlNavbar.Location = new Point(10, 10);
            PnlNavbar.Margin = new Padding(0);
            PnlNavbar.Name = "PnlNavbar";
            PnlNavbar.Size = new Size(275, 860);
            PnlNavbar.TabIndex = 0;
            // 
            // BtnReport
            // 
            BtnReport.BackColor = Color.White;
            BtnReport.BackgroundColor = Color.White;
            BtnReport.BorderColor = Color.White;
            BtnReport.BorderRadius = 20;
            BtnReport.BorderSize = 0;
            BtnReport.Dock = DockStyle.Top;
            BtnReport.FlatAppearance.BorderSize = 0;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.ForeColor = Color.FromArgb(69, 69, 74);
            BtnReport.Image = (Image)resources.GetObject("BtnReport.Image");
            BtnReport.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReport.Location = new Point(0, 308);
            BtnReport.Name = "BtnReport";
            BtnReport.Padding = new Padding(20, 0, 0, 0);
            BtnReport.Size = new Size(275, 57);
            BtnReport.TabIndex = 6;
            BtnReport.Text = "Report";
            BtnReport.TextColor = Color.FromArgb(69, 69, 74);
            BtnReport.UseVisualStyleBackColor = false;
            BtnReport.Click += BtnReport_Click;
            // 
            // BtnSchedule
            // 
            BtnSchedule.BackColor = Color.White;
            BtnSchedule.BackgroundColor = Color.White;
            BtnSchedule.BorderColor = Color.White;
            BtnSchedule.BorderRadius = 20;
            BtnSchedule.BorderSize = 0;
            BtnSchedule.Dock = DockStyle.Top;
            BtnSchedule.FlatAppearance.BorderSize = 0;
            BtnSchedule.FlatStyle = FlatStyle.Flat;
            BtnSchedule.ForeColor = Color.FromArgb(69, 69, 74);
            BtnSchedule.Image = (Image)resources.GetObject("BtnSchedule.Image");
            BtnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSchedule.Location = new Point(0, 251);
            BtnSchedule.Name = "BtnSchedule";
            BtnSchedule.Padding = new Padding(20, 0, 0, 0);
            BtnSchedule.Size = new Size(275, 57);
            BtnSchedule.TabIndex = 5;
            BtnSchedule.Text = "Schedule";
            BtnSchedule.TextColor = Color.FromArgb(69, 69, 74);
            BtnSchedule.UseVisualStyleBackColor = false;
            BtnSchedule.Click += BtnSchedule_Click;
            // 
            // BtnResource
            // 
            BtnResource.BackColor = Color.White;
            BtnResource.BackgroundColor = Color.White;
            BtnResource.BorderColor = Color.White;
            BtnResource.BorderRadius = 20;
            BtnResource.BorderSize = 0;
            BtnResource.Dock = DockStyle.Top;
            BtnResource.FlatAppearance.BorderSize = 0;
            BtnResource.FlatStyle = FlatStyle.Flat;
            BtnResource.ForeColor = Color.FromArgb(69, 69, 74);
            BtnResource.Image = (Image)resources.GetObject("BtnResource.Image");
            BtnResource.ImageAlign = ContentAlignment.MiddleLeft;
            BtnResource.Location = new Point(0, 194);
            BtnResource.Name = "BtnResource";
            BtnResource.Padding = new Padding(20, 0, 0, 0);
            BtnResource.Size = new Size(275, 57);
            BtnResource.TabIndex = 4;
            BtnResource.Text = "Resource";
            BtnResource.TextColor = Color.FromArgb(69, 69, 74);
            BtnResource.UseVisualStyleBackColor = false;
            BtnResource.Click += BtnResource_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.White;
            BtnDashboard.BackgroundColor = Color.White;
            BtnDashboard.BorderColor = Color.White;
            BtnDashboard.BorderRadius = 20;
            BtnDashboard.BorderSize = 0;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.ForeColor = Color.FromArgb(69, 69, 74);
            BtnDashboard.Image = (Image)resources.GetObject("BtnDashboard.Image");
            BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.Location = new Point(0, 137);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Padding = new Padding(20, 0, 0, 0);
            BtnDashboard.Size = new Size(275, 57);
            BtnDashboard.TabIndex = 3;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextColor = Color.FromArgb(69, 69, 74);
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblID);
            panel2.Controls.Add(pBDefault);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(BtnOut);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 811);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 49);
            panel2.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 4F, FontStyle.Bold);
            lblID.Location = new Point(53, 29);
            lblID.Name = "lblID";
            lblID.Size = new Size(12, 10);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // pBDefault
            // 
            pBDefault.Image = (Image)resources.GetObject("pBDefault.Image");
            pBDefault.Location = new Point(12, 7);
            pBDefault.Name = "pBDefault";
            pBDefault.Size = new Size(35, 35);
            pBDefault.SizeMode = PictureBoxSizeMode.StretchImage;
            pBDefault.TabIndex = 1;
            pBDefault.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 6F, FontStyle.Bold);
            lblName.Location = new Point(53, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(32, 12);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += lb1_Click;
            // 
            // BtnOut
            // 
            BtnOut.BackColor = Color.White;
            BtnOut.BackgroundColor = Color.White;
            BtnOut.BorderColor = Color.White;
            BtnOut.BorderRadius = 20;
            BtnOut.BorderSize = 0;
            BtnOut.Dock = DockStyle.Right;
            BtnOut.FlatAppearance.BorderSize = 0;
            BtnOut.FlatStyle = FlatStyle.Flat;
            BtnOut.ForeColor = Color.White;
            BtnOut.Image = (Image)resources.GetObject("BtnOut.Image");
            BtnOut.Location = new Point(228, 0);
            BtnOut.Name = "BtnOut";
            BtnOut.Size = new Size(47, 49);
            BtnOut.TabIndex = 3;
            BtnOut.TextColor = Color.White;
            BtnOut.UseVisualStyleBackColor = false;
            BtnOut.Click += BtnOut_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbTitle);
            panel1.Controls.Add(BtnNavbar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 137);
            panel1.TabIndex = 0;
            // 
            // pbTitle
            // 
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.Location = new Point(3, 23);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(234, 86);
            pbTitle.SizeMode = PictureBoxSizeMode.AutoSize;
            pbTitle.TabIndex = 7;
            pbTitle.TabStop = false;
            // 
            // BtnNavbar
            // 
            BtnNavbar.BackColor = Color.White;
            BtnNavbar.BackgroundColor = Color.White;
            BtnNavbar.BorderColor = Color.White;
            BtnNavbar.BorderRadius = 20;
            BtnNavbar.BorderSize = 0;
            BtnNavbar.Dock = DockStyle.Right;
            BtnNavbar.FlatAppearance.BorderSize = 0;
            BtnNavbar.FlatStyle = FlatStyle.Flat;
            BtnNavbar.ForeColor = Color.FromArgb(69, 69, 74);
            BtnNavbar.Image = (Image)resources.GetObject("BtnNavbar.Image");
            BtnNavbar.Location = new Point(243, 0);
            BtnNavbar.Name = "BtnNavbar";
            BtnNavbar.Size = new Size(32, 137);
            BtnNavbar.TabIndex = 6;
            BtnNavbar.TextColor = Color.FromArgb(69, 69, 74);
            BtnNavbar.UseVisualStyleBackColor = false;
            BtnNavbar.Click += BtnNavbar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 128, 182);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(285, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1266, 23);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(42, 128, 182);
            btnClose.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnClose.BorderColor = Color.FromArgb(42, 128, 182);
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1220, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 2;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(42, 128, 182);
            btnExit.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnExit.BorderColor = Color.FromArgb(42, 128, 182);
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1246, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 20);
            btnExit.TabIndex = 1;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(285, 33);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1266, 837);
            panelContainer.TabIndex = 5;
            // 
            // eclipseControl1
            // 
            eclipseControl1.CornerRedius = 50;
            eclipseControl1.TargetControl = this;
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.ImageScalingSize = new Size(32, 32);
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { staffListToolStripMenuItem, ingreListToolStripMenuItem, foodListToolStripMenuItem });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.Empty;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.Empty;
            rjDropdownMenu1.Size = new Size(139, 76);
            // 
            // staffListToolStripMenuItem
            // 
            staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            staffListToolStripMenuItem.Size = new Size(138, 24);
            staffListToolStripMenuItem.Text = "Staff List";
            staffListToolStripMenuItem.Click += staffListToolStripMenuItem_Click;
            // 
            // ingreListToolStripMenuItem
            // 
            ingreListToolStripMenuItem.Name = "ingreListToolStripMenuItem";
            ingreListToolStripMenuItem.Size = new Size(138, 24);
            ingreListToolStripMenuItem.Text = "Ingre List";
            ingreListToolStripMenuItem.Click += ingreListToolStripMenuItem_Click;
            // 
            // foodListToolStripMenuItem
            // 
            foodListToolStripMenuItem.Name = "foodListToolStripMenuItem";
            foodListToolStripMenuItem.Size = new Size(138, 24);
            foodListToolStripMenuItem.Text = "Food List";
            foodListToolStripMenuItem.Click += foodListToolStripMenuItem_Click;
            // 
            // rjDropdownMenu2
            // 
            rjDropdownMenu2.ImageScalingSize = new Size(32, 32);
            rjDropdownMenu2.IsMainMenu = false;
            rjDropdownMenu2.Items.AddRange(new ToolStripItem[] { createOrderToolStripMenuItem, orderDetailToolStripMenuItem });
            rjDropdownMenu2.MenuItemHeight = 25;
            rjDropdownMenu2.MenuItemTextColor = Color.Empty;
            rjDropdownMenu2.Name = "rjDropdownMenu2";
            rjDropdownMenu2.PrimaryColor = Color.Empty;
            rjDropdownMenu2.Size = new Size(164, 52);
            // 
            // createOrderToolStripMenuItem
            // 
            createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            createOrderToolStripMenuItem.Size = new Size(163, 24);
            createOrderToolStripMenuItem.Text = "Create Order";
            // 
            // orderDetailToolStripMenuItem
            // 
            orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            orderDetailToolStripMenuItem.Size = new Size(163, 24);
            orderDetailToolStripMenuItem.Text = "Order Detail";
            // 
            // MenuForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1561, 880);
            Controls.Add(panelContainer);
            Controls.Add(panel3);
            Controls.Add(PnlNavbar);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(69, 69, 74);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load_1;
            MouseDown += MenuForm_MouseDown;
            PnlNavbar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBDefault).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            panel3.ResumeLayout(false);
            rjDropdownMenu1.ResumeLayout(false);
            rjDropdownMenu2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PnlNavbar;
        private System.Windows.Forms.Panel panel1;
        private EclipseControl eclipseControl1;
        private ArtanButton btnExit;
        private ArtanButton btnClose;
        private ArtanButton BtnReport;
        private ArtanButton BtnSchedule;
        private ArtanButton BtnResource;
        private ArtanButton BtnDashboard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ArtanButton BtnNavbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pBDefault;
        private System.Windows.Forms.Label lblName;
        private ArtanButton BtnOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingreListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodListToolStripMenuItem;
        private RJDropdownMenu rjDropdownMenu2;
        private ToolStripMenuItem createOrderToolStripMenuItem;
        private ToolStripMenuItem orderDetailToolStripMenuItem;
        private PictureBox pbTitle;
    }
    #endregion
}