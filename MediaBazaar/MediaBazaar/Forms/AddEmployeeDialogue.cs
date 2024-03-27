using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
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
				// Create Contract
				if (!Enum.TryParse(comboBox1.SelectedValue.ToString(), out EmployeeRoleEnum role))
					throw new Exception("Invalid role selected.");

				if (!decimal.TryParse(textBox1.Text, out decimal hourlyWage))
					throw new Exception("Hourly wage must be a decimal number.");

				if (!int.TryParse(textBox2.Text, out int weeklyHours))
					throw new Exception("Weekly hours must be an integer.");

				var startDate = dateTimePicker1.Value;
				var contract = new Contract(_contractManager.contracts.Count + 1, role, hourlyWage, weeklyHours, startDate, null, true, null, DateTime.Now);

				// Create EmergencyContact
				var emcFirstName = emcFirstNameBox.Text;
				var emcLastName = emcLastNameBox.Text;
				var emcPhone = emcPhoneText.Text;
				var emcEmail = emcEmailBox.Text;
				var emergencyContact = new EmergencyContact(_employeeManager.employees.Count + 1, emcFirstName, emcLastName, emcPhone, emcEmail);

				// Create Employee
				var firstName = textBox6.Text;
				var lastName = textBox7.Text;
				var email = textBox5.Text;
				var password = textBox4.Text;
				var bsn = textBox3.Text;
				var phoneNumber = textBox9.Text;
				var address = textBox8.Text;

				if (!DateTime.TryParse(dateTimePicker2.Text, out DateTime birthday))
					throw new Exception("Invalid date format for birthday.");

				var employee = new Employee(_employeeManager.employees.Count + 1, firstName, lastName, email, password, phoneNumber, bsn, birthday, (int)role, false, emergencyContact, address, contract);
				// Add to EmployeeManager
				//_employeeManager.AddEmployee(employee);
			}
			catch (Exception ex)
			{
				// Show error message
				MessageBox.Show(ex.Message);
			}
		}


		private void InitializeTabNavigation()
		{
			// nav indexing logic
			nextBtnP1.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };
			previousBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 0; };
			nextBtnP2.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 2; };
			previousBtnP3.Click += (sender, e) => { addEmployeeTabControl.SelectedIndex = 1; };
			completeFormBtn.Click += (sender, e) => { };

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
