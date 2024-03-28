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
			PopulateWorksheetData();
			Load += YourFormName_Load;

		}

		public void PopulateWorksheetData()
		{
			
			worksheetData = new DataTable();
			worksheetData.Columns.Add("ID", typeof(int));
			worksheetData.Columns.Add("Time Slot", typeof(string));
			worksheetData.Columns.Add("Weekday", typeof(string));
			worksheetData.Columns.Add("Employee", typeof(string));
			worksheetData.Columns.Add("Week Number", typeof(int));
			employeeWorksheetManager.GetAllWorksheetsInDB();
			foreach (EmployeeWorksheet worksheet in employeeWorksheetManager.assignedWorksheets)
			{
				Employee employee = employeeManager.GetEmployeeById(worksheet.employee);
				worksheetData.Rows.Add(worksheet.id, worksheet.timeSlot.ToString(), worksheet.weekDay.ToString(),employee.GetFullName, worksheet.weekNr);
			}
			employeeWorksheetGrid.DataSource = worksheetData;
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
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Department", HeaderText = "Department" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Role", HeaderText = "Role" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Worksheet", HeaderText = "Worksheet" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date Created", HeaderText = "Date Created" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Due Date", HeaderText = "Due Date" });
			employeeWorksheetGrid.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Status", HeaderText = "Status" });

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

			employeeWorksheetGrid.SelectionChanged += dataGridViewWorksheet_SelectionChanged;
			employeeWorksheetGrid.ScrollBars = ScrollBars.Vertical;
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

		private void YourFormName_Load(object sender, EventArgs e)
		{
			employeeWorksheetGrid.ClearSelection();
			groupBox1.Visible = false;
		}
	}
}
