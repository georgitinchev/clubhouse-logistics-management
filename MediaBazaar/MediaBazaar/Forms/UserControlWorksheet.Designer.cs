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
            btnUnassignWorksheet = new CustomButton();
            btnAddWorksheet = new CustomButton();
            employeeWorksheetGrid = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxName = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbShift = new ComboBox();
            lbDate = new Label();
            lbShift = new Label();
            pictureBox2 = new PictureBox();
            worksheetDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            comboBoxRole = new ComboBox();
            lblRole = new Label();
            lblName = new Label();
            assignUnassignGroup = new GroupBox();
            btnRemoveWorksheet = new CustomButton();
            btnAssignWorksheet = new CustomButton();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            cbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            assignUnassignGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // btnUnassignWorksheet
            // 
            btnUnassignWorksheet.BackColor = Color.DarkOrange;
            btnUnassignWorksheet.BackgroundColor = Color.DarkOrange;
            btnUnassignWorksheet.BorderColor = Color.White;
            btnUnassignWorksheet.BorderRadius = 15;
            btnUnassignWorksheet.BorderSize = 2;
            btnUnassignWorksheet.FlatStyle = FlatStyle.Flat;
            btnUnassignWorksheet.ForeColor = Color.White;
            btnUnassignWorksheet.Location = new Point(24, 145);
            btnUnassignWorksheet.Margin = new Padding(4, 3, 4, 3);
            btnUnassignWorksheet.Name = "btnUnassignWorksheet";
            btnUnassignWorksheet.Size = new Size(409, 83);
            btnUnassignWorksheet.TabIndex = 24;
            btnUnassignWorksheet.Text = "Unassign Worksheet";
            btnUnassignWorksheet.TextColor = Color.White;
            btnUnassignWorksheet.UseVisualStyleBackColor = false;
            btnUnassignWorksheet.Click += btnUnassignedWorksheet_Click_1;
            // 
            // btnAddWorksheet
            // 
            btnAddWorksheet.BackColor = Color.DarkOrange;
            btnAddWorksheet.BackgroundColor = Color.DarkOrange;
            btnAddWorksheet.BorderColor = Color.White;
            btnAddWorksheet.BorderRadius = 15;
            btnAddWorksheet.BorderSize = 2;
            btnAddWorksheet.FlatStyle = FlatStyle.Flat;
            btnAddWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWorksheet.ForeColor = Color.White;
            btnAddWorksheet.Location = new Point(1279, 143);
            btnAddWorksheet.Margin = new Padding(4, 5, 4, 5);
            btnAddWorksheet.Name = "btnAddWorksheet";
            btnAddWorksheet.Size = new Size(281, 68);
            btnAddWorksheet.TabIndex = 23;
            btnAddWorksheet.Text = "Add Worksheet";
            btnAddWorksheet.TextColor = Color.White;
            btnAddWorksheet.UseVisualStyleBackColor = false;
            btnAddWorksheet.Click += btnAddWorksheet_Click_1;
            // 
            // employeeWorksheetGrid
            // 
            employeeWorksheetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeWorksheetGrid.Location = new Point(44, 233);
            employeeWorksheetGrid.Margin = new Padding(4, 3, 4, 3);
            employeeWorksheetGrid.Name = "employeeWorksheetGrid";
            employeeWorksheetGrid.RowHeadersWidth = 51;
            employeeWorksheetGrid.Size = new Size(1516, 940);
            employeeWorksheetGrid.TabIndex = 22;
            employeeWorksheetGrid.CellClick += employeeWorksheetGrid_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cbShift);
            groupBox1.Controls.Add(lbDate);
            groupBox1.Controls.Add(lbShift);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(worksheetDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(assignUnassignGroup);
            groupBox1.Location = new Point(1604, 85);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(537, 1088);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11.25F);
            textBoxName.FormattingEnabled = true;
            textBoxName.Location = new Point(146, 117);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(338, 39);
            textBoxName.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(146, 268);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(338, 37);
            dateTimePicker1.TabIndex = 39;
            // 
            // cbShift
            // 
            cbShift.Font = new Font("Segoe UI", 11.25F);
            cbShift.FormattingEnabled = true;
            cbShift.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            cbShift.Location = new Point(146, 352);
            cbShift.Margin = new Padding(4, 5, 4, 5);
            cbShift.Name = "cbShift";
            cbShift.Size = new Size(338, 39);
            cbShift.TabIndex = 38;
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Segoe UI", 11.25F);
            lbDate.Location = new Point(69, 277);
            lbDate.Margin = new Padding(4, 0, 4, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(69, 30);
            lbDate.TabIndex = 37;
            lbDate.Text = "Date:";
            // 
            // lbShift
            // 
            lbShift.Font = new Font("Segoe UI", 11.25F);
            lbShift.Location = new Point(73, 363);
            lbShift.Margin = new Padding(4, 0, 4, 0);
            lbShift.Name = "lbShift";
            lbShift.Size = new Size(69, 35);
            lbShift.TabIndex = 36;
            lbShift.Text = "Shift:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(26, 87);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 3);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // worksheetDetailsLabel
            // 
            worksheetDetailsLabel.AutoSize = true;
            worksheetDetailsLabel.BackColor = Color.Transparent;
            worksheetDetailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            worksheetDetailsLabel.ForeColor = Color.Black;
            worksheetDetailsLabel.Location = new Point(69, 58);
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
            userPictureBox.Location = new Point(9, 37);
            userPictureBox.Margin = new Padding(4, 3, 4, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(76, 48);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 25;
            userPictureBox.TabStop = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = SystemColors.Control;
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.Font = new Font("Segoe UI", 11.25F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 31;
            comboBoxRole.Items.AddRange(new object[] { "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            comboBoxRole.Location = new Point(146, 192);
            comboBoxRole.Margin = new Padding(4, 3, 4, 3);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(338, 39);
            comboBoxRole.TabIndex = 16;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 11.25F);
            lblRole.Location = new Point(69, 197);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(60, 35);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11.25F);
            lblName.Location = new Point(26, 123);
            lblName.Margin = new Padding(1, 0, 1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 40);
            lblName.TabIndex = 0;
            lblName.Text = "Employee:";
            // 
            // assignUnassignGroup
            // 
            assignUnassignGroup.Controls.Add(btnRemoveWorksheet);
            assignUnassignGroup.Controls.Add(btnAssignWorksheet);
            assignUnassignGroup.Controls.Add(btnUnassignWorksheet);
            assignUnassignGroup.Font = new Font("Segoe UI", 11.25F);
            assignUnassignGroup.Location = new Point(53, 683);
            assignUnassignGroup.Name = "assignUnassignGroup";
            assignUnassignGroup.Size = new Size(451, 370);
            assignUnassignGroup.TabIndex = 44;
            assignUnassignGroup.TabStop = false;
            assignUnassignGroup.Text = "Assignation";
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
            btnRemoveWorksheet.Location = new Point(24, 255);
            btnRemoveWorksheet.Margin = new Padding(4, 5, 4, 5);
            btnRemoveWorksheet.Name = "btnRemoveWorksheet";
            btnRemoveWorksheet.Size = new Size(409, 83);
            btnRemoveWorksheet.TabIndex = 43;
            btnRemoveWorksheet.Text = "Remove Worksheet";
            btnRemoveWorksheet.TextColor = Color.White;
            btnRemoveWorksheet.UseVisualStyleBackColor = false;
            btnRemoveWorksheet.Click += btnRemoveWorksheet_Click;
            // 
            // btnAssignWorksheet
            // 
            btnAssignWorksheet.BackColor = Color.DarkOrange;
            btnAssignWorksheet.BackgroundColor = Color.DarkOrange;
            btnAssignWorksheet.BorderColor = Color.White;
            btnAssignWorksheet.BorderRadius = 15;
            btnAssignWorksheet.BorderSize = 2;
            btnAssignWorksheet.FlatStyle = FlatStyle.Flat;
            btnAssignWorksheet.ForeColor = Color.White;
            btnAssignWorksheet.Location = new Point(24, 40);
            btnAssignWorksheet.Margin = new Padding(4, 3, 4, 3);
            btnAssignWorksheet.Name = "btnAssignWorksheet";
            btnAssignWorksheet.Size = new Size(409, 83);
            btnAssignWorksheet.TabIndex = 24;
            btnAssignWorksheet.Text = "Assign Worksheet";
            btnAssignWorksheet.TextColor = Color.White;
            btnAssignWorksheet.UseVisualStyleBackColor = false;
            btnAssignWorksheet.Click += btnAssignWorksheet_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(44, 147);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(713, 39);
            textBoxSearch.TabIndex = 26;
            textBoxSearch.Text = "Search...";
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(753, 143);
            pictureBoxSearch.Margin = new Padding(4, 3, 4, 3);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(60, 53);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 28;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // cbFilter
            // 
            cbFilter.Cursor = Cursors.Hand;
            cbFilter.DropDownHeight = 108;
            cbFilter.Font = new Font("Segoe UI", 11.25F);
            cbFilter.FormattingEnabled = true;
            cbFilter.IntegralHeight = false;
            cbFilter.ItemHeight = 31;
            cbFilter.Items.AddRange(new object[] { "Any Role", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            cbFilter.Location = new Point(844, 153);
            cbFilter.Margin = new Padding(4, 5, 4, 5);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(397, 39);
            cbFilter.TabIndex = 29;
            cbFilter.Text = "Choose Role";
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // UserControlWorksheet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbFilter);
            Controls.Add(btnAddWorksheet);
            Controls.Add(pictureBoxSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(groupBox1);
            Controls.Add(employeeWorksheetGrid);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserControlWorksheet";
            Size = new Size(2141, 1217);
            ((System.ComponentModel.ISupportInitialize)employeeWorksheetGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            assignUnassignGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton btnUnassignWorksheet;
        private CustomButton btnAddWorksheet;
        private DataGridView employeeWorksheetGrid;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label worksheetDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxEmployee;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblName;
        private TextBox textBoxSearch;
        private ComboBox comboBoxRoleWorksheet;
        private PictureBox pictureBoxSearch;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbShift;
        private Label lbDate;
        private Label lbShift;
        private CustomButton btnAssignWorksheet;
        private CustomButton btnRemoveWorksheet;
        private GroupBox assignUnassignGroup;
        private ComboBox cbFilter;
        private ComboBox textBoxName;
    }
}
