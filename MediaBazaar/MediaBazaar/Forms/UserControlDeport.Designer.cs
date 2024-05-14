namespace MediaBazaar.Forms
{
    partial class UserControlDeport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDeport));
            panelOperationsWorksheet = new Panel();
            searchPictureBox = new PictureBox();
            pictureBoxSearch = new PictureBox();
            btnAddProduct = new CustomButton();
            categoryFilter = new ComboBox();
            textBoxSearch = new TextBox();
            productsGrid = new DataGridView();
            productDetailsGroupbox = new GroupBox();
            priceNumericUpDown = new NumericUpDown();
            lblPrice = new Label();
            lblDescription = new Label();
            productPictureBox = new PictureBox();
            productDetailsLabel = new Label();
            productImage = new PictureBox();
            lblBrand = new Label();
            lblModel = new Label();
            productOperationsGroup = new GroupBox();
            btnRemoveProduct = new CustomButton();
            btnUpdateProduct = new CustomButton();
            textBoxDescription = new RichTextBox();
            lblWeight = new Label();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            lblHeight = new Label();
            numericUpDownWeight = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            lblDepth = new Label();
            numericUpDownWidth = new NumericUpDown();
            lblWidth = new Label();
            numericUpDownDepth = new NumericUpDown();
            lblCategory = new Label();
            comboBoxCategory = new ComboBox();
            panelOperationsWorksheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            productDetailsGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            productOperationsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).BeginInit();
            SuspendLayout();
            // 
            // panelOperationsWorksheet
            // 
            panelOperationsWorksheet.Controls.Add(searchPictureBox);
            panelOperationsWorksheet.Controls.Add(pictureBoxSearch);
            panelOperationsWorksheet.Controls.Add(btnAddProduct);
            panelOperationsWorksheet.Controls.Add(categoryFilter);
            panelOperationsWorksheet.Controls.Add(textBoxSearch);
            panelOperationsWorksheet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelOperationsWorksheet.Location = new Point(32, 64);
            panelOperationsWorksheet.Name = "panelOperationsWorksheet";
            panelOperationsWorksheet.Size = new Size(1030, 70);
            panelOperationsWorksheet.TabIndex = 31;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchPictureBox.BackColor = Color.White;
            searchPictureBox.Cursor = Cursors.Hand;
            searchPictureBox.Image = Properties.Resources.search_icon;
            searchPictureBox.Location = new Point(633, 19);
            searchPictureBox.Margin = new Padding(3, 2, 3, 2);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(42, 28);
            searchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            searchPictureBox.TabIndex = 30;
            searchPictureBox.TabStop = false;
            searchPictureBox.Click += searchPictureBox_Click;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxSearch.BackColor = Color.White;
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search_icon;
            pictureBoxSearch.Location = new Point(1334, -10);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(42, 28);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 28;
            pictureBoxSearch.TabStop = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.DarkOrange;
            btnAddProduct.BackgroundColor = Color.DarkOrange;
            btnAddProduct.BorderColor = Color.White;
            btnAddProduct.BorderRadius = 15;
            btnAddProduct.BorderSize = 2;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(868, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(159, 62);
            btnAddProduct.TabIndex = 23;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.TextColor = Color.White;
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // categoryFilter
            // 
            categoryFilter.Cursor = Cursors.Hand;
            categoryFilter.DropDownHeight = 108;
            categoryFilter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryFilter.FormattingEnabled = true;
            categoryFilter.IntegralHeight = false;
            categoryFilter.ItemHeight = 20;
            categoryFilter.Items.AddRange(new object[] { "Any Role", "DepartmentManager", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            categoryFilter.Location = new Point(694, 19);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(168, 28);
            categoryFilter.TabIndex = 29;
            categoryFilter.Text = "Choose Category";
            categoryFilter.SelectedIndexChanged += categoryFilter_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(13, 19);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(623, 29);
            textBoxSearch.TabIndex = 26;
            textBoxSearch.Text = "Search...";
            // 
            // productsGrid
            // 
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Cursor = Cursors.Hand;
            productsGrid.Location = new Point(41, 129);
            productsGrid.Margin = new Padding(3, 2, 3, 2);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.Size = new Size(1079, 564);
            productsGrid.TabIndex = 32;
            // 
            // productDetailsGroupbox
            // 
            productDetailsGroupbox.BackColor = Color.OrangeRed;
            productDetailsGroupbox.Controls.Add(comboBoxCategory);
            productDetailsGroupbox.Controls.Add(lblCategory);
            productDetailsGroupbox.Controls.Add(numericUpDownDepth);
            productDetailsGroupbox.Controls.Add(numericUpDownWidth);
            productDetailsGroupbox.Controls.Add(lblDepth);
            productDetailsGroupbox.Controls.Add(lblWidth);
            productDetailsGroupbox.Controls.Add(numericUpDownHeight);
            productDetailsGroupbox.Controls.Add(numericUpDownWeight);
            productDetailsGroupbox.Controls.Add(lblHeight);
            productDetailsGroupbox.Controls.Add(textBoxBrand);
            productDetailsGroupbox.Controls.Add(textBoxModel);
            productDetailsGroupbox.Controls.Add(lblWeight);
            productDetailsGroupbox.Controls.Add(textBoxDescription);
            productDetailsGroupbox.Controls.Add(priceNumericUpDown);
            productDetailsGroupbox.Controls.Add(lblPrice);
            productDetailsGroupbox.Controls.Add(lblDescription);
            productDetailsGroupbox.Controls.Add(productPictureBox);
            productDetailsGroupbox.Controls.Add(productDetailsLabel);
            productDetailsGroupbox.Controls.Add(productImage);
            productDetailsGroupbox.Controls.Add(lblBrand);
            productDetailsGroupbox.Controls.Add(lblModel);
            productDetailsGroupbox.Controls.Add(productOperationsGroup);
            productDetailsGroupbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productDetailsGroupbox.Location = new Point(1123, 58);
            productDetailsGroupbox.Margin = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Name = "productDetailsGroupbox";
            productDetailsGroupbox.Padding = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Size = new Size(376, 666);
            productDetailsGroupbox.TabIndex = 33;
            productDetailsGroupbox.TabStop = false;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Location = new Point(160, 181);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(125, 27);
            priceNumericUpDown.TabIndex = 48;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblPrice.Location = new Point(48, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 20);
            lblPrice.TabIndex = 37;
            lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDescription.Location = new Point(4, 229);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 24);
            lblDescription.TabIndex = 36;
            lblDescription.Text = "Description:";
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.DimGray;
            productPictureBox.Location = new Point(18, 59);
            productPictureBox.Margin = new Padding(3, 2, 3, 2);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(253, 2);
            productPictureBox.TabIndex = 25;
            productPictureBox.TabStop = false;
            // 
            // productDetailsLabel
            // 
            productDetailsLabel.AutoSize = true;
            productDetailsLabel.BackColor = Color.Transparent;
            productDetailsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            productDetailsLabel.ForeColor = Color.Black;
            productDetailsLabel.Location = new Point(65, 32);
            productDetailsLabel.Name = "productDetailsLabel";
            productDetailsLabel.Size = new Size(120, 21);
            productDetailsLabel.TabIndex = 26;
            productDetailsLabel.Text = "Product details";
            // 
            // productImage
            // 
            productImage.BackColor = Color.OrangeRed;
            productImage.Image = (Image)resources.GetObject("productImage.Image");
            productImage.Location = new Point(6, 25);
            productImage.Margin = new Padding(3, 2, 3, 2);
            productImage.Name = "productImage";
            productImage.Size = new Size(53, 33);
            productImage.SizeMode = PictureBoxSizeMode.Zoom;
            productImage.TabIndex = 25;
            productImage.TabStop = false;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblBrand.Location = new Point(39, 133);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(57, 24);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            lblModel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblModel.Location = new Point(39, 82);
            lblModel.Margin = new Padding(1, 0, 1, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(57, 27);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model:";
            // 
            // productOperationsGroup
            // 
            productOperationsGroup.Controls.Add(btnRemoveProduct);
            productOperationsGroup.Controls.Add(btnUpdateProduct);
            productOperationsGroup.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productOperationsGroup.Location = new Point(34, 484);
            productOperationsGroup.Margin = new Padding(2);
            productOperationsGroup.Name = "productOperationsGroup";
            productOperationsGroup.Padding = new Padding(2);
            productOperationsGroup.Size = new Size(316, 169);
            productOperationsGroup.TabIndex = 44;
            productOperationsGroup.TabStop = false;
            productOperationsGroup.Text = "Product Operations";
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.BackColor = Color.DarkOrange;
            btnRemoveProduct.BackgroundColor = Color.DarkOrange;
            btnRemoveProduct.BorderColor = Color.White;
            btnRemoveProduct.BorderRadius = 15;
            btnRemoveProduct.BorderSize = 2;
            btnRemoveProduct.FlatStyle = FlatStyle.Flat;
            btnRemoveProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRemoveProduct.ForeColor = Color.White;
            btnRemoveProduct.Location = new Point(20, 98);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(286, 57);
            btnRemoveProduct.TabIndex = 43;
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.TextColor = Color.White;
            btnRemoveProduct.UseVisualStyleBackColor = false;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.DarkOrange;
            btnUpdateProduct.BackgroundColor = Color.DarkOrange;
            btnUpdateProduct.BorderColor = Color.White;
            btnUpdateProduct.BorderRadius = 15;
            btnUpdateProduct.BorderSize = 2;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(20, 24);
            btnUpdateProduct.Margin = new Padding(3, 2, 3, 2);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(286, 57);
            btnUpdateProduct.TabIndex = 24;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.TextColor = Color.White;
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(102, 229);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(238, 92);
            textBoxDescription.TabIndex = 49;
            textBoxDescription.Text = "";
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblWeight.Location = new Point(30, 337);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(66, 24);
            lblWeight.TabIndex = 50;
            lblWeight.Text = "Weight:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(102, 82);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(238, 27);
            textBoxModel.TabIndex = 51;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(102, 130);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(238, 27);
            textBoxBrand.TabIndex = 52;
            // 
            // lblHeight
            // 
            lblHeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblHeight.Location = new Point(30, 382);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(66, 27);
            lblHeight.TabIndex = 54;
            lblHeight.Text = "Height:";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(102, 334);
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(83, 27);
            numericUpDownWeight.TabIndex = 55;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(102, 380);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(83, 27);
            numericUpDownHeight.TabIndex = 56;
            // 
            // lblDepth
            // 
            lblDepth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDepth.Location = new Point(191, 380);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(65, 27);
            lblDepth.TabIndex = 58;
            lblDepth.Text = "Depth:";
            lblDepth.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(262, 334);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(92, 27);
            numericUpDownWidth.TabIndex = 59;
            // 
            // lblWidth
            // 
            lblWidth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblWidth.Location = new Point(191, 336);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(65, 27);
            lblWidth.TabIndex = 57;
            lblWidth.Text = "Width:";
            lblWidth.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDownDepth
            // 
            numericUpDownDepth.Location = new Point(262, 380);
            numericUpDownDepth.Name = "numericUpDownDepth";
            numericUpDownDepth.Size = new Size(92, 27);
            numericUpDownDepth.TabIndex = 60;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCategory.Location = new Point(9, 435);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 28);
            lblCategory.TabIndex = 61;
            lblCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(102, 435);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(238, 28);
            comboBoxCategory.TabIndex = 62;
            // 
            // UserControlDeport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productDetailsGroupbox);
            Controls.Add(productsGrid);
            Controls.Add(panelOperationsWorksheet);
            Name = "UserControlDeport";
            Size = new Size(1499, 730);
            panelOperationsWorksheet.ResumeLayout(false);
            panelOperationsWorksheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            productDetailsGroupbox.ResumeLayout(false);
            productDetailsGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            productOperationsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperationsWorksheet;
        private PictureBox pictureBoxSearch;
        private CustomButton btnAddProduct;
        private ComboBox categoryFilter;
        private TextBox textBoxSearch;
        private DataGridView productsGrid;
        private GroupBox productDetailsGroupbox;
        private Label lblPrice;
        private Label lblDescription;
        private PictureBox productPictureBox;
        private Label productDetailsLabel;
        private PictureBox productImage;
        private Label lblBrand;
        private Label lblModel;
        private GroupBox productOperationsGroup;
        private CustomButton btnRemoveProduct;
        private CustomButton btnUpdateProduct;
        private PictureBox searchPictureBox;
        private NumericUpDown priceNumericUpDown;
        private RichTextBox textBoxDescription;
        private Label lblHeight;
        private TextBox textBoxBrand;
        private TextBox textBoxModel;
        private Label lblWeight;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownHeight;
        private Label lblDepth;
        private NumericUpDown numericUpDownWidth;
        private Label lblWidth;
        private NumericUpDown numericUpDownDepth;
        private Label lblCategory;
        private ComboBox comboBoxCategory;
    }
}
