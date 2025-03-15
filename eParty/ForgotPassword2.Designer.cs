namespace eParty
{
    partial class ForgotPassword2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword2));
            artanPanel1 = new ArtanPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            artanButton1 = new ArtanButton();
            label5 = new Label();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            artanButton2 = new ArtanButton();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(artanButton2);
            artanPanel1.Controls.Add(pictureBox1);
            artanPanel1.Controls.Add(txtEmail);
            artanPanel1.Controls.Add(artanButton1);
            artanPanel1.Controls.Add(label4);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(label1);
            artanPanel1.Controls.Add(label5);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.White;
            artanPanel1.GradientTopColor = Color.White;
            artanPanel1.Location = new Point(81, 36);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1099, 664);
            artanPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(42, 128, 182);
            label1.Location = new Point(574, 121);
            label1.Name = "label1";
            label1.Size = new Size(189, 72);
            label1.TabIndex = 0;
            label1.Text = "Forgot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.FromArgb(42, 128, 182);
            label2.Location = new Point(574, 191);
            label2.Name = "label2";
            label2.Size = new Size(292, 72);
            label2.TabIndex = 1;
            label2.Text = "Password ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(574, 261);
            label3.Name = "label3";
            label3.Size = new Size(353, 45);
            label3.TabIndex = 2;
            label3.Text = "Enter the email address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(574, 311);
            label4.Name = "label4";
            label4.Size = new Size(438, 45);
            label4.TabIndex = 3;
            label4.Text = "associated with your account.";
            // 
            // artanButton1
            // 
            artanButton1.BackColor = Color.FromArgb(42, 128, 182);
            artanButton1.BackgroundColor = Color.FromArgb(42, 128, 182);
            artanButton1.BorderColor = Color.FromArgb(42, 128, 182);
            artanButton1.BorderRadius = 59;
            artanButton1.BorderSize = 0;
            artanButton1.FlatAppearance.BorderSize = 0;
            artanButton1.FlatStyle = FlatStyle.Flat;
            artanButton1.ForeColor = Color.White;
            artanButton1.Location = new Point(868, 532);
            artanButton1.Name = "artanButton1";
            artanButton1.Size = new Size(144, 62);
            artanButton1.TabIndex = 4;
            artanButton1.Text = "Next";
            artanButton1.TextColor = Color.White;
            artanButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(574, 448);
            label5.Name = "label5";
            label5.Size = new Size(434, 32);
            label5.TabIndex = 5;
            label5.Text = "__________________________________________";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(574, 422);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(438, 43);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Enter Email Address";
            txtEmail.UseWaitCursor = true;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // artanButton2
            // 
            artanButton2.BackColor = Color.FromArgb(42, 128, 182);
            artanButton2.BackgroundColor = Color.FromArgb(42, 128, 182);
            artanButton2.BorderColor = Color.FromArgb(42, 128, 182);
            artanButton2.BorderRadius = 59;
            artanButton2.BorderSize = 0;
            artanButton2.FlatAppearance.BorderSize = 0;
            artanButton2.FlatStyle = FlatStyle.Flat;
            artanButton2.ForeColor = Color.White;
            artanButton2.Location = new Point(574, 532);
            artanButton2.Name = "artanButton2";
            artanButton2.Size = new Size(144, 62);
            artanButton2.TabIndex = 8;
            artanButton2.Text = "Back";
            artanButton2.TextColor = Color.White;
            artanButton2.UseVisualStyleBackColor = false;
            artanButton2.Click += artanButton2_Click;
            // 
            // ForgotPassword2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            ClientSize = new Size(1261, 737);
            Controls.Add(artanPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword2";
            Text = "ForgotPassword2";
            Load += ForgotPassword2_Load;
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ArtanPanel artanPanel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private ArtanButton artanButton1;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private ArtanButton artanButton2;
    }
}