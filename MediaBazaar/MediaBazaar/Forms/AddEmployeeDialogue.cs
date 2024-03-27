using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			employeeRoleComboBox.DataSource = Enum.GetValues(typeof(EmployeeRoleEnum));
		}

		private void completeFormBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Enum.TryParse(employeeRoleComboBox.SelectedValue.ToString(), out EmployeeRoleEnum role))
					throw new Exception("Invalid role selected.");

				if (!decimal.TryParse(hourlyWageTextBox.Text, out decimal hourlyWage))
					throw new Exception("Hourly wage must be a decimal number.");

				if (!int.TryParse(weeklyHoursTextBox.Text, out int weeklyHours))
					throw new Exception("Weekly hours must be an integer.");

				ValidateFields();
				int contractId = idCheckerContract();

				// Create Contract
				var contract = new Contract(contractId, role, hourlyWage, weeklyHours, startDatePicker.Value, null, true, null, DateTime.Now);
				

				// Get Employee ID
				int employeeId = idCheckerEmployee();

				// Create EmergencyContact
				var emergencyContact = new EmergencyContact(employeeId, emcFirstNameBox.Text, emcLastNameBox.Text, emcPhoneText.Text, emcEmailBox.Text);

				// Create Employee
				var employee = new Employee(employeeId, firstNameText.Text, lastNameText.Text, emailText.Text, passwordText.Text, phoneText.Text, bsnText.Text, birthdayDatePicker.Value, (int)role, false, emergencyContact, addressText.Text, contract);
				_contractManager.AddContract(contract);
				_employeeManager._emergencyContactManager.AddEmergencyContact(emergencyContact);
				_employeeManager.AddEmployee(employee);
				MessageBox.Show("Employee added successfully.");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int idCheckerContract()
		{
			if (_contractManager.contracts == null || _contractManager.contracts.Count == 0)
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
			if (_employeeManager.employees == null || _employeeManager.employees.Count == 0)
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

		private void ValidateFields()
		{
			if (string.IsNullOrWhiteSpace(firstNameText.Text))
				throw new Exception("First name is required.");

			if (string.IsNullOrWhiteSpace(lastNameText.Text))
				throw new Exception("Last name is required.");

			if (string.IsNullOrWhiteSpace(emailText.Text))
				throw new Exception("Email is required.");

			if (string.IsNullOrWhiteSpace(passwordText.Text))
				throw new Exception("Password is required.");

			if (string.IsNullOrWhiteSpace(phoneText.Text))
				throw new Exception("Phone number is required.");

			if (string.IsNullOrWhiteSpace(bsnText.Text))
				throw new Exception("BSN is required.");

			if (string.IsNullOrWhiteSpace(addressText.Text))
				throw new Exception("Address is required.");

			if (string.IsNullOrWhiteSpace(emcFirstNameBox.Text))
				throw new Exception("Emergency contact first name is required.");

			if (string.IsNullOrWhiteSpace(emcLastNameBox.Text))
				throw new Exception("Emergency contact last name is required.");

			if (string.IsNullOrWhiteSpace(emcPhoneText.Text))
				throw new Exception("Emergency contact phone number is required.");

			if (string.IsNullOrWhiteSpace(emcEmailBox.Text))
				throw new Exception("Emergency contact email is required.");

			// email validation regex
			var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");

			if (!emailRegex.IsMatch(emailText.Text))
				throw new Exception("Email is not in a valid format.");

			if (!emailRegex.IsMatch(emcEmailBox.Text))
				throw new Exception("Emergency contact email is not in a valid format.");

			// phone num validation regex
			var phoneRegex = new Regex(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
			if (!phoneRegex.IsMatch(phoneText.Text))
				throw new Exception("Phone number is not in a valid format.");

			if (!phoneRegex.IsMatch(emcPhoneText.Text))
				throw new Exception("Emergency contact phone number is required.");

			if (startDatePicker.Value.Date > DateTime.Now.Date)
				throw new Exception("Contract start date cannot be in the future.");

			if (birthdayDatePicker.Value.Date > DateTime.Now.Date)
				throw new Exception("Employee birthday cannot be in the future.");
		}
	}
}
