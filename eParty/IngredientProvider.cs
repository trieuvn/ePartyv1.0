using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eParty
{
    public partial class IngredientProvider : Form
    {
        private MenuForm Menu;
        private IngredientListForm IngredientListForm;
        public string username;
        public IngredientProvider(MenuForm menu, IngredientListForm ingredientListForm, string username)
        {
            this.username = username;
            InitializeComponent();
            this.Menu = menu;
            this.IngredientListForm = ingredientListForm;
            this.username = username;
        }

        private void artanButton2_Click(object sender, EventArgs e)
        {
            Menu.OpenForm(new IngredientListForm(username)); // Remove the 'Menu' argument        }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
