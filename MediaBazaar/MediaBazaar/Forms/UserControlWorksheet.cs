using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DTOLayer;
using MediaBazaar;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
    public partial class UserControlWorksheet : UserControl
    {
        private EmployeeWorksheetManager employeeWorksheetManager;
        private DataTable worksheetData;
        public UserControlWorksheet()
        {
            employeeWorksheetManager = new EmployeeWorksheetManager();
            InitializeComponent();
            InitializeFocus();
            InitializeGridViewWorksheet();
            Load += YourFormName_Load;

        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        private void InitializeGridViewWorksheet()
        {
            dataGridViewWorksheet.AutoGenerateColumns = false;
            //dataGridViewWorksheet.DataSource = worksheetData;
            dataGridViewWorksheet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWorksheet.EnableHeadersVisualStyles = false;
            dataGridViewWorksheet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Material blue
            dataGridViewWorksheet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // White text
            dataGridViewWorksheet.DefaultCellStyle.BackColor = Color.White; // White background
            dataGridViewWorksheet.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33); // Dark text
            dataGridViewWorksheet.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200); // Light gray
            dataGridViewWorksheet.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            dataGridViewWorksheet.RowHeadersVisible = false;
            dataGridViewWorksheet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWorksheet.Font = new Font("Segoe UI", 10);

            // Apply subtle animations
            dataGridViewWorksheet.EnableHeadersVisualStyles = false;
            dataGridViewWorksheet.BorderStyle = BorderStyle.None;
            dataGridViewWorksheet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewWorksheet.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235); // Light gray
            dataGridViewWorksheet.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            dataGridViewWorksheet.BackgroundColor = Color.White; // White background


            // Apply hover effect
            dataGridViewWorksheet.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewWorksheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light gray
                }
            };

            dataGridViewWorksheet.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewWorksheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Reset to white
                }
            };

            dataGridViewWorksheet.SelectionChanged += dataGridViewWorksheet_SelectionChanged;
            dataGridViewWorksheet.ScrollBars = ScrollBars.Vertical;
        }

        private void dataGridViewWorksheet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewWorksheet.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void YourFormName_Load(object sender, EventArgs e)
        {
            dataGridViewWorksheet.ClearSelection();
            groupBox1.Visible = false;
        }

        private void btnAddWorksheet_Click(object sender, EventArgs e)
        {
            AddWorksheetDialogue addWorksheetDialogue = new AddWorksheetDialogue();
            addWorksheetDialogue.ShowDialog();
            PopulateWorksheetDataTable(worksheetData);
            dataGridViewWorksheet.DataSource = worksheetData;
            dataGridViewWorksheet.ClearSelection();
        }

        private void PopulateWorksheetDataTable(DataTable worksheetData)
        {
            worksheetData.Clear();
            EmployeeWorksheetManager employeeWorksheetManager = new EmployeeWorksheetManager();
            employeeWorksheetManager.GetAllWorksheetsInDB();

            foreach (EmployeeWorksheet worksheet in employeeWorksheetManager.assignedWorksheets)
            {
                worksheetData.Rows.Add(worksheet.id, worksheet.timeSlot, worksheet.weekDay, worksheet.employee.EmployeeID, worksheet.weekNr);
            }
        }

        private string placeholder = "Search...";

        private void textBoxSearch_GotFocus(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == placeholder)
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = placeholder;
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string selectedRole = comboBoxRoleWorksheet.SelectedItem?.ToString();

            var query = worksheetData.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "Any Role")
            {
                query = query.Where(row => row.Field<string>("Role") == selectedRole);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(row =>
                    row.Field<string>("Employee").Contains(searchTerm) ||
                    row.Field<string>("Weekday").Contains(searchTerm));
            }

            DataTable searchResults = query.Any() ? query.CopyToDataTable() : worksheetData.Clone();
            dataGridViewWorksheet.DataSource = searchResults;

            dataGridViewWorksheet.ClearSelection();
        }
    }
}
