using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class FoodManagementForm : Form
    {
        private readonly ePartyDbDbContext _context;
        private List<Food> _danhSachMonAn;
        private Food _monAnDangChon;
        private DateTime _thoiGianMoForm;

        // Điều khiển được tạo động
        private DataGridView dataGridViewMonAn;
        private TextBox txtTenMonAn, txtMoTa, txtSoLuong, txtDonVi, txtChiPhi;
        private Label lblTenMonAn, lblMoTa, lblSoLuong, lblDonVi, lblChiPhi;
        private ListBox listBoxNguyenLieu;
        private ComboBox comboBoxNguyenLieu;
        private Button btnThemMonAn, btnCapNhat, btnQuanLyNguyenLieu, btnThemNguyenLieu;

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

        public FoodManagementForm(DateTime thoiGianMo)
        {
            _thoiGianMoForm = thoiGianMo;
            _context = new ePartyDbDbContext();
            _danhSachMonAn = new List<Food>();
            _monAnDangChon = null;

            InitializeComponent();
            TaoDieuKhien();

            btnThemMonAn.Click += btnThemMonAn_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnQuanLyNguyenLieu.Click += btnQuanLyNguyenLieu_Click;
            btnThemNguyenLieu.Click += btnThemNguyenLieu_Click;
            dataGridViewMonAn.CellDoubleClick += dataGridViewMonAn_CellDoubleClick;
            Load += FoodManagementForm_Load;
        }

        public FoodManagementForm() : this(DateTime.Now)
        {
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FoodManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FoodManagementForm";
            Text = "Quản Lý Món Ăn";
            Load += FoodManagementForm_Load;
            ResumeLayout(false);
        }
        #endregion

        private void FoodManagementForm_Load(object sender, EventArgs e)
        {
            OnFormLoad();
        }

        private void OnFormLoad()
        {
            try
            {
                TaiDanhSachMonAn();
                comboBoxNguyenLieu.DataSource = _context.Ingredients.ToList();
                comboBoxNguyenLieu.DisplayMember = "Name";
                comboBoxNguyenLieu.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaoDieuKhien()
        {
            // DataGridView: Hiển thị danh sách món ăn
            dataGridViewMonAn = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(1500, 400), // Tăng kích thước để hiển thị nhiều dữ liệu hơn
                AutoGenerateColumns = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Font = new Font("Arial", 12) // Tăng kích thước font cho dễ đọc
            };
            this.Controls.Add(dataGridViewMonAn);

            // Labels và TextBoxes: Thông tin chi tiết món ăn
            lblTenMonAn = new Label { Text = "Tên món ăn:", Location = new Point(20, 450), Size = new Size(150, 30), Font = new Font("Arial", 14) };
            txtTenMonAn = new TextBox { Location = new Point(180, 450), Size = new Size(400, 30), Font = new Font("Arial", 12) };

            lblMoTa = new Label { Text = "Mô tả:", Location = new Point(20, 500), Size = new Size(150, 30), Font = new Font("Arial", 14) };
            txtMoTa = new TextBox { Location = new Point(180, 500), Size = new Size(400, 30), Font = new Font("Arial", 12) };

            lblSoLuong = new Label { Text = "Số lượng:", Location = new Point(20, 550), Size = new Size(150, 30), Font = new Font("Arial", 14) };
            txtSoLuong = new TextBox { Location = new Point(180, 550), Size = new Size(400, 30), Font = new Font("Arial", 12) };

            lblDonVi = new Label { Text = "Đơn vị:", Location = new Point(20, 600), Size = new Size(150, 30), Font = new Font("Arial", 14) };
            txtDonVi = new TextBox { Location = new Point(180, 600), Size = new Size(400, 30), Font = new Font("Arial", 12) };

            lblChiPhi = new Label { Text = "Chi phí:", Location = new Point(20, 650), Size = new Size(150, 30), Font = new Font("Arial", 14) };
            txtChiPhi = new TextBox { Location = new Point(180, 650), Size = new Size(400, 30), Font = new Font("Arial", 12) };

            this.Controls.AddRange(new Control[] { lblTenMonAn, txtTenMonAn, lblMoTa, txtMoTa, lblSoLuong, txtSoLuong, lblDonVi, txtDonVi, lblChiPhi, txtChiPhi });

            // ListBox: Hiển thị danh sách nguyên liệu
            listBoxNguyenLieu = new ListBox
            {
                Location = new Point(600, 450),
                Size = new Size(300, 230), // Tăng kích thước
                Font = new Font("Arial", 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(listBoxNguyenLieu);

            // ComboBox: Lựa chọn nguyên liệu
            comboBoxNguyenLieu = new ComboBox
            {
                Location = new Point(600, 700),
                Size = new Size(300, 40), // Tăng kích thước
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Arial", 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(comboBoxNguyenLieu);

            // Buttons: Các nút chức năng
            btnThemMonAn = new Button { Text = "Thêm món ăn", Location = new Point(20, 700), Size = new Size(150, 50), Font = new Font("Arial", 12) };
            btnCapNhat = new Button { Text = "Cập nhật", Location = new Point(200, 700), Size = new Size(150, 50), Font = new Font("Arial", 12) };
            btnQuanLyNguyenLieu = new Button { Text = "Quản lý nguyên liệu", Location = new Point(20, 770), Size = new Size(150, 50), Font = new Font("Arial", 12) };
            btnThemNguyenLieu = new Button { Text = "Thêm nguyên liệu", Location = new Point(200, 770), Size = new Size(150, 50), Font = new Font("Arial", 12) };
            this.Controls.AddRange(new Control[] { btnThemMonAn, btnCapNhat, btnQuanLyNguyenLieu, btnThemNguyenLieu });

            // Đặt kích thước cố định cho form (đã có trong InitializeComponent)
            this.Size = new Size(1920, 1080);
        }

        private void TaiDanhSachMonAn()
        {
            try
            {
                _danhSachMonAn = _context.Foods.ToList();
                dataGridViewMonAn.DataSource = _danhSachMonAn;
                dataGridViewMonAn.Columns["FoodNeedIngres"].Visible = false;
                dataGridViewMonAn.Columns["OrderHaveFoods"].Visible = false;
                dataGridViewMonAn.Columns["StaticFoods"].Visible = false;
                dataGridViewMonAn.Columns["ManagerNavigation"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            using (var form = new ChiTietMonAnForm(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var monAnMoi = form.MonAn;
                    _context.Foods.Add(monAnMoi);
                    _context.SaveChanges();
                    TaiLaiForm();
                }
            }
        }

        private void dataGridViewMonAn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maMonAn = (int)dataGridViewMonAn.Rows[e.RowIndex].Cells["Id"].Value;
                _monAnDangChon = _context.Foods.Include(f => f.FoodNeedIngres).ThenInclude(fni => fni.Ingredient)
                    .FirstOrDefault(f => f.Id == maMonAn);
                HienThiChiTietMonAn();
            }
        }

        private void HienThiChiTietMonAn()
        {
            if (_monAnDangChon != null)
            {
                txtTenMonAn.Text = _monAnDangChon.Name ?? "";
                txtMoTa.Text = _monAnDangChon.Description ?? "";
                txtSoLuong.Text = _monAnDangChon.Amount?.ToString() ?? "";
                txtDonVi.Text = _monAnDangChon.Unit ?? "";
                txtChiPhi.Text = _monAnDangChon.Cost?.ToString() ?? "";
                TaiDanhSachNguyenLieu();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_monAnDangChon != null)
            {
                try
                {
                    _monAnDangChon.Name = txtTenMonAn.Text;
                    _monAnDangChon.Description = txtMoTa.Text;
                    _monAnDangChon.Amount = string.IsNullOrEmpty(txtSoLuong.Text) ? null : int.Parse(txtSoLuong.Text);
                    _monAnDangChon.Unit = txtDonVi.Text;
                    _monAnDangChon.Cost = string.IsNullOrEmpty(txtChiPhi.Text) ? null : int.Parse(txtChiPhi.Text);
                    _context.SaveChanges();
                    MessageBox.Show("Thông tin món ăn đã được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiLaiForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuanLyNguyenLieu_Click(object sender, EventArgs e)
        {
            if (_monAnDangChon != null)
            {
                using (var form = new QuanLyNguyenLieuForm(_monAnDangChon))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _monAnDangChon = form.MonAnDaCapNhat;
                        _context.SaveChanges();
                        TinhChiPhi();
                        HienThiChiTietMonAn();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để quản lý nguyên liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TinhChiPhi()
        {
            if (_monAnDangChon != null && _monAnDangChon.FoodNeedIngres != null)
            {
                int tongChiPhi = 0;
                foreach (var nguyenLieuCanDung in _monAnDangChon.FoodNeedIngres)
                {
                    if (nguyenLieuCanDung.Ingredient?.Cost != null && nguyenLieuCanDung.Amount != null)
                    {
                        tongChiPhi += nguyenLieuCanDung.Ingredient.Cost.Value * nguyenLieuCanDung.Amount.Value;
                    }
                }
                _monAnDangChon.Cost = tongChiPhi;
                _context.SaveChanges();
            }
        }

        private void TaiDanhSachNguyenLieu()
        {
            if (_monAnDangChon != null)
            {
                try
                {
                    var danhSachNguyenLieu = _context.FoodNeedIngres
                        .Where(fni => fni.FoodId == _monAnDangChon.Id)
                        .Select(fni => fni.Ingredient)
                        .ToList();
                    listBoxNguyenLieu.DataSource = danhSachNguyenLieu;
                    listBoxNguyenLieu.DisplayMember = "Name";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            if (_monAnDangChon != null && !string.IsNullOrEmpty(comboBoxNguyenLieu.SelectedValue?.ToString()))
            {
                int maNguyenLieu = (int)comboBoxNguyenLieu.SelectedValue;
                var nguyenLieu = _context.Ingredients.Find(maNguyenLieu);
                if (nguyenLieu != null)
                {
                    var nguyenLieuCanDung = new FoodNeedIngre
                    {
                        FoodId = _monAnDangChon.Id,
                        IngredientId = maNguyenLieu,
                        Amount = 1
                    };
                    _context.FoodNeedIngres.Add(nguyenLieuCanDung);
                    _context.SaveChanges();
                    TaiLaiForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn và nguyên liệu để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TaiLaiForm()
        {
            TaiDanhSachMonAn();
            _monAnDangChon = null;
            XoaTrangCacTruong();
        }

        private void XoaTrangCacTruong()
        {
            txtTenMonAn.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            txtDonVi.Text = "";
            txtChiPhi.Text = "";
            listBoxNguyenLieu.DataSource = null;
        }
    }

    public partial class ChiTietMonAnForm : Form
    {
        public Food MonAn { get; private set; }

        private TextBox txtTenMonAn, txtMoTa, txtSoLuong, txtDonVi, txtChiPhi;
        private Label lblTenMonAn, lblMoTa, lblSoLuong, lblDonVi, lblChiPhi;
        private Button btnLuu;

        public ChiTietMonAnForm(Food monAn)
        {
            MonAn = monAn ?? new Food();

            lblTenMonAn = new Label { Text = "Tên món ăn:", Location = new Point(10, 10), Size = new Size(100, 30), Font = new Font("Arial", 12) };
            txtTenMonAn = new TextBox { Location = new Point(110, 10), Size = new Size(200, 30), Font = new Font("Arial", 12) };

            lblMoTa = new Label { Text = "Mô tả:", Location = new Point(10, 50), Size = new Size(100, 30), Font = new Font("Arial", 12) };
            txtMoTa = new TextBox { Location = new Point(110, 50), Size = new Size(200, 30), Font = new Font("Arial", 12) };

            lblSoLuong = new Label { Text = "Số lượng:", Location = new Point(10, 90), Size = new Size(100, 30), Font = new Font("Arial", 12) };
            txtSoLuong = new TextBox { Location = new Point(110, 90), Size = new Size(200, 30), Font = new Font("Arial", 12) };

            lblDonVi = new Label { Text = "Đơn vị:", Location = new Point(10, 130), Size = new Size(100, 30), Font = new Font("Arial", 12) };
            txtDonVi = new TextBox { Location = new Point(110, 130), Size = new Size(200, 30), Font = new Font("Arial", 12) };

            lblChiPhi = new Label { Text = "Chi phí:", Location = new Point(10, 170), Size = new Size(100, 30), Font = new Font("Arial", 12) };
            txtChiPhi = new TextBox { Location = new Point(110, 170), Size = new Size(200, 30), Font = new Font("Arial", 12) };

            btnLuu = new Button { Text = "Lưu", Location = new Point(110, 210), Size = new Size(100, 40), Font = new Font("Arial", 12) };

            this.Controls.AddRange(new Control[] { lblTenMonAn, txtTenMonAn, lblMoTa, txtMoTa, lblSoLuong, txtSoLuong, lblDonVi, txtDonVi, lblChiPhi, txtChiPhi, btnLuu });
            this.Size = new Size(350, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            txtTenMonAn.Text = MonAn.Name ?? "";
            txtMoTa.Text = MonAn.Description ?? "";
            txtSoLuong.Text = MonAn.Amount?.ToString() ?? "";
            txtDonVi.Text = MonAn.Unit ?? "";
            txtChiPhi.Text = MonAn.Cost?.ToString() ?? "";

            btnLuu.Click += btnLuu_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn.Name = txtTenMonAn.Text;
                MonAn.Description = txtMoTa.Text;
                MonAn.Amount = string.IsNullOrEmpty(txtSoLuong.Text) ? null : int.Parse(txtSoLuong.Text);
                MonAn.Unit = txtDonVi.Text;
                MonAn.Cost = string.IsNullOrEmpty(txtChiPhi.Text) ? null : int.Parse(txtChiPhi.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public partial class QuanLyNguyenLieuForm : Form
    {
        public Food MonAnDaCapNhat { get; private set; }

        private ListBox listBoxNguyenLieu;
        private Button btnLuuThayDoi;

        public QuanLyNguyenLieuForm(Food monAn)
        {
            MonAnDaCapNhat = monAn;

            listBoxNguyenLieu = new ListBox { Location = new Point(10, 10), Size = new Size(200, 150), Font = new Font("Arial", 12) };
            btnLuuThayDoi = new Button { Text = "Lưu thay đổi", Location = new Point(10, 170), Size = new Size(100, 40), Font = new Font("Arial", 12) };

            this.Controls.AddRange(new Control[] { listBoxNguyenLieu, btnLuuThayDoi });
            this.Size = new Size(250, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            TaiDanhSachNguyenLieu();

            btnLuuThayDoi.Click += btnLuuThayDoi_Click;
        }

        private void TaiDanhSachNguyenLieu()
        {
            listBoxNguyenLieu.DataSource = MonAnDaCapNhat.FoodNeedIngres?.Select(fni => fni.Ingredient).ToList() ?? new List<Ingredient>();
            listBoxNguyenLieu.DisplayMember = "Name";
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}