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
			customButton1 = new CustomButton();
			label4 = new Label();
			dateTimePicker1 = new DateTimePicker();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			comboBox1 = new ComboBox();
			employeeEmergencyDetailsTab = new TabPage();
			customButton2 = new CustomButton();
			emcLastNameBox = new TextBox();
			emcFirstNameBox = new TextBox();
			emcEmailBox = new TextBox();
			emcPhoneText = new TextBox();
			emcEmail = new Label();
			emcPhoneNum = new Label();
			emcLastName = new Label();
			emcFirstName = new Label();
			employeeDetailsTab = new TabPage();
			textBox7 = new TextBox();
			textBox6 = new TextBox();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			dateTimePicker2 = new DateTimePicker();
			personalBirthday = new Label();
			personalBsn = new Label();
			personalPassword = new Label();
			personalEmail = new Label();
			personalLastName = new Label();
			personalFirstName = new Label();
			customButton3 = new CustomButton();
			addEmployeeTabControl.SuspendLayout();
			employeeContractTab.SuspendLayout();
			employeeEmergencyDetailsTab.SuspendLayout();
			employeeDetailsTab.SuspendLayout();
			SuspendLayout();
			// 
			// addEmployeeTabControl
			// 
			addEmployeeTabControl.Anchor = AnchorStyles.Top;
			addEmployeeTabControl.Controls.Add(employeeContractTab);
			addEmployeeTabControl.Controls.Add(employeeEmergencyDetailsTab);
			addEmployeeTabControl.Controls.Add(employeeDetailsTab);
			addEmployeeTabControl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			addEmployeeTabControl.ItemSize = new Size(30, 30);
			addEmployeeTabControl.Location = new Point(11, 12);
			addEmployeeTabControl.Name = "addEmployeeTabControl";
			addEmployeeTabControl.SelectedIndex = 0;
			addEmployeeTabControl.Size = new Size(493, 386);
			addEmployeeTabControl.TabIndex = 0;
			addEmployeeTabControl.Tag = "";
			// 
			// employeeContractTab
			// 
			employeeContractTab.BackColor = Color.White;
			employeeContractTab.Controls.Add(customButton1);
			employeeContractTab.Controls.Add(label4);
			employeeContractTab.Controls.Add(dateTimePicker1);
			employeeContractTab.Controls.Add(textBox2);
			employeeContractTab.Controls.Add(label3);
			employeeContractTab.Controls.Add(textBox1);
			employeeContractTab.Controls.Add(label2);
			employeeContractTab.Controls.Add(label1);
			employeeContractTab.Controls.Add(comboBox1);
			employeeContractTab.Location = new Point(4, 34);
			employeeContractTab.Name = "employeeContractTab";
			employeeContractTab.Padding = new Padding(3);
			employeeContractTab.Size = new Size(485, 348);
			employeeContractTab.TabIndex = 0;
			employeeContractTab.Text = "📝 Contract Details";
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.DarkOrange;
			customButton1.BackgroundColor = Color.DarkOrange;
			customButton1.BorderColor = Color.White;
			customButton1.BorderRadius = 15;
			customButton1.BorderSize = 1;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			customButton1.ForeColor = Color.White;
			customButton1.Location = new Point(145, 260);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(150, 40);
			customButton1.TabIndex = 8;
			customButton1.Text = "Next";
			customButton1.TextColor = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label4.Location = new Point(66, 36);
			label4.Name = "label4";
			label4.Size = new Size(110, 28);
			label4.TabIndex = 7;
			label4.Text = "Start Date";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
			dateTimePicker1.Location = new Point(47, 73);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(148, 27);
			dateTimePicker1.TabIndex = 6;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 12F);
			textBox2.Location = new Point(47, 180);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(148, 29);
			textBox2.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label3.Location = new Point(47, 140);
			label3.Name = "label3";
			label3.Size = new Size(143, 28);
			label3.TabIndex = 4;
			label3.Text = "Weekly Hours";
			label3.Click += label3_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 12F);
			textBox1.Location = new Point(254, 180);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(157, 29);
			textBox1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label2.Location = new Point(271, 140);
			label2.Name = "label2";
			label2.Size = new Size(135, 28);
			label2.TabIndex = 2;
			label2.Text = "Hourly Wage";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label1.Location = new Point(254, 36);
			label1.Name = "label1";
			label1.Size = new Size(152, 28);
			label1.TabIndex = 1;
			label1.Text = "Employee Role";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 12F);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(254, 73);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(157, 29);
			comboBox1.TabIndex = 0;
			// 
			// employeeEmergencyDetailsTab
			// 
			employeeEmergencyDetailsTab.Controls.Add(customButton2);
			employeeEmergencyDetailsTab.Controls.Add(emcLastNameBox);
			employeeEmergencyDetailsTab.Controls.Add(emcFirstNameBox);
			employeeEmergencyDetailsTab.Controls.Add(emcEmailBox);
			employeeEmergencyDetailsTab.Controls.Add(emcPhoneText);
			employeeEmergencyDetailsTab.Controls.Add(emcEmail);
			employeeEmergencyDetailsTab.Controls.Add(emcPhoneNum);
			employeeEmergencyDetailsTab.Controls.Add(emcLastName);
			employeeEmergencyDetailsTab.Controls.Add(emcFirstName);
			employeeEmergencyDetailsTab.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			employeeEmergencyDetailsTab.Location = new Point(4, 34);
			employeeEmergencyDetailsTab.Name = "employeeEmergencyDetailsTab";
			employeeEmergencyDetailsTab.Padding = new Padding(3);
			employeeEmergencyDetailsTab.Size = new Size(485, 348);
			employeeEmergencyDetailsTab.TabIndex = 1;
			employeeEmergencyDetailsTab.Text = "🚑 Emergency Contact";
			employeeEmergencyDetailsTab.UseVisualStyleBackColor = true;
			// 
			// customButton2
			// 
			customButton2.BackColor = Color.DarkOrange;
			customButton2.BackgroundColor = Color.DarkOrange;
			customButton2.BorderColor = Color.White;
			customButton2.BorderRadius = 15;
			customButton2.BorderSize = 1;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.ForeColor = Color.White;
			customButton2.Location = new Point(164, 277);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(150, 40);
			customButton2.TabIndex = 8;
			customButton2.Text = "Next";
			customButton2.TextColor = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// emcLastNameBox
			// 
			emcLastNameBox.Font = new Font("Segoe UI", 15F);
			emcLastNameBox.Location = new Point(274, 80);
			emcLastNameBox.Name = "emcLastNameBox";
			emcLastNameBox.Size = new Size(154, 34);
			emcLastNameBox.TabIndex = 7;
			// 
			// emcFirstNameBox
			// 
			emcFirstNameBox.Font = new Font("Segoe UI", 15F);
			emcFirstNameBox.Location = new Point(46, 80);
			emcFirstNameBox.Name = "emcFirstNameBox";
			emcFirstNameBox.Size = new Size(154, 34);
			emcFirstNameBox.TabIndex = 6;
			// 
			// emcEmailBox
			// 
			emcEmailBox.Font = new Font("Segoe UI", 15F);
			emcEmailBox.Location = new Point(274, 194);
			emcEmailBox.Name = "emcEmailBox";
			emcEmailBox.Size = new Size(154, 34);
			emcEmailBox.TabIndex = 5;
			emcEmailBox.TextChanged += emcEmailBox_TextChanged;
			// 
			// emcPhoneText
			// 
			emcPhoneText.Font = new Font("Segoe UI", 15F);
			emcPhoneText.Location = new Point(46, 194);
			emcPhoneText.Name = "emcPhoneText";
			emcPhoneText.Size = new Size(154, 34);
			emcPhoneText.TabIndex = 4;
			// 
			// emcEmail
			// 
			emcEmail.AutoSize = true;
			emcEmail.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			emcEmail.Location = new Point(316, 149);
			emcEmail.Name = "emcEmail";
			emcEmail.Size = new Size(64, 28);
			emcEmail.TabIndex = 3;
			emcEmail.Text = "Email";
			// 
			// emcPhoneNum
			// 
			emcPhoneNum.AutoSize = true;
			emcPhoneNum.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			emcPhoneNum.Location = new Point(45, 149);
			emcPhoneNum.Name = "emcPhoneNum";
			emcPhoneNum.Size = new Size(154, 28);
			emcPhoneNum.TabIndex = 2;
			emcPhoneNum.Text = "Phone Number";
			// 
			// emcLastName
			// 
			emcLastName.AutoSize = true;
			emcLastName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			emcLastName.Location = new Point(290, 37);
			emcLastName.Name = "emcLastName";
			emcLastName.Size = new Size(112, 28);
			emcLastName.TabIndex = 1;
			emcLastName.Text = "Last Name";
			// 
			// emcFirstName
			// 
			emcFirstName.AutoSize = true;
			emcFirstName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			emcFirstName.Location = new Point(55, 37);
			emcFirstName.Name = "emcFirstName";
			emcFirstName.Size = new Size(115, 28);
			emcFirstName.TabIndex = 0;
			emcFirstName.Text = "First Name";
			// 
			// employeeDetailsTab
			// 
			employeeDetailsTab.Controls.Add(customButton3);
			employeeDetailsTab.Controls.Add(textBox7);
			employeeDetailsTab.Controls.Add(textBox6);
			employeeDetailsTab.Controls.Add(textBox5);
			employeeDetailsTab.Controls.Add(textBox4);
			employeeDetailsTab.Controls.Add(textBox3);
			employeeDetailsTab.Controls.Add(dateTimePicker2);
			employeeDetailsTab.Controls.Add(personalBirthday);
			employeeDetailsTab.Controls.Add(personalBsn);
			employeeDetailsTab.Controls.Add(personalPassword);
			employeeDetailsTab.Controls.Add(personalEmail);
			employeeDetailsTab.Controls.Add(personalLastName);
			employeeDetailsTab.Controls.Add(personalFirstName);
			employeeDetailsTab.Location = new Point(4, 34);
			employeeDetailsTab.Name = "employeeDetailsTab";
			employeeDetailsTab.Padding = new Padding(3);
			employeeDetailsTab.Size = new Size(485, 348);
			employeeDetailsTab.TabIndex = 2;
			employeeDetailsTab.Text = "👤 Personal Details";
			employeeDetailsTab.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			textBox7.Location = new Point(279, 66);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(170, 33);
			textBox7.TabIndex = 11;
			// 
			// textBox6
			// 
			textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			textBox6.Location = new Point(38, 66);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(173, 33);
			textBox6.TabIndex = 10;
			// 
			// textBox5
			// 
			textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			textBox5.Location = new Point(38, 140);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(173, 33);
			textBox5.TabIndex = 9;
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			textBox4.Location = new Point(272, 140);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(177, 33);
			textBox4.TabIndex = 8;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			textBox3.Location = new Point(38, 221);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(173, 33);
			textBox3.TabIndex = 7;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Font = new Font("Segoe UI", 12F);
			dateTimePicker2.Location = new Point(272, 221);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(184, 29);
			dateTimePicker2.TabIndex = 6;
			// 
			// personalBirthday
			// 
			personalBirthday.AutoSize = true;
			personalBirthday.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			personalBirthday.Location = new Point(313, 193);
			personalBirthday.Name = "personalBirthday";
			personalBirthday.Size = new Size(88, 25);
			personalBirthday.TabIndex = 5;
			personalBirthday.Text = "Birthday";
			// 
			// personalBsn
			// 
			personalBsn.AutoSize = true;
			personalBsn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			personalBsn.Location = new Point(87, 193);
			personalBsn.Name = "personalBsn";
			personalBsn.Size = new Size(50, 25);
			personalBsn.TabIndex = 4;
			personalBsn.Text = "BSN";
			personalBsn.Click += personalBsn_Click;
			// 
			// personalPassword
			// 
			personalPassword.AutoSize = true;
			personalPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			personalPassword.Location = new Point(306, 112);
			personalPassword.Name = "personalPassword";
			personalPassword.Size = new Size(97, 25);
			personalPassword.TabIndex = 3;
			personalPassword.Text = "Password";
			// 
			// personalEmail
			// 
			personalEmail.AutoSize = true;
			personalEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			personalEmail.Location = new Point(87, 112);
			personalEmail.Name = "personalEmail";
			personalEmail.Size = new Size(59, 25);
			personalEmail.TabIndex = 2;
			personalEmail.Text = "Email";
			// 
			// personalLastName
			// 
			personalLastName.AutoSize = true;
			personalLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			personalLastName.Location = new Point(306, 38);
			personalLastName.Name = "personalLastName";
			personalLastName.Size = new Size(104, 25);
			personalLastName.TabIndex = 1;
			personalLastName.Text = "Last Name";
			// 
			// personalFirstName
			// 
			personalFirstName.AutoSize = true;
			personalFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			personalFirstName.Location = new Point(64, 38);
			personalFirstName.Name = "personalFirstName";
			personalFirstName.Size = new Size(107, 25);
			personalFirstName.TabIndex = 0;
			personalFirstName.Text = "First Name";
			// 
			// customButton3
			// 
			customButton3.BackColor = Color.DarkOrange;
			customButton3.BackgroundColor = Color.DarkOrange;
			customButton3.BorderColor = Color.White;
			customButton3.BorderRadius = 15;
			customButton3.BorderSize = 1;
			customButton3.FlatStyle = FlatStyle.Flat;
			customButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			customButton3.ForeColor = Color.White;
			customButton3.Location = new Point(139, 275);
			customButton3.Name = "customButton3";
			customButton3.Size = new Size(219, 54);
			customButton3.TabIndex = 12;
			customButton3.Text = "Complete Form";
			customButton3.TextColor = Color.White;
			customButton3.UseVisualStyleBackColor = false;
			// 
			// AddEmployeeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(518, 410);
			Controls.Add(addEmployeeTabControl);
			Name = "AddEmployeeForm";
			Text = "Add Employee Dialogue";
			addEmployeeTabControl.ResumeLayout(false);
			employeeContractTab.ResumeLayout(false);
			employeeContractTab.PerformLayout();
			employeeEmergencyDetailsTab.ResumeLayout(false);
			employeeEmergencyDetailsTab.PerformLayout();
			employeeDetailsTab.ResumeLayout(false);
			employeeDetailsTab.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl addEmployeeTabControl;
		private TabPage employeeContractTab;
		private TabPage employeeEmergencyDetailsTab;
		private TabPage employeeDetailsTab;
		private Label label4;
		private DateTimePicker dateTimePicker1;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private ComboBox comboBox1;
		private CustomButton customButton1;
		private Label emcFirstName;
		private Label emcEmail;
		private Label emcPhoneNum;
		private Label emcLastName;
		private TextBox emcLastNameBox;
		private TextBox emcFirstNameBox;
		private TextBox emcEmailBox;
		private TextBox emcPhoneText;
		private DateTimePicker dateTimePicker2;
		private Label personalBirthday;
		private Label personalBsn;
		private Label personalPassword;
		private Label personalEmail;
		private Label personalLastName;
		private Label personalFirstName;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private CustomButton customButton2;
		private CustomButton customButton3;
	}
}