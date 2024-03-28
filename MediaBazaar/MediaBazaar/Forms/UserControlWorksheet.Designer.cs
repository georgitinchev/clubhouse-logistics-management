namespace MediaBazaar.Forms
{
    partial class UserControlWorksheet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWorksheet));
			btnRemoveWorksheet = new CustomButton();
			btnAddWorksheet = new CustomButton();
			employeeWorksheetGrid = new DataGridView();
			groupBox1 = new GroupBox();
			cbStatus = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			cbShift = new ComboBox();
			lbDate = new Label();
			lbShift = new Label();
			label6 = new Label();
			pictureBox2 = new PictureBox();
			worksheetDetailsLabel = new Label();
			userPictureBox = new PictureBox();
			textBoxName = new TextBox();
			comboBoxRole = new ComboBox();
			lblRole = new Label();
			lblName = new Label();
			textBoxSearch = new TextBox();
			comboBoxDepartment = new ComboBox();
			pictureBoxSearch = new PictureBox();
			((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
			SuspendLayout();
			// 
			// btnRemoveWorksheet
			// 
			btnRemoveWorksheet.BackColor = Color.DarkOrange;
			btnRemoveWorksheet.BackgroundColor = Color.DarkOrange;
			btnRemoveWorksheet.BorderColor = Color.White;
			btnRemoveWorksheet.BorderRadius = 15;
			btnRemoveWorksheet.BorderSize = 2;
			btnRemoveWorksheet.FlatStyle = FlatStyle.Flat;
			btnRemoveWorksheet.ForeColor = Color.White;
			btnRemoveWorksheet.Location = new Point(66, 605);
			btnRemoveWorksheet.Margin = new Padding(4, 5, 4, 5);
			btnRemoveWorksheet.Name = "btnRemoveWorksheet";
			btnRemoveWorksheet.Size = new Size(321, 67);
			btnRemoveWorksheet.TabIndex = 24;
			btnRemoveWorksheet.Text = "Remove Worksheet";
			btnRemoveWorksheet.TextColor = Color.White;
			btnRemoveWorksheet.UseVisualStyleBackColor = false;
			// 
			// btnAddWorksheet
			// 
			btnAddWorksheet.BackColor = Color.DarkOrange;
			btnAddWorksheet.BackgroundColor = Color.DarkOrange;
			btnAddWorksheet.BorderColor = Color.White;
			btnAddWorksheet.BorderRadius = 15;
			btnAddWorksheet.BorderSize = 2;
			btnAddWorksheet.FlatStyle = FlatStyle.Flat;
			btnAddWorksheet.ForeColor = Color.White;
			btnAddWorksheet.Location = new Point(67, 528);
			btnAddWorksheet.Margin = new Padding(4, 5, 4, 5);
			btnAddWorksheet.Name = "btnAddWorksheet";
			btnAddWorksheet.Size = new Size(321, 67);
			btnAddWorksheet.TabIndex = 23;
			btnAddWorksheet.Text = "Add Worksheet";
			btnAddWorksheet.TextColor = Color.White;
			btnAddWorksheet.UseVisualStyleBackColor = false;
			// 
			// employeeWorksheetGrid
			// 
			employeeWorksheetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			employeeWorksheetGrid.Location = new Point(59, 190);
			employeeWorksheetGrid.Margin = new Padding(4, 3, 4, 3);
			employeeWorksheetGrid.Name = "employeeWorksheetGrid";
			employeeWorksheetGrid.RowHeadersWidth = 51;
			employeeWorksheetGrid.Size = new Size(1147, 602);
			employeeWorksheetGrid.TabIndex = 22;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.OrangeRed;
			groupBox1.Controls.Add(cbStatus);
			groupBox1.Controls.Add(dateTimePicker1);
			groupBox1.Controls.Add(cbShift);
			groupBox1.Controls.Add(lbDate);
			groupBox1.Controls.Add(lbShift);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(pictureBox2);
			groupBox1.Controls.Add(btnRemoveWorksheet);
			groupBox1.Controls.Add(worksheetDetailsLabel);
			groupBox1.Controls.Add(btnAddWorksheet);
			groupBox1.Controls.Add(userPictureBox);
			groupBox1.Controls.Add(textBoxName);
			groupBox1.Controls.Add(comboBoxRole);
			groupBox1.Controls.Add(lblRole);
			groupBox1.Controls.Add(lblName);
			groupBox1.Location = new Point(1267, 85);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(429, 727);
			groupBox1.TabIndex = 25;
			groupBox1.TabStop = false;
			// 
			// cbStatus
			// 
			cbStatus.FormattingEnabled = true;
			cbStatus.Location = new Point(146, 323);
			cbStatus.Margin = new Padding(4, 5, 4, 5);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(241, 33);
			cbStatus.TabIndex = 40;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(146, 218);
			dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(240, 31);
			dateTimePicker1.TabIndex = 39;
			// 
			// cbShift
			// 
			cbShift.FormattingEnabled = true;
			cbShift.Location = new Point(146, 273);
			cbShift.Margin = new Padding(4, 5, 4, 5);
			cbShift.Name = "cbShift";
			cbShift.Size = new Size(240, 33);
			cbShift.TabIndex = 38;
			// 
			// lbDate
			// 
			lbDate.AutoSize = true;
			lbDate.Location = new Point(20, 228);
			lbDate.Margin = new Padding(4, 0, 4, 0);
			lbDate.Name = "lbDate";
			lbDate.Size = new Size(53, 25);
			lbDate.TabIndex = 37;
			lbDate.Text = "Date:";
			// 
			// lbShift
			// 
			lbShift.AutoSize = true;
			lbShift.Location = new Point(20, 278);
			lbShift.Margin = new Padding(4, 0, 4, 0);
			lbShift.Name = "lbShift";
			lbShift.Size = new Size(52, 25);
			lbShift.TabIndex = 36;
			lbShift.Text = "Shift:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(20, 328);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(64, 25);
			label6.TabIndex = 31;
			label6.Text = "Status:";
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.DimGray;
			pictureBox2.Location = new Point(26, 87);
			pictureBox2.Margin = new Padding(4, 3, 4, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(363, 3);
			pictureBox2.TabIndex = 25;
			pictureBox2.TabStop = false;
			// 
			// worksheetDetailsLabel
			// 
			worksheetDetailsLabel.AutoSize = true;
			worksheetDetailsLabel.BackColor = Color.Transparent;
			worksheetDetailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			worksheetDetailsLabel.ForeColor = Color.Black;
			worksheetDetailsLabel.Location = new Point(67, 58);
			worksheetDetailsLabel.Margin = new Padding(4, 0, 4, 0);
			worksheetDetailsLabel.Name = "worksheetDetailsLabel";
			worksheetDetailsLabel.Size = new Size(161, 25);
			worksheetDetailsLabel.TabIndex = 26;
			worksheetDetailsLabel.Text = "Worksheet details";
			// 
			// userPictureBox
			// 
			userPictureBox.BackColor = Color.OrangeRed;
			userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
			userPictureBox.Location = new Point(7, 37);
			userPictureBox.Margin = new Padding(4, 3, 4, 3);
			userPictureBox.Name = "userPictureBox";
			userPictureBox.Size = new Size(76, 48);
			userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			userPictureBox.TabIndex = 25;
			userPictureBox.TabStop = false;
			// 
			// textBoxName
			// 
			textBoxName.BackColor = SystemColors.ControlDark;
			textBoxName.Location = new Point(146, 118);
			textBoxName.Margin = new Padding(4, 3, 4, 3);
			textBoxName.Name = "textBoxName";
			textBoxName.ReadOnly = true;
			textBoxName.Size = new Size(240, 31);
			textBoxName.TabIndex = 18;
			// 
			// comboBoxRole
			// 
			comboBoxRole.BackColor = SystemColors.Control;
			comboBoxRole.DropDownHeight = 108;
			comboBoxRole.Enabled = false;
			comboBoxRole.FormattingEnabled = true;
			comboBoxRole.IntegralHeight = false;
			comboBoxRole.ItemHeight = 25;
			comboBoxRole.Items.AddRange(new object[] { "Security Guard" });
			comboBoxRole.Location = new Point(146, 168);
			comboBoxRole.Margin = new Padding(4, 3, 4, 3);
			comboBoxRole.Name = "comboBoxRole";
			comboBoxRole.Size = new Size(240, 33);
			comboBoxRole.TabIndex = 16;
			comboBoxRole.Text = "HR Manager";
			// 
			// lblRole
			// 
			lblRole.AutoSize = true;
			lblRole.Location = new Point(21, 173);
			lblRole.Margin = new Padding(4, 0, 4, 0);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(50, 25);
			lblRole.TabIndex = 2;
			lblRole.Text = "Role:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(21, 123);
			lblName.Margin = new Padding(4, 0, 4, 0);
			lblName.Name = "lblName";
			lblName.Size = new Size(63, 25);
			lblName.TabIndex = 0;
			lblName.Text = "Name:";
			// 
			// textBoxSearch
			// 
			textBoxSearch.Cursor = Cursors.IBeam;
			textBoxSearch.Location = new Point(59, 123);
			textBoxSearch.Margin = new Padding(4, 3, 4, 3);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(445, 31);
			textBoxSearch.TabIndex = 26;
			textBoxSearch.Text = "Search...";
			// 
			// comboBoxDepartment
			// 
			comboBoxDepartment.Cursor = Cursors.Hand;
			comboBoxDepartment.DropDownHeight = 108;
			comboBoxDepartment.FormattingEnabled = true;
			comboBoxDepartment.IntegralHeight = false;
			comboBoxDepartment.ItemHeight = 25;
			comboBoxDepartment.Items.AddRange(new object[] { "HR Manager", "Sales Representative", "Support", "Cashier", "Security Guard", "Depot Worker" });
			comboBoxDepartment.Location = new Point(539, 123);
			comboBoxDepartment.Margin = new Padding(4, 3, 4, 3);
			comboBoxDepartment.Name = "comboBoxDepartment";
			comboBoxDepartment.Size = new Size(381, 33);
			comboBoxDepartment.TabIndex = 27;
			comboBoxDepartment.Text = "Role";
			// 
			// pictureBoxSearch
			// 
			pictureBoxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pictureBoxSearch.BackColor = Color.White;
			pictureBoxSearch.Cursor = Cursors.Hand;
			pictureBoxSearch.Image = Properties.Resources.search_icon;
			pictureBoxSearch.Location = new Point(476, 122);
			pictureBoxSearch.Margin = new Padding(4, 3, 4, 3);
			pictureBoxSearch.Name = "pictureBoxSearch";
			pictureBoxSearch.Size = new Size(30, 38);
			pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSearch.TabIndex = 28;
			pictureBoxSearch.TabStop = false;
			// 
			// UserControlWorksheet
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pictureBoxSearch);
			Controls.Add(comboBoxDepartment);
			Controls.Add(textBoxSearch);
			Controls.Add(groupBox1);
			Controls.Add(employeeWorksheetGrid);
			Margin = new Padding(4, 5, 4, 5);
			Name = "UserControlWorksheet";
			Size = new Size(1700, 932);
			((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CustomButton btnRemoveWorksheet;
        private CustomButton btnAddWorksheet;
        private DataGridView employeeWorksheetGrid;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label worksheetDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxName;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblName;
        private TextBox textBoxSearch;
        private ComboBox comboBoxDepartment;
        private PictureBox pictureBoxSearch;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbShift;
        private Label lbDate;
        private Label lbShift;
        private ComboBox cbStatus;
    }
}
