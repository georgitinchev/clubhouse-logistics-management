namespace MediaBazaar.Forms
{
	partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            userNameLoginTxt = new TextBox();
            passwordLoginTxt = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            pictureBoxJupiter = new PictureBox();
            loginFormGroup = new GroupBox();
            label1 = new Label();
            userPictureBox = new PictureBox();
            loginBtn = new CustomButton();
            loginStatusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
            loginFormGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // userNameLoginTxt
            // 
            userNameLoginTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userNameLoginTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLoginTxt.Location = new Point(83, 54);
            userNameLoginTxt.Name = "userNameLoginTxt";
            userNameLoginTxt.Size = new Size(288, 39);
            userNameLoginTxt.TabIndex = 0;
            // 
            // passwordLoginTxt
            // 
            passwordLoginTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLoginTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLoginTxt.Location = new Point(83, 166);
            passwordLoginTxt.Name = "passwordLoginTxt";
            passwordLoginTxt.Size = new Size(288, 39);
            passwordLoginTxt.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(186, 19);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(83, 32);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(165, 131);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(129, 32);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.BackColor = Color.OrangeRed;
            pictureBoxJupiter.BackgroundImage = (Image)resources.GetObject("pictureBoxJupiter.BackgroundImage");
            pictureBoxJupiter.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxJupiter.Image = Properties.Resources.Jupiter_logo2;
            pictureBoxJupiter.Location = new Point(436, 7);
            pictureBoxJupiter.Margin = new Padding(3, 2, 3, 2);
            pictureBoxJupiter.Name = "pictureBoxJupiter";
            pictureBoxJupiter.Size = new Size(288, 100);
            pictureBoxJupiter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJupiter.TabIndex = 20;
            pictureBoxJupiter.TabStop = false;
            // 
            // loginFormGroup
            // 
            loginFormGroup.BackColor = Color.Gainsboro;
            loginFormGroup.Controls.Add(userNameLabel);
            loginFormGroup.Controls.Add(userNameLoginTxt);
            loginFormGroup.Controls.Add(userPictureBox);
            loginFormGroup.Controls.Add(passwordLabel);
            loginFormGroup.Controls.Add(passwordLoginTxt);
            loginFormGroup.Location = new Point(353, 189);
            loginFormGroup.Name = "loginFormGroup";
            loginFormGroup.Size = new Size(467, 228);
            loginFormGroup.TabIndex = 21;
            loginFormGroup.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 138);
            label1.Name = "label1";
            label1.Size = new Size(373, 30);
            label1.TabIndex = 22;
            label1.Text = "Please enter administrative credentials:";
            // 
            // userPictureBox
            // 
            userPictureBox.BackColor = Color.OrangeRed;
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(428, 0);
            userPictureBox.Margin = new Padding(3, 2, 3, 2);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(39, 30);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 26;
            userPictureBox.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkOrange;
            loginBtn.BackgroundColor = Color.DarkOrange;
            loginBtn.BorderColor = Color.White;
            loginBtn.BorderRadius = 15;
            loginBtn.BorderSize = 1;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 20F);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(436, 474);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(288, 58);
            loginBtn.TabIndex = 27;
            loginBtn.Text = "Login ";
            loginBtn.TextColor = Color.White;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginStatusLabel
            // 
            loginStatusLabel.BackColor = Color.Gainsboro;
            loginStatusLabel.Font = new Font("Segoe UI", 16F);
            loginStatusLabel.Location = new Point(353, 410);
            loginStatusLabel.Name = "loginStatusLabel";
            loginStatusLabel.Size = new Size(467, 37);
            loginStatusLabel.TabIndex = 28;
            loginStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 568);
            Controls.Add(loginStatusLabel);
            Controls.Add(loginBtn);
            Controls.Add(label1);
            Controls.Add(loginFormGroup);
            Controls.Add(pictureBoxJupiter);
            DoubleBuffered = true;
            Name = "Authentication";
            Text = "Authentication";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).EndInit();
            loginFormGroup.ResumeLayout(false);
            loginFormGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox userNameLoginTxt;
		private TextBox passwordLoginTxt;
		private Label userNameLabel;
		private Label passwordLabel;
		private PictureBox pictureBoxJupiter;
		private GroupBox loginFormGroup;
		private Label label1;
		private PictureBox userPictureBox;
		private CustomButton loginBtn;
		private Label loginStatusLabel;
	}
}