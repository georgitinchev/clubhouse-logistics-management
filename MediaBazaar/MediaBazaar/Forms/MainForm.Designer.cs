﻿namespace MediaBazaar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            btnProduct = new CustomButton();
            logOutBtn = new CustomButton();
            pictureBox1 = new PictureBox();
            lineEmployee = new PictureBox();
            pictureBoxLogo = new PictureBox();
            pictureBoxJupiter = new PictureBox();
            btnWorksheet = new CustomButton();
            btnDashboard = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(logOutBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lineEmployee);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(pictureBoxJupiter);
            panel1.Controls.Add(btnWorksheet);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 66);
            panel1.TabIndex = 1;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.None;
            btnProduct.BackColor = Color.OrangeRed;
            btnProduct.BackgroundColor = Color.OrangeRed;
            btnProduct.BorderColor = Color.Black;
            btnProduct.BorderRadius = 15;
            btnProduct.BorderSize = 2;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.Black;
            btnProduct.Location = new Point(792, 8);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(150, 40);
            btnProduct.TabIndex = 24;
            btnProduct.Text = "Product";
            btnProduct.TextColor = Color.Black;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.Anchor = AnchorStyles.None;
            logOutBtn.BackColor = Color.OrangeRed;
            logOutBtn.BackgroundColor = Color.OrangeRed;
            logOutBtn.BorderColor = Color.Black;
            logOutBtn.BorderRadius = 15;
            logOutBtn.BorderSize = 2;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Location = new Point(1357, 9);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(120, 44);
            logOutBtn.TabIndex = 23;
            logOutBtn.Text = "Logout 🔑";
            logOutBtn.TextColor = Color.Black;
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox1.Location = new Point(793, 51);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 2);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // lineEmployee
            // 
            lineEmployee.BackColor = Color.FromArgb(255, 128, 0);
            lineEmployee.Location = new Point(552, 52);
            lineEmployee.Margin = new Padding(3, 2, 3, 2);
            lineEmployee.Name = "lineEmployee";
            lineEmployee.Size = new Size(150, 2);
            lineEmployee.TabIndex = 21;
            lineEmployee.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(720, 8);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(61, 52);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.Anchor = AnchorStyles.None;
            pictureBoxJupiter.BackColor = Color.OrangeRed;
            pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
            pictureBoxJupiter.Location = new Point(25, -4);
            pictureBoxJupiter.Margin = new Padding(3, 2, 3, 2);
            pictureBoxJupiter.Name = "pictureBoxJupiter";
            pictureBoxJupiter.Size = new Size(163, 60);
            pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJupiter.TabIndex = 18;
            pictureBoxJupiter.TabStop = false;
            // 
            // btnWorksheet
            // 
            btnWorksheet.Anchor = AnchorStyles.None;
            btnWorksheet.BackColor = Color.OrangeRed;
            btnWorksheet.BackgroundColor = Color.OrangeRed;
            btnWorksheet.BorderColor = Color.Black;
            btnWorksheet.BorderRadius = 15;
            btnWorksheet.BorderSize = 2;
            btnWorksheet.FlatStyle = FlatStyle.Flat;
            btnWorksheet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorksheet.ForeColor = Color.Black;
            btnWorksheet.Location = new Point(793, 8);
            btnWorksheet.Name = "btnWorksheet";
            btnWorksheet.Size = new Size(150, 40);
            btnWorksheet.TabIndex = 2;
            btnWorksheet.Text = "Worksheet";
            btnWorksheet.TextColor = Color.Black;
            btnWorksheet.UseVisualStyleBackColor = false;
            btnWorksheet.Click += btnWorksheet_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.None;
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.BackgroundColor = Color.OrangeRed;
            btnDashboard.BorderColor = Color.Black;
            btnDashboard.BorderRadius = 15;
            btnDashboard.BorderSize = 2;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(554, 8);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextColor = Color.Black;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1483, 691);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Bazaar Managment";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private CustomButton btnAddEmployee;
        private CustomButton btnEmployeeManagment;
        private CustomButton btnEditEmployee;
        private CustomButton btnRemoveEmployee;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox lineEmployee;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxJupiter;
        private CustomButton btnWorksheet;
        private CustomButton btnDashboard;
		private CustomButton logOutBtn;
        private CustomButton btnProduct;
    }
}
