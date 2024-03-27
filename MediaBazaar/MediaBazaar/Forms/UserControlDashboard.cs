using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediaBazaar.Forms
{
    public partial class UserControlDashboard : UserControl
    {
        private EmployeeManager employeeManager;
        private ContractManager contractManager;
        private List<Employee> employees;
        private DataTable employeeData;
        private Employee selectedEmployee;
        private List<(Control control, Color originalBackColor, bool originalReadOnly)> originalControlStates = new List<(Control, Color, bool)>();
        public UserControlDashboard()
        {
            employeeManager = new EmployeeManager();
            InitializeComponent();
            InitializeData();
            PopulateGridView();
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

            originalControlLocations.Add((textBoxSearch, textBoxSearch.Location));
            originalControlLocations.Add((comboBoxRole, comboBoxRole.Location));
            originalControlLocations.Add((addEmployeeBtn, addEmployeeBtn.Location));
            originalControlLocations.Add((pictureBoxSearch, pictureBoxSearch.Location));
        }


        private void InitializeData()
        {
            employeeData = new DataTable();
            employeeData.Columns.Add("EmployeeID", typeof(int));
            employeeData.Columns.Add("Name", typeof(string));
            employeeData.Columns.Add("Email", typeof(string));
            employeeData.Columns.Add("Role", typeof(string));
            employeeData.Columns.Add("Worksheet", typeof(string));
            employeeData.Rows.Add("John Doe", "john@example.com", "HR Manager", "A");
            employeeData.Rows.Add("Jane Smith", "jane@example.com", "Sales Representative", "B");
            employeeData.Rows.Add("Alice Johnson", "alice@example.com", "Support", "C");
            employeeData.Rows.Add("Bob Brown", "bob@example.com", "Cashier", "D");
            employeeData.Rows.Add("Charlie Chen", "charlie@example.com", "Security Guard", "E");
            employeeData.Rows.Add("David Davis", "david@example.com", "Depot Worker", "F");
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
            userDataGridView.Columns["Password"].Visible = false;
            userDataGridView.Columns["BSN"].Visible = false;
            userDataGridView.Columns["PhoneNumber"].Visible = false;
            userDataGridView.Columns["Birthday"].Visible = false;
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
            AddEmployeeForm addEmployeeDialogue = new AddEmployeeForm(employeeManager,employeeManager._contractManager);
            addEmployeeDialogue.ShowDialog();
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
                        if (textBox == textBoxPassword || textBox == textBoxBSN)
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
                UpdateRoleInDataGridView(newRole);
                foreach (var (control, originalBackColor, originalReadOnly) in originalControlStates)
                {
                    control.BackColor = originalBackColor;
                    if (control is TextBox textBox)
                    {
                        textBox.ReadOnly = originalReadOnly;
                        if (textBox == textBoxPassword || textBox == textBoxBSN)
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

        private void UpdateEmployeeDetails()
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                selectedRow.Cells["Name"].Value = textBoxName.Text;
                selectedRow.Cells["Role"].Value = comboBoxRoleDetails.SelectedItem.ToString();
                selectedRow.Cells["Email"].Value = textBoxEmail.Text;
                selectedRow.Cells["Password"].Value = textBoxPassword.Text;
                selectedRow.Cells["BSN"].Value = textBoxBSN.Text;
                selectedRow.Cells["PhoneNumber"].Value = textBoxPhone.Text;
                selectedRow.Cells["Birthday"].Value = dateTimePickerBirthday.Value;
            }
        }

        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                PopulateEmployeeDetails();
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void PopulateEmployeeDetails()
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];

                string name = selectedRow.Cells["Name"].Value.ToString();
                string[] nameParts = name.Split(' ');
                string firstName = nameParts[0];
                string lastName = string.Join(" ", nameParts.Skip(1));

                string email = selectedRow.Cells["Email"].Value.ToString();
                string role = selectedRow.Cells["Role"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string bsn = selectedRow.Cells["BSN"].Value.ToString();
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                DateTime birthday = (DateTime)selectedRow.Cells["Birthday"].Value;

                textBoxName.Text = firstName;
                comboBoxRoleDetails.SelectedItem = role;
                textBoxEmail.Text = email;

                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = password;
                textBoxBSN.UseSystemPasswordChar = true;
                textBoxBSN.Text = bsn;

                textBoxPhone.Text = phoneNumber;
                dateTimePickerBirthday.Value = birthday;
            }
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employeeData.Rows.Count)
            {
                DataGridViewRow selectedRow = userDataGridView.Rows[e.RowIndex];

                textBoxName.ReadOnly = false;
                comboBoxRoleDetails.Enabled = true;
                textBoxEmail.ReadOnly = false;
                textBoxPassword.ReadOnly = false;
                textBoxBSN.ReadOnly = false;
                textBoxPhone.ReadOnly = false;

                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                comboBoxRoleDetails.Text = selectedRow.Cells["Role"].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                textBoxPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                textBoxBSN.Text = selectedRow.Cells["BSN"].Value.ToString();
                textBoxPhone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();

                textBoxName.ReadOnly = true;
                comboBoxRoleDetails.Enabled = false;
                textBoxEmail.ReadOnly = true;
                textBoxPassword.ReadOnly = true;
                textBoxBSN.ReadOnly = true;
                textBoxPhone.ReadOnly = true;

                dateTimePickerBirthday.Value = (DateTime)selectedRow.Cells["Birthday"].Value;
            }
        }

        private void GenerateMockData(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string[] firstNames = { "John", "Jane", "Alice", "Bob", "Charlie", "David" };
                string[] lastNames = { "Doe", "Smith", "Johnson", "Brown", "Chen", "Davis" };
                string[] roles = { "Manager", "Cashier", "Sales Representative", "HR Manager", "Support", "Security Guard", "Depot Worker" };

                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com";
                string role = roles[random.Next(roles.Length)];
                string password = GenerateRandomPassword();
                string bsn = GenerateRandomBSN();
                string phoneNumber = GenerateRandomPhoneNumber();
                DateTime birthday = GenerateRandomBirthday();
                int employeeID = GenerateEmployeeID();

                DataRow newRow = employeeData.NewRow();
                newRow["EmployeeID"] = employeeID;
                newRow["Name"] = $"{firstName} {lastName}";
                newRow["Email"] = email;
                newRow["Role"] = role;
                newRow["Password"] = password;
                newRow["BSN"] = bsn;
                newRow["PhoneNumber"] = phoneNumber;
                newRow["Birthday"] = birthday;

                employeeData.Rows.Add(newRow);
            }
        }

        private int GenerateEmployeeID()
        {
            return new Random().Next(1000, 9999);
        }

        private string GenerateRandomPassword()
        {
            return "randompassword";
        }

        private string GenerateRandomBSN()
        {
            return new Random().Next(100000000, 999999999).ToString();
        }

        private string GenerateRandomPhoneNumber()
        {
            return $"06{new Random().Next(10000000, 99999999)}";
        }

        private DateTime GenerateRandomBirthday()
        {
            DateTime startDate = DateTime.Today.AddYears(-65);
            DateTime endDate = DateTime.Today.AddYears(-18);
            int range = (endDate - startDate).Days;
            return startDate.AddDays(new Random().Next(range));
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
    }
}

