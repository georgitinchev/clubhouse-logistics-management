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
            userDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePickerBirthday = new DateTimePicker();
            label5 = new Label();
            textBoxAddress = new TextBox();
            label6 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            textBoxBSN = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            comboBoxRoleDetails = new ComboBox();
            removeEmployeeBtn = new CustomButton();
            editEmployeeBtn = new CustomButton();
            pictureBox2 = new PictureBox();
            employeeDetailsLabel = new Label();
            userPictureBox = new PictureBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            lblRole = new Label();
            lblName = new Label();
            pictureBoxSearch = new PictureBox();
            comboBoxRole = new ComboBox();
            textBoxSearch = new TextBox();
            addEmployeeBtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(41, 114);
            userDataGridView.Margin = new Padding(3, 2, 3, 2);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(803, 373);
            userDataGridView.TabIndex = 22;
            userDataGridView.CellClick += userDataGridView_CellClick;
            userDataGridView.SelectionChanged += userDataGridView_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(dateTimePickerBirthday);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxBSN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxRoleDetails);
            groupBox1.Controls.Add(removeEmployeeBtn);
            groupBox1.Controls.Add(editEmployeeBtn);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(employeeDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(887, 51);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(300, 436);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Enabled = false;
            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthday.Location = new Point(117, 249);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(169, 23);
            dateTimePickerBirthday.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 249);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 39;
            label5.Text = "Birthday:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = SystemColors.ControlDark;
            textBoxAddress.Location = new Point(116, 276);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(169, 23);
            textBoxAddress.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 278);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 37;
            label6.Text = "Address:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = SystemColors.ControlDark;
            textBoxPhone.Location = new Point(117, 220);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(169, 23);
            textBoxPhone.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 222);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 37;
            label4.Text = "Phone Number:";
            // 
            // textBoxBSN
            // 
            textBoxBSN.BackColor = SystemColors.ControlDark;
            textBoxBSN.Location = new Point(117, 194);
            textBoxBSN.Name = "textBoxBSN";
            textBoxBSN.ReadOnly = true;
            textBoxBSN.Size = new Size(169, 23);
            textBoxBSN.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 194);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 35;
            label3.Text = "BSN:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.ControlDark;
            textBoxPassword.Location = new Point(117, 165);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(169, 23);
            textBoxPassword.TabIndex = 34;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 165);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 33;
            label2.Text = "Password:";
            // 
            // comboBoxRoleDetails
            // 
            comboBoxRoleDetails.Cursor = Cursors.Hand;
            comboBoxRoleDetails.DropDownHeight = 108;
            comboBoxRoleDetails.FormattingEnabled = true;
            comboBoxRoleDetails.IntegralHeight = false;
            comboBoxRoleDetails.ItemHeight = 15;
            comboBoxRoleDetails.Items.AddRange(new object[] { "DepartmentManager", "HR Manager", "Sales Representative", "Support Employee", "Cashier", "Security Guard", "Depot Worker" });
            comboBoxRoleDetails.Location = new Point(116, 104);
            comboBoxRoleDetails.Margin = new Padding(3, 2, 3, 2);
            comboBoxRoleDetails.Name = "comboBoxRoleDetails";
            comboBoxRoleDetails.Size = new Size(170, 23);
            comboBoxRoleDetails.TabIndex = 32;
            comboBoxRoleDetails.SelectedIndexChanged += comboBoxRoleDetails_SelectedIndexChanged;
            // 
            // removeEmployeeBtn
            // 
            removeEmployeeBtn.BackColor = Color.DarkOrange;
            removeEmployeeBtn.BackgroundColor = Color.DarkOrange;
            removeEmployeeBtn.BorderColor = Color.White;
            removeEmployeeBtn.BorderRadius = 15;
            removeEmployeeBtn.BorderSize = 2;
            removeEmployeeBtn.Cursor = Cursors.Hand;
            removeEmployeeBtn.FlatStyle = FlatStyle.Flat;
            removeEmployeeBtn.ForeColor = Color.White;
            removeEmployeeBtn.Location = new Point(46, 382);
            removeEmployeeBtn.Name = "removeEmployeeBtn";
            removeEmployeeBtn.Size = new Size(225, 40);
            removeEmployeeBtn.TabIndex = 30;
            removeEmployeeBtn.Text = "Remove Employee";
            removeEmployeeBtn.TextColor = Color.White;
            removeEmployeeBtn.UseVisualStyleBackColor = false;
            removeEmployeeBtn.Click += removeEmployeeBtn_Click;
            // 
            // editEmployeeBtn
            // 
            editEmployeeBtn.BackColor = Color.DarkOrange;
            editEmployeeBtn.BackgroundColor = Color.DarkOrange;
            editEmployeeBtn.BorderColor = Color.White;
            editEmployeeBtn.BorderRadius = 15;
            editEmployeeBtn.BorderSize = 2;
            editEmployeeBtn.Cursor = Cursors.Hand;
            editEmployeeBtn.FlatStyle = FlatStyle.Flat;
            editEmployeeBtn.ForeColor = Color.White;
            editEmployeeBtn.Location = new Point(46, 337);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(225, 40);
            editEmployeeBtn.TabIndex = 29;
            editEmployeeBtn.Text = "Edit Employee";
            editEmployeeBtn.TextColor = Color.White;
            editEmployeeBtn.UseVisualStyleBackColor = false;
            editEmployeeBtn.Click += editEmployeeBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(18, 52);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 3);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // employeeDetailsLabel
            // 
            employeeDetailsLabel.AutoSize = true;
            employeeDetailsLabel.BackColor = Color.Transparent;
            employeeDetailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeDetailsLabel.ForeColor = Color.DimGray;
            employeeDetailsLabel.Location = new Point(50, 36);
            employeeDetailsLabel.Name = "employeeDetailsLabel";
            employeeDetailsLabel.Size = new Size(96, 15);
            employeeDetailsLabel.TabIndex = 26;
            employeeDetailsLabel.Text = "Employee details";
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.OrangeRed;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(5, 22);
            userPictureBox.Margin = new Padding(3, 2, 3, 2);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(53, 29);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 25;
            userPictureBox.TabStop = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.ControlDark;
            textBoxEmail.Location = new Point(117, 135);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(169, 23);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ControlDark;
            textBoxName.Location = new Point(116, 72);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(170, 23);
            textBoxName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 135);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 17;
            label1.Text = "Email:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 104);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(333, 74);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(21, 23);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 19;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Cursor = Cursors.Hand;
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 15;
            comboBoxRole.Items.AddRange(new object[] { "Any Role", "HRManager", "SalesRepresentative", "Support", "Cashier", "SecurityGuard", "DepotWorker" });
            comboBoxRole.Location = new Point(377, 74);
            comboBoxRole.Margin = new Padding(3, 2, 3, 2);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(268, 23);
            comboBoxRole.TabIndex = 18;
            comboBoxRole.Text = "Choose Role";
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Location = new Point(41, 74);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(313, 23);
            textBoxSearch.TabIndex = 17;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.BackColor = Color.DarkOrange;
            addEmployeeBtn.BackgroundColor = Color.DarkOrange;
            addEmployeeBtn.BorderColor = Color.White;
            addEmployeeBtn.BorderRadius = 15;
            addEmployeeBtn.BorderSize = 2;
            addEmployeeBtn.Cursor = Cursors.Hand;
            addEmployeeBtn.FlatStyle = FlatStyle.Flat;
            addEmployeeBtn.ForeColor = Color.White;
            addEmployeeBtn.Location = new Point(651, 69);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(193, 30);
            addEmployeeBtn.TabIndex = 31;
            addEmployeeBtn.Text = "Add Employee";
            addEmployeeBtn.TextColor = Color.White;
            addEmployeeBtn.UseVisualStyleBackColor = false;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addEmployeeBtn);
            Controls.Add(userDataGridView);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxSearch);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxSearch);
            Cursor = Cursors.Hand;
            Name = "UserControlDashboard";
            Size = new Size(1499, 644);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userDataGridView;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label employeeDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label1;
        private Label lblRole;
        private Label lblName;
        private PictureBox pictureBoxSearch;
        private ComboBox comboBoxRole;
        private TextBox textBoxSearch;
        private CustomButton removeEmployeeBtn;
        private CustomButton editEmployeeBtn;
        private CustomButton addEmployeeBtn;
        private ComboBox comboBoxRoleDetails;
        private TextBox textBoxBSN;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerBirthday;
        private TextBox textBoxAddress;
        private Label label6;
    }
}
