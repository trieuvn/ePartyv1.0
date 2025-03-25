namespace eParty
{
    partial class IngredientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientListForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            btnUpdate = new ArtanButton();
            btnAdd = new ArtanButton();
            btnDelete = new ArtanButton();
            txtDescription = new TextBox();
            txtCost = new TextBox();
            txtUnit = new TextBox();
            txtname = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            artanButton2 = new ArtanButton();
            artanPanel3 = new ArtanPanel();
            txtSearch = new TextBox();
            artanButton4 = new ArtanButton();
            panel3 = new Panel();
            dataGridIngre = new DataGridView();
            Order = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            artanPanel3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridIngre).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(635, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 549);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(227, 242, 253);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(txtDescription);
            panel4.Controls.Add(txtCost);
            panel4.Controls.Add(txtUnit);
            panel4.Controls.Add(txtname);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 549);
            panel4.TabIndex = 46;
            panel4.Paint += panel4_Paint;
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
            btnUpdate.Location = new Point(79, 459);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 39);
            btnUpdate.TabIndex = 50;
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
            btnAdd.Location = new Point(79, 414);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 39);
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
            btnDelete.Location = new Point(79, 507);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 39);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(227, 242, 253);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(21, 364);
            txtDescription.Margin = new Padding(5, 4, 5, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(207, 27);
            txtDescription.TabIndex = 42;
            txtDescription.Text = "Description";
            txtDescription.UseWaitCursor = true;
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.FromArgb(227, 242, 253);
            txtCost.BorderStyle = BorderStyle.None;
            txtCost.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCost.Location = new Point(21, 320);
            txtCost.Margin = new Padding(5, 4, 5, 4);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(207, 27);
            txtCost.TabIndex = 40;
            txtCost.Text = "Cost";
            txtCost.UseWaitCursor = true;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.FromArgb(227, 242, 253);
            txtUnit.BorderStyle = BorderStyle.None;
            txtUnit.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnit.Location = new Point(21, 276);
            txtUnit.Margin = new Padding(5, 4, 5, 4);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(207, 27);
            txtUnit.TabIndex = 38;
            txtUnit.Text = "Unit";
            txtUnit.UseWaitCursor = true;
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(227, 242, 253);
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(21, 232);
            txtname.Margin = new Padding(5, 4, 5, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(207, 27);
            txtname.TabIndex = 36;
            txtname.Text = "Name";
            txtname.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 47);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 182);
            label5.Location = new Point(21, 383);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(225, 19);
            label5.TabIndex = 43;
            label5.Text = "____________________________________";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 182);
            label4.Location = new Point(21, 339);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 19);
            label4.TabIndex = 41;
            label4.Text = "____________________________________";
            label4.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 182);
            label2.Location = new Point(21, 252);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 19);
            label2.TabIndex = 37;
            label2.Text = "____________________________________";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 182);
            label3.Location = new Point(21, 296);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(225, 19);
            label3.TabIndex = 39;
            label3.Text = "____________________________________";
            label3.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 47);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(artanButton2);
            panel2.Controls.Add(artanPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 47);
            panel2.TabIndex = 1;
            // 
            // artanButton2
            // 
            artanButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            artanButton2.BackColor = Color.FromArgb(0, 122, 204);
            artanButton2.BackgroundColor = Color.FromArgb(0, 122, 204);
            artanButton2.BorderColor = Color.FromArgb(0, 122, 204);
            artanButton2.BorderRadius = 29;
            artanButton2.BorderSize = 0;
            artanButton2.FlatAppearance.BorderSize = 0;
            artanButton2.FlatStyle = FlatStyle.Flat;
            artanButton2.ForeColor = Color.White;
            artanButton2.Image = (Image)resources.GetObject("artanButton2.Image");
            artanButton2.ImageAlign = ContentAlignment.MiddleRight;
            artanButton2.Location = new Point(466, 5);
            artanButton2.Margin = new Padding(2, 3, 2, 3);
            artanButton2.Name = "artanButton2";
            artanButton2.Size = new Size(166, 39);
            artanButton2.TabIndex = 49;
            artanButton2.Text = "View Provider Info";
            artanButton2.TextAlign = ContentAlignment.MiddleLeft;
            artanButton2.TextColor = Color.White;
            artanButton2.UseVisualStyleBackColor = false;
            artanButton2.Click += artanButton2_Click;
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
            artanPanel3.Location = new Point(14, 8);
            artanPanel3.Margin = new Padding(2, 3, 2, 3);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(262, 35);
            artanPanel3.TabIndex = 19;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Silver;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(18, 5);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 23);
            txtSearch.TabIndex = 20;
            txtSearch.Text = "Search by ingredient name...";
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
            artanButton4.Location = new Point(229, 0);
            artanButton4.Margin = new Padding(2, 3, 2, 3);
            artanButton4.Name = "artanButton4";
            artanButton4.Size = new Size(33, 35);
            artanButton4.TabIndex = 17;
            artanButton4.TextColor = Color.White;
            artanButton4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridIngre);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 47);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 502);
            panel3.TabIndex = 2;
            // 
            // dataGridIngre
            // 
            dataGridIngre.AllowUserToAddRows = false;
            dataGridIngre.AllowUserToDeleteRows = false;
            dataGridIngre.AllowUserToResizeColumns = false;
            dataGridIngre.AllowUserToResizeRows = false;
            dataGridIngre.BackgroundColor = Color.White;
            dataGridIngre.BorderStyle = BorderStyle.None;
            dataGridIngre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridIngre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridIngre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIngre.Columns.AddRange(new DataGridViewColumn[] { Order, Amount, Unit, Cost });
            dataGridIngre.Dock = DockStyle.Fill;
            dataGridIngre.EnableHeadersVisualStyles = false;
            dataGridIngre.GridColor = Color.LightGray;
            dataGridIngre.Location = new Point(0, 0);
            dataGridIngre.Margin = new Padding(5, 4, 5, 4);
            dataGridIngre.MultiSelect = false;
            dataGridIngre.Name = "dataGridIngre";
            dataGridIngre.ReadOnly = true;
            dataGridIngre.RowHeadersVisible = false;
            dataGridIngre.RowHeadersWidth = 30;
            dataGridIngre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridIngre.Size = new Size(635, 502);
            dataGridIngre.TabIndex = 21;
            dataGridIngre.CellContentClick += dataGridIngre_CellContentClick;
            // 
            // Order
            // 
            Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Order.HeaderText = "Name";
            Order.MinimumWidth = 10;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 76;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "Unit";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unit.HeaderText = "Cost";
            Unit.MinimumWidth = 10;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Description";
            Cost.MinimumWidth = 10;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // IngredientListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 549);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "IngredientListForm";
            Text = "IngredientListForm";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            artanPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridIngre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ArtanPanel artanPanel3;
        private TextBox txtSearch;
        private ArtanButton artanButton4;
        private DataGridView dataGridIngre;
        private PictureBox pictureBox1;
        private Panel panel4;
        private ArtanButton btnAdd;
        private ArtanButton btnDelete;
        private TextBox txtDescription;
        private TextBox txtCost;
        private TextBox txtUnit;
        private TextBox txtname;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private ArtanButton artanButton2;
        private ArtanButton btnUpdate;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Cost;
    }
}