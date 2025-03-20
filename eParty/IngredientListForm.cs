using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eParty
{
    public partial class IngredientListForm : Form
    {
        public MenuForm menuform;
        public IngredientListForm(MenuForm Menu)
        {
            InitializeComponent();
            this.menuform = Menu;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void artanButton2_Click(object sender, EventArgs e)
        {

            menuform.OpenForm(new IngredientProvider(menuform,this));

        }
    }
}
