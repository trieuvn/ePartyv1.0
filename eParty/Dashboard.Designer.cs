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
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            lbProfit = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbTotalStaff = new Label();
            label1 = new Label();
            lbTotal = new Label();
            label2 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(852, 450);
            chart2.Margin = new Padding(6, 7, 6, 7);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(0, 0);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea2.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = Color.FromArgb(42, 128, 182);
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            chart3.Location = new Point(936, -2);
            chart3.Margin = new Padding(6, 7, 6, 7);
            chart3.Name = "chart3";
            chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart3.PaletteCustomColors = new Color[]
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
            chart3.Series.Add(series2);
            chart3.Size = new Size(351, 418);
            chart3.TabIndex = 7;
            chart3.Text = "chart3";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.FromArgb(22, 88, 142);
            title1.Name = "Title1";
            title1.Text = "Total Order";
            chart3.Titles.Add(title1);
            chart3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 59);
            pictureBox1.Margin = new Padding(6, 7, 6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 155);
            pictureBox2.Margin = new Padding(6, 7, 6, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(26, 256);
            pictureBox3.Margin = new Padding(6, 7, 6, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 342);
            pictureBox4.Margin = new Padding(6, 7, 6, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbProfit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbTotalStaff);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 431);
            panel1.Margin = new Padding(6, 7, 6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 418);
            panel1.TabIndex = 6;
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Font = new Font("Segoe UI", 8F);
            lbProfit.ForeColor = Color.FromArgb(42, 128, 182);
            lbProfit.Location = new Point(80, 354);
            lbProfit.Margin = new Padding(4, 0, 4, 0);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(81, 30);
            lbProfit.TabIndex = 12;
            lbProfit.Text = "NProfit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.FromArgb(42, 128, 182);
            label5.Location = new Point(20, 305);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 11;
            label5.Text = "Profit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.ForeColor = Color.FromArgb(42, 128, 182);
            label4.Location = new Point(80, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 10;
            label4.Text = "Nfeedback";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.FromArgb(42, 128, 182);
            label3.Location = new Point(20, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 9;
            label3.Text = "Feedback";
            // 
            // lbTotalStaff
            // 
            lbTotalStaff.AutoSize = true;
            lbTotalStaff.Font = new Font("Segoe UI", 9F);
            lbTotalStaff.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotalStaff.Location = new Point(80, 155);
            lbTotalStaff.Margin = new Padding(4, 0, 4, 0);
            lbTotalStaff.Name = "lbTotalStaff";
            lbTotalStaff.Size = new Size(153, 32);
            lbTotalStaff.TabIndex = 8;
            lbTotalStaff.Text = "Staff number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = Color.FromArgb(42, 128, 182);
            label1.Location = new Point(20, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 7;
            label1.Text = "Staff";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 9F);
            lbTotal.ForeColor = Color.FromArgb(42, 128, 182);
            lbTotal.Location = new Point(80, 59);
            lbTotal.Margin = new Padding(4, 0, 4, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(166, 32);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Number order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(42, 128, 182);
            label2.Location = new Point(20, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 5;
            label2.Text = "Total Order";
            // 
            // chart1
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
            chart1.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new Font("Microsoft Sans Serif", 7F);
            legend3.ForeColor = Color.FromArgb(42, 128, 182);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(0, -2);
            chart1.Margin = new Padding(6, 7, 6, 7);
            chart1.Name = "chart1";
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
            chart1.Series.Add(series3);
            chart1.Size = new Size(923, 418);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Segoe UI", 12F);
            title2.ForeColor = Color.FromArgb(22, 88, 142);
            title2.Name = "Revenue gross";
            title2.Text = "Annual Growth Report";
            chart1.Titles.Add(title2);
            // 
            // chart4
            // 
            chartArea4.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 11);
            chartArea4.AxisY.MajorTickMark.LineWidth = 0;
            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = Color.FromArgb(42, 128, 182);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(936, 431);
            chart4.Margin = new Padding(6, 7, 6, 7);
            chart4.Name = "chart4";
            chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart4.PaletteCustomColors = new Color[]
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
            chart4.Series.Add(series4);
            chart4.Size = new Size(351, 418);
            chart4.TabIndex = 12;
            chart4.Text = "chart4";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title3.ForeColor = Color.FromArgb(22, 88, 142);
            title3.Name = "Title1";
            title3.Text = "Total Profit";
            chart4.Titles.Add(title3);
            chart4.Visible = false;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(42, 128, 182);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Order });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(309, 431);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(614, 418);
            dataGridView1.TabIndex = 13;
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1313, 879);
            Controls.Add(dataGridView1);
            Controls.Add(chart4);
            Controls.Add(chart1);
            Controls.Add(chart3);
            Controls.Add(panel1);
            Controls.Add(chart2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Dashboard";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTotalStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Order;
    }

}