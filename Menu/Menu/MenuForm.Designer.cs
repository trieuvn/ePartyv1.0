namespace Menu
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PnlNavbar = new System.Windows.Forms.Panel();
            this.BtnReport = new Menu.ArtanButton();
            this.BtnSchedule = new Menu.ArtanButton();
            this.BtnResource = new Menu.ArtanButton();
            this.BtnDashboard = new Menu.ArtanButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb2 = new System.Windows.Forms.Label();
            this.pBDefault = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.BtnOut = new Menu.ArtanButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNavbar = new Menu.ArtanButton();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new Menu.ArtanButton();
            this.btnExit = new Menu.ArtanButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eclipseControl1 = new Menu.EclipseControl();
            this.PnlNavbar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDefault)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNavbar
            // 
            this.PnlNavbar.Controls.Add(this.BtnReport);
            this.PnlNavbar.Controls.Add(this.BtnSchedule);
            this.PnlNavbar.Controls.Add(this.BtnResource);
            this.PnlNavbar.Controls.Add(this.BtnDashboard);
            this.PnlNavbar.Controls.Add(this.panel2);
            this.PnlNavbar.Controls.Add(this.panel1);
            this.PnlNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNavbar.Location = new System.Drawing.Point(10, 10);
            this.PnlNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlNavbar.Name = "PnlNavbar";
            this.PnlNavbar.Size = new System.Drawing.Size(230, 430);
            this.PnlNavbar.TabIndex = 0;
            this.PnlNavbar.MouseHover += new System.EventHandler(this.PnlNavbar_MouseHover);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.White;
            this.BtnReport.BackgroundColor = System.Drawing.Color.White;
            this.BtnReport.BorderColor = System.Drawing.Color.White;
            this.BtnReport.BorderRadius = 20;
            this.BtnReport.BorderSize = 0;
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(0, 257);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnReport.Size = new System.Drawing.Size(230, 40);
            this.BtnReport.TabIndex = 6;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.artanButton4_Click);
            this.BtnReport.MouseLeave += new System.EventHandler(this.BtnReport_MouseLeave);
            this.BtnReport.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.BackColor = System.Drawing.Color.White;
            this.BtnSchedule.BackgroundColor = System.Drawing.Color.White;
            this.BtnSchedule.BorderColor = System.Drawing.Color.White;
            this.BtnSchedule.BorderRadius = 20;
            this.BtnSchedule.BorderSize = 0;
            this.BtnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSchedule.FlatAppearance.BorderSize = 0;
            this.BtnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("BtnSchedule.Image")));
            this.BtnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSchedule.Location = new System.Drawing.Point(0, 217);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSchedule.Size = new System.Drawing.Size(230, 40);
            this.BtnSchedule.TabIndex = 5;
            this.BtnSchedule.Text = "Schedule";
            this.BtnSchedule.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnSchedule.UseVisualStyleBackColor = false;
            this.BtnSchedule.MouseLeave += new System.EventHandler(this.BtnReport_MouseLeave);
            this.BtnSchedule.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // BtnResource
            // 
            this.BtnResource.BackColor = System.Drawing.Color.White;
            this.BtnResource.BackgroundColor = System.Drawing.Color.White;
            this.BtnResource.BorderColor = System.Drawing.Color.White;
            this.BtnResource.BorderRadius = 20;
            this.BtnResource.BorderSize = 0;
            this.BtnResource.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnResource.FlatAppearance.BorderSize = 0;
            this.BtnResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnResource.Image = ((System.Drawing.Image)(resources.GetObject("BtnResource.Image")));
            this.BtnResource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResource.Location = new System.Drawing.Point(0, 177);
            this.BtnResource.Name = "BtnResource";
            this.BtnResource.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnResource.Size = new System.Drawing.Size(230, 40);
            this.BtnResource.TabIndex = 4;
            this.BtnResource.Text = "Resource";
            this.BtnResource.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnResource.UseVisualStyleBackColor = false;
            this.BtnResource.Click += new System.EventHandler(this.artanButton2_Click);
            this.BtnResource.MouseLeave += new System.EventHandler(this.BtnReport_MouseLeave);
            this.BtnResource.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.White;
            this.BtnDashboard.BackgroundColor = System.Drawing.Color.White;
            this.BtnDashboard.BorderColor = System.Drawing.Color.White;
            this.BtnDashboard.BorderRadius = 20;
            this.BtnDashboard.BorderSize = 0;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 137);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(230, 40);
            this.BtnDashboard.TabIndex = 3;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.MouseLeave += new System.EventHandler(this.BtnReport_MouseLeave);
            this.BtnDashboard.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.pBDefault);
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Controls.Add(this.BtnOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 49);
            this.panel2.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lb2.Location = new System.Drawing.Point(54, 28);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(18, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "ID";
            // 
            // pBDefault
            // 
            this.pBDefault.Location = new System.Drawing.Point(12, 7);
            this.pBDefault.Name = "pBDefault";
            this.pBDefault.Size = new System.Drawing.Size(35, 35);
            this.pBDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDefault.TabIndex = 1;
            this.pBDefault.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(53, 7);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 21);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Name";
            // 
            // BtnOut
            // 
            this.BtnOut.BackColor = System.Drawing.Color.White;
            this.BtnOut.BackgroundColor = System.Drawing.Color.White;
            this.BtnOut.BorderColor = System.Drawing.Color.White;
            this.BtnOut.BorderRadius = 20;
            this.BtnOut.BorderSize = 0;
            this.BtnOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnOut.FlatAppearance.BorderSize = 0;
            this.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOut.ForeColor = System.Drawing.Color.White;
            this.BtnOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnOut.Image")));
            this.BtnOut.Location = new System.Drawing.Point(183, 0);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(47, 49);
            this.BtnOut.TabIndex = 3;
            this.BtnOut.TextColor = System.Drawing.Color.White;
            this.BtnOut.UseVisualStyleBackColor = false;
            this.BtnOut.MouseLeave += new System.EventHandler(this.BtnOut_MouseLeave);
            this.BtnOut.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNavbar);
            this.panel1.Controls.Add(this.pbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 137);
            this.panel1.TabIndex = 0;
            // 
            // BtnNavbar
            // 
            this.BtnNavbar.BackColor = System.Drawing.Color.White;
            this.BtnNavbar.BackgroundColor = System.Drawing.Color.White;
            this.BtnNavbar.BorderColor = System.Drawing.Color.White;
            this.BtnNavbar.BorderRadius = 20;
            this.BtnNavbar.BorderSize = 0;
            this.BtnNavbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNavbar.FlatAppearance.BorderSize = 0;
            this.BtnNavbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNavbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnNavbar.Image = ((System.Drawing.Image)(resources.GetObject("BtnNavbar.Image")));
            this.BtnNavbar.Location = new System.Drawing.Point(183, 0);
            this.BtnNavbar.Name = "BtnNavbar";
            this.BtnNavbar.Size = new System.Drawing.Size(47, 137);
            this.BtnNavbar.TabIndex = 6;
            this.BtnNavbar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.BtnNavbar.UseVisualStyleBackColor = false;
            this.BtnNavbar.Click += new System.EventHandler(this.BtnNavbar_Click);
            // 
            // pbTitle
            // 
            this.pbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(0, 0);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(185, 137);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitle.TabIndex = 3;
            this.pbTitle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 23);
            this.panel3.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(504, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(530, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(240, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 407);
            this.panel4.TabIndex = 5;
            // 
            // eclipseControl1
            // 
            this.eclipseControl1.CornerRedius = 50;
            this.eclipseControl1.TargetControl = this;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlNavbar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            this.PnlNavbar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDefault)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.PictureBox pBDefault;
        private System.Windows.Forms.Label lb1;
        private ArtanButton BtnOut;
    }
}

