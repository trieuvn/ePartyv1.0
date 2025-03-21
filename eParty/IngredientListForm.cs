using System;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class IngredientListForm : Form
    {
        private ePartyDbDbContext _context;
        private Ingredient _selectedIngredient;
        public string username;
        public IngredientListForm(string username)
        {
            this.username = username;
            InitializeComponent();
            _context = new ePartyDbDbContext();
            try
            {
                _context.Database.EnsureCreated();
                if (!_context.Database.CanConnect())
                {
                    MessageBox.Show("Cannot connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConfigureDataGridView();
            AttachEventHandlers();

            // Attach the Shown event
            this.Shown += IngredientListForm_Shown;
            this.username = username;
        }

        private void ConfigureDataGridView()
        {
            // Thêm cột ẩn để lưu Id
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                Visible = false // Ẩn cột Id trên giao diện
            };
            dataGridIngre.Columns.Insert(0, idColumn); // Thêm cột Id vào đầu

            // Ensure the DataGridView has the correct columns
            if (dataGridIngre.Columns["Order"] == null)
            {
                dataGridIngre.Columns.Add("Order", "Name");
            }
            else
            {
                dataGridIngre.Columns["Order"].HeaderText = "Name";
            }

            if (dataGridIngre.Columns["Amount"] == null)
            {
                dataGridIngre.Columns.Add("Amount", "Unit");
            }
            else
            {
                dataGridIngre.Columns["Amount"].HeaderText = "Unit";
            }

            if (dataGridIngre.Columns["Unit"] == null)
            {
                dataGridIngre.Columns.Add("Unit", "Cost");
            }
            else
            {
                dataGridIngre.Columns["Unit"].HeaderText = "Cost";
            }

            if (dataGridIngre.Columns["Cost"] == null)
            {
                dataGridIngre.Columns.Add("Cost", "Description");
            }
            else
            {
                dataGridIngre.Columns["Cost"].HeaderText = "Description";
            }

            if (dataGridIngre.Columns["Description"] == null)
            {
                dataGridIngre.Columns.Add("Description", "Manager");
            }
            else
            {
                dataGridIngre.Columns["Description"].HeaderText = "Manager";
            }

            dataGridIngre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridIngre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridIngre.RowTemplate.Height = 30;
            dataGridIngre.AllowUserToResizeRows = false;
        }

        private void AttachEventHandlers()
        {
            // Gắn sự kiện cho các nút và ô tìm kiếm
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridIngre.SelectionChanged += DataGridIngre_SelectionChanged;

            // Xử lý placeholder cho txtSearch
            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == "Search by ingredient name...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search by ingredient name...";
                    txtSearch.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // Xử lý placeholder cho các trường nhập liệu
            txtname.Enter += (s, e) => ClearPlaceholder(txtname, "Name");
            txtname.Leave += (s, e) => SetPlaceholder(txtname, "Name");
            txtUnit.Enter += (s, e) => ClearPlaceholder(txtUnit, "Unit");
            txtUnit.Leave += (s, e) => SetPlaceholder(txtUnit, "Unit");
            txtCost.Enter += (s, e) => ClearPlaceholder(txtCost, "Cost");
            txtCost.Leave += (s, e) => SetPlaceholder(txtCost, "Cost");
            txtDescription.Enter += (s, e) => ClearPlaceholder(txtDescription, "Description");
            txtDescription.Leave += (s, e) => SetPlaceholder(txtDescription, "Description");
        }

        private void ClearPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void LoadManagersIntoComboBox()
        {
            cboManager.Items.Clear();
            cboManager.Items.Add("None");
            try
            {
                var managers = _context.Managers
                    .Select(m => m.UserName)
                    .ToList();
                if (!managers.Any())
                {
                    MessageBox.Show("No managers found in the database. Please add a manager.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cboManager.Items.AddRange(managers.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading managers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cboManager.Items.Count > 0)
            {
                cboManager.SelectedIndex = 0;
            }
            else
            {
                cboManager.SelectedIndex = -1;
            }
        }

        private void LoadIngredientData(string searchText = "")
        {
            try
            {
                dataGridIngre.Rows.Clear();

                var ingredientQuery = _context.Ingredients.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Search by ingredient name...")
                {
                    ingredientQuery = ingredientQuery.Where(i => i.Name.Contains(searchText));
                }

                var ingredientList = ingredientQuery
                    .Select(i => new
                    {
                        i.Id,
                        i.Name,
                        i.Unit,
                        i.Cost,
                        i.Description,
                        i.Manager
                    })
                    .ToList();

                if (!ingredientList.Any())
                {
                    MessageBox.Show("No ingredients found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                foreach (var ingredient in ingredientList)
                {
                    dataGridIngre.Rows.Add(
                        ingredient.Id,
                        ingredient.Name,
                        ingredient.Unit,
                        ingredient.Cost,
                        ingredient.Description,
                        ingredient.Manager ?? "None"
                    );
                }

                if (dataGridIngre.InvokeRequired)
                {
                    dataGridIngre.Invoke(new Action(() =>
                    {
                        dataGridIngre.Refresh();
                        dataGridIngre.Invalidate();
                        dataGridIngre.Update();
                    }));
                }
                else
                {
                    dataGridIngre.Refresh();
                    dataGridIngre.Invalidate();
                    dataGridIngre.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngredientListForm_Load(object sender, EventArgs e)
        {
            // Logic moved to Shown event
        }

        private void IngredientListForm_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadManagersIntoComboBox();
                LoadIngredientData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridIngre_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridIngre.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridIngre.SelectedRows[0];
                string ingredientId = selectedRow.Cells["Id"].Value?.ToString();

                if (!string.IsNullOrEmpty(ingredientId) && int.TryParse(ingredientId, out int id))
                {
                    _selectedIngredient = _context.Ingredients.FirstOrDefault(i => i.Id == id);

                    if (_selectedIngredient != null)
                    {
                        txtname.Text = _selectedIngredient.Name ?? "Name";
                        txtname.ForeColor = System.Drawing.Color.Black;
                        txtUnit.Text = _selectedIngredient.Unit ?? "Unit";
                        txtUnit.ForeColor = System.Drawing.Color.Black;
                        txtCost.Text = _selectedIngredient.Cost?.ToString() ?? "Cost";
                        txtCost.ForeColor = System.Drawing.Color.Black;
                        txtDescription.Text = _selectedIngredient.Description ?? "Description";
                        txtDescription.ForeColor = System.Drawing.Color.Black;
                        cboManager.SelectedItem = _selectedIngredient.Manager ?? "None";
                    }
                    else
                    {
                        MessageBox.Show("Selected ingredient not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearForm();
                    }
                }
                else
                {
                    ClearForm();
                }
            }
            else
            {
                ClearForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadIngredientData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var newIngredient = new Ingredient
                {
                    Name = txtname.Text.Trim(),
                    Unit = txtUnit.Text.Trim(),
                    Cost = int.Parse(txtCost.Text.Trim()),
                    Description = txtDescription.Text.Trim(),
                    Manager = cboManager.SelectedItem?.ToString() == "None" ? null : cboManager.SelectedItem?.ToString()
                };

                _context.Ingredients.Add(newIngredient);
                _context.SaveChanges();

                MessageBox.Show("Ingredient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredientData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIngredient == null)
                {
                    MessageBox.Show("Please select an ingredient to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                _selectedIngredient.Name = txtname.Text.Trim();
                _selectedIngredient.Unit = txtUnit.Text.Trim();
                _selectedIngredient.Cost = int.Parse(txtCost.Text.Trim());
                _selectedIngredient.Description = txtDescription.Text.Trim();
                _selectedIngredient.Manager = cboManager.SelectedItem?.ToString() == "None" ? null : cboManager.SelectedItem?.ToString();

                _context.SaveChanges();

                MessageBox.Show("Ingredient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredientData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIngredient == null)
                {
                    MessageBox.Show("Please select an ingredient to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this ingredient? This will also delete related records.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                // Xóa các bản ghi liên quan trong FoodNeedIngres
                var foodNeedIngres = _context.FoodNeedIngres
                    .Where(fni => fni.IngredientId == _selectedIngredient.Id)
                    .ToList();
                if (foodNeedIngres.Any())
                {
                    _context.FoodNeedIngres.RemoveRange(foodNeedIngres);
                }

                // Xóa các bản ghi liên quan trong Supplies
                var supplies = _context.Supplies
                    .Where(s => s.IngredientId == _selectedIngredient.Id)
                    .ToList();
                if (supplies.Any())
                {
                    _context.Supplies.RemoveRange(supplies);
                }

                // Xóa nguyên liệu
                _context.Ingredients.Remove(_selectedIngredient);
                _context.SaveChanges();

                MessageBox.Show("Ingredient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredientData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || txtname.Text == "Name")
            {
                MessageBox.Show("Please enter an ingredient name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text) || txtUnit.Text == "Unit")
            {
                MessageBox.Show("Please enter a unit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text) || txtCost.Text == "Cost" || !int.TryParse(txtCost.Text, out int cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid cost (non-negative number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text) || txtDescription.Text == "Description")
            {
                MessageBox.Show("Please enter a description!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtname.Text = "Name";
            txtname.ForeColor = System.Drawing.Color.Gray;
            txtUnit.Text = "Unit";
            txtUnit.ForeColor = System.Drawing.Color.Gray;
            txtCost.Text = "Cost";
            txtCost.ForeColor = System.Drawing.Color.Gray;
            txtDescription.Text = "Description";
            txtDescription.ForeColor = System.Drawing.Color.Gray;
            if (cboManager.Items.Count > 0)
            {
                cboManager.SelectedIndex = 0;
            }
            else
            {
                cboManager.SelectedIndex = -1;
            }
            _selectedIngredient = null;
            dataGridIngre.ClearSelection();
        }

        private void artanButton2_Click(object sender, EventArgs e)
        {
            // Có thể thêm logic để hiển thị thông tin nhà cung cấp (Provider) nếu cần
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}