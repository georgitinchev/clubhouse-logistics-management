﻿namespace MediaBazaar.Forms
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
            dataGridViewWorksheet = new DataGridView();
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
            comboBoxRoleWorksheet = new ComboBox();
            pictureBoxSearch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorksheet).BeginInit();
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
            btnRemoveWorksheet.Location = new Point(53, 484);
            btnRemoveWorksheet.Margin = new Padding(3, 4, 3, 4);
            btnRemoveWorksheet.Name = "btnRemoveWorksheet";
            btnRemoveWorksheet.Size = new Size(257, 53);
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
            btnAddWorksheet.Location = new Point(54, 423);
            btnAddWorksheet.Margin = new Padding(3, 4, 3, 4);
            btnAddWorksheet.Name = "btnAddWorksheet";
            btnAddWorksheet.Size = new Size(257, 53);
            btnAddWorksheet.TabIndex = 23;
            btnAddWorksheet.Text = "Add Worksheet";
            btnAddWorksheet.TextColor = Color.White;
            btnAddWorksheet.UseVisualStyleBackColor = false;
            btnAddWorksheet.Click += btnAddWorksheet_Click;
            // 
            // dataGridViewWorksheet
            // 
            dataGridViewWorksheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorksheet.Location = new Point(47, 152);
            dataGridViewWorksheet.Name = "dataGridViewWorksheet";
            dataGridViewWorksheet.RowHeadersWidth = 51;
            dataGridViewWorksheet.Size = new Size(918, 481);
            dataGridViewWorksheet.TabIndex = 22;
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
            groupBox1.Location = new Point(1014, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 581);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.Enabled = false;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(117, 259);
            cbStatus.Margin = new Padding(3, 4, 3, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(194, 28);
            cbStatus.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(117, 175);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // cbShift
            // 
            cbShift.Enabled = false;
            cbShift.FormattingEnabled = true;
            cbShift.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            cbShift.Location = new Point(117, 219);
            cbShift.Margin = new Padding(3, 4, 3, 4);
            cbShift.Name = "cbShift";
            cbShift.Size = new Size(193, 28);
            cbShift.TabIndex = 38;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(16, 183);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(44, 20);
            lbDate.TabIndex = 37;
            lbDate.Text = "Date:";
            // 
            // lbShift
            // 
            lbShift.AutoSize = true;
            lbShift.Location = new Point(16, 223);
            lbShift.Name = "lbShift";
            lbShift.Size = new Size(42, 20);
            lbShift.TabIndex = 36;
            lbShift.Text = "Shift:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 263);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 31;
            label6.Text = "Status:";
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
            // worksheetDetailsLabel
            // 
            worksheetDetailsLabel.AutoSize = true;
            worksheetDetailsLabel.BackColor = Color.Transparent;
            worksheetDetailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            worksheetDetailsLabel.ForeColor = Color.Black;
            worksheetDetailsLabel.Location = new Point(54, 47);
            worksheetDetailsLabel.Name = "worksheetDetailsLabel";
            worksheetDetailsLabel.Size = new Size(130, 20);
            worksheetDetailsLabel.TabIndex = 26;
            worksheetDetailsLabel.Text = "Worksheet details";
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
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Control;
            textBoxName.Location = new Point(117, 95);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(193, 27);
            textBoxName.TabIndex = 18;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = SystemColors.Control;
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 20;
            comboBoxRole.Items.AddRange(new object[] { "Security Guard" });
            comboBoxRole.Location = new Point(117, 135);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(193, 28);
            comboBoxRole.TabIndex = 16;
            comboBoxRole.Text = "HR Manager";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(17, 139);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Location = new Point(47, 99);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(357, 27);
            textBoxSearch.TabIndex = 26;
            textBoxSearch.Text = "Search...";
            // 
            // comboBoxRoleWorksheet
            // 
            comboBoxRoleWorksheet.Cursor = Cursors.Hand;
            comboBoxRoleWorksheet.DropDownHeight = 108;
            comboBoxRoleWorksheet.FormattingEnabled = true;
            comboBoxRoleWorksheet.IntegralHeight = false;
            comboBoxRoleWorksheet.ItemHeight = 20;
            comboBoxRoleWorksheet.Items.AddRange(new object[] { "HR Manager", "Sales Representative", "Support", "Cashier", "Security Guard", "Depot Worker" });
            comboBoxRoleWorksheet.Location = new Point(432, 99);
            comboBoxRoleWorksheet.Name = "comboBoxRoleWorksheet";
            comboBoxRoleWorksheet.Size = new Size(306, 28);
            comboBoxRoleWorksheet.TabIndex = 27;
            comboBoxRoleWorksheet.Text = "Role";
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(381, 97);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(24, 31);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 28;
            pictureBoxSearch.TabStop = false;
            // 
            // UserControlWorksheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxSearch);
            Controls.Add(comboBoxRoleWorksheet);
            Controls.Add(textBoxSearch);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewWorksheet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlWorksheet";
            Size = new Size(1360, 745);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorksheet).EndInit();
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
        private DataGridView dataGridViewWorksheet;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label worksheetDetailsLabel;
        private PictureBox userPictureBox;
        private TextBox textBoxName;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblName;
        private TextBox textBoxSearch;
        private ComboBox comboBoxRoleWorksheet;
        private PictureBox pictureBoxSearch;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbShift;
        private Label lbDate;
        private Label lbShift;
        private ComboBox cbStatus;
    }
}
