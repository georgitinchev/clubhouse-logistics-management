using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
    public partial class UserControlDashboard : UserControl
    {
		private EmployeeManager employeeManager;
		public UserControlDashboard()
        {
            InitializeComponent();
			this.employeeManager = new EmployeeManager();
		}
	}
}
