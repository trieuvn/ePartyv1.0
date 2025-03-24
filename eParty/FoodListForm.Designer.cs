namespace eParty
{
    partial class FoodListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodListForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            artanPanel2 = new ArtanPanel();
            btnDelete = new ArtanButton();
            btnModify = new ArtanButton();
            btnAdd = new ArtanButton();
            pictureBox1 = new PictureBox();
            txtExpen = new TextBox();
            label5 = new Label();
            txtMeasure = new TextBox();
            txtStock = new TextBox();
            label3 = new Label();
            txtNote = new TextBox();
            txtFoodName = new TextBox();
            lbEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            artanPanel3 = new ArtanPanel();
            txtSearch = new TextBox();
            artanButton4 = new ArtanButton();
            panel2 = new Panel();
            dataGridFood = new DataGridView();
            Order = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            artanPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFood).BeginInit();
            SuspendLayout();
            // 
            // artanPanel2
            // 
            artanPanel2.BackColor = Color.FromArgb(227, 242, 253);
            artanPanel2.BorderRadius = 30;
            artanPanel2.Controls.Add(btnDelete);
            artanPanel2.Controls.Add(btnModify);
            artanPanel2.Controls.Add(btnAdd);
            artanPanel2.Controls.Add(pictureBox1);
            artanPanel2.Controls.Add(txtExpen);
            artanPanel2.Controls.Add(label5);
            artanPanel2.Controls.Add(txtMeasure);
            artanPanel2.Controls.Add(txtStock);
            artanPanel2.Controls.Add(label3);
            artanPanel2.Controls.Add(txtNote);
            artanPanel2.Controls.Add(txtFoodName);
            artanPanel2.Controls.Add(lbEmail);
            artanPanel2.Controls.Add(label2);
            artanPanel2.Controls.Add(label1);
            artanPanel2.Controls.Add(label4);
            artanPanel2.Dock = DockStyle.Right;
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 120F;
            artanPanel2.GradientBottomColor = Color.FromArgb(227, 242, 253);
            artanPanel2.GradientTopColor = Color.FromArgb(227, 242, 253);
            artanPanel2.Location = new Point(649, 0);
            artanPanel2.Margin = new Padding(2, 2, 2, 2);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(243, 368);
            artanPanel2.TabIndex = 1;
            artanPanel2.Paint += artanPanel2_Paint;
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
            btnDelete.Location = new Point(170, 308);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 29);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(42, 128, 182);
            btnModify.BackgroundColor = Color.FromArgb(42, 128, 182);
            btnModify.BorderColor = Color.FromArgb(42, 128, 182);
            btnModify.BorderRadius = 29;
            btnModify.BorderSize = 0;
            btnModify.FlatAppearance.BorderSize = 0;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(2, 308);
            btnModify.Margin = new Padding(2, 2, 2, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(78, 29);
            btnModify.TabIndex = 19;
            btnModify.Text = "Modify";
            btnModify.TextColor = Color.White;
            btnModify.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new Point(83, 308);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add Food";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 37);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtExpen
            // 
            txtExpen.BackColor = Color.FromArgb(227, 242, 253);
            txtExpen.BorderStyle = BorderStyle.None;
            txtExpen.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpen.Location = new Point(36, 266);
            txtExpen.Margin = new Padding(4, 3, 4, 3);
            txtExpen.Name = "txtExpen";
            txtExpen.Size = new Size(181, 22);
            txtExpen.TabIndex = 15;
            txtExpen.Text = "Cost";
            txtExpen.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 182);
            label5.Location = new Point(36, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 13);
            label5.TabIndex = 16;
            label5.Text = "____________________________________";
            label5.UseWaitCursor = true;
            // 
            // txtMeasure
            // 
            txtMeasure.BackColor = Color.FromArgb(227, 242, 253);
            txtMeasure.BorderStyle = BorderStyle.None;
            txtMeasure.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMeasure.Location = new Point(36, 232);
            txtMeasure.Margin = new Padding(4, 3, 4, 3);
            txtMeasure.Name = "txtMeasure";
            txtMeasure.Size = new Size(181, 22);
            txtMeasure.TabIndex = 13;
            txtMeasure.Text = "Unit";
            txtMeasure.UseWaitCursor = true;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(227, 242, 253);
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(36, 200);
            txtStock.Margin = new Padding(4, 3, 4, 3);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(181, 22);
            txtStock.TabIndex = 11;
            txtStock.Text = "Amount";
            txtStock.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 182);
            label3.Location = new Point(36, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 13);
            label3.TabIndex = 12;
            label3.Text = "____________________________________";
            label3.UseWaitCursor = true;
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.FromArgb(227, 242, 253);
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(36, 166);
            txtNote.Margin = new Padding(4, 3, 4, 3);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(181, 22);
            txtNote.TabIndex = 9;
            txtNote.Text = "Description";
            txtNote.UseWaitCursor = true;
            // 
            // txtFoodName
            // 
            txtFoodName.BackColor = Color.FromArgb(227, 242, 253);
            txtFoodName.BorderStyle = BorderStyle.None;
            txtFoodName.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFoodName.Location = new Point(36, 134);
            txtFoodName.Margin = new Padding(4, 3, 4, 3);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(181, 22);
            txtFoodName.TabIndex = 6;
            txtFoodName.Text = "Food Name";
            txtFoodName.UseWaitCursor = true;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Malgun Gothic", 15F);
            lbEmail.ForeColor = Color.FromArgb(42, 128, 182);
            lbEmail.Location = new Point(33, 10);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(171, 28);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "Food Information";
            lbEmail.UseWaitCursor = true;
            lbEmail.Click += lbEmail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 182);
            label2.Location = new Point(36, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 13);
            label2.TabIndex = 10;
            label2.Text = "____________________________________";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 182);
            label1.Location = new Point(36, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 13);
            label1.TabIndex = 7;
            label1.Text = "____________________________________";
            label1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(36, 247);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 13);
            label4.TabIndex = 14;
            label4.Text = "____________________________________";
            label4.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(artanPanel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 35);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            artanPanel3.Margin = new Padding(2, 2, 2, 2);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(229, 26);
            artanPanel3.TabIndex = 21;
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
            txtSearch.Text = "Search by food name...";
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
            artanButton4.Margin = new Padding(2, 2, 2, 2);
            artanButton4.Name = "artanButton4";
            artanButton4.Size = new Size(29, 26);
            artanButton4.TabIndex = 17;
            artanButton4.TextColor = Color.White;
            artanButton4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridFood);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 333);
            panel2.TabIndex = 3;
            // 
            // dataGridFood
            // 
            dataGridFood.AllowUserToAddRows = false;
            dataGridFood.AllowUserToDeleteRows = false;
            dataGridFood.AllowUserToResizeColumns = false;
            dataGridFood.AllowUserToResizeRows = false;
            dataGridFood.BackgroundColor = Color.White;
            dataGridFood.BorderStyle = BorderStyle.None;
            dataGridFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFood.Columns.AddRange(new DataGridViewColumn[] { Order, Amount, Unit, Cost, Description });
            dataGridFood.Dock = DockStyle.Fill;
            dataGridFood.EnableHeadersVisualStyles = false;
            dataGridFood.GridColor = Color.LightGray;
            dataGridFood.Location = new Point(0, 0);
            dataGridFood.Margin = new Padding(4, 3, 4, 3);
            dataGridFood.MultiSelect = false;
            dataGridFood.Name = "dataGridFood";
            dataGridFood.ReadOnly = true;
            dataGridFood.RowHeadersVisible = false;
            dataGridFood.RowHeadersWidth = 30;
            dataGridFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFood.Size = new Size(649, 333);
            dataGridFood.TabIndex = 17;
            // 
            // Order
            // 
            Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Order.HeaderText = "Name";
            Order.MinimumWidth = 10;
            Order.Name = "Order";
            Order.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 10;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 10;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // FoodListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 368);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(artanPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FoodListForm";
            Text = "FoodListForm";
            Load += FoodListForm_Load;
            artanPanel2.ResumeLayout(false);
            artanPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            artanPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridFood).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ArtanPanel artanPanel2;
        private TextBox txtFoodName;
        private Label label1;
        private Label lbEmail;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtNote;
        private Label label2;
        private TextBox txtMeasure;
        private Label label4;
        private TextBox txtExpen;
        private Label label5;
        private PictureBox pictureBox1;
        private ArtanButton btnModify;
        private ArtanButton btnAdd;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridFood;
        private DataGridViewTextBoxColumn ID;
        private ArtanPanel artanPanel3;
        private TextBox txtSearch;
        private ArtanButton artanButton4;
        private ArtanButton btnDelete;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Description;
    }
}