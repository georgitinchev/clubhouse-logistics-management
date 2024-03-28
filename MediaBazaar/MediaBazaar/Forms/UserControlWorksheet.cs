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
using BusinessLogicLayer;
using DTOLayer;


namespace MediaBazaar.Forms
{
    public partial class UserControlWorksheet : UserControl
    {
        private EmployeeWorksheetManager employeeWorksheetManager;
        private EmployeeManager employeeManager;
        private DataTable worksheetData;
        public UserControlWorksheet(EmployeeManager _employeeManager)
        {
            employeeWorksheetManager = new EmployeeWorksheetManager();
            employeeManager = _employeeManager;

            InitializeComponent();
            InitializeGridViewWorksheet();
            InitializeFocus();
            Load += UserControlWorksheet_Load;
            employeeWorksheetGrid.SelectionChanged += DataGridViewWorksheet_SelectionChanged;

            PopulateWorksheetData();
        }

        public void PopulateWorksheetData()
        {

            worksheetData = new DataTable();
            worksheetData.Columns.Add("ID", typeof(int));
            worksheetData.Columns.Add("Role", typeof(string));
            worksheetData.Columns.Add("TimeSlot", typeof(string));
            worksheetData.Columns.Add("Weekday", typeof(string));
            worksheetData.Columns.Add("Employee", typeof(string));
            worksheetData.Columns.Add("Week", typeof(int));
            employeeWorksheetManager.GetAllWorksheetsInDB();
            foreach (EmployeeWorksheet worksheet in employeeWorksheetManager.assignedWorksheets)
            {
                Employee employee = employeeManager.GetEmployeeById(worksheet.employee);

                worksheetData.Rows.Add(worksheet.id, employee.Role.ToString(), worksheet.timeSlot.ToString(), worksheet.weekDay.ToString(), employee.GetFullName(), worksheet.weekNr);
            }
            employeeWorksheetGrid.DataSource = worksheetData;
        }
        private void btnAddWorksheet_Click(object sender, EventArgs e)
        {
            AddWorksheetDialogue addWorksheetDialogue = new AddWorksheetDialogue();
            addWorksheetDialogue.ShowDialog();
            PopulateWorksheetData();
            employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.ClearSelection();
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        private void InitializeGridViewWorksheet()
        {
            employeeWorksheetGrid.AutoGenerateColumns = false;
            //dataGridViewWorksheet.DataSource = worksheetData;
            employeeWorksheetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Material blue
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // White text
            employeeWorksheetGrid.DefaultCellStyle.BackColor = Color.White; // White background
            employeeWorksheetGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33); // Dark text
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200); // Light gray
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            employeeWorksheetGrid.RowHeadersVisible = false;
            employeeWorksheetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeWorksheetGrid.Font = new Font("Segoe UI", 10);

            // Apply subtle animations
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.BorderStyle = BorderStyle.None;
            employeeWorksheetGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235); // Light gray
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            employeeWorksheetGrid.BackgroundColor = Color.White; // White background

            // Add columns
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ID", HeaderText = "Id" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Department" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "TimeSlot", HeaderText = "TimeSlot" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "WeekDay", HeaderText = "WeekDay" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Employee", HeaderText = "Employee" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Week", HeaderText = "Week" });

            // Apply hover effect
            employeeWorksheetGrid.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    employeeWorksheetGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light gray
                }
            };

            employeeWorksheetGrid.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    employeeWorksheetGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Reset to white
                }
            };

            employeeWorksheetGrid.ScrollBars = ScrollBars.Vertical;
            employeeWorksheetGrid.SelectionChanged += dataGridViewWorksheet_SelectionChanged;
        }

        private void UserControlWorksheet_Load(object sender, EventArgs e)
        {
            employeeWorksheetGrid.ClearSelection();
            groupBox1.Visible = false;
            UpdateLayout();
        }

        private void dataGridViewWorksheet_SelectionChanged(object sender, EventArgs e)
        {
            if (employeeWorksheetGrid.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void DataGridViewWorksheet_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }


        private void UpdateLayout()
        {
            bool isEmployeeSelected = employeeWorksheetGrid.SelectedRows.Count > 0;

            if (isEmployeeSelected)
            {
                MoveControlsToLocation(textBoxSearch, new Point(41, 74), new Size(313, 23));
                MoveControlsToLocation(comboBoxRoleWorksheet, new Point(377, 74), new Size(268, 23));
                MoveControlsToLocation(pictureBoxSearch, new Point(333, 74), new Size(21, 23));
            }
            else
            {
                MoveControlsToLocation(textBoxSearch, new Point(855, 114), new Size(313, 23));
                MoveControlsToLocation(comboBoxRoleWorksheet, new Point(855, 152), new Size(313, 23));
                MoveControlsToLocation(pictureBoxSearch, new Point(1147, 114), new Size(21, 23));
            }
        }

        private void MoveControlsToLocation(Control control, Point location, Size size)
        {
            control.Location = location;
            control.Size = size;
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
            employeeWorksheetGrid.DataSource = searchResults;

            employeeWorksheetGrid.ClearSelection();
        }
    }
}
