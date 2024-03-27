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
            userControlWorksheet = new UserControlWorksheet();
            Controls.Add(userControlDashboard);
            Controls.Add(userControlWorksheet);
            userControlDashboard.Show();
            userControlWorksheet.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
