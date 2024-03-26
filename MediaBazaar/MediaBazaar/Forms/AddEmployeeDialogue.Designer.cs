namespace MediaBazaar.Forms
{
	partial class AddEmployeeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			addEmployeeTabControl = new TabControl();
			employeeContractTab = new TabPage();
			employeeEmergencyDetailsTab = new TabPage();
			employeeDetailsTab = new TabPage();
			addEmployeeTabControl.SuspendLayout();
			SuspendLayout();
			// 
			// addEmployeeTabControl
			// 
			addEmployeeTabControl.Anchor = AnchorStyles.Top;
			addEmployeeTabControl.Controls.Add(employeeContractTab);
			addEmployeeTabControl.Controls.Add(employeeEmergencyDetailsTab);
			addEmployeeTabControl.Controls.Add(employeeDetailsTab);
			addEmployeeTabControl.ItemSize = new Size(40, 20);
			addEmployeeTabControl.Location = new Point(12, 12);
			addEmployeeTabControl.Name = "addEmployeeTabControl";
			addEmployeeTabControl.SelectedIndex = 0;
			addEmployeeTabControl.Size = new Size(776, 426);
			addEmployeeTabControl.TabIndex = 0;
			addEmployeeTabControl.Tag = "";
			// 
			// employeeContractTab
			// 
			employeeContractTab.Location = new Point(4, 24);
			employeeContractTab.Name = "employeeContractTab";
			employeeContractTab.Padding = new Padding(3);
			employeeContractTab.Size = new Size(768, 398);
			employeeContractTab.TabIndex = 0;
			employeeContractTab.Text = "1.";
			employeeContractTab.UseVisualStyleBackColor = true;
			// 
			// employeeEmergencyDetailsTab
			// 
			employeeEmergencyDetailsTab.Location = new Point(4, 34);
			employeeEmergencyDetailsTab.Name = "employeeEmergencyDetailsTab";
			employeeEmergencyDetailsTab.Padding = new Padding(3);
			employeeEmergencyDetailsTab.Size = new Size(768, 388);
			employeeEmergencyDetailsTab.TabIndex = 1;
			employeeEmergencyDetailsTab.Text = "2.";
			employeeEmergencyDetailsTab.UseVisualStyleBackColor = true;
			// 
			// employeeDetailsTab
			// 
			employeeDetailsTab.Location = new Point(4, 34);
			employeeDetailsTab.Name = "employeeDetailsTab";
			employeeDetailsTab.Padding = new Padding(3);
			employeeDetailsTab.Size = new Size(768, 388);
			employeeDetailsTab.TabIndex = 2;
			employeeDetailsTab.Text = "3.";
			employeeDetailsTab.UseVisualStyleBackColor = true;
			// 
			// AddEmployeeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(800, 450);
			Controls.Add(addEmployeeTabControl);
			Name = "AddEmployeeForm";
			Text = "Add Employee Dialogue";
			addEmployeeTabControl.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl addEmployeeTabControl;
		private TabPage employeeContractTab;
		private TabPage employeeEmergencyDetailsTab;
		private TabPage employeeDetailsTab;
	}
}