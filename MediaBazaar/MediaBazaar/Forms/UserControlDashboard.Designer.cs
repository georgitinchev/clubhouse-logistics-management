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
            removeEmployeeBtn = new CustomButton();
            editEmployeeBtn = new CustomButton();
            pictureBox2 = new PictureBox();
            employeeDetailsLabel = new Label();
            userPictureBox = new PictureBox();
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
            userDataGridView.Location = new Point(31, 152);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(918, 497);
            userDataGridView.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.OrangeRed;
            groupBox1.Controls.Add(removeEmployeeBtn);
            groupBox1.Controls.Add(editEmployeeBtn);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(employeeDetailsLabel);
            groupBox1.Controls.Add(userPictureBox);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblSurname);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(1014, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 581);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
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
            removeEmployeeBtn.Location = new Point(53, 472);
            removeEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            removeEmployeeBtn.Name = "removeEmployeeBtn";
            removeEmployeeBtn.Size = new Size(257, 53);
            removeEmployeeBtn.TabIndex = 30;
            removeEmployeeBtn.Text = "Remove Employee";
            removeEmployeeBtn.TextColor = Color.White;
            removeEmployeeBtn.UseVisualStyleBackColor = false;
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
            editEmployeeBtn.Location = new Point(53, 397);
            editEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(257, 53);
            editEmployeeBtn.TabIndex = 29;
            editEmployeeBtn.Text = "Edit Employee";
            editEmployeeBtn.TextColor = Color.White;
            editEmployeeBtn.UseVisualStyleBackColor = false;
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
            // employeeDetailsLabel
            // 
            employeeDetailsLabel.AutoSize = true;
            employeeDetailsLabel.BackColor = Color.Transparent;
            employeeDetailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeDetailsLabel.ForeColor = Color.DimGray;
            employeeDetailsLabel.Location = new Point(57, 48);
            employeeDetailsLabel.Name = "employeeDetailsLabel";
            employeeDetailsLabel.Size = new Size(124, 20);
            employeeDetailsLabel.TabIndex = 26;
            employeeDetailsLabel.Text = "Employee details";
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.OrangeRed;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(6, 29);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(61, 39);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 25;
            userPictureBox.TabStop = false;
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
            label1.Location = new Point(16, 205);
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
            lblRole.Location = new Point(16, 169);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(16, 132);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(70, 20);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 93);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // vScrollBar
            // 
            vScrollBar.Location = new Point(950, 152);
            vScrollBar.Name = "vScrollBar";
            vScrollBar.Size = new Size(26, 497);
            vScrollBar.TabIndex = 20;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(359, 101);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(21, 21);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 19;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Cursor = Cursors.Hand;
            comboBoxDepartment.DropDownHeight = 108;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.IntegralHeight = false;
            comboBoxDepartment.ItemHeight = 20;
            comboBoxDepartment.Items.AddRange(new object[] { "HR Manager", "Sales Representative", "Support ", "Cashier", "Security Guard", "Depot Worker" });
            comboBoxDepartment.Location = new Point(394, 99);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(306, 28);
            comboBoxDepartment.TabIndex = 18;
            comboBoxDepartment.Text = "Role";
            comboBoxDepartment.Click += comboBoxDepartment_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Location = new Point(31, 99);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(357, 27);
            textBoxSearch.TabIndex = 17;
            textBoxSearch.Text = "Search...";
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
            addEmployeeBtn.Location = new Point(706, 92);
            addEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(243, 40);
            addEmployeeBtn.TabIndex = 31;
            addEmployeeBtn.Text = "Add Employee";
            addEmployeeBtn.TextColor = Color.White;
            addEmployeeBtn.UseVisualStyleBackColor = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addEmployeeBtn);
            Controls.Add(userDataGridView);
            Controls.Add(groupBox1);
            Controls.Add(vScrollBar);
            Controls.Add(pictureBoxSearch);
            Controls.Add(comboBoxDepartment);
            Controls.Add(textBoxSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlDashboard";
            Size = new Size(1360, 745);
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
        private CustomButton removeEmployeeBtn;
        private CustomButton editEmployeeBtn;
        private CustomButton addEmployeeBtn;
    }
}
