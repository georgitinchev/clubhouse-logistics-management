namespace MediaBazaar.Forms
{
    partial class Worksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worksheet));
            panel1 = new Panel();
            button4 = new Button();
            btnEmployeeManagement = new Button();
            pictureBoxJupiter = new PictureBox();
            lineWorksheet = new PictureBox();
            lineEmployee = new PictureBox();
            pictureBoxLogo = new PictureBox();
            dataGridView1 = new DataGridView();
            btnAddWorksheet = new Button();
            btnRemoveWorksheet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineWorksheet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnEmployeeManagement);
            panel1.Controls.Add(pictureBoxJupiter);
            panel1.Controls.Add(lineWorksheet);
            panel1.Controls.Add(lineEmployee);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Location = new Point(-4, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 61);
            panel1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(671, 13);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 26;
            button4.Text = "Worksheet Management";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeManagement
            // 
            btnEmployeeManagement.Location = new Point(432, 13);
            btnEmployeeManagement.Name = "btnEmployeeManagement";
            btnEmployeeManagement.Size = new Size(150, 23);
            btnEmployeeManagement.TabIndex = 25;
            btnEmployeeManagement.Text = "Employee Management";
            btnEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.BackColor = SystemColors.ButtonShadow;
            pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
            pictureBoxJupiter.Location = new Point(25, -4);
            pictureBoxJupiter.Margin = new Padding(3, 2, 3, 2);
            pictureBoxJupiter.Name = "pictureBoxJupiter";
            pictureBoxJupiter.Size = new Size(155, 55);
            pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJupiter.TabIndex = 17;
            pictureBoxJupiter.TabStop = false;
            // 
            // lineWorksheet
            // 
            lineWorksheet.BackColor = Color.FromArgb(255, 128, 0);
            lineWorksheet.Location = new Point(671, 41);
            lineWorksheet.Margin = new Padding(3, 2, 3, 2);
            lineWorksheet.Name = "lineWorksheet";
            lineWorksheet.Size = new Size(150, 2);
            lineWorksheet.TabIndex = 24;
            lineWorksheet.TabStop = false;
            // 
            // lineEmployee
            // 
            lineEmployee.BackColor = Color.FromArgb(255, 160, 0);
            lineEmployee.Location = new Point(432, 41);
            lineEmployee.Margin = new Padding(3, 2, 3, 2);
            lineEmployee.Name = "lineEmployee";
            lineEmployee.Size = new Size(150, 2);
            lineEmployee.TabIndex = 20;
            lineEmployee.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = SystemColors.ButtonShadow;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(602, 8);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(53, 46);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 70);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 361);
            dataGridView1.TabIndex = 17;
            // 
            // btnAddWorksheet
            // 
            btnAddWorksheet.Location = new Point(125, 446);
            btnAddWorksheet.Name = "btnAddWorksheet";
            btnAddWorksheet.Size = new Size(225, 23);
            btnAddWorksheet.TabIndex = 18;
            btnAddWorksheet.Text = "Add Worksheet";
            btnAddWorksheet.UseVisualStyleBackColor = true;
            // 
            // btnRemoveWorksheet
            // 
            btnRemoveWorksheet.Location = new Point(498, 446);
            btnRemoveWorksheet.Name = "btnRemoveWorksheet";
            btnRemoveWorksheet.Size = new Size(225, 23);
            btnRemoveWorksheet.TabIndex = 19;
            btnRemoveWorksheet.Text = "Remove Woksheet";
            btnRemoveWorksheet.UseVisualStyleBackColor = true;
            // 
            // Worksheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 481);
            Controls.Add(btnRemoveWorksheet);
            Controls.Add(btnAddWorksheet);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Worksheet";
            Text = "Worksheet";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineWorksheet).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox lineWorksheet;
        private PictureBox lineEmployee;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxJupiter;
        private DataGridView dataGridView1;
        private Button button4;
        private Button btnEmployeeManagement;
        private Button btnAddWorksheet;
        private Button btnRemoveWorksheet;
    }
}