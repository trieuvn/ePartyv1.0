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
        public IngredientProvider(MenuForm menu, IngredientListForm ingredientListForm)
        {
            InitializeComponent();
            this.Menu = menu;
            this.IngredientListForm = ingredientListForm;
        }

        private void artanButton2_Click(object sender, EventArgs e)
        {
            Menu.OpenForm(new IngredientListForm()); // Remove the 'Menu' argument        }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
