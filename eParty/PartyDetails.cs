using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer.Repository.Models;

namespace eParty
{
    public partial class PartyDetails : Form
    {
        // 🟢 Khai báo các biến thành viên (fields)
        private int partyId;
        private string description;
        private int tables;
        private string startTime;
        private string endTime;
        private string manager;
        private string feedback;

        // ✅ Constructor nhận dữ liệu từ FormSchedule
        public PartyDetails(int partyId, string description, int tables, string startTime, string endTime, string manager, string feedback)
        {
            InitializeComponent();

            // Gán dữ liệu vào các biến thành viên
            this.partyId = partyId;
            this.description = description;
            this.tables = tables;
            this.startTime = startTime;
            this.endTime = endTime;
            this.manager = manager;
            this.feedback = feedback;

            this.Text = "Chi tiết tiệc";
            InitializeUI();
        }
        private void InitializeUI()
        {
            // 🟢 Tạo giao diện hiển thị thông tin
            Label lblInfo = new Label()
            {
                Text = $"🆔 ID Tiệc: {partyId}\n\n📌 Mô tả: {description}\n\n🍽️ Số bàn: {tables}\n\n⏰ Thời gian: {startTime} - {endTime}\n\n👨‍💼 Người quản lý: {manager}\n\n📝 Feedback: {feedback}",
                AutoSize = true,
                Location = new Point(20, 20),
                Font = new Font("Arial", 10, FontStyle.Regular)
            };

            Button btnClose = new Button()
            {
                Text = "Đóng",
                Location = new Point(100, 200),
                Size = new Size(100, 30)
            };

            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblInfo);
            this.Controls.Add(btnClose);
            this.Size = new Size(400, 300);
        }

        private void PartyDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
