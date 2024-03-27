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
	public partial class UserControlDefault : UserControl
	{
		public UserControlDefault()
		{
			InitializeComponent();
		}

		private void UserControlDashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				Application.Exit();
			}
		}
	}
}
