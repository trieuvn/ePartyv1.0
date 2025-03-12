namespace Menu
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalStaff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(393, 183);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(0, 0);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(11)))));
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(432, -1);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = System.Drawing.Color.AliceBlue;
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.DodgerBlue;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(162, 170);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(142)))));
            title1.Name = "Title1";
            title1.Text = "Total Order";
            this.chart3.Titles.Add(title1);
            this.chart3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 140);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbProfit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTotalStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 170);
            this.panel1.TabIndex = 6;
            // 
            // lbProfit
            // 
            this.lbProfit.AutoSize = true;
            this.lbProfit.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.lbProfit.Location = new System.Drawing.Point(37, 144);
            this.lbProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProfit.Name = "lbProfit";
            this.lbProfit.Size = new System.Drawing.Size(43, 13);
            this.lbProfit.TabIndex = 12;
            this.lbProfit.Text = "NProfit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(37, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nfeedback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Feedback";
            // 
            // lbTotalStaff
            // 
            this.lbTotalStaff.AutoSize = true;
            this.lbTotalStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTotalStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.lbTotalStaff.Location = new System.Drawing.Point(37, 63);
            this.lbTotalStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalStaff.Name = "lbTotalStaff";
            this.lbTotalStaff.Size = new System.Drawing.Size(76, 15);
            this.lbTotalStaff.TabIndex = 8;
            this.lbTotalStaff.Text = "Staff number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.lbTotal.Location = new System.Drawing.Point(37, 24);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(82, 15);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Number order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Order";
            // 
            // chart1
            // 
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.Size = 3F;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            chartArea3.AxisY.LabelStyle.Format = "#,##0 VND";
            chartArea3.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea3.AxisY.MajorTickMark.LineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, -1);
            this.chart1.Name = "chart1";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.MediumPurple;
            series3.MarkerSize = 8;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(426, 170);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Segoe UI", 12F);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(142)))));
            title2.Name = "Revenue gross";
            title2.Text = "Annual Growth Report";
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OrderStatus});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(131, 175);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(295, 170);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "Order ID ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // chart4
            // 
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(11)))));
            chartArea4.AxisY.MajorTickMark.LineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(432, 175);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart4.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BackSecondaryColor = System.Drawing.Color.AliceBlue;
            series4.BorderColor = System.Drawing.Color.White;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.DodgerBlue;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(162, 170);
            this.chart4.TabIndex = 12;
            this.chart4.Text = "chart4";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(142)))));
            title3.Name = "Title1";
            title3.Text = "Total Profit";
            this.chart4.Titles.Add(title3);
            this.chart4.Visible = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 357);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}