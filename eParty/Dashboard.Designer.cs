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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(458, 211);
            chart2.Margin = new Padding(4, 3, 4, 3);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(0, 0);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chartTotalOrder
            // 
            chartArea2.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartTotalOrder.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = Color.FromArgb(42, 128, 182);
            legend2.Name = "Legend1";
            chartTotalOrder.Legends.Add(legend2);
            chartTotalOrder.Location = new Point(504, -1);
            chartTotalOrder.Margin = new Padding(4, 3, 4, 3);
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
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = Color.AliceBlue;
            series2.BorderColor = Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = Color.DodgerBlue;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTotalOrder.Series.Add(series2);
            chartTotalOrder.Size = new Size(189, 196);
            chartTotalOrder.TabIndex = 7;
            chartTotalOrder.Text = "chart3";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.FromArgb(22, 88, 142);
            title1.Name = "Title1";
            title1.Text = "Total Order";
            chartTotalOrder.Titles.Add(title1);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 28);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 73);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 120);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 160);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 19);
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
            panel1.Location = new Point(0, 202);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 196);
            panel1.TabIndex = 6;
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Font = new Font("Segoe UI", 8F);
            lbProfit.ForeColor = Color.FromArgb(42, 128, 182);
            lbProfit.Location = new Point(43, 166);
            lbProfit.Margin = new Padding(2, 0, 2, 0);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(43, 13);
            lbProfit.TabIndex = 12;
            lbProfit.Text = "NProfit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.FromArgb(42, 128, 182);
            label5.Location = new Point(10, 143);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 13);
            label5.TabIndex = 11;
            label5.Text = "Profit";
            // 
            // lbFeedBack
            // 
            lbFeedBack.AutoSize = true;
            lbFeedBack.Font = new Font("Segoe UI", 8F);
            lbFeedBack.ForeColor = Color.FromArgb(42, 128, 182);
            lbFeedBack.Location = new Point(43, 120);
            lbFeedBack.Margin = new Padding(2, 0, 2, 0);
            lbFeedBack.Name = "lbFeedBack";
            lbFeedBack.Size = new Size(62, 13);
            lbFeedBack.TabIndex = 10;
            lbFeedBack.Text = "Nfeedback";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.FromArgb(42, 128, 182);
            label3.Location = new Point(10, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 9;
            label3.Text = "Feedback";
            // 
            // lbTotalStaff
            // 
            lbTotalStaff.AutoSize = true;
            lbTotalStaff.Font = new Font("Segoe UI", 9F);
            lbTotalStaff.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotalStaff.Location = new Point(43, 73);
            lbTotalStaff.Margin = new Padding(2, 0, 2, 0);
            lbTotalStaff.Name = "lbTotalStaff";
            lbTotalStaff.Size = new Size(76, 15);
            lbTotalStaff.TabIndex = 8;
            lbTotalStaff.Text = "Staff number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = Color.FromArgb(42, 128, 182);
            label1.Location = new Point(10, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 13);
            label1.TabIndex = 7;
            label1.Text = "Staff";
            // 
            // lbTotalNumber
            // 
            lbTotalNumber.AutoSize = true;
            lbTotalNumber.Font = new Font("Segoe UI", 9F);
            lbTotalNumber.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotalNumber.Location = new Point(43, 32);
            lbTotalNumber.Margin = new Padding(2, 0, 2, 0);
            lbTotalNumber.Name = "lbTotalNumber";
            lbTotalNumber.Size = new Size(82, 15);
            lbTotalNumber.TabIndex = 6;
            lbTotalNumber.Text = "Number order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(42, 128, 182);
            label2.Location = new Point(10, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 13);
            label2.TabIndex = 5;
            label2.Text = "Total Order";
            // 
            // chartAnnual
            // 
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = Color.FromArgb(42, 128, 182);
            chartArea3.AxisX.LineColor = Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = Color.White;
            chartArea3.AxisX.MajorTickMark.Size = 3F;
            chartArea3.AxisY.LabelStyle.ForeColor = Color.FromArgb(42, 128, 182);
            chartArea3.AxisY.LabelStyle.Format = "#,##0 VND";
            chartArea3.AxisY.LineColor = Color.WhiteSmoke;
            chartArea3.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea3.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            chartArea3.AxisY.MajorTickMark.LineWidth = 0;
            chartArea3.Name = "ChartArea1";
            chartAnnual.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new Font("Microsoft Sans Serif", 7F);
            legend3.ForeColor = Color.FromArgb(42, 128, 182);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            chartAnnual.Legends.Add(legend3);
            chartAnnual.Location = new Point(0, -1);
            chartAnnual.Margin = new Padding(4, 3, 4, 3);
            chartAnnual.Name = "chartAnnual";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = Color.FromArgb(50, 200, 100);
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = Color.FromArgb(80, 160, 255);
            series3.Legend = "Legend1";
            series3.MarkerColor = Color.MediumPurple;
            series3.MarkerSize = 8;
            series3.Name = "Series1";
            chartAnnual.Series.Add(series3);
            chartAnnual.Size = new Size(497, 196);
            chartAnnual.TabIndex = 10;
            chartAnnual.Text = "chart1";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Segoe UI", 12F);
            title2.ForeColor = Color.FromArgb(22, 88, 142);
            title2.Name = "Revenue gross";
            title2.Text = "Annual Growth Report";
            chartAnnual.Titles.Add(title2);
            chartAnnual.Click += chart1_Click;
            // 
            // chartTotalProfit
            // 
            chartArea4.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea4.AxisY.MajorTickMark.LineWidth = 0;
            chartArea4.Name = "ChartArea1";
            chartTotalProfit.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = Color.FromArgb(42, 128, 182);
            legend4.Name = "Legend1";
            chartTotalProfit.Legends.Add(legend4);
            chartTotalProfit.Location = new Point(504, 202);
            chartTotalProfit.Margin = new Padding(4, 3, 4, 3);
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
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BackSecondaryColor = Color.AliceBlue;
            series4.BorderColor = Color.White;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = Color.DodgerBlue;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartTotalProfit.Series.Add(series4);
            chartTotalProfit.Size = new Size(189, 196);
            chartTotalProfit.TabIndex = 12;
            chartTotalProfit.Text = "chart4";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title3.ForeColor = Color.FromArgb(22, 88, 142);
            title3.Name = "Title1";
            title3.Text = "Total Profit";
            chartTotalProfit.Titles.Add(title3);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataOrderStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataOrderStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataOrderStatus.Columns.AddRange(new DataGridViewColumn[] { ID, Order });
            DataOrderStatus.EnableHeadersVisualStyles = false;
            DataOrderStatus.GridColor = Color.LightGray;
            DataOrderStatus.Location = new Point(166, 202);
            DataOrderStatus.Margin = new Padding(4, 3, 4, 3);
            DataOrderStatus.MultiSelect = false;
            DataOrderStatus.Name = "DataOrderStatus";
            DataOrderStatus.ReadOnly = true;
            DataOrderStatus.RowHeadersVisible = false;
            DataOrderStatus.RowHeadersWidth = 30;
            DataOrderStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataOrderStatus.Size = new Size(331, 196);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 456);
            Controls.Add(DataOrderStatus);
            Controls.Add(chartTotalProfit);
            Controls.Add(chartAnnual);
            Controls.Add(chartTotalOrder);
            Controls.Add(panel1);
            Controls.Add(chart2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
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