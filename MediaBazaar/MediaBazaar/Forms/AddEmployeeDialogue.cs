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
		public AddEmployeeForm()
		{
			InitializeComponent();
			HideTabControls();
			InitializeTabNavigation();
		}
		private void nextBtnP1_Click(object sender, EventArgs e)
		{

		}

		private void previousBtn_Click(object sender, EventArgs e)
		{

		}

		private void nextBtnP2_Click(object sender, EventArgs e)
		{

		}

		private void completeFormBtn_Click(object sender, EventArgs e)
		{

		}

		private void InitializeTabNavigation()
		{
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
