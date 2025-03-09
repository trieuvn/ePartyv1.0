
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
            listViewOrders = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            radio7Days = new RadioButton();
            radio1Month = new RadioButton();
            radioAll = new RadioButton();
            btnOpenSchedule = new Button();
            SuspendLayout();
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewOrders.Location = new Point(359, 236);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(565, 252);
            listViewOrders.TabIndex = 2;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order ID";
            columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Description";
            columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "No. Tables";
            columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Begin Time";
            columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "End Time";
            columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Feedback";
            columnHeader6.Width = 90;
            // 
            // radio7Days
            // 
            radio7Days.AutoSize = true;
            radio7Days.Location = new Point(234, 145);
            radio7Days.Name = "radio7Days";
            radio7Days.Size = new Size(97, 19);
            radio7Days.TabIndex = 3;
            radio7Days.TabStop = true;
            radio7Days.Text = "lịch 7 ngày kế";
            radio7Days.UseVisualStyleBackColor = true;
            // 
            // radio1Month
            // 
            radio1Month.AutoSize = true;
            radio1Month.Location = new Point(234, 188);
            radio1Month.Name = "radio1Month";
            radio1Month.Size = new Size(102, 19);
            radio1Month.TabIndex = 4;
            radio1Month.TabStop = true;
            radio1Month.Text = "lịch 1 tháng kế";
            radio1Month.UseVisualStyleBackColor = true;
            radio1Month.CheckedChanged += radio1Month_CheckedChanged;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Location = new Point(234, 236);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(76, 19);
            radioAll.TabIndex = 5;
            radioAll.TabStop = true;
            radioAll.Text = "lịch tất cả";
            radioAll.UseVisualStyleBackColor = true;
            // 
            // btnOpenSchedule
            // 
            btnOpenSchedule.Location = new Point(155, 411);
            btnOpenSchedule.Name = "btnOpenSchedule";
            btnOpenSchedule.Size = new Size(135, 55);
            btnOpenSchedule.TabIndex = 6;
            btnOpenSchedule.Text = "Mở thời khóa biểu";
            btnOpenSchedule.UseVisualStyleBackColor = true;
            btnOpenSchedule.Click += btnOpenSchedule_Click;
            // 
            // FormOrderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(btnOpenSchedule);
            Controls.Add(radioAll);
            Controls.Add(radio1Month);
            Controls.Add(radio7Days);
            Controls.Add(listViewOrders);
            Margin = new Padding(4);
            Name = "FormOrderList";
            Text = "Form1";
            Load += FormOrderList_Load;
            ResumeLayout(false);
            PerformLayout();
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

