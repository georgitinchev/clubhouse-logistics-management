﻿namespace MediaBazaar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBoxJupiter = new PictureBox();
			pictureBoxLogo = new PictureBox();
			bindingSource1 = new BindingSource(components);
			textBoxSearch = new TextBox();
			comboBoxDepartment = new ComboBox();
			pictureBoxSearch = new PictureBox();
			vScrollBar = new VScrollBar();
			groupBox1 = new GroupBox();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			textBoxEmail = new TextBox();
			textBoxSurname = new TextBox();
			textBoxName = new TextBox();
			label1 = new Label();
			comboBoxRole = new ComboBox();
			lblRole = new Label();
			lblSurname = new Label();
			lblName = new Label();
			panel1 = new Panel();
			btnWorksheetManagement = new Button();
			btnEmployeeManagement = new Button();
			lineWorksheet = new PictureBox();
			lineEmployee = new PictureBox();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)lineWorksheet).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineEmployee).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// pictureBoxJupiter
			// 
			pictureBoxJupiter.BackColor = SystemColors.ButtonShadow;
			pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
			pictureBoxJupiter.Location = new Point(29, -5);
			pictureBoxJupiter.Name = "pictureBoxJupiter";
			pictureBoxJupiter.Size = new Size(177, 73);
			pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxJupiter.TabIndex = 2;
			pictureBoxJupiter.TabStop = false;
			// 
			// pictureBoxLogo
			// 
			pictureBoxLogo.BackColor = SystemColors.ButtonShadow;
			pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
			pictureBoxLogo.Location = new Point(688, 11);
			pictureBoxLogo.Name = "pictureBoxLogo";
			pictureBoxLogo.Size = new Size(61, 61);
			pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxLogo.TabIndex = 3;
			pictureBoxLogo.TabStop = false;
			// 
			// textBoxSearch
			// 
			textBoxSearch.Location = new Point(41, 92);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(357, 27);
			textBoxSearch.TabIndex = 9;
			textBoxSearch.Text = "Search";
			// 
			// comboBoxDepartment
			// 
			comboBoxDepartment.DropDownHeight = 108;
			comboBoxDepartment.FormattingEnabled = true;
			comboBoxDepartment.IntegralHeight = false;
			comboBoxDepartment.ItemHeight = 20;
			comboBoxDepartment.Location = new Point(406, 92);
			comboBoxDepartment.Name = "comboBoxDepartment";
			comboBoxDepartment.Size = new Size(286, 28);
			comboBoxDepartment.TabIndex = 10;
			comboBoxDepartment.Text = "Department";
			// 
			// pictureBoxSearch
			// 
			pictureBoxSearch.BackColor = Color.White;
			pictureBoxSearch.Image = Properties.Resources.search_icon;
			pictureBoxSearch.Location = new Point(369, 93);
			pictureBoxSearch.Name = "pictureBoxSearch";
			pictureBoxSearch.Size = new Size(21, 21);
			pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSearch.TabIndex = 11;
			pictureBoxSearch.TabStop = false;
			// 
			// vScrollBar
			// 
			vScrollBar.Location = new Point(960, 152);
			vScrollBar.Name = "vScrollBar";
			vScrollBar.Size = new Size(26, 480);
			vScrollBar.TabIndex = 13;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(pictureBox2);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(textBoxEmail);
			groupBox1.Controls.Add(textBoxSurname);
			groupBox1.Controls.Add(textBoxName);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(comboBoxRole);
			groupBox1.Controls.Add(lblRole);
			groupBox1.Controls.Add(lblSurname);
			groupBox1.Controls.Add(lblName);
			groupBox1.Location = new Point(1015, 83);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(326, 551);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Enter += groupBox1_Enter;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.DimGray;
			pictureBox2.Location = new Point(21, 69);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(290, 3);
			pictureBox2.TabIndex = 25;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DimGray;
			label2.Location = new Point(57, 49);
			label2.Name = "label2";
			label2.Size = new Size(124, 20);
			label2.TabIndex = 26;
			label2.Text = "Employee details";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.Control;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(6, 29);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(61, 39);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 25;
			pictureBox1.TabStop = false;
			// 
			// textBoxEmail
			// 
			textBoxEmail.BackColor = SystemColors.ControlDark;
			textBoxEmail.Location = new Point(117, 207);
			textBoxEmail.Name = "textBoxEmail";
			textBoxEmail.ReadOnly = true;
			textBoxEmail.Size = new Size(193, 27);
			textBoxEmail.TabIndex = 20;
			// 
			// textBoxSurname
			// 
			textBoxSurname.BackColor = SystemColors.ControlDark;
			textBoxSurname.Location = new Point(117, 131);
			textBoxSurname.Name = "textBoxSurname";
			textBoxSurname.ReadOnly = true;
			textBoxSurname.Size = new Size(193, 27);
			textBoxSurname.TabIndex = 19;
			// 
			// textBoxName
			// 
			textBoxName.BackColor = SystemColors.ControlDark;
			textBoxName.Location = new Point(117, 95);
			textBoxName.Name = "textBoxName";
			textBoxName.ReadOnly = true;
			textBoxName.Size = new Size(193, 27);
			textBoxName.TabIndex = 18;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 207);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 17;
			label1.Text = "Email:";
			// 
			// comboBoxRole
			// 
			comboBoxRole.BackColor = SystemColors.Control;
			comboBoxRole.DropDownHeight = 108;
			comboBoxRole.Enabled = false;
			comboBoxRole.FormattingEnabled = true;
			comboBoxRole.IntegralHeight = false;
			comboBoxRole.ItemHeight = 20;
			comboBoxRole.Items.AddRange(new object[] { "Security Guard" });
			comboBoxRole.Location = new Point(117, 169);
			comboBoxRole.Name = "comboBoxRole";
			comboBoxRole.Size = new Size(193, 28);
			comboBoxRole.TabIndex = 16;
			comboBoxRole.Text = "HR Manager";
			// 
			// lblRole
			// 
			lblRole.AutoSize = true;
			lblRole.Location = new Point(16, 171);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(42, 20);
			lblRole.TabIndex = 2;
			lblRole.Text = "Role:";
			// 
			// lblSurname
			// 
			lblSurname.AutoSize = true;
			lblSurname.Location = new Point(16, 133);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(70, 20);
			lblSurname.TabIndex = 1;
			lblSurname.Text = "Surname:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(17, 95);
			lblName.Name = "lblName";
			lblName.Size = new Size(52, 20);
			lblName.TabIndex = 0;
			lblName.Text = "Name:";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ButtonShadow;
			panel1.Controls.Add(btnWorksheetManagement);
			panel1.Controls.Add(btnEmployeeManagement);
			panel1.Controls.Add(lineWorksheet);
			panel1.Controls.Add(lineEmployee);
			panel1.Controls.Add(pictureBoxLogo);
			panel1.Location = new Point(-2, -3);
			panel1.Name = "panel1";
			panel1.Size = new Size(1360, 81);
			panel1.TabIndex = 15;
			// 
			// btnWorksheetManagement
			// 
			btnWorksheetManagement.Location = new Point(767, 17);
			btnWorksheetManagement.Margin = new Padding(3, 4, 3, 4);
			btnWorksheetManagement.Name = "btnWorksheetManagement";
			btnWorksheetManagement.Size = new Size(168, 31);
			btnWorksheetManagement.TabIndex = 26;
			btnWorksheetManagement.Text = "Worksheet Management";
			btnWorksheetManagement.UseVisualStyleBackColor = true;
			// 
			// btnEmployeeManagement
			// 
			btnEmployeeManagement.Location = new Point(498, 17);
			btnEmployeeManagement.Margin = new Padding(3, 4, 3, 4);
			btnEmployeeManagement.Name = "btnEmployeeManagement";
			btnEmployeeManagement.Size = new Size(171, 31);
			btnEmployeeManagement.TabIndex = 25;
			btnEmployeeManagement.Text = "Employee Management";
			btnEmployeeManagement.UseVisualStyleBackColor = true;
			// 
			// lineWorksheet
			// 
			lineWorksheet.BackColor = Color.FromArgb(255, 128, 0);
			lineWorksheet.Location = new Point(763, 55);
			lineWorksheet.Name = "lineWorksheet";
			lineWorksheet.Size = new Size(171, 3);
			lineWorksheet.TabIndex = 24;
			lineWorksheet.TabStop = false;
			// 
			// lineEmployee
			// 
			lineEmployee.BackColor = Color.FromArgb(255, 128, 0);
			lineEmployee.Location = new Point(498, 55);
			lineEmployee.Name = "lineEmployee";
			lineEmployee.Size = new Size(171, 3);
			lineEmployee.TabIndex = 20;
			lineEmployee.TabStop = false;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(41, 152);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(918, 481);
			dataGridView1.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1353, 641);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox1);
			Controls.Add(vScrollBar);
			Controls.Add(pictureBoxSearch);
			Controls.Add(comboBoxDepartment);
			Controls.Add(textBoxSearch);
			Controls.Add(pictureBoxJupiter);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Media Bazaar Managment";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)lineWorksheet).EndInit();
			((System.ComponentModel.ISupportInitialize)lineEmployee).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBoxJupiter;
        private PictureBox pictureBoxLogo;
        private BindingSource bindingSource1;
        private TextBox textBoxSearch;
        private ComboBox comboBoxDepartment;
        private PictureBox pictureBoxSearch;
        private VScrollBar vScrollBar;
        private GroupBox groupBox1;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblSurname;
        private Label lblName;
        private Panel panel1;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridView1;
        private CustomButton btnAddEmployee;
        private PictureBox lineEmployee;
        private CustomButton btnEmployeeManagment;
        private CustomButton customButton1;
        private PictureBox lineWorksheet;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private CustomButton btnEditEmployee;
        private CustomButton btnRemoveEmployee;
        private Button btnWorksheetManagement;
        private Button btnEmployeeManagement;
    }
}
