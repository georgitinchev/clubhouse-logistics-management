using MediaBazaar.Classes;
using MediaBazaar.Forms;
using DTOLayer;

namespace MediaBazaar
{

    public partial class MainForm : Form
    {
        private EmployeeManager employeeManager;
        private UserControlDashboard userControlDashboard;
        private UserControlWorksheet userControlWorksheet;


        public MainForm(EmployeeManager _employeeManager)
        {
            employeeManager = _employeeManager;
            Application.EnableVisualStyles();
            InitializeComponent();
            userControlDashboard = new UserControlDashboard(employeeManager);
            userControlWorksheet = new UserControlWorksheet(employeeManager);
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
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlWorksheet.Hide();
            userControlDashboard.Show();
        }

        private void btnWorksheet_Click(object sender, EventArgs e)
        {
            userControlDashboard.Hide();
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
