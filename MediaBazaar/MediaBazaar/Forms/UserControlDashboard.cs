using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
    public partial class UserControlDashboard : UserControl
    {
        private EmployeeManager employeeManager;
        private ContractManager contractManager;
        private List<(Control control, Color originalBackColor, bool originalReadOnly)> originalControlStates = new List<(Control, Color, bool)>();
        public UserControlDashboard()
        {
            employeeManager = new EmployeeManager();
            contractManager = new ContractManager();
            InitializeComponent();
            InitializeData();
            InitializeDataGridView();
            InitializeControls();
            InitializeFocus();
            Load += YourFormName_Load;
        }
        private DataTable employeeData;

        private void InitializeControls()
        {
            originalControlStates.Add((textBoxName, textBoxName.BackColor, textBoxName.ReadOnly));
            originalControlStates.Add((textBoxSurname, textBoxSurname.BackColor, textBoxSurname.ReadOnly));
            originalControlStates.Add((comboBoxRole, comboBoxRole.BackColor, comboBoxRole.Enabled));
            originalControlStates.Add((textBoxEmail, textBoxEmail.BackColor, textBoxEmail.ReadOnly));
        }


        private void InitializeData()
        {
            employeeData = new DataTable();
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

            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Email", HeaderText = "Email" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Role" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Worksheet", HeaderText = "Worksheet" });

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
            AddEmployeeForm addEmployeeDialogue = new AddEmployeeForm(employeeManager, contractManager);
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
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Enabled = true;
                    }
                }
                editEmployeeBtn.Text = "Save";
            }
            else if (editEmployeeBtn.Text == "Save")
            {
                foreach (var (control, originalBackColor, originalReadOnly) in originalControlStates)
                {
                    control.BackColor = originalBackColor;
                    if (control is TextBox textBox)
                    {
                        textBox.ReadOnly = originalReadOnly;
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Enabled = originalReadOnly;
                    }
                }
                editEmployeeBtn.Text = "Edit Employee";
            }
        }

        private Employee GetSelectedEmployee()
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userDataGridView.SelectedRows[0];
                return (Employee)selectedRow.DataBoundItem;
            }
            else
            {
                return null;
            }
        }
    }
}

