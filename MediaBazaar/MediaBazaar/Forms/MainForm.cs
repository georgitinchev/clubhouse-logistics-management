using MediaBazaar.Classes;
using MediaBazaar.Forms;
using DTOLayer;

namespace MediaBazaar
{

	public partial class MainForm : Form
	{
		private EmployeeManager employeeManager;
		private EmployeeWorksheetManager worksheetManager;
		private UserControlDashboard userControlDashboard;
		private UserControlWorksheet userControlWorksheet;


		public MainForm(EmployeeManager _employeeManager)
		{
			employeeManager = _employeeManager;
			worksheetManager = new EmployeeWorksheetManager();
			Application.EnableVisualStyles();
			InitializeComponent();
			userControlDashboard = new UserControlDashboard(employeeManager, worksheetManager);
			userControlWorksheet = new UserControlWorksheet(employeeManager, worksheetManager);
			Controls.Add(userControlDashboard);
			Controls.Add(userControlWorksheet);
			userControlDashboard.Show();
			userControlWorksheet.Hide();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			userControlWorksheet.Hide();
			userControlDashboard.Show();
		}

		private void btnWorksheet_Click(object sender, EventArgs e)
		{
			userControlDashboard.Hide();
			userControlWorksheet.PopulateWorksheetData();
			userControlWorksheet.Show();
		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			Authentication authForm = new Authentication();
            this.Hide(); 
            authForm.ShowDialog(); 
            if (authForm.isAuthenticated)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
	}
}
