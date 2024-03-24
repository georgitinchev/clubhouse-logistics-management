namespace MediaBazaar.Forms
{
    partial class UserControlDashboard
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
			employeeDataGrid = new DataGridView();
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
			vScrollBar = new VScrollBar();
			pictureBoxSearch = new PictureBox();
			comboBoxDepartment = new ComboBox();
			textBoxSearch = new TextBox();
			((System.ComponentModel.ISupportInitialize)employeeDataGrid).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
			SuspendLayout();
			// 
			// employeeDataGrid
			// 
			employeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			employeeDataGrid.Location = new Point(27, 114);
			employeeDataGrid.Margin = new Padding(3, 2, 3, 2);
			employeeDataGrid.Name = "employeeDataGrid";
			employeeDataGrid.RowHeadersWidth = 51;
			employeeDataGrid.Size = new Size(803, 361);
			employeeDataGrid.TabIndex = 22;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.OrangeRed;
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
			groupBox1.Location = new Point(887, 51);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(300, 436);
			groupBox1.TabIndex = 21;
			groupBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.DimGray;
			pictureBox2.Location = new Point(18, 52);
			pictureBox2.Margin = new Padding(3, 2, 3, 2);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(254, 2);
			pictureBox2.TabIndex = 25;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DimGray;
			label2.Location = new Point(50, 36);
			label2.Name = "label2";
			label2.Size = new Size(96, 15);
			label2.TabIndex = 26;
			label2.Text = "Employee details";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.OrangeRed;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(5, 22);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(53, 29);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 25;
			pictureBox1.TabStop = false;
			// 
			// textBoxEmail
			// 
			textBoxEmail.BackColor = SystemColors.ControlDark;
			textBoxEmail.Location = new Point(102, 155);
			textBoxEmail.Margin = new Padding(3, 2, 3, 2);
			textBoxEmail.Name = "textBoxEmail";
			textBoxEmail.ReadOnly = true;
			textBoxEmail.Size = new Size(169, 23);
			textBoxEmail.TabIndex = 20;
			// 
			// textBoxSurname
			// 
			textBoxSurname.BackColor = SystemColors.ControlDark;
			textBoxSurname.Location = new Point(102, 98);
			textBoxSurname.Margin = new Padding(3, 2, 3, 2);
			textBoxSurname.Name = "textBoxSurname";
			textBoxSurname.ReadOnly = true;
			textBoxSurname.Size = new Size(169, 23);
			textBoxSurname.TabIndex = 19;
			// 
			// textBoxName
			// 
			textBoxName.BackColor = SystemColors.ControlDark;
			textBoxName.Location = new Point(102, 71);
			textBoxName.Margin = new Padding(3, 2, 3, 2);
			textBoxName.Name = "textBoxName";
			textBoxName.ReadOnly = true;
			textBoxName.Size = new Size(169, 23);
			textBoxName.TabIndex = 18;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 154);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
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
			comboBoxRole.ItemHeight = 15;
			comboBoxRole.Items.AddRange(new object[] { "Security Guard" });
			comboBoxRole.Location = new Point(102, 127);
			comboBoxRole.Margin = new Padding(3, 2, 3, 2);
			comboBoxRole.Name = "comboBoxRole";
			comboBoxRole.Size = new Size(169, 23);
			comboBoxRole.TabIndex = 16;
			comboBoxRole.Text = "HR Manager";
			// 
			// lblRole
			// 
			lblRole.AutoSize = true;
			lblRole.Location = new Point(14, 127);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(33, 15);
			lblRole.TabIndex = 2;
			lblRole.Text = "Role:";
			// 
			// lblSurname
			// 
			lblSurname.AutoSize = true;
			lblSurname.Location = new Point(14, 99);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(57, 15);
			lblSurname.TabIndex = 1;
			lblSurname.Text = "Surname:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(15, 70);
			lblName.Name = "lblName";
			lblName.Size = new Size(42, 15);
			lblName.TabIndex = 0;
			lblName.Text = "Name:";
			// 
			// vScrollBar
			// 
			vScrollBar.Location = new Point(831, 114);
			vScrollBar.Name = "vScrollBar";
			vScrollBar.Size = new Size(26, 360);
			vScrollBar.TabIndex = 20;
			// 
			// pictureBoxSearch
			// 
			pictureBoxSearch.BackColor = Color.White;
			pictureBoxSearch.Image = Properties.Resources.search_icon;
			pictureBoxSearch.Location = new Point(314, 70);
			pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
			pictureBoxSearch.Name = "pictureBoxSearch";
			pictureBoxSearch.Size = new Size(18, 16);
			pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSearch.TabIndex = 19;
			pictureBoxSearch.TabStop = false;
			// 
			// comboBoxDepartment
			// 
			comboBoxDepartment.DropDownHeight = 108;
			comboBoxDepartment.FormattingEnabled = true;
			comboBoxDepartment.IntegralHeight = false;
			comboBoxDepartment.ItemHeight = 15;
			comboBoxDepartment.Location = new Point(346, 69);
			comboBoxDepartment.Margin = new Padding(3, 2, 3, 2);
			comboBoxDepartment.Name = "comboBoxDepartment";
			comboBoxDepartment.Size = new Size(251, 23);
			comboBoxDepartment.TabIndex = 18;
			comboBoxDepartment.Text = "Department";
			// 
			// textBoxSearch
			// 
			textBoxSearch.Location = new Point(27, 69);
			textBoxSearch.Margin = new Padding(3, 2, 3, 2);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(313, 23);
			textBoxSearch.TabIndex = 17;
			textBoxSearch.Text = "Search";
			// 
			// UserControlDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(employeeDataGrid);
			Controls.Add(groupBox1);
			Controls.Add(vScrollBar);
			Controls.Add(pictureBoxSearch);
			Controls.Add(comboBoxDepartment);
			Controls.Add(textBoxSearch);
			Name = "UserControlDashboard";
			Size = new Size(1190, 559);
			((System.ComponentModel.ISupportInitialize)employeeDataGrid).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView employeeDataGrid;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblSurname;
        private Label lblName;
        private VScrollBar vScrollBar;
        private PictureBox pictureBoxSearch;
        private ComboBox comboBoxDepartment;
        private TextBox textBoxSearch;
        private CustomButton btnRemoveEmployee;
        private CustomButton btnEditEmployee;
    }
}
