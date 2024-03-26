﻿using System;
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
            Load += YourFormName_Load;
        }

        private DataTable employeeData;

        private void InitializeData()
        {
            // Sample data - replace this with actual data source
            employeeData = new DataTable();
            employeeData.Columns.Add("Name", typeof(string));
            employeeData.Columns.Add("Email", typeof(string));
            employeeData.Columns.Add("Role", typeof(string));
            employeeData.Columns.Add("Worksheet", typeof(string));

            employeeData.Rows.Add("John Doe", "john@example.com", "Developer", "A");
            employeeData.Rows.Add("Jane Smith", "jane@example.com", "Manager", "B");
            employeeData.Rows.Add("Alice Johnson", "alice@example.com", "Accountant", "C");
            employeeData.Rows.Add("Bob Brown", "bob@example.com", "Marketing Specialist", "D");
        }
        private void YourFormName_Load(object sender, EventArgs e)
        {
            // Clear the selection in the DataGridView when the form loads
            userDataGridView.ClearSelection();
            // Optionally, hide the gbEmployeeDetails group box initially
            groupBox1.Visible = false;
        }

        private void InitializeDataGridView()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.DataSource = employeeData;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Material blue
            userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // White text
            userDataGridView.DefaultCellStyle.BackColor = Color.White; // White background
            userDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33); // Dark text
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200); // Light gray
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Font = new Font("Segoe UI", 10);

            // Apply subtle animations
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.BorderStyle = BorderStyle.None;
            userDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235); // Light gray
            userDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33); // Dark text
            userDataGridView.BackgroundColor = Color.White; // White background

            // Add columns
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Email", HeaderText = "Email" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Department", HeaderText = "Department" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Role" });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Worksheet", HeaderText = "Worksheet" });

            // Apply hover effect
            userDataGridView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light gray
                }
            };

            userDataGridView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    userDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Reset to white
                }
            };

            userDataGridView.SelectionChanged += DataGridView1_SelectionChanged;
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
                            where row.Field<string>("Email").Contains(searchTerm)
                            where row.Field<string>("Email").Contains(searchTerm)
                            select row;

                DataTable searchResults = query.Any() ? query.CopyToDataTable() : employeeData.Clone();
                userDataGridView.DataSource = searchResults;
            }
            else
            {
                userDataGridView.DataSource = employeeData;
            }
        }

        private void comboBoxDepartment_Click(object sender, EventArgs e)
        {
            comboBoxDepartment.DroppedDown = true;
        }
    }
}
