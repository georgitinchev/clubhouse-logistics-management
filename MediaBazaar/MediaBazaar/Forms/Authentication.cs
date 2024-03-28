using System;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using MediaBazaar.Classes;

namespace MediaBazaar.Forms
{
	public partial class Authentication : Form
	{
		public EmployeeManager employeeManager { get; private set; }
		public bool isAuthenticated { get; private set; } = false;
		public Authentication()
		{
			employeeManager = new EmployeeManager();
			InitializeComponent();
			passwordLoginTxt.PasswordChar = '*';
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
					isAuthenticated = true;
					this.Close();
				}
				else
				{
					throw (new Exception("⚠️ Invalid credentials or unauthorized access"));
				}
			}
			catch (Exception ex)
			{
				loginStatusLabel.Text = ex.Message;
			}
		}
	}
}
