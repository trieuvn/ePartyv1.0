using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace eParty
{
    public partial class FormPrint : Form
    {
        private string reportTitle;
        private object reportDataSource;
        private DataTable dataTable;
        private string username;

        public FormPrint(string reportTitle, object reportDataSource, string username)
        {
            this.reportTitle = reportTitle;
            this.reportDataSource = reportDataSource;
            this.username = username;
            InitializeComponent();
            LoadData();
        }

        private ArtanPanel panelContainer;
        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dataGridView;
        private ArtanButton btnExport;
        private ArtanButton btnPrint;
        private ArtanButton btnBack; // Thêm nút Back để quay lại ReportForm

        private void InitializeComponent()
        {
            this.Text = "Print Report";
            // Đặt form để hiển thị bên trong MenuForm
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Panel chính
            panelContainer = new ArtanPanel
            {
                Location = new Point(0, 0),
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height),
                GradientTopColor = Color.FromArgb(135, 206, 250),
                GradientBottomColor = Color.FromArgb(70, 130, 180),
                BorderRadius = 30,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panelContainer);

            // Tiêu đề báo cáo
            lblTitle = new Label
            {
                Text = reportTitle,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 20)
            };
            panelContainer.Controls.Add(lblTitle);

            // Thông tin phụ (ngày, người tạo)
            lblSubtitle = new Label
            {
                Text = $"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm} | By: {username}",
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 50)
            };
            panelContainer.Controls.Add(lblSubtitle);

            // DataGridView để hiển thị dữ liệu
            dataGridView = new DataGridView
            {
                Location = new Point(20, 80),
                Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 160),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 10),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                RowHeadersVisible = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            panelContainer.Controls.Add(dataGridView);

            // Nút Export to Excel
            btnExport = new ArtanButton
            {
                Text = "Export to Excel",
                Location = new Point(20, this.ClientSize.Height - 60),
                Size = new Size(150, 40),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                BorderRadius = 20,
                Font = new Font("Segoe UI", 12),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnExport.Click += BtnExport_Click;
            panelContainer.Controls.Add(btnExport);

            // Nút Print
            btnPrint = new ArtanButton
            {
                Text = "Print",
                Location = new Point(180, this.ClientSize.Height - 60),
                Size = new Size(150, 40),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White,
                BorderRadius = 20,
                Font = new Font("Segoe UI", 12),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnPrint.Click += BtnPrint_Click;
            panelContainer.Controls.Add(btnPrint);

            // Nút Back
            btnBack = new ArtanButton
            {
                Text = "Back",
                Location = new Point(340, this.ClientSize.Height - 60),
                Size = new Size(150, 40),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                BorderRadius = 20,
                Font = new Font("Segoe UI", 12),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnBack.Click += BtnBack_Click;
            panelContainer.Controls.Add(btnBack);

            // Xử lý sự kiện thay đổi kích thước form
            this.Resize += (s, e) =>
            {
                panelContainer.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
                dataGridView.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 160);
                btnExport.Location = new Point(20, this.ClientSize.Height - 60);
                btnPrint.Location = new Point(180, this.ClientSize.Height - 60);
                btnBack.Location = new Point(340, this.ClientSize.Height - 60);
            };
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Quay lại ReportForm
            var menuForm = this.ParentForm as MenuForm;
            if (menuForm != null)
            {
                menuForm.OpenForm(new ReportForm(menuForm, username));
            }
        }

        private void LoadData()
        {
            try
            {
                dataTable = ConvertToDataTable(reportDataSource);
                dataGridView.DataSource = dataTable;

                // Định dạng các cột số tiền (nếu có)
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name.Contains("Cost") || column.Name.Contains("Profit") || column.Name.Contains("Revenue") || column.Name.Contains("Earnings"))
                    {
                        column.DefaultCellStyle.Format = "#,##0 VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void ExportToExcel()
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string excelPath = $"{reportTitle.Replace(" ", "_")}_{timestamp}.xlsx";

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Report");

                    // Tiêu đề báo cáo
                    worksheet.Cell(1, 1).Value = reportTitle;
                    worksheet.Range(1, 1, 1, dataTable.Columns.Count).Merge();
                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Thông tin phụ
                    worksheet.Cell(2, 1).Value = $"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm} | By: {username}";
                    worksheet.Range(2, 1, 2, dataTable.Columns.Count).Merge();
                    worksheet.Cell(2, 1).Style.Font.Italic = true;
                    worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Tiêu đề cột
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cell(4, i + 1).Value = dataTable.Columns[i].ColumnName;
                        worksheet.Cell(4, i + 1).Style.Font.Bold = true;
                        worksheet.Cell(4, i + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                    }

                    // Dữ liệu
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 5, j + 1).Value = dataTable.Rows[i][j].ToString();
                        }
                    }

                    // Định dạng số tiền (nếu có cột Cost, Revenue, Profit, Earnings)
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        if (column.ColumnName.Contains("Cost") || column.ColumnName.Contains("Profit") || column.ColumnName.Contains("Revenue") || column.ColumnName.Contains("Earnings"))
                        {
                            var columnIndex = column.Ordinal + 1;
                            worksheet.Column(columnIndex).Style.NumberFormat.Format = "#,##0 VND";
                        }
                    }

                    // Điều chỉnh độ rộng cột
                    worksheet.Columns().AdjustToContents();

                    // Thêm viền cho bảng
                    worksheet.Range(4, 1, dataTable.Rows.Count + 4, dataTable.Columns.Count).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    worksheet.Range(4, 1, dataTable.Rows.Count + 4, dataTable.Columns.Count).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    workbook.SaveAs(excelPath);
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(excelPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReport()
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Implement printing logic here (requires PrintDocument and custom drawing)
                MessageBox.Show("Printing functionality not fully implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static DataTable ConvertToDataTable(object dataSource)
        {
            DataTable dataTable = new DataTable("Data");

            if (dataSource is System.Collections.IEnumerable list)
            {
                var firstItem = list.Cast<object>().FirstOrDefault();
                if (firstItem != null)
                {
                    var properties = firstItem.GetType().GetProperties();
                    foreach (var prop in properties)
                    {
                        dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                    }

                    foreach (var item in list)
                    {
                        var row = dataTable.NewRow();
                        foreach (var prop in properties)
                        {
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(row);
                    }
                }
            }

            if (dataTable.Rows.Count == 0)
            {
                throw new InvalidOperationException("Data source is empty.");
            }

            return dataTable;
        }
    }
}