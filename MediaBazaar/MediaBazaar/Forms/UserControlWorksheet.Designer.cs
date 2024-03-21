namespace MediaBazaar.Forms
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
            btnRemoveWorksheet = new CustomButton();
            btnAddWorksheet = new CustomButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnRemoveWorksheet.Location = new Point(916, 405);
            btnRemoveWorksheet.Name = "btnRemoveWorksheet";
            btnRemoveWorksheet.Size = new Size(225, 40);
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
            btnAddWorksheet.Location = new Point(916, 359);
            btnAddWorksheet.Name = "btnAddWorksheet";
            btnAddWorksheet.Size = new Size(225, 40);
            btnAddWorksheet.TabIndex = 23;
            btnAddWorksheet.Text = "Add Worksheet";
            btnAddWorksheet.TextColor = Color.White;
            btnAddWorksheet.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 84);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 361);
            dataGridView1.TabIndex = 22;
            // 
            // UserControlWorksheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemoveWorksheet);
            Controls.Add(btnAddWorksheet);
            Controls.Add(dataGridView1);
            Name = "UserControlWorksheet";
            Size = new Size(1190, 559);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomButton btnRemoveWorksheet;
        private CustomButton btnAddWorksheet;
        private DataGridView dataGridView1;
    }
}
