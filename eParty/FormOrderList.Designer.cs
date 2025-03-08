namespace eParty
{
    partial class FormOrderList
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
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radio7Days = new System.Windows.Forms.RadioButton();
            this.radio1Month = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.btnOpenSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(410, 252);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(645, 269);
            this.listViewOrders.TabIndex = 2;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No. Tables";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Begin Time";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "End Time";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Feedback";
            this.columnHeader6.Width = 90;
            // 
            // radio7Days
            // 
            this.radio7Days.AutoSize = true;
            this.radio7Days.Location = new System.Drawing.Point(267, 155);
            this.radio7Days.Name = "radio7Days";
            this.radio7Days.Size = new System.Drawing.Size(109, 20);
            this.radio7Days.TabIndex = 3;
            this.radio7Days.TabStop = true;
            this.radio7Days.Text = "lịch 7 ngày kế";
            this.radio7Days.UseVisualStyleBackColor = true;
            // 
            // radio1Month
            // 
            this.radio1Month.AutoSize = true;
            this.radio1Month.Location = new System.Drawing.Point(267, 201);
            this.radio1Month.Name = "radio1Month";
            this.radio1Month.Size = new System.Drawing.Size(112, 20);
            this.radio1Month.TabIndex = 4;
            this.radio1Month.TabStop = true;
            this.radio1Month.Text = "lịch 1 tháng kế";
            this.radio1Month.UseVisualStyleBackColor = true;
            this.radio1Month.CheckedChanged += new System.EventHandler(this.radio1Month_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(267, 252);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(83, 20);
            this.radioAll.TabIndex = 5;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "lịch tất cả";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // btnOpenSchedule
            // 
            this.btnOpenSchedule.Location = new System.Drawing.Point(177, 438);
            this.btnOpenSchedule.Name = "btnOpenSchedule";
            this.btnOpenSchedule.Size = new System.Drawing.Size(154, 59);
            this.btnOpenSchedule.TabIndex = 6;
            this.btnOpenSchedule.Text = "Mở thời khóa biểu";
            this.btnOpenSchedule.UseVisualStyleBackColor = true;
            //this.btnOpenSchedule.Click += new System.EventHandler(this.btnOpenSchedule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenSchedule);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.radio1Month);
            this.Controls.Add(this.radio7Days);
            this.Controls.Add(this.listViewOrders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton radio7Days;
        private System.Windows.Forms.RadioButton radio1Month;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Button btnOpenSchedule;
    }
}

