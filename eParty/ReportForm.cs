﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOLayer.Repository;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace eParty
{
    public partial class ReportForm : Form
    {
        private MenuForm _menuForm;
        private ePartyDbDbContext _context;
        public string username;
        private ArtanPanel panelContainer;
        private Label lblTitle;
        private ArtanButton btnOrderReport;
        private ArtanButton btnProfitReport;
        private ArtanButton btnStaffReport;
        private ArtanButton btnFoodReport;
        private ArtanButton btnBack;

        public ReportForm(MenuForm menuForm, string username)
        {
            this.username = username;
            _menuForm = menuForm;
            _context = new ePartyDbDbContext();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Report Form";
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Create a custom header panel for the title
            Panel headerPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(this.ClientSize.Width, 80),
                BackColor = Color.DodgerBlue,
                Dock = DockStyle.Top
            };
            this.Controls.Add(headerPanel);

            panelContainer = new ArtanPanel
            {
                Location = new Point(0, 80),
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 80),
                GradientTopColor = Color.FromArgb(135, 206, 250),
                GradientBottomColor = Color.FromArgb(70, 130, 180),
                BorderRadius = 30,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panelContainer);

            lblTitle = new Label
            {
                Text = "Generate Reports",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(this.ClientSize.Width / 2 - 150, 20),
                Size = new Size(300, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None
            };
            headerPanel.Controls.Add(lblTitle);

            // Create a FlowLayoutPanel to hold the buttons
            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Location = new Point(0, 0), // Will be centered later
                Padding = new Padding(0, 20, 0, 20) // Add some vertical padding between buttons
            };
            panelContainer.Controls.Add(buttonPanel);

            btnOrderReport = new ArtanButton
            {
                Text = "Order Report",
                Size = new Size(200, 50),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                BorderRadius = 25,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            btnOrderReport.Click += BtnOrderReport_Click;
            buttonPanel.Controls.Add(btnOrderReport);

            btnProfitReport = new ArtanButton
            {
                Text = "Profit Report",
                Size = new Size(200, 50),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                BorderRadius = 25,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            btnProfitReport.Click += BtnProfitReport_Click;
            buttonPanel.Controls.Add(btnProfitReport);

            btnStaffReport = new ArtanButton
            {
                Text = "Staff Report",
                Size = new Size(200, 50),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                BorderRadius = 25,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            btnStaffReport.Click += BtnStaffReport_Click;
            buttonPanel.Controls.Add(btnStaffReport);

            btnFoodReport = new ArtanButton
            {
                Text = "Food Report",
                Size = new Size(200, 50),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                BorderRadius = 25,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            btnFoodReport.Click += BtnFoodReport_Click;
            buttonPanel.Controls.Add(btnFoodReport);

            btnBack = new ArtanButton
            {
                Text = "Back to Dashboard",
                Size = new Size(200, 50),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White,
                BorderRadius = 25,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            };
            btnBack.Click += BtnBack_Click;
            buttonPanel.Controls.Add(btnBack);

            // Center the buttonPanel both horizontally and vertically
            this.Resize += (s, e) =>
            {
                headerPanel.Size = new Size(this.ClientSize.Width, 80);
                panelContainer.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 80);
                lblTitle.Location = new Point(this.ClientSize.Width / 2 - 150, 20);

                // Center the buttonPanel
                buttonPanel.Location = new Point(
                    (panelContainer.ClientSize.Width - buttonPanel.Width) / 2, // Center horizontally
                    (panelContainer.ClientSize.Height - buttonPanel.Height) / 2 // Center vertically
                );
            };
        }

        private void BtnOrderReport_Click(object sender, EventArgs e)
        {
            try
            {
                // First, fetch the data without null-conditional operators
                var orderData = _context.Orders
                    .Where(o => o.Manager == username)
                    .GroupJoin(_context.OrderHaveFoods,
                        o => o.Id,
                        ohf => ohf.OrderId,
                        (o, ohfs) => new { Order = o, OrderHaveFoods = ohfs })
                    .SelectMany(x => x.OrderHaveFoods.DefaultIfEmpty(),
                        (o, ohf) => new { o.Order, OrderHaveFood = ohf })
                    .Join(_context.Foods,
                        x => x.OrderHaveFood != null ? x.OrderHaveFood.FoodId : -1,
                        f => f.Id,
                        (x, f) => new
                        {
                            OrderId = x.Order.Id,
                            Description = x.Order.Description ?? "N/A",
                            NoTables = x.Order.NoTables ?? 0,
                            Address = x.Order.Address ?? "N/A",
                            BeginTime = x.Order.BeginTime.HasValue ? x.Order.BeginTime.Value.ToString("dd/MM/yyyy HH:mm") : "N/A",
                            EndTime = x.Order.EndTime.HasValue ? x.Order.EndTime.Value.ToString("dd/MM/yyyy HH:mm") : "N/A",
                            Feedback = x.Order.Feedback ?? "N/A",
                            Manager = x.Order.Manager ?? "N/A",
                            PhoneNumber = x.Order.PhoneNumber ?? "N/A",
                            Status = x.Order.Status.HasValue ? (x.Order.Status.Value ? "Completed" : "Pending") : "Unknown",
                            ActualCost = x.Order.ActualCost ?? 0,
                            FoodId = x.OrderHaveFood != null ? x.OrderHaveFood.FoodId : (int?)null,
                            FoodName = x.OrderHaveFood != null ? f.Name : null,
                            FoodAmount = x.OrderHaveFood != null ? x.OrderHaveFood.Amount : null,
                            FoodCost = x.OrderHaveFood != null ? f.Cost : null
                        })
                    .ToList();

                // Now, transform the data in memory to handle nulls
                var orders = orderData.Select(x => new
                {
                    x.OrderId,
                    x.Description,
                    x.NoTables,
                    x.Address,
                    x.BeginTime,
                    x.EndTime,
                    x.Feedback,
                    x.Manager,
                    x.PhoneNumber,
                    x.Status,
                    x.ActualCost,
                    FoodName = x.FoodName ?? "N/A",
                    FoodAmount = x.FoodAmount ?? 0,
                    FoodCost = x.FoodAmount.HasValue && x.FoodCost.HasValue ? (x.FoodCost.Value * x.FoodAmount.Value) : 0
                })
                .ToList();

                if (!orders.Any())
                {
                    MessageBox.Show("No order data available for the report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị FormPrint bên trong MenuForm
                _menuForm.OpenForm(new FormPrint("Order Report", orders, username));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating order report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProfitReport_Click(object sender, EventArgs e)
        {
            try
            {
                var profitByMonth = _context.OrderHaveFoods
                    .Where(ohf => ohf.Order.Status == true && ohf.Order.BeginTime.HasValue && ohf.Order.Manager == username)
                    .Join(_context.Foods,
                        ohf => ohf.FoodId,
                        f => f.Id,
                        (ohf, f) => new { ohf, f })
                    .Join(_context.FoodNeedIngres,
                        x => x.f.Id,
                        fni => fni.FoodId,
                        (x, fni) => new { x.ohf, x.f, fni })
                    .Join(_context.Ingredients,
                        x => x.fni.IngredientId,
                        i => i.Id,
                        (x, i) => new { x.ohf, x.f, x.fni, i })
                    .GroupBy(x => new { x.ohf.Order.BeginTime.Value.Year, x.ohf.Order.BeginTime.Value.Month })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        Year = g.Key.Year,
                        TotalRevenue = g.Sum(x => x.ohf.Amount * x.f.Cost),
                        TotalIngredientCost = g.Sum(x => x.fni.Amount * x.i.Cost * x.ohf.Amount) ?? 0,
                        OrderCount = g.Select(x => x.ohf.OrderId).Distinct().Count(),
                        NetProfit = g.Sum(x => x.ohf.Amount * x.f.Cost) - (g.Sum(x => x.fni.Amount * x.i.Cost * x.ohf.Amount) ?? 0)
                    })
                    .OrderBy(g => g.Year).ThenBy(g => g.Month)
                    .ToList();

                if (!profitByMonth.Any())
                {
                    MessageBox.Show("No profit data available for the report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị FormPrint bên trong MenuForm
                _menuForm.OpenForm(new FormPrint("Profit Report", profitByMonth, username));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating profit report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnStaffReport_Click(object sender, EventArgs e)
        {
            try
            {
                var staffList = _context.Staff
                    .Where(s => s.Manager == username)
                    .GroupJoin(_context.OrderHaveStaffs,
                        s => s.Id,
                        ohs => ohs.StaffId,
                        (s, ohs) => new { Staff = s, OrderHaveStaffs = ohs })
                    .Select(x => new
                    {
                        FullName = x.Staff.FullName ?? "N/A",
                        Role = x.Staff.Role ?? "N/A",
                        PhoneNumber = x.Staff.PhoneNumber ?? "N/A",
                        Location = x.Staff.Location ?? "N/A",
                        Cost = x.Staff.Cost ?? 0,
                        Manager = x.Staff.Manager ?? "N/A",
                        OrderCount = x.OrderHaveStaffs.Count(),
                        TotalEarnings = x.OrderHaveStaffs.Count() * (x.Staff.Cost ?? 0)
                    })
                    .ToList();

                if (!staffList.Any())
                {
                    MessageBox.Show("No staff data available for the report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị FormPrint bên trong MenuForm
                _menuForm.OpenForm(new FormPrint("Staff Report", staffList, username));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating staff report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFoodReport_Click(object sender, EventArgs e)
        {
            try
            {
                // First, fetch the data without null-conditional operators
                var foodData = _context.Foods
                    .Where(f => f.Manager == username)
                    .GroupJoin(_context.FoodNeedIngres,
                        f => f.Id,
                        fni => fni.FoodId,
                        (f, fnis) => new { Food = f, FoodNeedIngres = fnis })
                    .SelectMany(x => x.FoodNeedIngres.DefaultIfEmpty(),
                        (f, fni) => new { f.Food, FoodNeedIngre = fni })
                    .Join(_context.Ingredients,
                        x => x.FoodNeedIngre != null ? x.FoodNeedIngre.IngredientId : -1,
                        i => i.Id,
                        (x, i) => new
                        {
                            Name = x.Food.Name ?? "N/A",
                            Amount = x.Food.Amount ?? 0,
                            Unit = x.Food.Unit ?? "N/A",
                            Cost = x.Food.Cost ?? 0,
                            Description = x.Food.Description ?? "N/A",
                            Manager = x.Food.Manager ?? "N/A",
                            IngredientId = x.FoodNeedIngre != null ? x.FoodNeedIngre.IngredientId : (int?)null,
                            IngredientName = x.FoodNeedIngre != null ? i.Name : null,
                            IngredientAmount = x.FoodNeedIngre != null ? x.FoodNeedIngre.Amount : null,
                            IngredientUnit = x.FoodNeedIngre != null ? i.Unit : null,
                            IngredientCost = x.FoodNeedIngre != null ? i.Cost : null
                        })
                    .ToList();

                // Now, transform the data in memory to handle nulls
                var foodList = foodData.Select(x => new
                {
                    x.Name,
                    x.Amount,
                    x.Unit,
                    x.Cost,
                    x.Description,
                    x.Manager,
                    IngredientName = x.IngredientName ?? "N/A",
                    IngredientAmount = x.IngredientAmount ?? 0,
                    IngredientUnit = x.IngredientUnit ?? "N/A",
                    IngredientCost = x.IngredientAmount.HasValue && x.IngredientCost.HasValue ? (x.IngredientCost.Value * x.IngredientAmount.Value) : 0
                })
                .ToList();

                if (!foodList.Any())
                {
                    MessageBox.Show("No food data available for the report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị FormPrint bên trong MenuForm
                _menuForm.OpenForm(new FormPrint("Food Report", foodList, username));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating food report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _menuForm.OpenForm(new Dashboard(username));
        }
    }
}