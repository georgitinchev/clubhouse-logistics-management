using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
	public partial class AddEmployeeForm : Form
	{
		private EmployeeManager _employeeManager;
		private ContractManager _contractManager;

		public AddEmployeeForm(EmployeeManager employeeManager, ContractManager contractManager)
		{
			_employeeManager = employeeManager;
			_contractManager = contractManager;
			InitializeComponent();
			HideTabControls();
			InitializeTabNavigation();
			comboBox1.DataSource = Enum.GetValues(typeof(EmployeeRoleEnum));
		}

		private void completeFormBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Enum.TryParse(comboBox1.SelectedValue.ToString(), out EmployeeRoleEnum role))
					throw new Exception("Invalid role selected.");

				if (!decimal.TryParse(textBox1.Text, out decimal hourlyWage))
					throw new Exception("Hourly wage must be a decimal number.");

				if (!int.TryParse(textBox2.Text, out int weeklyHours))
					throw new Exception("Weekly hours must be an integer.");

				// Get Contract ID
				int contractId = idCheckerContract();

				// Create Contract
				var contract = new Contract(contractId, role, hourlyWage, weeklyHours, dateTimePicker1.Value, null, true, null, null);
				_contractManager.AddContract(contract);

				// Get Employee ID
				int employeeId = idCheckerEmployee();

				// Create EmergencyContact
				var emergencyContact = new EmergencyContact(employeeId, emcFirstNameBox.Text, emcLastNameBox.Text, emcPhoneText.Text, emcEmailBox.Text);

				// Create Employee
				var employee = new Employee(employeeId, textBox6.Text, textBox7.Text, textBox5.Text, textBox4.Text, textBox9.Text, textBox3.Text, dateTimePicker2.Value, (int)role, false, emergencyContact, textBox8.Text, contract);
				_employeeManager.AddEmployee(employee);

				MessageBox.Show("Employee added successfully.");

				this.Close(); // Close the form after successfully adding an employee
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int idCheckerContract()
		{
			if (_contractManager.contracts.Count == 0)
			{
				return 1;
			}
			else
			{
				return _contractManager.contracts.Count + 1;
			}
		}

		private int idCheckerEmployee()
		{
			if (_employeeManager.employees.Count == 0)
			{
				return 1;
			}
			else
			{
				return _employeeManager.employees.Count + 1;
			}
		}

		private void InitializeTabNavigation()
		{
			// nav indexing logic
			nextBtnP1.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };
			previousBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 0; };
			nextBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 2; };
			previousBtnP3.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };
			completeFormBtn.Click += completeFormBtn_Click; // Wire up the button click event handler

			addEmployeeTabControl.SelectedIndexChanged += (sender, e) =>
			{
				if (addEmployeeTabControl.SelectedIndex == 0)
				{
					previousBtnP2.Enabled = false;
				}
				else if (addEmployeeTabControl.SelectedIndex == 1)
				{
					previousBtnP2.Enabled = true;
					nextBtnP1.Enabled = true;
					nextBtnP2.Enabled = true;
				}
				else if (addEmployeeTabControl.SelectedIndex == 2)
				{
					nextBtnP2.Enabled = false;
				}
			};
		}

		private void HideTabControls()
		{
			addEmployeeTabControl.Appearance = TabAppearance.FlatButtons;
			addEmployeeTabControl.SizeMode = TabSizeMode.Fixed;
			addEmployeeTabControl.ItemSize = new Size(0, 1);
		}
	}
}
