namespace MediaBazaar.Forms
{
    partial class AddWorksheetDialogue
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
            panel1 = new Panel();
            comboBoxEmployee = new ComboBox();
            comboBoxTimeSlot = new ComboBox();
            textBoxWeekNumber = new TextBox();
            customButton1 = new CustomButton();
            btnSubmit = new CustomButton();
            comboBoxWeekDay = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBoxEmployee);
            panel1.Controls.Add(comboBoxTimeSlot);
            panel1.Controls.Add(textBoxWeekNumber);
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(comboBoxWeekDay);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 282);
            panel1.TabIndex = 0;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.Font = new Font("Segoe UI", 12F);
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(45, 155);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(236, 29);
            comboBoxEmployee.TabIndex = 28;
            // 
            // comboBoxTimeSlot
            // 
            comboBoxTimeSlot.Font = new Font("Segoe UI", 12F);
            comboBoxTimeSlot.FormattingEnabled = true;
            comboBoxTimeSlot.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening" });
            comboBoxTimeSlot.Location = new Point(45, 88);
            comboBoxTimeSlot.Margin = new Padding(3, 2, 3, 2);
            comboBoxTimeSlot.Name = "comboBoxTimeSlot";
            comboBoxTimeSlot.Size = new Size(236, 29);
            comboBoxTimeSlot.TabIndex = 27;
            // 
            // textBoxWeekNumber
            // 
            textBoxWeekNumber.Font = new Font("Segoe UI", 12F);
            textBoxWeekNumber.Location = new Point(363, 155);
            textBoxWeekNumber.Name = "textBoxWeekNumber";
            textBoxWeekNumber.Size = new Size(206, 29);
            textBoxWeekNumber.TabIndex = 26;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DarkOrange;
            customButton1.BackgroundColor = Color.DarkOrange;
            customButton1.BorderColor = Color.White;
            customButton1.BorderRadius = 6;
            customButton1.BorderSize = 1;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(529, 220);
            customButton1.Margin = new Padding(3, 2, 3, 2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(7, 6);
            customButton1.TabIndex = 24;
            customButton1.Text = "customButton1";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkOrange;
            btnSubmit.BackgroundColor = Color.DarkOrange;
            btnSubmit.BorderColor = Color.White;
            btnSubmit.BorderRadius = 15;
            btnSubmit.BorderSize = 1;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(248, 226);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(109, 41);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // comboBoxWeekDay
            // 
            comboBoxWeekDay.Font = new Font("Segoe UI", 12F);
            comboBoxWeekDay.FormattingEnabled = true;
            comboBoxWeekDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            comboBoxWeekDay.Location = new Point(363, 88);
            comboBoxWeekDay.Margin = new Padding(3, 2, 3, 2);
            comboBoxWeekDay.Name = "comboBoxWeekDay";
            comboBoxWeekDay.Size = new Size(206, 29);
            comboBoxWeekDay.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 137);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 13;
            label5.Text = "Week Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 70);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "WeekDay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 137);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 11;
            label3.Text = "Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Time Slot:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 27);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Worksheet Details:";
            // 
            // AddWorksheetDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(752, 343);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddWorksheetDialogue";
            Text = "AddWorksheetDialogue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBox5;
        private ComboBox comboBoxWeekDay;
        private CustomButton customButton1;
        private CustomButton btnSubmit;
        private TextBox textBoxWeekNumber;
        private TextBox textBox4;
        private ComboBox comboBoxTimeSlot;
        private ComboBox comboBoxEmployee;
    }
}