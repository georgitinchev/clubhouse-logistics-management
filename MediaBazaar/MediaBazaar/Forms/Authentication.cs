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
			this.Resize += AuthenticationForm_Resize;
		}


		// Responsive UI Design for Authentication Form Elements
        private void AuthenticationForm_Resize(object sender, EventArgs e)
        {
            int groupX = (this.ClientSize.Width - loginFormGroup.Width) / 2;
            int groupY = (this.ClientSize.Height - loginFormGroup.Height) / 2;
            loginFormGroup.Location = new Point(groupX, groupY);
            int statusLabelX = groupX;
            int statusLabelY = groupY + loginFormGroup.Height + 10; 
            int labelX = groupX + (loginFormGroup.Width - label1.Width) / 2;
            int labelY = groupY - label1.Height - 10;
            label1.Location = new Point(labelX, labelY);
            pictureBoxJupiter.Location = new Point(groupX + (loginFormGroup.Width - pictureBoxJupiter.Width) / 2, groupY - pictureBoxJupiter.Height - label1.Height - 20);
            loginStatusLabel.Location = new Point(statusLabelX, statusLabelY);
            loginBtn.Location = new Point(groupX + (loginFormGroup.Width - loginBtn.Width) / 2, statusLabelY + loginStatusLabel.Height + 10); 
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
