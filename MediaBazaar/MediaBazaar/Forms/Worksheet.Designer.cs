﻿namespace MediaBazaar.Forms
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
			panel1.Location = new Point(-5, -5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1360, 81);
			panel1.TabIndex = 16;
			// 
			// button4
			// 
			button4.Location = new Point(767, 17);
			button4.Margin = new Padding(3, 4, 3, 4);
			button4.Name = "button4";
			button4.Size = new Size(171, 31);
			button4.TabIndex = 26;
			button4.Text = "Worksheet Management";
			button4.UseVisualStyleBackColor = true;
			// 
			// btnEmployeeManagement
			// 
			btnEmployeeManagement.Location = new Point(494, 17);
			btnEmployeeManagement.Margin = new Padding(3, 4, 3, 4);
			btnEmployeeManagement.Name = "btnEmployeeManagement";
			btnEmployeeManagement.Size = new Size(171, 31);
			btnEmployeeManagement.TabIndex = 25;
			btnEmployeeManagement.Text = "Employee Management";
			btnEmployeeManagement.UseVisualStyleBackColor = true;
			// 
			// pictureBoxJupiter
			// 
			pictureBoxJupiter.BackColor = SystemColors.ButtonShadow;
			pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
			pictureBoxJupiter.Location = new Point(29, -5);
			pictureBoxJupiter.Name = "pictureBoxJupiter";
			pictureBoxJupiter.Size = new Size(177, 73);
			pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxJupiter.TabIndex = 17;
			pictureBoxJupiter.TabStop = false;
			// 
			// lineWorksheet
			// 
			lineWorksheet.BackColor = Color.FromArgb(255, 128, 0);
			lineWorksheet.Location = new Point(767, 55);
			lineWorksheet.Name = "lineWorksheet";
			lineWorksheet.Size = new Size(171, 3);
			lineWorksheet.TabIndex = 24;
			lineWorksheet.TabStop = false;
			// 
			// lineEmployee
			// 
			lineEmployee.BackColor = Color.FromArgb(255, 160, 0);
			lineEmployee.Location = new Point(494, 55);
			lineEmployee.Name = "lineEmployee";
			lineEmployee.Size = new Size(171, 3);
			lineEmployee.TabIndex = 20;
			lineEmployee.TabStop = false;
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
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(41, 93);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(918, 481);
			dataGridView1.TabIndex = 17;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btnAddWorksheet
			// 
			btnAddWorksheet.Location = new Point(143, 595);
			btnAddWorksheet.Margin = new Padding(3, 4, 3, 4);
			btnAddWorksheet.Name = "btnAddWorksheet";
			btnAddWorksheet.Size = new Size(257, 31);
			btnAddWorksheet.TabIndex = 18;
			btnAddWorksheet.Text = "Add Worksheet";
			btnAddWorksheet.UseVisualStyleBackColor = true;
			// 
			// btnRemoveWorksheet
			// 
			btnRemoveWorksheet.Location = new Point(569, 595);
			btnRemoveWorksheet.Margin = new Padding(3, 4, 3, 4);
			btnRemoveWorksheet.Name = "btnRemoveWorksheet";
			btnRemoveWorksheet.Size = new Size(257, 31);
			btnRemoveWorksheet.TabIndex = 19;
			btnRemoveWorksheet.Text = "Remove Woksheet";
			btnRemoveWorksheet.UseVisualStyleBackColor = true;
			// 
			// Worksheet
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1353, 641);
			Controls.Add(btnRemoveWorksheet);
			Controls.Add(btnAddWorksheet);
			Controls.Add(dataGridView1);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
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