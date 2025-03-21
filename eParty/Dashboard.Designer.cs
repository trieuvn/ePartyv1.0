namespace eParty
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTotalOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            lbProfit = new Label();
            label5 = new Label();
            lbFeedBack = new Label();
            label3 = new Label();
            lbTotalStaff = new Label();
            label1 = new Label();
            lbTotalNumber = new Label();
            label2 = new Label();
            chartAnnual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTotalProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataOrderStatus = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAnnual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTotalProfit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataOrderStatus).BeginInit();
            SuspendLayout();
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chart2.Legends.Add(legend5);
            chart2.Location = new Point(524, 281);
            chart2.Margin = new Padding(4, 4, 4, 4);
            chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart2.Series.Add(series5);
            chart2.Size = new Size(0, 0);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chartTotalOrder
            // 
            chartArea6.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea6.AxisY.MajorTickMark.LineWidth = 0;
            chartArea6.Name = "ChartArea1";
            chartTotalOrder.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.ForeColor = Color.FromArgb(42, 128, 182);
            legend6.Name = "Legend1";
            chartTotalOrder.Legends.Add(legend6);
            chartTotalOrder.Location = new Point(576, -1);
            chartTotalOrder.Margin = new Padding(4, 4, 4, 4);
            chartTotalOrder.Name = "chartTotalOrder";
            chartTotalOrder.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartTotalOrder.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(241, 160, 139),
    Color.FromArgb(239, 188, 0),
    Color.FromArgb(241, 88, 127),
    Color.FromArgb(1, 220, 205),
    Color.FromArgb(107, 83, 255),
    Color.FromArgb(94, 153, 254)
    };
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series6.BackSecondaryColor = Color.AliceBlue;
            series6.BorderColor = Color.White;
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Color = Color.DodgerBlue;
            series6.IsValueShownAsLabel = true;
            series6.LabelForeColor = Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartTotalOrder.Series.Add(series6);
            chartTotalOrder.Size = new Size(216, 261);
            chartTotalOrder.TabIndex = 7;
            chartTotalOrder.Text = "chart3";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title4.ForeColor = Color.FromArgb(22, 88, 142);
            title4.Name = "Title1";
            title4.Text = "Total Order";
            chartTotalOrder.Titles.Add(title4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 37);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 97);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 160);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 214);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbProfit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbFeedBack);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbTotalStaff);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbTotalNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 269);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 261);
            panel1.TabIndex = 6;
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Font = new Font("Segoe UI", 8F);
            lbProfit.ForeColor = Color.FromArgb(42, 128, 182);
            lbProfit.Location = new Point(49, 221);
            lbProfit.Margin = new Padding(2, 0, 2, 0);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(52, 19);
            lbProfit.TabIndex = 12;
            lbProfit.Text = "NProfit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.FromArgb(42, 128, 182);
            label5.Location = new Point(12, 191);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 11;
            label5.Text = "Profit";
            // 
            // lbFeedBack
            // 
            lbFeedBack.AutoSize = true;
            lbFeedBack.Font = new Font("Segoe UI", 8F);
            lbFeedBack.ForeColor = Color.FromArgb(42, 128, 182);
            lbFeedBack.Location = new Point(49, 160);
            lbFeedBack.Margin = new Padding(2, 0, 2, 0);
            lbFeedBack.Name = "lbFeedBack";
            lbFeedBack.Size = new Size(73, 19);
            lbFeedBack.TabIndex = 10;
            lbFeedBack.Text = "Nfeedback";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.FromArgb(42, 128, 182);
            label3.Location = new Point(12, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 9;
            label3.Text = "Feedback";
            // 
            // lbTotalStaff
            // 
            lbTotalStaff.AutoSize = true;
            lbTotalStaff.Font = new Font("Segoe UI", 9F);
            lbTotalStaff.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotalStaff.Location = new Point(49, 97);
            lbTotalStaff.Margin = new Padding(2, 0, 2, 0);
            lbTotalStaff.Name = "lbTotalStaff";
            lbTotalStaff.Size = new Size(95, 20);
            lbTotalStaff.TabIndex = 8;
            lbTotalStaff.Text = "Staff number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = Color.FromArgb(42, 128, 182);
            label1.Location = new Point(12, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 7;
            label1.Text = "Staff";
            // 
            // lbTotalNumber
            // 
            lbTotalNumber.AutoSize = true;
            lbTotalNumber.Font = new Font("Segoe UI", 9F);
            lbTotalNumber.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotalNumber.Location = new Point(49, 42);
            lbTotalNumber.Margin = new Padding(2, 0, 2, 0);
            lbTotalNumber.Name = "lbTotalNumber";
            lbTotalNumber.Size = new Size(103, 20);
            lbTotalNumber.TabIndex = 6;
            lbTotalNumber.Text = "Number order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(42, 128, 182);
            label2.Location = new Point(12, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 5;
            label2.Text = "Total Order";
            // 
            // chartAnnual
            // 
            chartArea7.AxisX.IsMarginVisible = false;
            chartArea7.AxisX.LabelStyle.ForeColor = Color.FromArgb(42, 128, 182);
            chartArea7.AxisX.LineColor = Color.White;
            chartArea7.AxisX.LineWidth = 0;
            chartArea7.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea7.AxisX.MajorGrid.LineWidth = 0;
            chartArea7.AxisX.MajorTickMark.LineColor = Color.White;
            chartArea7.AxisX.MajorTickMark.Size = 3F;
            chartArea7.AxisY.LabelStyle.ForeColor = Color.FromArgb(42, 128, 182);
            chartArea7.AxisY.LabelStyle.Format = "#,##0 VND";
            chartArea7.AxisY.LineColor = Color.WhiteSmoke;
            chartArea7.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea7.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            chartArea7.AxisY.MajorTickMark.LineWidth = 0;
            chartArea7.Name = "ChartArea1";
            chartAnnual.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Font = new Font("Microsoft Sans Serif", 7F);
            legend7.ForeColor = Color.FromArgb(42, 128, 182);
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            chartAnnual.Legends.Add(legend7);
            chartAnnual.Location = new Point(0, -1);
            chartAnnual.Margin = new Padding(4, 4, 4, 4);
            chartAnnual.Name = "chartAnnual";
            series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series7.BackSecondaryColor = Color.FromArgb(50, 200, 100);
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series7.Color = Color.FromArgb(80, 160, 255);
            series7.Legend = "Legend1";
            series7.MarkerColor = Color.MediumPurple;
            series7.MarkerSize = 8;
            series7.Name = "Series1";
            chartAnnual.Series.Add(series7);
            chartAnnual.Size = new Size(568, 261);
            chartAnnual.TabIndex = 10;
            chartAnnual.Text = "chart1";
            title5.Alignment = ContentAlignment.TopLeft;
            title5.Font = new Font("Segoe UI", 12F);
            title5.ForeColor = Color.FromArgb(22, 88, 142);
            title5.Name = "Revenue gross";
            title5.Text = "Annual Growth Report";
            chartAnnual.Titles.Add(title5);
            chartAnnual.Click += chart1_Click;
            // 
            // chartTotalProfit
            // 
            chartArea8.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea8.AxisY.MajorTickMark.LineWidth = 0;
            chartArea8.Name = "ChartArea1";
            chartTotalProfit.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.ForeColor = Color.FromArgb(42, 128, 182);
            legend8.Name = "Legend1";
            chartTotalProfit.Legends.Add(legend8);
            chartTotalProfit.Location = new Point(576, 269);
            chartTotalProfit.Margin = new Padding(4, 4, 4, 4);
            chartTotalProfit.Name = "chartTotalProfit";
            chartTotalProfit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartTotalProfit.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(241, 160, 139),
    Color.FromArgb(239, 188, 0),
    Color.FromArgb(241, 88, 127),
    Color.FromArgb(1, 220, 205),
    Color.FromArgb(107, 83, 255),
    Color.FromArgb(94, 153, 254)
    };
            series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series8.BackSecondaryColor = Color.AliceBlue;
            series8.BorderColor = Color.White;
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Color = Color.DodgerBlue;
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chartTotalProfit.Series.Add(series8);
            chartTotalProfit.Size = new Size(216, 261);
            chartTotalProfit.TabIndex = 12;
            chartTotalProfit.Text = "chart4";
            title6.Alignment = ContentAlignment.TopLeft;
            title6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title6.ForeColor = Color.FromArgb(22, 88, 142);
            title6.Name = "Title1";
            title6.Text = "Total Profit";
            chartTotalProfit.Titles.Add(title6);
            // 
            // DataOrderStatus
            // 
            DataOrderStatus.AllowUserToAddRows = false;
            DataOrderStatus.AllowUserToDeleteRows = false;
            DataOrderStatus.AllowUserToResizeColumns = false;
            DataOrderStatus.AllowUserToResizeRows = false;
            DataOrderStatus.BackgroundColor = Color.White;
            DataOrderStatus.BorderStyle = BorderStyle.None;
            DataOrderStatus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataOrderStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataOrderStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataOrderStatus.Columns.AddRange(new DataGridViewColumn[] { ID, Order });
            DataOrderStatus.EnableHeadersVisualStyles = false;
            DataOrderStatus.GridColor = Color.LightGray;
            DataOrderStatus.Location = new Point(190, 269);
            DataOrderStatus.Margin = new Padding(4, 4, 4, 4);
            DataOrderStatus.MultiSelect = false;
            DataOrderStatus.Name = "DataOrderStatus";
            DataOrderStatus.ReadOnly = true;
            DataOrderStatus.RowHeadersVisible = false;
            DataOrderStatus.RowHeadersWidth = 30;
            DataOrderStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataOrderStatus.Size = new Size(378, 261);
            DataOrderStatus.TabIndex = 13;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.FillWeight = 50F;
            ID.HeaderText = "OrderID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Order
            // 
            Order.HeaderText = "Order Status";
            Order.MinimumWidth = 10;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 393;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(808, 549);
            Controls.Add(DataOrderStatus);
            Controls.Add(chartTotalProfit);
            Controls.Add(chartAnnual);
            Controls.Add(chartTotalOrder);
            Controls.Add(panel1);
            Controls.Add(chart2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Dashboard";
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTotalOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartAnnual).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTotalProfit).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataOrderStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartTotalOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnnual;
        private System.Windows.Forms.Label lbTotalStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFeedBack;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartTotalProfit;
        private DataGridView DataOrderStatus;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Order;
    }

}