namespace eParty
{
    partial class LoginShortcut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginShortcut));
            lbUsername = new Label();
            lbGmail = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(85, 163);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(145, 32);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "phucga1234";
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGmail.ForeColor = Color.White;
            lbGmail.Location = new Point(33, 202);
            lbGmail.Margin = new Padding(4, 0, 4, 0);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(256, 32);
            lbGmail.TabIndex = 1;
            lbGmail.Text = "sangntt22@uef.edu.vn";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(43, 128, 195);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(92, 286);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 18);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LoginShortcut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 128, 195);
            ClientSize = new Size(333, 351);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lbGmail);
            Controls.Add(lbUsername);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginShortcut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginShortcut";
            Load += LoginShortcut_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbGmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}