using System;
using DTOLayer;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
	public partial class Authentication : Form
	{
		private EmployeeManager employeeManager;
		public Authentication()
		{
			employeeManager = new EmployeeManager();
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			string email = userNameLoginTxt.Text;
			string password = passwordLoginTxt.Text;
			try
			{
				Employee employee = employeeManager.AuthenticateEmployee(email, password);

				if (employee != null)
				{
					MainForm mainForm = new MainForm(employeeManager);
					mainForm.Show();
					this.Hide();
				}

				else
				{
					throw (new Exception("Invalid credentials or unauthorized access"));
				}
			}
			catch(Exception ex)
			{
				loginStatusLabel.Text = ex.Message;
			}
		}
	}
}
