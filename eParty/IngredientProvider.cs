using System;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class IngredientProvider : Form
    {
        private ePartyDbDbContext _context;
        private Provider _selectedProvider;
        private Supply _selectedSupply;
        private MenuForm _menuForm;
        private IngredientListForm _ingredientListForm;
        public string username;

        public IngredientProvider(MenuForm menu, IngredientListForm ingredientListForm, string username)
        {
            this.username = username;
            InitializeComponent();
            _menuForm = menu;
            _ingredientListForm = ingredientListForm;
            _context = new ePartyDbDbContext();
            ConfigureDataGridView();
            AttachEventHandlers();
            LoadIngredientsIntoComboBox();
            LoadProviderData();
            ClearForm();
        }

        private void ConfigureDataGridView()
        {
            // Add hidden column for ProviderId
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                Visible = false
            };
            dataGridProvider.Columns.Insert(0, idColumn);

            // Add hidden column for IngredientId
            DataGridViewTextBoxColumn ingredientIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "IngredientId",
                HeaderText = "IngredientId",
                Visible = false
            };
            dataGridProvider.Columns.Insert(1, ingredientIdColumn);

            dataGridProvider.Columns["Order"].HeaderText = "Name";
            dataGridProvider.Columns["Location"].HeaderText = "Location";
            dataGridProvider.Columns["PhoneNumber"].HeaderText = "Phone";
            dataGridProvider.Columns["Ingredient"].HeaderText = "Ingredient";
            dataGridProvider.Columns["Cost"].HeaderText = "Cost";

            dataGridProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProvider.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridProvider.RowTemplate.Height = 30;
            dataGridProvider.AllowUserToResizeRows = false;
        }

        private void AttachEventHandlers()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridProvider.SelectionChanged += DataGridProvider_SelectionChanged;

            // Placeholder handling for textboxes
            txtFullname.Enter += (s, e) => ClearPlaceholder(txtFullname, "Full name");
            txtFullname.Leave += (s, e) => SetPlaceholder(txtFullname, "Full name");
            txtLocation.Enter += (s, e) => ClearPlaceholder(txtLocation, "Location");
            txtLocation.Leave += (s, e) => SetPlaceholder(txtLocation, "Location");
            txtPhoneNumber.Enter += (s, e) => ClearPlaceholder(txtPhoneNumber, "Phone number");
            txtPhoneNumber.Leave += (s, e) => SetPlaceholder(txtPhoneNumber, "Phone number");
            txtCost.Enter += (s, e) => ClearPlaceholder(txtCost, "Cost");
            txtCost.Leave += (s, e) => SetPlaceholder(txtCost, "Cost");
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

        private void LoadIngredientsIntoComboBox()
        {
            txtIngredient.Items.Clear();
            try
            {
                var ingredients = _context.Ingredients
                                    .Where(i => i.Manager == username) 
                                    .Select(i => i.Name)              
                                    .ToList();
                if (!ingredients.Any())
                {
                    MessageBox.Show("No ingredients found in the database. Please add an ingredient first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtIngredient.Items.AddRange(ingredients.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtIngredient.Items.Count > 0)
            {
                txtIngredient.SelectedIndex = 0;
            }
            else
            {
                txtIngredient.SelectedIndex = -1;
            }
        }

        private void LoadProviderData()
        {
            try
            {
                dataGridProvider.Rows.Clear();

                var providerList = _context.Providers
                    .GroupJoin(_context.Supplies,
                        p => p.Id,
                        s => s.ProviderId,
                        (p, supplies) => new { Provider = p, Supplies = supplies })
                    .SelectMany(ps => ps.Supplies, // Remove DefaultIfEmpty to exclude providers with no supplies
                        (p, s) => new { Provider = p.Provider, Supply = s })
                    .GroupJoin(_context.Ingredients,
                        ps => ps.Supply.IngredientId,
                        i => i.Id,
                        (ps, ingredients) => new { ps.Provider, ps.Supply, Ingredients = ingredients })
                    .SelectMany(ps => ps.Ingredients,
                        (ps, i) => new
                        {
                            ProviderId = ps.Provider.Id,
                            IngredientId = ps.Supply.IngredientId,
                            Name = ps.Provider.Name,
                            Location = ps.Provider.Location,
                            PhoneNumber = ps.Provider.PhoneNumber,
                            Ingredient = i.Name,
                            Cost = ps.Supply.Cost,
                            Manager = i.Manager
                        })
                    .ToList().Where(f => f.Manager == username);

                if (!providerList.Any())
                {
                    MessageBox.Show("No providers with supply records found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                foreach (var provider in providerList)
                {
                    dataGridProvider.Rows.Add(
                        provider.ProviderId,
                        provider.IngredientId,
                        provider.Name,
                        provider.Location,
                        provider.PhoneNumber,
                        provider.Ingredient,
                        provider.Cost
                    );
                }

                dataGridProvider.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading provider data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridProvider_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridProvider.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProvider.SelectedRows[0];
                string providerId = selectedRow.Cells["Id"].Value?.ToString();
                string ingredientId = selectedRow.Cells["IngredientId"].Value?.ToString();

                if (!string.IsNullOrEmpty(providerId) && int.TryParse(providerId, out int pId) &&
                    !string.IsNullOrEmpty(ingredientId) && int.TryParse(ingredientId, out int iId))
                {
                    _selectedProvider = _context.Providers.FirstOrDefault(p => p.Id == pId);
                    _selectedSupply = _context.Supplies.FirstOrDefault(s => s.ProviderId == pId && s.IngredientId == iId);

                    if (_selectedProvider != null && _selectedSupply != null)
                    {
                        var ingredient = _context.Ingredients.FirstOrDefault(i => i.Id == _selectedSupply.IngredientId);

                        txtFullname.Text = _selectedProvider.Name ?? "Full name";
                        txtFullname.ForeColor = System.Drawing.Color.Black;
                        txtLocation.Text = _selectedProvider.Location ?? "Location";
                        txtLocation.ForeColor = System.Drawing.Color.Black;
                        txtPhoneNumber.Text = _selectedProvider.PhoneNumber ?? "Phone number";
                        txtPhoneNumber.ForeColor = System.Drawing.Color.Black;

                        if (ingredient != null && txtIngredient.Items.Contains(ingredient.Name))
                        {
                            txtIngredient.SelectedItem = ingredient.Name;
                        }
                        else
                        {
                            txtIngredient.SelectedIndex = -1;
                        }

                        txtCost.Text = _selectedSupply.Cost.ToString();
                        txtCost.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Selected provider or supply not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                string phoneNumber = txtPhoneNumber.Text.Trim();
                string providerName = txtFullname.Text.Trim();

                // Check if a provider with the same Name and PhoneNumber already exists
                var existingProvider = _context.Providers
                    .FirstOrDefault(p => p.Name == providerName && p.PhoneNumber == phoneNumber);

                Provider providerToUse;
                if (existingProvider != null)
                {
                    // Reuse the existing provider
                    providerToUse = existingProvider;
                }
                else
                {
                    // Create a new provider
                    providerToUse = new Provider
                    {
                        Name = providerName,
                        Location = txtLocation.Text.Trim(),
                        PhoneNumber = phoneNumber
                    };
                    _context.Providers.Add(providerToUse);
                    _context.SaveChanges();
                }

                string selectedIngredientName = txtIngredient.SelectedItem != null ? txtIngredient.SelectedItem.ToString() : null;
                if (string.IsNullOrEmpty(selectedIngredientName))
                {
                    MessageBox.Show("Please select a valid ingredient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ingredient = _context.Ingredients.FirstOrDefault(i => i.Name == selectedIngredientName);
                if (ingredient == null)
                {
                    MessageBox.Show("Selected ingredient not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the provider already supplies this ingredient
                var existingSupply = _context.Supplies
                    .FirstOrDefault(s => s.ProviderId == providerToUse.Id && s.IngredientId == ingredient.Id);

                if (existingSupply != null)
                {
                    MessageBox.Show("This provider already supplies this ingredient. Please update the existing record instead.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSupply = new Supply
                {
                    ProviderId = providerToUse.Id,
                    IngredientId = ingredient.Id,
                    Cost = int.Parse(txtCost.Text.Trim())
                };

                _context.Supplies.Add(newSupply);
                _context.SaveChanges();

                MessageBox.Show("Provider and supply added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProviderData();
                ClearForm();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : dbEx.Message;
                MessageBox.Show($"Error adding provider: {innerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding provider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedProvider == null)
                {
                    MessageBox.Show("Please select a provider to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_selectedSupply == null)
                {
                    MessageBox.Show("No supply record associated with this provider. Please add a supply record first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                string phoneNumber = txtPhoneNumber.Text.Trim();
                // Check for duplicate phone number, excluding the current provider
                if (_context.Providers.Any(p => p.PhoneNumber == phoneNumber && p.Id != _selectedProvider.Id))
                {
                    MessageBox.Show("A provider with this phone number already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _selectedProvider.Name = txtFullname.Text.Trim();
                _selectedProvider.Location = txtLocation.Text.Trim();
                _selectedProvider.PhoneNumber = phoneNumber;

                string selectedIngredientName = txtIngredient.SelectedItem != null ? txtIngredient.SelectedItem.ToString() : null;
                if (string.IsNullOrEmpty(selectedIngredientName))
                {
                    MessageBox.Show("Please select a valid ingredient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ingredient = _context.Ingredients.FirstOrDefault(i => i.Name == selectedIngredientName);
                if (ingredient == null)
                {
                    MessageBox.Show("Selected ingredient not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the updated ingredient already exists for this provider (excluding the current supply record)
                var existingSupply = _context.Supplies
                    .FirstOrDefault(s => s.ProviderId == _selectedProvider.Id && s.IngredientId == ingredient.Id);

                if (existingSupply != null &&
                    !(existingSupply.ProviderId == _selectedSupply.ProviderId && existingSupply.IngredientId == _selectedSupply.IngredientId))
                {
                    MessageBox.Show("This provider already supplies this ingredient in another record. Please delete the existing record and add a new one.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If the ingredient has changed, inform the user to delete and add a new record
                if (_selectedSupply.IngredientId != ingredient.Id)
                {
                    MessageBox.Show("Cannot update the ingredient of a supply record. Please delete the existing record and add a new one.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the provider and supply (only if the ingredient hasn't changed)
                _selectedSupply.Cost = int.Parse(txtCost.Text.Trim());

                _context.SaveChanges();

                MessageBox.Show($"Provider '{_selectedProvider.Name}' and supply for ingredient '{selectedIngredientName}' updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProviderData();
                ClearForm();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : dbEx.Message;
                MessageBox.Show($"Error updating provider: {innerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating provider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedProvider == null || _selectedSupply == null)
                {
                    MessageBox.Show("Please select a provider and ingredient to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Are you sure you want to delete the supply of ingredient '{txtIngredient.SelectedItem}' for provider '{_selectedProvider.Name}' (ID: {_selectedProvider.Id})?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                // Delete the specific Supply record
                _context.Supplies.Remove(_selectedSupply);
                _context.SaveChanges();

                // Check if the Provider has any remaining Supply records
                var remainingSupplies = _context.Supplies.Any(s => s.ProviderId == _selectedProvider.Id);
                if (!remainingSupplies)
                {
                    // If no remaining Supply records, delete the Provider
                    _context.Providers.Remove(_selectedProvider);
                    _context.SaveChanges();
                    MessageBox.Show($"Supply record deleted, and provider with ID {_selectedProvider.Id} was also deleted as it had no remaining supplies.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Supply record for ingredient '{txtIngredient.SelectedItem}' deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadProviderData();
                ClearForm();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : dbEx.Message;
                MessageBox.Show($"Error deleting supply: {innerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting supply: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullname.Text) || txtFullname.Text == "Full name")
            {
                MessageBox.Show("Please enter a full name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text == "Location")
            {
                MessageBox.Show("Please enter a location!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string phoneNumber = txtPhoneNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(phoneNumber) || txtPhoneNumber.Text == "Phone number")
            {
                MessageBox.Show("Please enter a phone number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(phoneNumber.Length == 10 && phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{10}$")) &&
                !(phoneNumber.Length == 9 && !phoneNumber.StartsWith("0") && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[0-9]{9}$")))
            {
                MessageBox.Show("Phone number must be 10 digits starting with 0, or 9 digits not starting with 0!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtIngredient.SelectedItem == null || string.IsNullOrWhiteSpace(txtIngredient.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select an ingredient!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text) || txtCost.Text == "Cost" || !int.TryParse(txtCost.Text, out int cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid cost (non-negative number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtFullname.Text = "Full name";
            txtFullname.ForeColor = System.Drawing.Color.Gray;
            txtLocation.Text = "Location";
            txtLocation.ForeColor = System.Drawing.Color.Gray;
            txtPhoneNumber.Text = "Phone number";
            txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            txtCost.Text = "Cost";
            txtCost.ForeColor = System.Drawing.Color.Gray;
            if (txtIngredient.Items.Count > 0)
            {
                txtIngredient.SelectedIndex = 0;
            }
            else
            {
                txtIngredient.SelectedIndex = -1;
            }
            _selectedProvider = null;
            _selectedSupply = null;
            dataGridProvider.ClearSelection();

            // Reset the context to avoid carrying over changes from previous operations
            _context.ChangeTracker.Clear();
        }

        private void artanButton2_Click(object sender, EventArgs e)
        {
            if (_menuForm != null)
            {
                _menuForm.OpenForm(new IngredientListForm(username, _menuForm));
            }
            else
            {
                MessageBox.Show("MenuForm reference is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for future functionality if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder for panel1 paint event
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder for panel3 paint event
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}