namespace eParty
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel1 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            lbRegistration = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lbEmail = new Label();
            txtEmail = new TextBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnCheck = new Button();
            btnCancelcode = new Button();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            btnConfirm = new Button();
            btncancelpass = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 182);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbRegistration);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 134);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(315, 0);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbRegistration
            // 
            lbRegistration.AutoSize = true;
            lbRegistration.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRegistration.ForeColor = Color.White;
            lbRegistration.Location = new Point(90, 45);
            lbRegistration.Margin = new Padding(4, 0, 4, 0);
            lbRegistration.Name = "lbRegistration";
            lbRegistration.Size = new Size(222, 30);
            lbRegistration.TabIndex = 0;
            lbRegistration.Text = "Forgot your password";
            lbRegistration.Click += lbRegistration_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 162);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 182);
            label1.Location = new Point(10, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 13);
            label1.TabIndex = 7;
            label1.Text = "__________________________________________________";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.FromArgb(42, 128, 182);
            lbEmail.Location = new Point(41, 137);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(44, 162);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 22);
            txtEmail.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(44, 231);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 22);
            textBox1.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 231);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 182);
            label2.Location = new Point(10, 249);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(257, 13);
            label2.TabIndex = 11;
            label2.Text = "__________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(42, 128, 182);
            label3.Location = new Point(41, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 12;
            label3.Text = "Verify code";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(41, 128, 182);
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Malgun Gothic", 10F);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(14, 267);
            btnCheck.Margin = new Padding(2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(142, 31);
            btnCheck.TabIndex = 14;
            btnCheck.Text = "Verify";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnCancelcode
            // 
            btnCancelcode.BackColor = Color.FromArgb(41, 128, 182);
            btnCancelcode.FlatAppearance.BorderSize = 0;
            btnCancelcode.FlatStyle = FlatStyle.Flat;
            btnCancelcode.Font = new Font("Malgun Gothic", 10F);
            btnCancelcode.ForeColor = Color.White;
            btnCancelcode.Location = new Point(168, 267);
            btnCancelcode.Margin = new Padding(2);
            btnCancelcode.Name = "btnCancelcode";
            btnCancelcode.Size = new Size(142, 31);
            btnCancelcode.TabIndex = 15;
            btnCancelcode.Text = "Cancel";
            btnCancelcode.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(44, 340);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 22);
            textBox2.TabIndex = 19;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 340);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(10, 359);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(257, 13);
            label4.TabIndex = 17;
            label4.Text = "__________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(42, 128, 182);
            label5.Location = new Point(41, 324);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 18;
            label5.Text = "New password";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(44, 340);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 22);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(44, 410);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 22);
            textBox4.TabIndex = 24;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 410);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 182);
            label6.Location = new Point(10, 428);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(257, 13);
            label6.TabIndex = 22;
            label6.Text = "__________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(42, 128, 182);
            label7.Location = new Point(41, 393);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 23;
            label7.Text = "Confirm password";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(41, 128, 182);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Malgun Gothic", 10F);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(13, 445);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(142, 31);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btncancelpass
            // 
            btncancelpass.BackColor = Color.FromArgb(41, 128, 182);
            btncancelpass.FlatAppearance.BorderSize = 0;
            btncancelpass.FlatStyle = FlatStyle.Flat;
            btncancelpass.Font = new Font("Malgun Gothic", 10F);
            btncancelpass.ForeColor = Color.White;
            btncancelpass.Location = new Point(160, 445);
            btncancelpass.Margin = new Padding(2);
            btncancelpass.Name = "btncancelpass";
            btncancelpass.Size = new Size(142, 31);
            btncancelpass.TabIndex = 26;
            btncancelpass.Text = "Cancel";
            btncancelpass.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 182);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(238, 197);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(72, 31);
            button1.TabIndex = 27;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(344, 501);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btncancelpass);
            Controls.Add(btnConfirm);
            Controls.Add(textBox4);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnCancelcode);
            Controls.Add(btnCheck);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(lbEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRegistration;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancelcode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btncancelpass;
        private System.Windows.Forms.Button button1;
    }
}