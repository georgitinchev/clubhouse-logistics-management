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


        public MainForm(EmployeeManager _employeeManager, EmployeeWorksheetManager _worksheetManager)
        {
            employeeManager = _employeeManager;
            worksheetManager = _worksheetManager;
            Application.EnableVisualStyles();
            InitializeComponent();
            userControlDashboard = new UserControlDashboard(employeeManager,worksheetManager);
            userControlWorksheet = new UserControlWorksheet(employeeManager, worksheetManager);
            Controls.Add(userControlDashboard);
            Controls.Add(userControlWorksheet);
            userControlDashboard.Show();
            userControlWorksheet.Hide();
            this.Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pictureBoxJupiter.Location = new Point(25, -4);
            btnDashboard.Location = new Point(panel1.Width / 3 - btnDashboard.Width / 2, 8);
            pictureBoxLogo.Location = new Point(panel1.Width / 2 - pictureBoxLogo.Width / 2, 8);
            btnWorksheet.Location = new Point(panel1.Width * 2 / 3 - btnWorksheet.Width / 2, 8);
            logOutBtn.Location = new Point(panel1.Width - logOutBtn.Width - 25, 9);
            pictureBox1.Location = new Point(btnDashboard.Location.X + (btnDashboard.Width - pictureBox1.Width) / 2, btnDashboard.Location.Y + btnDashboard.Height + 10);
            lineEmployee.Location = new Point(btnWorksheet.Location.X + (btnWorksheet.Width - lineEmployee.Width) / 2, btnWorksheet.Location.Y + btnWorksheet.Height + 10);
            userControlDashboard.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlDashboard.Location = new Point(0, panel1.Height);
            userControlWorksheet.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlWorksheet.Location = new Point(0, panel1.Height);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlWorksheet.Hide();
            userControlDashboard.InitializeData();
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
