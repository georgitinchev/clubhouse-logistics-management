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
            InitializeFocus();
            Load += UserControlWorksheet_Load;
            employeeWorksheetGrid.SelectionChanged += DataGridViewWorksheet_SelectionChanged;
            employeeWorksheetGrid.CellClick += employeeWorksheetGrid_CellClick;

            PopulateWorksheetData();
        }

        private void UserControlWorksheet_Load_1(object sender, EventArgs e)
        {
            InitializeGridViewWorksheet();
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

            worksheetData.Clear();
            employeeWorksheetManager.GetAllWorksheetsInDB();
            foreach (EmployeeWorksheet worksheet in employeeWorksheetManager.assignedWorksheets)
            {
                string employeeName = "Unassigned";
                string employeeRole = "Unassigned";
                if (worksheet.employee != 0)
                {
                    Employee employee = employeeManager.GetEmployeeById(worksheet.employee);
                    if (employee != null)
                    {
                        employeeName = employee.GetFullName();
                        employeeRole = employee.Role.ToString();
                    }
                }
                worksheetData.Rows.Add(worksheet.id, employeeRole, worksheet.timeSlot.ToString(), worksheet.weekDay.ToString(), employeeName, worksheet.weekNr);
            }
            employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.ClearSelection();
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
            //employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeWorksheetGrid.AllowUserToAddRows = false;
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            employeeWorksheetGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            employeeWorksheetGrid.DefaultCellStyle.BackColor = Color.White;
            employeeWorksheetGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.RowHeadersVisible = false;
            employeeWorksheetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeWorksheetGrid.Font = new Font("Segoe UI", 10);

            // Apply subtle animations
            employeeWorksheetGrid.EnableHeadersVisualStyles = false;
            employeeWorksheetGrid.BorderStyle = BorderStyle.None;
            employeeWorksheetGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            employeeWorksheetGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            employeeWorksheetGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            employeeWorksheetGrid.BackgroundColor = Color.White;

            // Add columns
            /*employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "ID", HeaderText = "Id" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Department" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "TimeSlot", HeaderText = "TimeSlot" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "WeekDay", HeaderText = "WeekDay" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Employee", HeaderText = "Employee" });
            employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Week", HeaderText = "Week" });*/

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
                //MoveControlsToLocation(comboBoxDepartment, new Point(377, 74), new Size(268, 23));
                MoveControlsToLocation(pictureBoxSearch, new Point(333, 74), new Size(21, 23));
            }
            else
            {
                MoveControlsToLocation(textBoxSearch, new Point(855, 114), new Size(313, 23));
                //MoveControlsToLocation(comboBoxDepartment, new Point(855, 152), new Size(313, 23));
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

        private void employeeWorksheetGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < worksheetData.Rows.Count)
            {
                DataGridViewRow selectedRow = employeeWorksheetGrid.Rows[e.RowIndex];

                textBoxEmployee.Text = selectedRow.Cells["Employee"].Value.ToString();

                comboBoxRole.SelectedItem = selectedRow.Cells["Role"].Value.ToString();

                int weekNumber = Convert.ToInt32(selectedRow.Cells["Week"].Value);
                DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), selectedRow.Cells["WeekDay"].Value.ToString());

                DateTime jan1 = new DateTime(DateTime.Now.Year, 1, 1);
                while (jan1.DayOfWeek != dayOfWeek)
                {
                    jan1 = jan1.AddDays(1);
                }
                DateTime result = jan1.AddDays((weekNumber - 1) * 7);
                dateTimePicker1.Value = result;

                string timeSlot = selectedRow.Cells["TimeSlot"].Value.ToString();
                if (timeSlot == "Morning")
                    cbShift.SelectedItem = "Morning";
                else if (timeSlot == "Afternoon")
                    cbShift.SelectedItem = "Afternoon";
                else if (timeSlot == "Evening")
                    cbShift.SelectedItem = "Evening";
            }
        }

        private void Search()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string selectedRole = comboBoxRole.SelectedItem?.ToString();

            var query = worksheetData.AsEnumerable();

            try
            {
                if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "Any Role")
                {
                    query = query.Where(row => row.Field<string>("Role") == selectedRole);
                }

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(row => row.Field<string>("Role").StartsWith(searchTerm));
                }

                DataTable searchResults = query.Any() ? query.CopyToDataTable() : worksheetData.Clone();
                employeeWorksheetGrid.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                employeeWorksheetGrid.ClearSelection();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem?.ToString() == "All Roles")
            {
                employeeWorksheetGrid.DataSource = worksheetData;
            }
            else
            {
                Search();
            }
        }

        private void textBoxSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAddWorksheet_Click_1(object sender, EventArgs e)
        {
            // make a constructor for the add worksheet dialogue and pass to it the employeemanager and the employeeworksheet manager 
            AddWorksheetDialogue addWorksheetDialogue = new AddWorksheetDialogue(employeeManager, employeeWorksheetManager);
            addWorksheetDialogue.ShowDialog();
            PopulateWorksheetData();
            employeeWorksheetGrid.DataSource = worksheetData;
            employeeWorksheetGrid.ClearSelection();
        }

        private void btnRemoveWorksheet_Click(object sender, EventArgs e)
        {
        }
    }
}
