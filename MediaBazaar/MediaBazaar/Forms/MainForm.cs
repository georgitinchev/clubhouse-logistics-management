using MediaBazaar.Classes;
using MediaBazaar.Forms;
using DTOLayer;
using BusinessLogicLayer;

namespace MediaBazaar
{

    public partial class MainForm : Form
    {
        private EmployeeManager employeeManager;
        private EmployeeWorksheetManager worksheetManager;
        private ProductManager productManager;
        private UserControlDashboard userControlDashboard;
        private UserControlWorksheet userControlWorksheet;
        private UserControlDeport userControlDeport;
        



        public MainForm(EmployeeManager _employeeManager, EmployeeWorksheetManager _worksheetManager, ProductManager _productManager,EmployeeRoleEnum userRole)
        {
            employeeManager = _employeeManager;
            worksheetManager = _worksheetManager;
            productManager = _productManager;
            Application.EnableVisualStyles();
            InitializeComponent();
            userControlDashboard = new UserControlDashboard(employeeManager, worksheetManager);
            userControlWorksheet = new UserControlWorksheet(employeeManager, worksheetManager);
            userControlDeport = new UserControlDeport(productManager);
            Controls.Add(userControlDashboard);
            Controls.Add(userControlWorksheet);
            Controls.Add(userControlDeport);
            userControlDashboard.Show();
            userControlWorksheet.Hide();
            userControlDeport.Hide();
            if (userRole == EmployeeRoleEnum.DepotWorker)
            {

                Controls.Add(userControlDeport);
                userControlDeport.Show();
                userControlDashboard.Hide();
                userControlWorksheet.Hide();
                btnDashboard.Hide();
                btnWorksheet.Hide();
                lineEmployee.Hide(); 
                pictureBox1.Hide();
            }
            else
            {

                Controls.Add(userControlDashboard);
                Controls.Add(userControlWorksheet);
                userControlDashboard.Show();
                userControlWorksheet.Hide();
                userControlDeport.Hide();
                btnProduct.Hide();
                lineProduct.Hide();
            }

            this.Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pictureBoxJupiter.Location = new Point(25, -4);
            pictureBoxLogo.Location = new Point(pictureBoxJupiter.Right + 10, 0); 
            btnDashboard.Location = new Point(panel1.Width / 4 - btnDashboard.Width / 2, 8);
            btnWorksheet.Location = new Point(panel1.Width / 2 - btnWorksheet.Width / 2, 8);
            btnProduct.Location = new Point(panel1.Width * 3 / 4 - btnProduct.Width / 2, 8);
            logOutBtn.Location = new Point(panel1.Width - logOutBtn.Width - 25, 9);
            pictureBox1.Location = new Point(btnDashboard.Location.X + (btnDashboard.Width - pictureBox1.Width) / 2, btnDashboard.Location.Y + btnDashboard.Height + 10);
            lineEmployee.Location = new Point(btnWorksheet.Location.X + (btnWorksheet.Width - lineEmployee.Width) / 2, btnWorksheet.Location.Y + btnWorksheet.Height + 10);
            lineProduct.Location = new Point(btnProduct.Location.X + (btnProduct.Width - lineProduct.Width) / 2, btnProduct.Location.Y + btnProduct.Height + 10);
            userControlDashboard.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlDashboard.Location = new Point(0, panel1.Height);
            userControlWorksheet.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlWorksheet.Location = new Point(0, panel1.Height);
            userControlDeport.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - panel1.Height);
            userControlDeport.Location = new Point(0, panel1.Height);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlWorksheet.Hide();
            userControlDeport.Hide();
            userControlDashboard.InitializeData();
            userControlDashboard.Show();
        }

        private void btnWorksheet_Click(object sender, EventArgs e)
        {
            userControlDashboard.Hide();
            userControlDeport.Hide();
            userControlWorksheet.PopulateWorksheetData();
            userControlWorksheet.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            userControlDashboard.Hide();
            userControlWorksheet.Hide();
            userControlDeport.InitializeProductData();
            userControlDeport.ClearProductDetails();
            userControlDeport.Show();
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
