namespace MediaBazaar.Forms
{
    partial class addProductForm
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
            addStockNumeric = new NumericUpDown();
            lblAddStock = new Label();
            lblErrorHandling = new Label();
            lblAddCategory = new Label();
            addCategoryCombo = new ComboBox();
            lblAddDescription = new Label();
            descriptionTextBox = new RichTextBox();
            dimensionsGroup = new GroupBox();
            addDepthNumeric = new NumericUpDown();
            addHeightNumeric = new NumericUpDown();
            addWidthNumeric = new NumericUpDown();
            lblAddWidth = new Label();
            lblAddDepth = new Label();
            lblAddHeight = new Label();
            addWeightNumeric = new NumericUpDown();
            lblAddWeight = new Label();
            addPriceNumeric = new NumericUpDown();
            lblAddPrice = new Label();
            addBrandTextBox = new TextBox();
            lblAddBrand = new Label();
            lblAddModel = new Label();
            addModelTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addStockNumeric).BeginInit();
            dimensionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addDepthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addHeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addWidthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addWeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(addStockNumeric);
            panel1.Controls.Add(lblAddStock);
            panel1.Controls.Add(lblErrorHandling);
            panel1.Controls.Add(lblAddCategory);
            panel1.Controls.Add(addCategoryCombo);
            panel1.Controls.Add(lblAddDescription);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(dimensionsGroup);
            panel1.Controls.Add(addWeightNumeric);
            panel1.Controls.Add(lblAddWeight);
            panel1.Controls.Add(addPriceNumeric);
            panel1.Controls.Add(lblAddPrice);
            panel1.Controls.Add(addBrandTextBox);
            panel1.Controls.Add(lblAddBrand);
            panel1.Controls.Add(lblAddModel);
            panel1.Controls.Add(addModelTextBox);
            panel1.Location = new Point(39, 39);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 783);
            panel1.TabIndex = 0;
            // 
            // addStockNumeric
            // 
            addStockNumeric.Font = new Font("Segoe UI", 14.25F);
            addStockNumeric.Location = new Point(668, 336);
            addStockNumeric.Margin = new Padding(3, 4, 3, 4);
            addStockNumeric.Name = "addStockNumeric";
            addStockNumeric.Size = new Size(176, 39);
            addStockNumeric.TabIndex = 27;
            // 
            // lblAddStock
            // 
            lblAddStock.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStock.Location = new Point(551, 338);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(94, 40);
            lblAddStock.TabIndex = 26;
            lblAddStock.Text = "Stock:";
            lblAddStock.TextAlign = ContentAlignment.TopRight;
            // 
            // lblErrorHandling
            // 
            lblErrorHandling.Font = new Font("Segoe UI", 12F);
            lblErrorHandling.ForeColor = Color.Red;
            lblErrorHandling.Location = new Point(31, 581);
            lblErrorHandling.Name = "lblErrorHandling";
            lblErrorHandling.Size = new Size(851, 88);
            lblErrorHandling.TabIndex = 25;
            lblErrorHandling.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddCategory
            // 
            lblAddCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddCategory.Location = new Point(-8, 335);
            lblAddCategory.Name = "lblAddCategory";
            lblAddCategory.Size = new Size(133, 40);
            lblAddCategory.TabIndex = 16;
            lblAddCategory.Text = "Category:";
            lblAddCategory.TextAlign = ContentAlignment.TopRight;
            // 
            // addCategoryCombo
            // 
            addCategoryCombo.Font = new Font("Segoe UI", 14.25F);
            addCategoryCombo.FormattingEnabled = true;
            addCategoryCombo.Location = new Point(131, 332);
            addCategoryCombo.Margin = new Padding(3, 4, 3, 4);
            addCategoryCombo.Name = "addCategoryCombo";
            addCategoryCombo.Size = new Size(299, 40);
            addCategoryCombo.TabIndex = 15;
            // 
            // lblAddDescription
            // 
            lblAddDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddDescription.Location = new Point(31, 420);
            lblAddDescription.Name = "lblAddDescription";
            lblAddDescription.Size = new Size(152, 40);
            lblAddDescription.TabIndex = 14;
            lblAddDescription.Text = "Description:";
            lblAddDescription.TextAlign = ContentAlignment.TopRight;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 14.25F);
            descriptionTextBox.Location = new Point(31, 464);
            descriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(851, 113);
            descriptionTextBox.TabIndex = 13;
            descriptionTextBox.Text = "";
            // 
            // dimensionsGroup
            // 
            dimensionsGroup.Controls.Add(addDepthNumeric);
            dimensionsGroup.Controls.Add(addHeightNumeric);
            dimensionsGroup.Controls.Add(addWidthNumeric);
            dimensionsGroup.Controls.Add(lblAddWidth);
            dimensionsGroup.Controls.Add(lblAddDepth);
            dimensionsGroup.Controls.Add(lblAddHeight);
            dimensionsGroup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dimensionsGroup.Location = new Point(514, 41);
            dimensionsGroup.Margin = new Padding(3, 4, 3, 4);
            dimensionsGroup.Name = "dimensionsGroup";
            dimensionsGroup.Padding = new Padding(3, 4, 3, 4);
            dimensionsGroup.Size = new Size(350, 242);
            dimensionsGroup.TabIndex = 12;
            dimensionsGroup.TabStop = false;
            dimensionsGroup.Text = "Dimensions";
            // 
            // addDepthNumeric
            // 
            addDepthNumeric.Font = new Font("Segoe UI", 14.25F);
            addDepthNumeric.Location = new Point(154, 173);
            addDepthNumeric.Margin = new Padding(3, 4, 3, 4);
            addDepthNumeric.Name = "addDepthNumeric";
            addDepthNumeric.Size = new Size(176, 39);
            addDepthNumeric.TabIndex = 15;
            // 
            // addHeightNumeric
            // 
            addHeightNumeric.Font = new Font("Segoe UI", 14.25F);
            addHeightNumeric.Location = new Point(154, 116);
            addHeightNumeric.Margin = new Padding(3, 4, 3, 4);
            addHeightNumeric.Name = "addHeightNumeric";
            addHeightNumeric.Size = new Size(176, 39);
            addHeightNumeric.TabIndex = 14;
            // 
            // addWidthNumeric
            // 
            addWidthNumeric.Font = new Font("Segoe UI", 14.25F);
            addWidthNumeric.Location = new Point(154, 55);
            addWidthNumeric.Margin = new Padding(3, 4, 3, 4);
            addWidthNumeric.Name = "addWidthNumeric";
            addWidthNumeric.Size = new Size(176, 39);
            addWidthNumeric.TabIndex = 13;
            // 
            // lblAddWidth
            // 
            lblAddWidth.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWidth.Location = new Point(48, 55);
            lblAddWidth.Name = "lblAddWidth";
            lblAddWidth.Size = new Size(83, 44);
            lblAddWidth.TabIndex = 9;
            lblAddWidth.Text = "Width:";
            lblAddWidth.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddDepth
            // 
            lblAddDepth.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddDepth.Location = new Point(38, 173);
            lblAddDepth.Name = "lblAddDepth";
            lblAddDepth.Size = new Size(94, 44);
            lblAddDepth.TabIndex = 11;
            lblAddDepth.Text = "Depth:";
            lblAddDepth.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddHeight
            // 
            lblAddHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddHeight.Location = new Point(38, 116);
            lblAddHeight.Name = "lblAddHeight";
            lblAddHeight.Size = new Size(94, 44);
            lblAddHeight.TabIndex = 10;
            lblAddHeight.Text = "Height:";
            lblAddHeight.TextAlign = ContentAlignment.TopRight;
            // 
            // addWeightNumeric
            // 
            addWeightNumeric.DecimalPlaces = 2;
            addWeightNumeric.Font = new Font("Segoe UI", 14.25F);
            addWeightNumeric.Location = new Point(199, 259);
            addWeightNumeric.Margin = new Padding(3, 4, 3, 4);
            addWeightNumeric.Name = "addWeightNumeric";
            addWeightNumeric.Size = new Size(168, 39);
            addWeightNumeric.TabIndex = 8;
            // 
            // lblAddWeight
            // 
            lblAddWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWeight.Location = new Point(31, 263);
            lblAddWeight.Name = "lblAddWeight";
            lblAddWeight.Size = new Size(94, 40);
            lblAddWeight.TabIndex = 7;
            lblAddWeight.Text = "Weight:";
            lblAddWeight.TextAlign = ContentAlignment.TopRight;
            // 
            // addPriceNumeric
            // 
            addPriceNumeric.DecimalPlaces = 2;
            addPriceNumeric.Font = new Font("Segoe UI", 14.25F);
            addPriceNumeric.Location = new Point(199, 188);
            addPriceNumeric.Margin = new Padding(3, 4, 3, 4);
            addPriceNumeric.Name = "addPriceNumeric";
            addPriceNumeric.Size = new Size(168, 39);
            addPriceNumeric.TabIndex = 6;
            // 
            // lblAddPrice
            // 
            lblAddPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddPrice.Location = new Point(31, 191);
            lblAddPrice.Name = "lblAddPrice";
            lblAddPrice.Size = new Size(94, 40);
            lblAddPrice.TabIndex = 5;
            lblAddPrice.Text = "Price:";
            lblAddPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // addBrandTextBox
            // 
            addBrandTextBox.Font = new Font("Segoe UI Semibold", 14.25F);
            addBrandTextBox.Location = new Point(131, 120);
            addBrandTextBox.Margin = new Padding(3, 4, 3, 4);
            addBrandTextBox.Name = "addBrandTextBox";
            addBrandTextBox.Size = new Size(299, 39);
            addBrandTextBox.TabIndex = 4;
            // 
            // lblAddBrand
            // 
            lblAddBrand.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBrand.Location = new Point(31, 124);
            lblAddBrand.Name = "lblAddBrand";
            lblAddBrand.Size = new Size(94, 40);
            lblAddBrand.TabIndex = 3;
            lblAddBrand.Text = "Brand:";
            lblAddBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddModel
            // 
            lblAddModel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddModel.Location = new Point(31, 45);
            lblAddModel.Name = "lblAddModel";
            lblAddModel.Size = new Size(94, 40);
            lblAddModel.TabIndex = 2;
            lblAddModel.Text = "Model:";
            lblAddModel.TextAlign = ContentAlignment.TopRight;
            // 
            // addModelTextBox
            // 
            addModelTextBox.Font = new Font("Segoe UI Semibold", 14.25F);
            addModelTextBox.Location = new Point(131, 41);
            addModelTextBox.Margin = new Padding(3, 4, 3, 4);
            addModelTextBox.Name = "addModelTextBox";
            addModelTextBox.Size = new Size(299, 39);
            addModelTextBox.TabIndex = 1;
            // 
            // addProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(994, 864);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "addProductForm";
            Text = "Add Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addStockNumeric).EndInit();
            dimensionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addDepthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addHeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addWidthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addWeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAddModel;
        private TextBox addModelTextBox;
        private NumericUpDown addPriceNumeric;
        private Label lblAddPrice;
        private TextBox addBrandTextBox;
        private Label lblAddBrand;
        private NumericUpDown addWeightNumeric;
        private Label lblAddWeight;
        private Label lblAddDepth;
        private Label lblAddHeight;
        private Label lblAddWidth;
        private GroupBox dimensionsGroup;
        private NumericUpDown addDepthNumeric;
        private NumericUpDown addHeightNumeric;
        private NumericUpDown addWidthNumeric;
        private Label lblAddCategory;
        private ComboBox addCategoryCombo;
        private Label lblAddDescription;
        private RichTextBox descriptionTextBox;
        private CustomButton btnSubmit;
        private Label lblErrorHandling;
        private NumericUpDown addStockNumeric;
        private Label lblAddStock;
    }
}