﻿namespace eParty
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            artanPanel1 = new ArtanPanel();
            txtConfirm = new TextBox();
            txtPass = new TextBox();
            artanButton1 = new ArtanButton();
            artanButton2 = new ArtanButton();
            btnstarted = new Button();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.Anchor = AnchorStyles.None;
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(txtConfirm);
            artanPanel1.Controls.Add(txtPass);
            artanPanel1.Controls.Add(artanButton1);
            artanPanel1.Controls.Add(artanButton2);
            artanPanel1.Controls.Add(btnstarted);
            artanPanel1.Controls.Add(pictureBox5);
            artanPanel1.Controls.Add(label7);
            artanPanel1.Controls.Add(pictureBox4);
            artanPanel1.Controls.Add(label5);
            artanPanel1.Controls.Add(label1);
            artanPanel1.Controls.Add(label6);
            artanPanel1.Controls.Add(label4);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.White;
            artanPanel1.GradientTopColor = Color.White;
            artanPanel1.Location = new Point(85, 70);
            artanPanel1.Margin = new Padding(4, 2, 4, 2);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1099, 663);
            artanPanel1.TabIndex = 0;
            artanPanel1.Paint += artanPanel1_Paint;
            // 
            // txtConfirm
            // 
            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.Location = new Point(108, 380);
            txtConfirm.Margin = new Padding(6, 6, 6, 6);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(832, 43);
            txtConfirm.TabIndex = 23;
            txtConfirm.UseWaitCursor = true;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(108, 230);
            txtPass.Margin = new Padding(6, 6, 6, 6);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(832, 43);
            txtPass.TabIndex = 19;
            txtPass.UseWaitCursor = true;
            // 
            // artanButton1
            // 
            artanButton1.BackColor = Color.White;
            artanButton1.BackgroundColor = Color.White;
            artanButton1.BorderColor = Color.White;
            artanButton1.BorderRadius = 28;
            artanButton1.BorderSize = 0;
            artanButton1.FlatAppearance.BorderSize = 0;
            artanButton1.FlatStyle = FlatStyle.Flat;
            artanButton1.ForeColor = Color.White;
            artanButton1.Image = (Image)resources.GetObject("artanButton1.Image");
            artanButton1.Location = new Point(960, 220);
            artanButton1.Margin = new Padding(4, 2, 4, 2);
            artanButton1.Name = "artanButton1";
            artanButton1.Size = new Size(59, 60);
            artanButton1.TabIndex = 29;
            artanButton1.TextColor = Color.White;
            artanButton1.UseVisualStyleBackColor = false;
            artanButton1.Click += artanButton1_Click;
            // 
            // artanButton2
            // 
            artanButton2.BackColor = Color.White;
            artanButton2.BackgroundColor = Color.White;
            artanButton2.BorderColor = Color.White;
            artanButton2.BorderRadius = 28;
            artanButton2.BorderSize = 0;
            artanButton2.FlatAppearance.BorderSize = 0;
            artanButton2.FlatStyle = FlatStyle.Flat;
            artanButton2.ForeColor = Color.White;
            artanButton2.Image = (Image)resources.GetObject("artanButton2.Image");
            artanButton2.Location = new Point(960, 367);
            artanButton2.Margin = new Padding(4, 2, 4, 2);
            artanButton2.Name = "artanButton2";
            artanButton2.Size = new Size(59, 60);
            artanButton2.TabIndex = 28;
            artanButton2.TextColor = Color.White;
            artanButton2.UseVisualStyleBackColor = false;
            artanButton2.Click += artanButton2_Click;
            // 
            // btnstarted
            // 
            btnstarted.BackColor = Color.FromArgb(41, 128, 182);
            btnstarted.FlatStyle = FlatStyle.Flat;
            btnstarted.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstarted.ForeColor = Color.White;
            btnstarted.Location = new Point(266, 523);
            btnstarted.Margin = new Padding(6, 6, 6, 6);
            btnstarted.Name = "btnstarted";
            btnstarted.Size = new Size(550, 100);
            btnstarted.TabIndex = 26;
            btnstarted.Text = "Confirm Authorization";
            btnstarted.UseVisualStyleBackColor = false;
            btnstarted.UseWaitCursor = true;
            btnstarted.Click += btnstarted_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(50, 380);
            pictureBox5.Margin = new Padding(6, 6, 6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            pictureBox5.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(42, 128, 182);
            label7.Location = new Point(108, 339);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(208, 32);
            label7.TabIndex = 25;
            label7.Text = "Confirm password";
            label7.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(50, 230);
            pictureBox4.Margin = new Padding(6, 6, 6, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(42, 128, 182);
            label5.Location = new Point(108, 192);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 21;
            label5.Text = "Password";
            label5.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = Color.FromArgb(42, 128, 182);
            label1.Location = new Point(206, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(714, 68);
            label1.TabIndex = 0;
            label1.Text = "Password-Based Authorization";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 182);
            label6.Location = new Point(45, 420);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(976, 30);
            label6.TabIndex = 24;
            label6.Text = "___________________________________________________________________________________________________________";
            label6.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(45, 273);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(976, 30);
            label4.TabIndex = 20;
            label4.Text = "___________________________________________________________________________________________________________";
            label4.UseWaitCursor = true;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            ClientSize = new Size(1287, 809);
            Controls.Add(artanPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            Load += AuthorizationForm_Load;
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ArtanPanel artanPanel1;
        private Label label1;
        private TextBox txtConfirm;
        private PictureBox pictureBox5;
        private Label label6;
        private Label label7;
        private TextBox txtPass;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private Button btnstarted;
        private ArtanButton artanButton2;
        private ArtanButton artanButton1;
    }
}