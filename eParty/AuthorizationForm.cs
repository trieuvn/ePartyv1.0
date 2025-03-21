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

namespace eParty
{
    public partial class AuthorizationForm : Form
    {
        private MenuForm menuForm;
        public string username;
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

        }

        private void lLforgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
