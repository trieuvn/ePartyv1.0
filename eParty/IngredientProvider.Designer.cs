namespace eParty
{
    partial class IngredientProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientProvider));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel3 = new Panel();
            txtIngredient = new ComboBox();
            btnUpdate = new ArtanButton();
            btnAdd = new ArtanButton();
            btnDelete = new ArtanButton();
            txtCost = new TextBox();
            label6 = new Label();
            txtIngredient1 = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLocation = new TextBox();
            txtFullname = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnBack = new ArtanButton();
            panel2 = new Panel();
            dataGridProvider = new DataGridView();
            Order = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Ingredient = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProvider).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 242, 253);
            panel3.Controls.Add(txtIngredient);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(txtCost);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtIngredient1);
            panel3.Controls.Add(txtPhoneNumber);
            panel3.Controls.Add(txtLocation);
            panel3.Controls.Add(txtFullname);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(743, 0);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 456);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // txtIngredient
            // 
            txtIngredient.FlatStyle = FlatStyle.Flat;
            txtIngredient.Font = new Font("Segoe UI", 8F);
            txtIngredient.FormattingEnabled = true;
            txtIngredient.Location = new Point(105, 278);
            txtIngredient.Margin = new Padding(2, 2, 2, 2);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(97, 21);
            txtIngredient.TabIndex = 52;
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
            btnUpdate.Margin = new Padding(2, 1, 2, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 29);
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
            btnAdd.Location = new Point(4, 378);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 29);
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
            btnDelete.Location = new Point(141, 378);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(54, 29);
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
            txtCost.Location = new Point(17, 305);
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
            label6.Location = new Point(17, 319);
            label6.Name = "label6";
            label6.Size = new Size(187, 13);
            label6.TabIndex = 46;
            label6.Text = "____________________________________";
            label6.UseWaitCursor = true;
            // 
            // txtIngredient1
            // 
            txtIngredient1.BackColor = Color.FromArgb(227, 242, 253);
            txtIngredient1.BorderStyle = BorderStyle.None;
            txtIngredient1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngredient1.Location = new Point(17, 273);
            txtIngredient1.Name = "txtIngredient1";
            txtIngredient1.Size = new Size(181, 22);
            txtIngredient1.TabIndex = 42;
            txtIngredient1.Text = "Ingredient";
            txtIngredient1.UseWaitCursor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(227, 242, 253);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(17, 240);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(181, 22);
            txtPhoneNumber.TabIndex = 40;
            txtPhoneNumber.Text = "Phone number";
            txtPhoneNumber.UseWaitCursor = true;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(227, 242, 253);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(17, 207);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(181, 22);
            txtLocation.TabIndex = 38;
            txtLocation.Text = "Location";
            txtLocation.UseWaitCursor = true;
            txtLocation.TextChanged += textBox2_TextChanged;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.FromArgb(227, 242, 253);
            txtFullname.BorderStyle = BorderStyle.None;
            txtFullname.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(17, 174);
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
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
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
            label5.Location = new Point(17, 287);
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
            label4.Location = new Point(17, 255);
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
            label2.Location = new Point(17, 189);
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
            label3.Location = new Point(17, 222);
            label3.Name = "label3";
            label3.Size = new Size(187, 13);
            label3.TabIndex = 39;
            label3.Text = "____________________________________";
            label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 45);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(42, 128, 182);
            btnBack.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnBack.BorderColor = Color.FromArgb(42, 128, 182);
            btnBack.BorderRadius = 29;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(13, 7);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 29);
            btnBack.TabIndex = 49;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += artanButton2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridProvider);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 411);
            panel2.TabIndex = 26;
            // 
            // dataGridProvider
            // 
            dataGridProvider.AllowUserToAddRows = false;
            dataGridProvider.AllowUserToDeleteRows = false;
            dataGridProvider.AllowUserToResizeColumns = false;
            dataGridProvider.AllowUserToResizeRows = false;
            dataGridProvider.BackgroundColor = Color.White;
            dataGridProvider.BorderStyle = BorderStyle.None;
            dataGridProvider.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProvider.Columns.AddRange(new DataGridViewColumn[] { Order, Location, PhoneNumber, Ingredient, Cost });
            dataGridProvider.Dock = DockStyle.Fill;
            dataGridProvider.EnableHeadersVisualStyles = false;
            dataGridProvider.GridColor = Color.LightGray;
            dataGridProvider.Location = new Point(0, 0);
            dataGridProvider.MultiSelect = false;
            dataGridProvider.Name = "dataGridProvider";
            dataGridProvider.ReadOnly = true;
            dataGridProvider.RowHeadersVisible = false;
            dataGridProvider.RowHeadersWidth = 30;
            dataGridProvider.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProvider.Size = new Size(743, 411);
            dataGridProvider.TabIndex = 22;
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
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Location.HeaderText = "Location";
            Location.MinimumWidth = 10;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.HeaderText = "Phone";
            PhoneNumber.MinimumWidth = 10;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Ingredient
            // 
            Ingredient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ingredient.HeaderText = "Ingredient";
            Ingredient.MinimumWidth = 10;
            Ingredient.Name = "Ingredient";
            Ingredient.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 10;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // IngredientProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 456);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "IngredientProvider";
            Text = "IngredientProvider";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private ArtanButton btnAdd;
        private ArtanButton btnDelete;
        private TextBox txtCost;
        private Label label6;
        private TextBox txtIngredient1;
        private TextBox txtPhoneNumber;
        private TextBox txtLocation;
        private TextBox txtFullname;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private ArtanButton btnBack;
        private Panel panel2;
        private DataGridView dataGridProvider;
        private ArtanButton btnUpdate;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Ingredient;
        private DataGridViewTextBoxColumn Cost;
        private ComboBox txtIngredient;
    }
}