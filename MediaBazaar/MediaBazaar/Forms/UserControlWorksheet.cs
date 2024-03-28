using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar;

namespace MediaBazaar.Forms
{
	public partial class UserControlWorksheet : UserControl
	{
		private EmployeeWorksheetManager employeeWorksheetManager;
		public UserControlWorksheet()
		{
			employeeWorksheetManager = new EmployeeWorksheetManager();
			InitializeComponent();
			InitializeGridViewWorksheet();
            Load += UserControlWorksheet_Load;
            dataGridViewWorksheet.SelectionChanged += DataGridViewWorksheet_SelectionChanged;
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

			// Add columns
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Department", HeaderText = "Department" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Role" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Worksheet", HeaderText = "Worksheet" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date Created", HeaderText = "Date Created" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Due Date", HeaderText = "Due Date" });
			dataGridViewWorksheet.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Status", HeaderText = "Status" });

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

            dataGridViewWorksheet.ScrollBars = ScrollBars.Vertical;
            dataGridViewWorksheet.SelectionChanged += dataGridViewWorksheet_SelectionChanged;
        }

        private void UserControlWorksheet_Load(object sender, EventArgs e)
        {
            dataGridViewWorksheet.ClearSelection();
            groupBox1.Visible = false;
            UpdateLayout();
        }

        private void DataGridViewWorksheet_SelectionChanged (object sender, EventArgs e)
        {
            UpdateLayout();
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


        private void UpdateLayout()
        {
            bool isEmployeeSelected = dataGridViewWorksheet.SelectedRows.Count > 0;

            if (isEmployeeSelected)
            {
                MoveControlsToLocation(textBoxSearch, new Point(41, 74), new Size(313, 23));
                MoveControlsToLocation(comboBoxDepartment, new Point(377, 74), new Size(268, 23));
                MoveControlsToLocation(pictureBoxSearch, new Point(333, 74), new Size(21, 23));
            }
            else
            {
                MoveControlsToLocation(textBoxSearch, new Point(855, 114), new Size(313, 23));
                MoveControlsToLocation(comboBoxDepartment, new Point(855, 152), new Size(313, 23));
                MoveControlsToLocation(pictureBoxSearch, new Point(1147, 114), new Size(21, 23));
            }
        }

        private void MoveControlsToLocation(Control control, Point location, Size size)
        {
            control.Location = location;
            control.Size = size;
        }
	}
}
