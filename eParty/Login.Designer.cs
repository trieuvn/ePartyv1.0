namespace eParty
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            lbLogin = new Label();
            panel3 = new Panel();
            txtLogin = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            txtPass = new TextBox();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            btnRegistration = new Button();
            lLforgot = new LinkLabel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 503);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(175, 289);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 3;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 252);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 2;
            label2.Text = "Party Management ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 217);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(41, 128, 185);
            btnExit.Location = new Point(416, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = Color.FromArgb(41, 128, 185);
            lbLogin.Location = new Point(37, 152);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(215, 28);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login to your account";
            lbLogin.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtLogin);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 49);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Malgun Gothic", 10F);
            txtLogin.ForeColor = Color.FromArgb(41, 128, 141);
            txtLogin.Location = new Point(43, 11);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(407, 23);
            txtLogin.TabIndex = 1;
            txtLogin.Click += txtLogin_Click;
            txtLogin.TextChanged += txtLogin_TextChanged;
            txtLogin.KeyPress += txtLogin_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPass);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 49);
            panel4.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.Control;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Malgun Gothic", 10F);
            txtPass.ForeColor = Color.FromArgb(41, 128, 181);
            txtPass.Location = new Point(43, 11);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(407, 23);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Click += txtPass_Click;
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 182);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Malgun Gothic", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(12, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(191, 42);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.FromArgb(41, 128, 182);
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Malgun Gothic", 10F);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(233, 378);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(191, 42);
            btnRegistration.TabIndex = 8;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // lLforgot
            // 
            lLforgot.ActiveLinkColor = Color.Blue;
            lLforgot.AutoSize = true;
            lLforgot.ForeColor = Color.FromArgb(41, 128, 181);
            lLforgot.LinkColor = Color.FromArgb(41, 128, 181);
            lLforgot.Location = new Point(144, 309);
            lLforgot.Name = "lLforgot";
            lLforgot.Size = new Size(164, 20);
            lLforgot.TabIndex = 9;
            lLforgot.TabStop = true;
            lLforgot.Text = "Forgot your password ?";
            lLforgot.LinkClicked += lLforgot_LinkClicked;
            // 
            // panel2
            // 
            panel2.Controls.Add(lLforgot);
            panel2.Controls.Add(btnRegistration);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbLogin);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(267, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 503);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 503);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.LinkLabel lLforgot;
        private System.Windows.Forms.Panel panel2;
    }
}