namespace MediaBazaar
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
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(logOutBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lineEmployee);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(pictureBoxJupiter);
            panel1.Controls.Add(btnWorksheet);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(-3, -3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1697, 102);
            panel1.TabIndex = 1;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.OrangeRed;
            logOutBtn.BackgroundColor = Color.OrangeRed;
            logOutBtn.BorderColor = Color.Black;
            logOutBtn.BorderRadius = 15;
            logOutBtn.BorderSize = 2;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Location = new Point(1557, 13);
            logOutBtn.Margin = new Padding(4, 5, 4, 5);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(124, 58);
            logOutBtn.TabIndex = 23;
            logOutBtn.Text = "Logout 🔑";
            logOutBtn.TextColor = Color.Black;
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox1.Location = new Point(959, 85);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 3);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // lineEmployee
            // 
            lineEmployee.BackColor = Color.FromArgb(255, 128, 0);
            lineEmployee.Location = new Point(614, 87);
            lineEmployee.Margin = new Padding(4, 3, 4, 3);
            lineEmployee.Name = "lineEmployee";
            lineEmployee.Size = new Size(214, 3);
            lineEmployee.TabIndex = 21;
            lineEmployee.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(860, 13);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(76, 77);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.BackColor = Color.OrangeRed;
            pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
            pictureBoxJupiter.Location = new Point(36, -7);
            pictureBoxJupiter.Margin = new Padding(4, 3, 4, 3);
            pictureBoxJupiter.Name = "pictureBoxJupiter";
            pictureBoxJupiter.Size = new Size(221, 92);
            pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJupiter.TabIndex = 18;
            pictureBoxJupiter.TabStop = false;
            // 
            // btnWorksheet
            // 
            btnWorksheet.BackColor = Color.OrangeRed;
            btnWorksheet.BackgroundColor = Color.OrangeRed;
            btnWorksheet.BorderColor = Color.Black;
            btnWorksheet.BorderRadius = 15;
            btnWorksheet.BorderSize = 2;
            btnWorksheet.FlatStyle = FlatStyle.Flat;
            btnWorksheet.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorksheet.ForeColor = Color.Black;
            btnWorksheet.Location = new Point(959, 13);
            btnWorksheet.Margin = new Padding(4, 5, 4, 5);
            btnWorksheet.Name = "btnWorksheet";
            btnWorksheet.Size = new Size(214, 58);
            btnWorksheet.TabIndex = 2;
            btnWorksheet.Text = "Worksheet";
            btnWorksheet.TextColor = Color.Black;
            btnWorksheet.UseVisualStyleBackColor = false;
            btnWorksheet.Click += btnWorksheet_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.BackgroundColor = Color.OrangeRed;
            btnDashboard.BorderColor = Color.Black;
            btnDashboard.BorderRadius = 15;
            btnDashboard.BorderSize = 2;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(617, 13);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(214, 58);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextColor = Color.Black;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1691, 852);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Bazaar Managment";
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
	}
}
