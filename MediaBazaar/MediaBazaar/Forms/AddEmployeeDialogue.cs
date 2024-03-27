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
			// logic to add employee
			try
			{
				//create contract
				Contract(int(_contractManager.Count) + 1,comboBox1.SelectedValue,textBox1.Text,textBox2.Text,dateTimePicker1.Value,);
				//create emergency contact
				//create employee + append contract + emergency contact 
				// add to employee manager
				_employeeManager.AddEmployee();
				// send to db
			}
			catch
			{

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
