using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DataAccessLayer;
using DTOLayer;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
    public partial class UserControlDashboard : UserControl
    {
        private DataTable employeeData;
        private EmployeeManager employeeManager;
        private List<(Control control, Color originalBackColor, bool originalReadOnly)> originalControlStates = new List<(Control, Color, bool)>();
        private EmployeeDAL employeeDAL;

        public UserControlDashboard(EmployeeManager _employeeManager)
        {
            employeeManager = _employeeManager;
            InitializeComponent();
            InitializeData();
            InitializeDataGridView();
            InitializeControls();
            InitializeFocus();
            SubscribeToLoadEvent();
            userDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void SubscribeToLoadEvent()
        {
            Load += UserControlDashboard_Load;
            Load += YourFormName_Load;
        }

        private void InitializeControls()
        {
            originalControlStates.Add((textBoxName, textBoxName.BackColor, textBoxName.ReadOnly));
            originalControlStates.Add((comboBoxRoleDetails, comboBoxRoleDetails.BackColor, comboBoxRoleDetails.Enabled)); // Ensure ComboBox is enabled
            originalControlStates.Add((textBoxEmail, textBoxEmail.BackColor, textBoxEmail.ReadOnly));
            originalControlStates.Add((textBoxPassword, textBoxPassword.BackColor, textBoxPassword.ReadOnly));
            originalControlStates.Add((textBoxBSN, textBoxBSN.BackColor, textBoxBSN.ReadOnly));
            originalControlStates.Add((textBoxPhone, textBoxPhone.BackColor, textBoxPhone.ReadOnly));
            originalControlStates.Add((dateTimePickerBirthday, dateTimePickerBirthday.BackColor, dateTimePickerBirthday.Enabled));
        }

        private void PopulateDataTable(DataTable employeeData)
        {
            employeeManager.GetEmployeesFromDB();
            foreach (Employee employee in employeeManager.employees)
            {
                employeeData.Rows.Add(employee.EmployeeID, $"{employee.FirstName} {employee.LastName}", employee.Email, employee.Role.ToString(), employee.Contract.weeklyHours);
            }

        }

        private void InitializeData()
        {
            employeeData = new DataTable();
            employeeData.Columns.Add("EmployeeID", typeof(int));
            employeeData.Columns.Add("Name", typeof(string));
            employeeData.Columns.Add("Email", typeof(string));
            employeeData.Columns.Add("Role", typeof(string));
            employeeData.Columns.Add("WeeklyHours", typeof(int));
            //employeeData.Columns.Add("Password", typeof(string));
            //employeeData.Columns.Add("BSN", typeof(string));
            //employeeData.Columns.Add("EmergencyPhoneNumber", typeof(string));
            //employeeData.Columns.Add("Birthday", typeof(DateTime));
            //employeeData.Columns.Add("EmergencyContact", typeof(string));
            //employeeData.Columns.Add("IsManager", typeof(bool));
            PopulateDataTable(employeeData);
            userDataGridView.DataSource = employeeData;
        }


        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            userDataGridView.ClearSelection();
            groupBox1.Visible = false;
            UpdateLayout();
        }

        private void YourFormName_Load(object sender, EventArgs e)
        {
            userDataGridView.ClearSelection();
            groupBox1.Visible = false;
        }

        private void InitializeDataGridView()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.DataSource = employeeData;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userDataGridView.DefaultCellStyle.BackColor = Color.White;
            userDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Font = new Font("Segoe UI", 10);

            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.BorderStyle = BorderStyle.None;
            userDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            userDataGridView.BackgroundColor = Color.White;

            userDataGridView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            userDataGridView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };

            userDataGridView.SelectionChanged += DataGridView1_SelectionChanged;
            userDataGridView.ScrollBars = ScrollBars.Vertical;
            /*userDataGridView.Columns["Password"].Visible = false;
			userDataGridView.Columns["BSN"].Visible = false;
			userDataGridView.Columns["PhoneNumber"].Visible = false;
			userDataGridView.Columns["Birthday"].Visible = false;
			userDataGridView.Columns["ActiveContract"].Visible = false;
			userDataGridView.Columns["EmergencyContact"].Visible = false;
			userDataGridView.Columns["IsManager"].Visible = false;*/
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            bool isEmployeeSelected = userDataGridView.SelectedRows.Count > 0;

            if (isEmployeeSelected)
            {
                MoveControlsToLocation(textBoxSearch, new Point(41, 74), new Size(313, 23));
                MoveControlsToLocation(comboBoxRole, new Point(377, 74), new Size(268, 23));
                MoveControlsToLocation(addEmployeeBtn, new Point(651, 69), new Size(193, 30));
                MoveControlsToLocation(pictureBoxSearch, new Point(333, 74), new Size(21, 23));
            }
            else
            {
                MoveControlsToLocation(textBoxSearch, new Point(855, 114), new Size(313, 23));
                MoveControlsToLocation(comboBoxRole, new Point(855, 152), new Size(313, 23));
                MoveControlsToLocation(addEmployeeBtn, new Point(855, 189), new Size(313, 30));
                MoveControlsToLocation(pictureBoxSearch, new Point(1147, 114), new Size(21, 23));
            }
        }

        private void MoveControlsToLocation(Control control, Point location, Size size)
        {
            control.Location = location;
            control.Size = size;
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void InitializeFocus()
        {
            textBoxSearch.GotFocus += new System.EventHandler(textBoxSearch_GotFocus);
            textBoxSearch.LostFocus += new System.EventHandler(textBoxSearch_LostFocus);
        }

        private string placeholder = "";

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
            string selectedRole = comboBoxRole.SelectedItem?.ToString();

            var query = employeeData.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "Any Role")
            {
                query = query.Where(row => row.Field<string>("Role") == selectedRole);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(row => row.Field<string>("Name").Contains(searchTerm) || row.Field<string>("Email").Contains(searchTerm));
            }

            DataTable searchResults = query.Any() ? query.CopyToDataTable() : employeeData.Clone();
            userDataGridView.DataSource = searchResults;

            userDataGridView.ClearSelection();
        }


        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeDialogue = new AddEmployeeForm(employeeManager, employeeManager._contractManager);
            addEmployeeDialogue.ShowDialog();
            employeeData.Clear();
            PopulateDataTable(employeeData);
            userDataGridView.DataSource = employeeData;
            userDataGridView.ClearSelection();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (editEmployeeBtn.Text == "Edit Employee")
            {
                foreach (var (control, _, _) in originalControlStates)
                {
                    control.BackColor = Color.White;
                    if (control is TextBox textBox)
                    {
                        textBox.ReadOnly = false;
                        if (textBox == textBoxPassword || textBox == textBoxBSN || textBox == textBoxAddress) // Enable textBoxAddress
                        {
                            textBox.UseSystemPasswordChar = false;
                        }
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Enabled = true;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Enabled = true;
                    }
                }
                editEmployeeBtn.Text = "Save";
            }
            else if (editEmployeeBtn.Text == "Save")
            {
                UpdateEmployeeDetails();
                foreach (var (control, originalBackColor, originalReadOnly) in originalControlStates)
                {
                    control.BackColor = originalBackColor;
                    if (control is TextBox textBox)
                    {
                        textBox.ReadOnly = originalReadOnly;
                        if (textBox == textBoxPassword)
                        {
                            textBox.UseSystemPasswordChar = true;
                        }
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Enabled = false;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Enabled = false;
                    }
                }
                editEmployeeBtn.Text = "Edit Employee";
            }
        }


        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void UpdateEmployeeDetails()
        {
            try
            {
                if (userDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                    int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                    

                    EmployeeDTO employee = new EmployeeDTO(
                        employeeId,
                        textBoxName.Text,
                        textBoxName.Text,
                        textBoxEmail.Text,
                        textBoxPassword.Text,
                        textBoxPhone.Text,
                        textBoxAddress.Text,
                        comboBoxRoleDetails.SelectedIndex,
                        employeeManager.CheckManager((EmployeeRoleEnum)comboBoxRoleDetails.SelectedIndex)


                    );

                    employeeDAL.UpdateEmployee(employee);
                    PopulateDataTable(employeeData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employeeData.Rows.Count)
            {
                DataGridViewRow selectedRow = userDataGridView.Rows[e.RowIndex];
                Employee selectedEmployee = employeeManager.GetEmployeeById(Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value));

                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                comboBoxRoleDetails.Text = selectedRow.Cells["Role"].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                textBoxPassword.Text = selectedEmployee.Password;
                textBoxBSN.Text = selectedEmployee.BSN;
                textBoxPhone.Text = selectedEmployee.PhoneNumber;

                dateTimePickerBirthday.Value = (DateTime)selectedEmployee.Birthday;
                dateTimePickerBirthday.Enabled = false;

                textBoxName.ReadOnly = true;
                comboBoxRoleDetails.Enabled = false;
                textBoxEmail.ReadOnly = true;
                textBoxPassword.ReadOnly = true;
                textBoxBSN.ReadOnly = true;
                textBoxPhone.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
            }
        }


        private string newRole;
        private void comboBoxRoleDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRole = comboBoxRoleDetails.SelectedItem?.ToString();
        }
        private void UpdateRoleInDataGridView(string newRole)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                selectedRow.Cells["Role"].Value = newRole;
            }
        }

		private void removeEmployeeBtn_Click(object sender, EventArgs e)
		{
			if (userDataGridView.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];

                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to remove this employee?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						employeeManager.DeleteEmployee(employeeId);
						userDataGridView.Rows.Remove(selectedRow);
						MessageBox.Show("Employee removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("No employee selected currently.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

