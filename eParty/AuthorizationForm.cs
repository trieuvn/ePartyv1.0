using Azure.Identity;
using eParty.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class AuthorizationForm : Form
    {
        private MenuForm menuForm;
        public string username;
        private int loginAttempts = 0; // Đếm số lần thử đăng nhập
        private const int MAX_ATTEMPTS = 3; // Giới hạn số lần thử

        public AuthorizationForm(MenuForm parent, string username)
        {
            InitializeComponent();
            menuForm = parent;
            this.username = username;
        }

        private void lLforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private bool CompareImages(Image img1, Image img2)
        {
            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                byte[] hash1 = MD5.Create().ComputeHash(ms1.ToArray());
                byte[] hash2 = MD5.Create().ComputeHash(ms2.ToArray());

                return StructuralComparisons.StructuralEqualityComparer.Equals(hash1, hash2);
            }
        }

        private void artanButton1_Click(object sender, EventArgs e)
        {
            if (CompareImages(artanButton1.Image, ByteArrayToImage(Resources.View)))
            {
                txtPass.UseSystemPasswordChar = false;
                artanButton1.Image = ByteArrayToImage(Resources.Hide);
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                artanButton1.Image = ByteArrayToImage(Resources.View);
            }
        }

        private void artanButton2_Click(object sender, EventArgs e)
        {
            if (CompareImages(artanButton2.Image, ByteArrayToImage(Resources.View)))
            {
                txtConfirm.UseSystemPasswordChar = false;
                artanButton2.Image = ByteArrayToImage(Resources.Hide);
            }
            else
            {
                txtConfirm.UseSystemPasswordChar = true;
                artanButton2.Image = ByteArrayToImage(Resources.View);
            }
        }

        private void btnstarted_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter both password and confirm password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mật khẩu nhập vào và mật khẩu xác nhận có khớp nhau không
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtConfirm.Clear();
                txtPass.Focus();
                return;
            }

            try
            {
                using (var context = new ePartyDbDbContext())
                {
                    // Lấy thông tin người dùng từ cơ sở dữ liệu
                    var manager = context.Managers
                        .AsNoTracking()
                        .FirstOrDefault(m => m.UserName == username);

                    if (manager == null)
                    {
                        // Nếu không tìm thấy người dùng
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // So sánh mật khẩu phân biệt hoa thường trong C#
                    if (manager.Password != password) // So sánh phân biệt hoa thường
                    {
                        loginAttempts++;
                        int remainingAttempts = MAX_ATTEMPTS - loginAttempts;

                        if (remainingAttempts > 0)
                        {
                            MessageBox.Show($"Incorrect password! You have {remainingAttempts} attempt(s) left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                            txtConfirm.Clear();
                            txtPass.Focus();
                        }
                        else
                        {
                            MessageBox.Show("You have exceeded the maximum number of attempts. You will be logged out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Đăng xuất: Đóng tất cả các form và quay lại form Login
                            Application.OpenForms.Cast<Form>().ToList().ForEach(form => form.Close());
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        return; // Thoát ngay nếu mật khẩu sai
                    }

                    // Nếu mật khẩu khớp với cơ sở dữ liệu
                    loginAttempts = 0; // Reset số lần thử
                    MessageBox.Show("Authorization successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển đến form ReportForm
                    this.Hide();
                    menuForm.OpenForm(new ReportForm(menuForm, username));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Authorization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lLforgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            // Đặt lại số lần thử khi form được tải
            loginAttempts = 0;

            // Ẩn mật khẩu mặc định
            txtPass.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;

            // Đặt hình ảnh của các nút thành "View" (biểu thị mật khẩu đang ẩn)
            artanButton1.Image = ByteArrayToImage(Resources.View);
            artanButton2.Image = ByteArrayToImage(Resources.View);
        }

        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}