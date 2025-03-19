namespace eParty
{
    partial class StaffListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            artanPanel3 = new ArtanPanel();
            textBox5 = new TextBox();
            artanButton4 = new ArtanButton();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            artanButton1 = new ArtanButton();
            artanButton37 = new ArtanButton();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txtFullname = new TextBox();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            artanPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(artanPanel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 878);
            panel1.TabIndex = 21;
            // 
            // artanPanel3
            // 
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 50;
            artanPanel3.Controls.Add(textBox5);
            artanPanel3.Controls.Add(artanButton4);
            artanPanel3.ForeColor = Color.Black;
            artanPanel3.GradientAngle = 90F;
            artanPanel3.GradientBottomColor = Color.Silver;
            artanPanel3.GradientTopColor = Color.Silver;
            artanPanel3.Location = new Point(22, 12);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(425, 54);
            artanPanel3.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Silver;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(29, 9);
            textBox5.Margin = new Padding(6, 7, 6, 7);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(342, 36);
            textBox5.TabIndex = 20;
            textBox5.Text = "Search by Name....";
            textBox5.UseWaitCursor = true;
            // 
            // artanButton4
            // 
            artanButton4.BackColor = Color.White;
            artanButton4.BackgroundColor = Color.White;
            artanButton4.BorderColor = Color.White;
            artanButton4.BorderRadius = 50;
            artanButton4.BorderSize = 0;
            artanButton4.Dock = DockStyle.Right;
            artanButton4.FlatAppearance.BorderSize = 0;
            artanButton4.FlatStyle = FlatStyle.Flat;
            artanButton4.ForeColor = Color.White;
            artanButton4.Image = (Image)resources.GetObject("artanButton4.Image");
            artanButton4.Location = new Point(371, 0);
            artanButton4.Name = "artanButton4";
            artanButton4.Size = new Size(54, 54);
            artanButton4.TabIndex = 17;
            artanButton4.TextColor = Color.White;
            artanButton4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 878);
            panel2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Order, Amount, Unit, Cost, Description, Image });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 75);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1026, 803);
            dataGridView1.TabIndex = 20;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Order
            // 
            Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Order.HeaderText = "Full Name";
            Order.MinimumWidth = 10;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 159;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "Role";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unit.HeaderText = "Phone";
            Unit.MinimumWidth = 10;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Location";
            Cost.MinimumWidth = 10;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Cost";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Image
            // 
            Image.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Image.HeaderText = "Manager";
            Image.MinimumWidth = 10;
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 242, 253);
            panel3.Controls.Add(artanButton1);
            panel3.Controls.Add(artanButton37);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(txtFullname);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1032, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 878);
            panel3.TabIndex = 22;
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
            artanButton1.Location = new Point(32, 807);
            artanButton1.Name = "artanButton1";
            artanButton1.Size = new Size(144, 62);
            artanButton1.TabIndex = 48;
            artanButton1.Text = "Add";
            artanButton1.TextColor = Color.White;
            artanButton1.UseVisualStyleBackColor = false;
            // 
            // artanButton37
            // 
            artanButton37.BackColor = Color.Red;
            artanButton37.BackgroundColor = Color.Red;
            artanButton37.BorderColor = Color.White;
            artanButton37.BorderRadius = 59;
            artanButton37.BorderSize = 0;
            artanButton37.FlatAppearance.BorderSize = 0;
            artanButton37.FlatStyle = FlatStyle.Flat;
            artanButton37.ForeColor = Color.White;
            artanButton37.Location = new Point(218, 807);
            artanButton37.Name = "artanButton37";
            artanButton37.Size = new Size(144, 62);
            artanButton37.TabIndex = 47;
            artanButton37.Text = "Delete";
            artanButton37.TextColor = Color.White;
            artanButton37.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(227, 242, 253);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(32, 718);
            textBox6.Margin = new Padding(6, 7, 6, 7);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(337, 43);
            textBox6.TabIndex = 42;
            textBox6.Text = "Manager";
            textBox6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(41, 128, 182);
            label7.Location = new Point(32, 749);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(337, 30);
            label7.TabIndex = 43;
            label7.Text = "____________________________________";
            label7.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(227, 242, 253);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(32, 650);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 43);
            textBox1.TabIndex = 45;
            textBox1.Text = "Cost";
            textBox1.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 182);
            label6.Location = new Point(32, 681);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(337, 30);
            label6.TabIndex = 46;
            label6.Text = "____________________________________";
            label6.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(227, 242, 253);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(32, 582);
            textBox4.Margin = new Padding(6, 7, 6, 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(337, 43);
            textBox4.TabIndex = 42;
            textBox4.Text = "Location";
            textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(227, 242, 253);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(32, 512);
            textBox3.Margin = new Padding(6, 7, 6, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(337, 43);
            textBox3.TabIndex = 40;
            textBox3.Text = "Phone number";
            textBox3.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(227, 242, 253);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(32, 442);
            textBox2.Margin = new Padding(6, 7, 6, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 43);
            textBox2.TabIndex = 38;
            textBox2.Text = "Role ";
            textBox2.UseWaitCursor = true;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.FromArgb(227, 242, 253);
            txtFullname.BorderStyle = BorderStyle.None;
            txtFullname.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(32, 372);
            txtFullname.Margin = new Padding(6, 7, 6, 7);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(337, 43);
            txtFullname.TabIndex = 36;
            txtFullname.Text = "Full name";
            txtFullname.UseWaitCursor = true;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(227, 242, 253);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(32, 302);
            txtID.Margin = new Padding(6, 7, 6, 7);
            txtID.Name = "txtID";
            txtID.Size = new Size(337, 43);
            txtID.TabIndex = 34;
            txtID.Text = "ID";
            txtID.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 182);
            label5.Location = new Point(32, 613);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(337, 30);
            label5.TabIndex = 43;
            label5.Text = "____________________________________";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(32, 543);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(337, 30);
            label4.TabIndex = 41;
            label4.Text = "____________________________________";
            label4.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 182);
            label1.Location = new Point(32, 333);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 30);
            label1.TabIndex = 35;
            label1.Text = "____________________________________";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 182);
            label2.Location = new Point(32, 404);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(337, 30);
            label2.TabIndex = 37;
            label2.Text = "____________________________________";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 182);
            label3.Location = new Point(32, 473);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(337, 30);
            label3.TabIndex = 39;
            label3.Text = "____________________________________";
            label3.UseWaitCursor = true;
            // 
            // StaffListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1406, 878);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemListForm";
            Load += StaffListForm_Load;
            panel1.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            artanPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ArtanPanel artanPanel3;
        private TextBox textBox5;
        private ArtanButton artanButton4;
        private Panel panel3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtFullname;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private ArtanButton artanButton1;
        private ArtanButton artanButton37;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Image;
    }
}