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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel3 = new Panel();
            btnUpdate = new ArtanButton();
            btnAdd = new ArtanButton();
            btnDelete = new ArtanButton();
            txtCost = new TextBox();
            label6 = new Label();
            txtLocation = new TextBox();
            txtPhoneNumber = new TextBox();
            txtRole = new TextBox();
            txtFullname = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            artanPanel3 = new ArtanPanel();
            txtSearch = new TextBox();
            artanButton4 = new ArtanButton();
            panel2 = new Panel();
            dataGridStaff = new DataGridView();
            Order = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            artanPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 242, 253);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(txtCost);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtLocation);
            panel3.Controls.Add(txtPhoneNumber);
            panel3.Controls.Add(txtRole);
            panel3.Controls.Add(txtFullname);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(556, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 412);
            panel3.TabIndex = 22;
            panel3.Paint += panel3_Paint;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(42, 128, 182);
            btnUpdate.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnUpdate.BorderColor = Color.FromArgb(42, 128, 182);
            btnUpdate.BorderRadius = 29;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(72, 378);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(63, 29);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Update";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(42, 128, 182);
            btnAdd.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnAdd.BorderColor = Color.FromArgb(42, 128, 182);
            btnAdd.BorderRadius = 29;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(2, 378);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 29);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundColor = Color.Red;
            btnDelete.BorderColor = Color.White;
            btnDelete.BorderRadius = 29;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(137, 378);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 29);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.FromArgb(227, 242, 253);
            txtCost.BorderStyle = BorderStyle.None;
            txtCost.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCost.Location = new Point(18, 304);
            txtCost.Margin = new Padding(4, 3, 4, 3);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(181, 22);
            txtCost.TabIndex = 45;
            txtCost.Text = "Cost";
            txtCost.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 182);
            label6.Location = new Point(18, 320);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(187, 13);
            label6.TabIndex = 46;
            label6.Text = "____________________________________";
            label6.UseWaitCursor = true;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(227, 242, 253);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(18, 273);
            txtLocation.Margin = new Padding(4, 3, 4, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(181, 22);
            txtLocation.TabIndex = 42;
            txtLocation.Text = "Location";
            txtLocation.UseWaitCursor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(227, 242, 253);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(18, 240);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(181, 22);
            txtPhoneNumber.TabIndex = 40;
            txtPhoneNumber.Text = "Phone number";
            txtPhoneNumber.UseWaitCursor = true;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(227, 242, 253);
            txtRole.BorderStyle = BorderStyle.None;
            txtRole.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(18, 207);
            txtRole.Margin = new Padding(4, 3, 4, 3);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(181, 22);
            txtRole.TabIndex = 38;
            txtRole.Text = "Role ";
            txtRole.UseWaitCursor = true;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.FromArgb(227, 242, 253);
            txtFullname.BorderStyle = BorderStyle.None;
            txtFullname.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(18, 174);
            txtFullname.Margin = new Padding(4, 3, 4, 3);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(181, 22);
            txtFullname.TabIndex = 36;
            txtFullname.Text = "Full name";
            txtFullname.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 35);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 182);
            label5.Location = new Point(18, 287);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 13);
            label5.TabIndex = 43;
            label5.Text = "____________________________________";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(18, 254);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 13);
            label4.TabIndex = 41;
            label4.Text = "____________________________________";
            label4.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 182);
            label2.Location = new Point(18, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 13);
            label2.TabIndex = 37;
            label2.Text = "____________________________________";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 182);
            label3.Location = new Point(18, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 13);
            label3.TabIndex = 39;
            label3.Text = "____________________________________";
            label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(artanPanel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 35);
            panel1.TabIndex = 23;
            // 
            // artanPanel3
            // 
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 50;
            artanPanel3.Controls.Add(txtSearch);
            artanPanel3.Controls.Add(artanButton4);
            artanPanel3.ForeColor = Color.Black;
            artanPanel3.GradientAngle = 90F;
            artanPanel3.GradientBottomColor = Color.Silver;
            artanPanel3.GradientTopColor = Color.Silver;
            artanPanel3.Location = new Point(12, 6);
            artanPanel3.Margin = new Padding(2);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(229, 26);
            artanPanel3.TabIndex = 20;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Silver;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(16, 4);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(184, 18);
            txtSearch.TabIndex = 20;
            txtSearch.Text = "Search by staff name...";
            txtSearch.UseWaitCursor = true;
            // 
            // artanButton4
            // 
            artanButton4.BackColor = Color.White;
            artanButton4.BackgroundColor = Color.White;
            artanButton4.BorderColor = Color.White;
            artanButton4.BorderRadius = 26;
            artanButton4.BorderSize = 0;
            artanButton4.Dock = DockStyle.Right;
            artanButton4.FlatAppearance.BorderSize = 0;
            artanButton4.FlatStyle = FlatStyle.Flat;
            artanButton4.ForeColor = Color.White;
            artanButton4.Image = (Image)resources.GetObject("artanButton4.Image");
            artanButton4.Location = new Point(200, 0);
            artanButton4.Margin = new Padding(2);
            artanButton4.Name = "artanButton4";
            artanButton4.Size = new Size(29, 26);
            artanButton4.TabIndex = 17;
            artanButton4.TextColor = Color.White;
            artanButton4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridStaff);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 377);
            panel2.TabIndex = 24;
            // 
            // dataGridStaff
            // 
            dataGridStaff.AllowUserToAddRows = false;
            dataGridStaff.AllowUserToDeleteRows = false;
            dataGridStaff.AllowUserToResizeColumns = false;
            dataGridStaff.AllowUserToResizeRows = false;
            dataGridStaff.BackgroundColor = Color.White;
            dataGridStaff.BorderStyle = BorderStyle.None;
            dataGridStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStaff.Columns.AddRange(new DataGridViewColumn[] { Order, Role, Phone, Location, Cost });
            dataGridStaff.Dock = DockStyle.Fill;
            dataGridStaff.EnableHeadersVisualStyles = false;
            dataGridStaff.GridColor = Color.LightGray;
            dataGridStaff.Location = new Point(0, 0);
            dataGridStaff.Margin = new Padding(4, 3, 4, 3);
            dataGridStaff.MultiSelect = false;
            dataGridStaff.Name = "dataGridStaff";
            dataGridStaff.ReadOnly = true;
            dataGridStaff.RowHeadersVisible = false;
            dataGridStaff.RowHeadersWidth = 30;
            dataGridStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStaff.Size = new Size(556, 377);
            dataGridStaff.TabIndex = 22;
            // 
            // Order
            // 
            Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Order.HeaderText = "Name";
            Order.MinimumWidth = 10;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 61;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.HeaderText = "Role";
            Role.MinimumWidth = 10;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 10;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Location.HeaderText = "Location";
            Location.MinimumWidth = 10;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 10;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // StaffListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(757, 412);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "StaffListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemListForm";
            Load += StaffListForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            artanPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private TextBox txtLocation;
        private TextBox txtPhoneNumber;
        private TextBox txtRole;
        private TextBox txtFullname;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtCost;
        private Label label6;
        private ArtanButton btnAdd;
        private ArtanButton btnDelete;
        private Panel panel1;
        private Panel panel2;
        private ArtanPanel artanPanel3;
        private TextBox txtSearch;
        private ArtanButton artanButton4;
        private DataGridView dataGridStaff;
        private ArtanButton btnUpdate;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Cost;
    }
}