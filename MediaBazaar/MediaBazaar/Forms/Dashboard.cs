using MediaBazaar.Classes;

namespace MediaBazaar
{

	public partial class Dashboard : Form
	{
		private EmployeeManager employeeManager;
		private DatabaseOperations dbOperations;
		private List<Employee> employees;

		public Dashboard()
		{
			Application.EnableVisualStyles();
			InitializeComponent();
			dbOperations = new DatabaseOperations();
			employeeManager = new EmployeeManager();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
