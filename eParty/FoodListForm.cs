using System;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class FoodListForm : Form
    {
        private ePartyDbDbContext _context;
        private Food _selectedFood;

        public FoodListForm()
        {
            InitializeComponent();
            _context = new ePartyDbDbContext();
            ConfigureDataGridView();
            AttachEventHandlers();
        }

        private void FoodListForm_Load(object sender, EventArgs e)
        {
            LoadFoodData();
            ClearForm();
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
            dataGridFood.Columns.Insert(0, idColumn); // Thêm cột Id vào đầu

            dataGridFood.Columns["Order"].HeaderText = "Name";
            dataGridFood.Columns["Amount"].HeaderText = "Amount";
            dataGridFood.Columns["Unit"].HeaderText = "Unit";
            dataGridFood.Columns["Cost"].HeaderText = "Cost";
            dataGridFood.Columns["Description"].HeaderText = "Description";
            //dataGridFood.Columns["Image"].HeaderText = "Image";
            //dataGridFood.Columns["Manager"].HeaderText = "Manager";
           // dataGridFood.Columns["Ingredients"].HeaderText = "Ingredients";

            dataGridFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFood.RowTemplate.Height = 30;
            dataGridFood.AllowUserToResizeRows = false;
        }

        private void AttachEventHandlers()
        {
            // Gắn sự kiện cho các nút và ô tìm kiếm
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnAdd.Click += btnAdd_Click;
            btnModify.Click += btnModify_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridFood.SelectionChanged += DataGridFood_SelectionChanged;

            // Xử lý placeholder cho txtSearch
            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == "Search by food name...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search by food name...";
                    txtSearch.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // Xử lý placeholder cho các trường nhập liệu
            txtFoodName.Enter += (s, e) => ClearPlaceholder(txtFoodName, "Food Name");
            txtFoodName.Leave += (s, e) => SetPlaceholder(txtFoodName, "Food Name");
            txtNote.Enter += (s, e) => ClearPlaceholder(txtNote, "Notes");
            txtNote.Leave += (s, e) => SetPlaceholder(txtNote, "Notes");
            txtStock.Enter += (s, e) => ClearPlaceholder(txtStock, "Stock");
            txtStock.Leave += (s, e) => SetPlaceholder(txtStock, "Stock");
            txtMeasure.Enter += (s, e) => ClearPlaceholder(txtMeasure, "Measurement");
            txtMeasure.Leave += (s, e) => SetPlaceholder(txtMeasure, "Measurement");
            txtExpen.Enter += (s, e) => ClearPlaceholder(txtExpen, "Expense");
            txtExpen.Leave += (s, e) => SetPlaceholder(txtExpen, "Expense");
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

        private void LoadFoodData(string searchText = "")
        {
            try
            {
                dataGridFood.Rows.Clear();

                var foodQuery = _context.Foods.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Search by food name...")
                {
                    foodQuery = foodQuery.Where(f => f.Name.Contains(searchText));
                }

                var foodList = foodQuery
                    .Select(f => new
                    {
                        f.Id,
                        f.Name,
                        f.Amount,
                        f.Unit,
                        f.Cost,
                        f.Description,
                       // f.Image,
                       // f.Manager,
                       // f.Ingredients
                    })
                    .ToList();

                foreach (var food in foodList)
                {
                    dataGridFood.Rows.Add(
                        food.Id, // Lưu Id vào cột ẩn
                        food.Name,
                        food.Amount,
                        food.Unit,
                        food.Cost,
                        food.Description
                        //food.Image ?? "N/A",
                       // food.Manager ?? "None",
                        //"View"
                    );
                }

                dataGridFood.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading food data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridFood.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridFood.SelectedRows[0];
                string foodId = selectedRow.Cells["Id"].Value?.ToString();

                if (!string.IsNullOrEmpty(foodId) && int.TryParse(foodId, out int id))
                {
                    _selectedFood = _context.Foods.FirstOrDefault(f => f.Id == id);

                    if (_selectedFood != null)
                    {
                        txtFoodName.Text = _selectedFood.Name ?? "Food Name";
                        txtFoodName.ForeColor = System.Drawing.Color.Black;
                        txtNote.Text = _selectedFood.Description ?? "Notes";
                        txtNote.ForeColor = System.Drawing.Color.Black;
                        txtStock.Text = _selectedFood.Amount?.ToString() ?? "Stock";
                        txtStock.ForeColor = System.Drawing.Color.Black;
                        txtMeasure.Text = _selectedFood.Unit ?? "Measurement";
                        txtMeasure.ForeColor = System.Drawing.Color.Black;
                        txtExpen.Text = _selectedFood.Cost?.ToString() ?? "Expense";
                        txtExpen.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Selected food not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadFoodData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var newFood = new Food
                {
                    Name = txtFoodName.Text.Trim(),
                    Description = txtNote.Text.Trim(),
                    Amount = int.Parse(txtStock.Text.Trim()),
                    Unit = txtMeasure.Text.Trim(),
                    Cost = int.Parse(txtExpen.Text.Trim()),
                  // Image = null,
                  //  Manager = null,
                   // Ingredients = null
                };

                _context.Foods.Add(newFood);
                _context.SaveChanges();

                MessageBox.Show("Food added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoodData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding food: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFood == null)
                {
                    MessageBox.Show("Please select a food to modify!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                _selectedFood.Name = txtFoodName.Text.Trim();
                _selectedFood.Description = txtNote.Text.Trim();
                _selectedFood.Amount = int.Parse(txtStock.Text.Trim());
                _selectedFood.Unit = txtMeasure.Text.Trim();
                _selectedFood.Cost = int.Parse(txtExpen.Text.Trim());

                _context.SaveChanges();

                MessageBox.Show("Food modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoodData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error modifying food: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFood == null)
                {
                    MessageBox.Show("Please select a food to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this food? This will also delete related records.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                var orderHaveFoods = _context.OrderHaveFoods
                    .Where(ohf => ohf.FoodId == _selectedFood.Id)
                    .ToList();
                if (orderHaveFoods.Any())
                {
                    _context.OrderHaveFoods.RemoveRange(orderHaveFoods);
                }

                var staticFoods = _context.StaticFoods
                    .Where(sf => sf.FoodId == _selectedFood.Id)
                    .ToList();
                if (staticFoods.Any())
                {
                    _context.StaticFoods.RemoveRange(staticFoods);
                }

                _context.Foods.Remove(_selectedFood);
                _context.SaveChanges();

                MessageBox.Show("Food deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoodData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting food: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text) || txtFoodName.Text == "Food Name")
            {
                MessageBox.Show("Please enter a food name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNote.Text) || txtNote.Text == "Notes")
            {
                MessageBox.Show("Please enter notes/description!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStock.Text) || txtStock.Text == "Stock" || !int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock amount (non-negative number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMeasure.Text) || txtMeasure.Text == "Measurement")
            {
                MessageBox.Show("Please enter a measurement unit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExpen.Text) || txtExpen.Text == "Expense" || !int.TryParse(txtExpen.Text, out int cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid expense (non-negative number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtFoodName.Text = "Food Name";
            txtFoodName.ForeColor = System.Drawing.Color.Gray;
            txtNote.Text = "Notes";
            txtNote.ForeColor = System.Drawing.Color.Gray;
            txtStock.Text = "Stock";
            txtStock.ForeColor = System.Drawing.Color.Gray;
            txtMeasure.Text = "Measurement";
            txtMeasure.ForeColor = System.Drawing.Color.Gray;
            txtExpen.Text = "Expense";
            txtExpen.ForeColor = System.Drawing.Color.Gray;
            _selectedFood = null;
            dataGridFood.ClearSelection();
        }

        private void artanPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Có thể thêm logic vẽ tùy chỉnh nếu cần
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            // Có thể thêm logic khi nhấp vào nhãn "Food Information" nếu cần
        }
    }
}