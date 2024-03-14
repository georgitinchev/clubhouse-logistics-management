namespace MediaBazaar
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
            btnEmployeeManagment = new Button();
            btnWorksheetManagment = new Button();
            bindingSource1 = new BindingSource(components);
            btnAddEmployee = new Button();
            textBoxSearch = new TextBox();
            comboBoxDepartment = new ComboBox();
            pictureBoxSearch = new PictureBox();
            vScrollBar1 = new VScrollBar();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnEditEmployee = new Button();
            textBoxEmail = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            comboBoxRole = new ComboBox();
            lblRole = new Label();
            lblSurname = new Label();
            lblName = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.BackColor = SystemColors.ButtonShadow;
            pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
            pictureBoxJupiter.Location = new Point(41, -5);
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
            pictureBoxLogo.Location = new Point(657, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(125, 62);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // btnEmployeeManagment
            // 
            btnEmployeeManagment.Location = new Point(448, 16);
            btnEmployeeManagment.Name = "btnEmployeeManagment";
            btnEmployeeManagment.Size = new Size(221, 40);
            btnEmployeeManagment.TabIndex = 4;
            btnEmployeeManagment.Text = "Employee Managment";
            btnEmployeeManagment.UseVisualStyleBackColor = true;
            // 
            // btnWorksheetManagment
            // 
            btnWorksheetManagment.Location = new Point(767, 15);
            btnWorksheetManagment.Name = "btnWorksheetManagment";
            btnWorksheetManagment.Size = new Size(221, 41);
            btnWorksheetManagment.TabIndex = 7;
            btnWorksheetManagment.Text = "Worksheet Managment";
            btnWorksheetManagment.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(668, 97);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(193, 28);
            btnAddEmployee.TabIndex = 8;
            btnAddEmployee.Text = "Add employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(41, 96);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(387, 27);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.Text = "Search";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownHeight = 108;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.IntegralHeight = false;
            comboBoxDepartment.ItemHeight = 20;
            comboBoxDepartment.Location = new Point(481, 96);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(151, 28);
            comboBoxDepartment.TabIndex = 10;
            comboBoxDepartment.Text = "Department";
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(397, 97);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(27, 23);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 11;
            pictureBoxSearch.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(960, 170);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 462);
            vScrollBar1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnEditEmployee);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblSurname);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(1015, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 537);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details";
            // 
            // button1
            // 
            button1.Location = new Point(23, 492);
            button1.Name = "button1";
            button1.Size = new Size(280, 28);
            button1.TabIndex = 21;
            button1.Text = "Remove employee";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(23, 458);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(280, 28);
            btnEditEmployee.TabIndex = 16;
            btnEditEmployee.Text = "Edit employee";
            btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(121, 179);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(176, 27);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(121, 95);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(176, 27);
            textBoxSurname.TabIndex = 19;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(121, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(176, 27);
            textBoxName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 179);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownHeight = 108;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.IntegralHeight = false;
            comboBoxRole.ItemHeight = 20;
            comboBoxRole.Location = new Point(121, 137);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(176, 28);
            comboBoxRole.TabIndex = 16;
            comboBoxRole.Text = "HR Manager";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(23, 137);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(23, 95);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 81);
            panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(918, 463);
            dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 641);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(pictureBoxSearch);
            Controls.Add(comboBoxDepartment);
            Controls.Add(textBoxSearch);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnWorksheetManagment);
            Controls.Add(btnEmployeeManagment);
            Controls.Add(pictureBoxLogo);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxJupiter;
        private PictureBox pictureBoxLogo;
        private Button btnEmployeeManagment;
        private Button btnWorksheetManagment;
        private BindingSource bindingSource1;
        private Button btnAddEmployee;
        private TextBox textBoxSearch;
        private ComboBox comboBoxDepartment;
        private PictureBox pictureBoxSearch;
        private VScrollBar vScrollBar1;
        private GroupBox groupBox1;
        private ComboBox comboBoxRole;
        private Label lblRole;
        private Label lblSurname;
        private Label lblName;
        private Panel panel1;
        private Button button1;
        private Button btnEditEmployee;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
