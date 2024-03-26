using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaBazaar.Forms
{
	public partial class UserControlDashboard : UserControl
	{

        public UserControlDashboard()
        {
            InitializeComponent();
            InitializeData();
            InitializeDataGridView();
            InitializeFocus();
        }

		private DataTable employeeData;

		private void InitializeData()
		{
			// Sample data - replace this with actual data source
			employeeData = new DataTable();
			employeeData.Columns.Add("Name", typeof(string));
			employeeData.Columns.Add("Email", typeof(string));
			employeeData.Columns.Add("Department", typeof(string));
			employeeData.Columns.Add("Role", typeof(string));
			employeeData.Columns.Add("Worksheet", typeof(string));

			employeeData.Rows.Add("John Doe", "john@example.com", "IT", "Developer", "A");
			employeeData.Rows.Add("Jane Smith", "jane@example.com", "HR", "Manager", "B");
			employeeData.Rows.Add("Alice Johnson", "alice@example.com", "Finance", "Accountant", "C");
			employeeData.Rows.Add("Bob Brown", "bob@example.com", "Marketing", "Marketing Specialist", "D");
		}

		private void InitializeDataGridView()
		{
			userDataGridView.AutoGenerateColumns = true;
			userDataGridView.DataSource = employeeData;
			userDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			userDataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            if (!string.IsNullOrEmpty(searchTerm) && searchTerm != placeholder)
            {
                var query = from row in employeeData.AsEnumerable()
                            where row.Field<string>("Name").Contains(searchTerm)
                            select row;

                DataTable searchResults = query.Any() ? query.CopyToDataTable() : employeeData.Clone();
                dataGridView1.DataSource = searchResults;
            }
            else
            {
                dataGridView1.DataSource = employeeData;
            }
        }
    }
}
