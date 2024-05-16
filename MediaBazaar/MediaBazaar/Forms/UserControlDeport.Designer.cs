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
            panelOperationsProduct = new Panel();
            addProductBtn = new CustomButton();
            searchPictureBox = new PictureBox();
            pictureBoxSearch = new PictureBox();
            categoryFilter = new ComboBox();
            textBoxSearch = new TextBox();
            productsGrid = new DataGridView();
            productDetailsGroupbox = new GroupBox();
            productOperationsGroup = new GroupBox();
            removeProductBtn = new CustomButton();
            updateProductBtn = new CustomButton();
            numericUpDownStock = new NumericUpDown();
            lblStock = new Label();
            comboBoxCategory = new ComboBox();
            lblCategory = new Label();
            numericUpDownDepth = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            lblDepth = new Label();
            lblWidth = new Label();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWeight = new NumericUpDown();
            lblHeight = new Label();
            textBoxBrand = new TextBox();
            textBoxModel = new TextBox();
            lblWeight = new Label();
            textBoxDescription = new RichTextBox();
            priceNumericUpDown = new NumericUpDown();
            lblPrice = new Label();
            lblDescription = new Label();
            productPictureBox = new PictureBox();
            productDetailsLabel = new Label();
            productImage = new PictureBox();
            lblBrand = new Label();
            lblModel = new Label();
            panelOperationsProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            productDetailsGroupbox.SuspendLayout();
            productOperationsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            SuspendLayout();
            // 
            // panelOperationsProduct
            // 
            panelOperationsProduct.Controls.Add(addProductBtn);
            panelOperationsProduct.Controls.Add(searchPictureBox);
            panelOperationsProduct.Controls.Add(pictureBoxSearch);
            panelOperationsProduct.Controls.Add(categoryFilter);
            panelOperationsProduct.Controls.Add(textBoxSearch);
            panelOperationsProduct.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelOperationsProduct.Location = new Point(41, 67);
            panelOperationsProduct.Name = "panelOperationsProduct";
            panelOperationsProduct.Size = new Size(946, 57);
            panelOperationsProduct.TabIndex = 31;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.DarkOrange;
            addProductBtn.BackgroundColor = Color.DarkOrange;
            addProductBtn.BorderColor = Color.White;
            addProductBtn.BorderRadius = 15;
            addProductBtn.BorderSize = 2;
            addProductBtn.Cursor = Cursors.Hand;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(704, 2);
            addProductBtn.Margin = new Padding(3, 2, 3, 2);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(147, 38);
            addProductBtn.TabIndex = 32;
            addProductBtn.Text = "Add Product";
            addProductBtn.TextColor = Color.White;
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchPictureBox.BackColor = Color.White;
            searchPictureBox.Cursor = Cursors.Hand;
            searchPictureBox.Image = Properties.Resources.search_icon;
            searchPictureBox.Location = new Point(551, 23);
            searchPictureBox.Margin = new Padding(3, 2, 3, 2);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(42, 24);
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
            pictureBoxSearch.Location = new Point(1251, -23);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(42, 28);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 28;
            pictureBoxSearch.TabStop = false;
            // 
            // categoryFilter
            // 
            categoryFilter.Cursor = Cursors.Hand;
            categoryFilter.DropDownHeight = 108;
            categoryFilter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            categoryFilter.FormattingEnabled = true;
            categoryFilter.IntegralHeight = false;
            categoryFilter.ItemHeight = 20;
            categoryFilter.Items.AddRange(new object[] { "Any Role", "DepartmentManager", "HRManager", "SalesRepresentative", "SupportEmployee", "Cashier", "SecurityGuard", "DepotWorker" });
            categoryFilter.Location = new Point(506, 8);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(193, 28);
            categoryFilter.TabIndex = 29;
            categoryFilter.Text = "Choose Category";
            categoryFilter.SelectedIndexChanged += categoryFilter_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxSearch.Location = new Point(13, 9);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(458, 27);
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
            productsGrid.Size = new Size(1061, 564);
            productsGrid.TabIndex = 32;
            // 
            // productDetailsGroupbox
            // 
            productDetailsGroupbox.BackColor = Color.OrangeRed;
            productDetailsGroupbox.Controls.Add(productOperationsGroup);
            productDetailsGroupbox.Controls.Add(numericUpDownStock);
            productDetailsGroupbox.Controls.Add(lblStock);
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
            productDetailsGroupbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productDetailsGroupbox.Location = new Point(1123, 40);
            productDetailsGroupbox.Margin = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Name = "productDetailsGroupbox";
            productDetailsGroupbox.Padding = new Padding(3, 2, 3, 2);
            productDetailsGroupbox.Size = new Size(376, 653);
            productDetailsGroupbox.TabIndex = 33;
            productDetailsGroupbox.TabStop = false;
            // 
            // productOperationsGroup
            // 
            productOperationsGroup.Controls.Add(removeProductBtn);
            productOperationsGroup.Controls.Add(updateProductBtn);
            productOperationsGroup.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            productOperationsGroup.Location = new Point(18, 374);
            productOperationsGroup.Margin = new Padding(2, 2, 2, 2);
            productOperationsGroup.Name = "productOperationsGroup";
            productOperationsGroup.Padding = new Padding(2, 2, 2, 2);
            productOperationsGroup.Size = new Size(294, 105);
            productOperationsGroup.TabIndex = 44;
            productOperationsGroup.TabStop = false;
            productOperationsGroup.Text = "Product Operations";
            // 
            // removeProductBtn
            // 
            removeProductBtn.BackColor = Color.DarkOrange;
            removeProductBtn.BackgroundColor = Color.DarkOrange;
            removeProductBtn.BorderColor = Color.White;
            removeProductBtn.BorderRadius = 9;
            removeProductBtn.BorderSize = 2;
            removeProductBtn.Cursor = Cursors.Hand;
            removeProductBtn.FlatStyle = FlatStyle.Flat;
            removeProductBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeProductBtn.ForeColor = Color.White;
            removeProductBtn.Location = new Point(22, 63);
            removeProductBtn.Margin = new Padding(3, 2, 3, 2);
            removeProductBtn.Name = "removeProductBtn";
            removeProductBtn.Size = new Size(250, 38);
            removeProductBtn.TabIndex = 65;
            removeProductBtn.Text = "Remove Product";
            removeProductBtn.TextColor = Color.White;
            removeProductBtn.UseVisualStyleBackColor = false;
            removeProductBtn.Click += removeProductBtn_Click;
            // 
            // updateProductBtn
            // 
            updateProductBtn.BackColor = Color.DarkOrange;
            updateProductBtn.BackgroundColor = Color.DarkOrange;
            updateProductBtn.BorderColor = Color.White;
            updateProductBtn.BorderRadius = 9;
            updateProductBtn.BorderSize = 2;
            updateProductBtn.Cursor = Cursors.Hand;
            updateProductBtn.FlatStyle = FlatStyle.Flat;
            updateProductBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateProductBtn.ForeColor = Color.White;
            updateProductBtn.Location = new Point(22, 23);
            updateProductBtn.Margin = new Padding(3, 2, 3, 2);
            updateProductBtn.Name = "updateProductBtn";
            updateProductBtn.Size = new Size(250, 38);
            updateProductBtn.TabIndex = 65;
            updateProductBtn.Text = "Update Product";
            updateProductBtn.TextColor = Color.White;
            updateProductBtn.UseVisualStyleBackColor = false;
            updateProductBtn.Click += updateProductBtn_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            numericUpDownStock.Location = new Point(138, 344);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(93, 27);
            numericUpDownStock.TabIndex = 64;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblStock.Location = new Point(77, 346);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 22);
            lblStock.TabIndex = 63;
            lblStock.Text = "Stock:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(92, 314);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(221, 28);
            comboBoxCategory.TabIndex = 62;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCategory.Location = new Point(0, 316);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 28);
            lblCategory.TabIndex = 61;
            lblCategory.Text = "Category:";
            // 
            // numericUpDownDepth
            // 
            numericUpDownDepth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            numericUpDownDepth.Location = new Point(220, 284);
            numericUpDownDepth.Name = "numericUpDownDepth";
            numericUpDownDepth.Size = new Size(92, 27);
            numericUpDownDepth.TabIndex = 60;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            numericUpDownWidth.Location = new Point(220, 254);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(92, 27);
            numericUpDownWidth.TabIndex = 59;
            // 
            // lblDepth
            // 
            lblDepth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDepth.Location = new Point(150, 283);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(65, 27);
            lblDepth.TabIndex = 58;
            lblDepth.Text = "Depth:";
            lblDepth.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWidth
            // 
            lblWidth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblWidth.Location = new Point(150, 255);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(65, 27);
            lblWidth.TabIndex = 57;
            lblWidth.Text = "Width:";
            lblWidth.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            numericUpDownHeight.Location = new Point(65, 284);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(83, 27);
            numericUpDownHeight.TabIndex = 56;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            numericUpDownWeight.Location = new Point(65, 254);
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(83, 27);
            numericUpDownWeight.TabIndex = 55;
            // 
            // lblHeight
            // 
            lblHeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblHeight.Location = new Point(3, 284);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(66, 27);
            lblHeight.TabIndex = 54;
            lblHeight.Text = "Height:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxBrand.Location = new Point(75, 98);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(238, 27);
            textBoxBrand.TabIndex = 52;
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxModel.Location = new Point(75, 68);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(238, 27);
            textBoxModel.TabIndex = 51;
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblWeight.Location = new Point(0, 254);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(69, 24);
            lblWeight.TabIndex = 50;
            lblWeight.Text = "Weight:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxDescription.Location = new Point(6, 175);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(307, 74);
            textBoxDescription.TabIndex = 49;
            textBoxDescription.Text = "";
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            priceNumericUpDown.Location = new Point(129, 128);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(125, 27);
            priceNumericUpDown.TabIndex = 48;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblPrice.Location = new Point(13, 128);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 20);
            lblPrice.TabIndex = 37;
            lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDescription.Location = new Point(6, 154);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 18);
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
            productDetailsLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            productDetailsLabel.ForeColor = Color.Black;
            productDetailsLabel.Location = new Point(65, 32);
            productDetailsLabel.Name = "productDetailsLabel";
            productDetailsLabel.Size = new Size(111, 20);
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
            lblBrand.Location = new Point(6, 98);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(66, 24);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            lblModel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblModel.Location = new Point(3, 64);
            lblModel.Margin = new Padding(1, 0, 1, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(69, 27);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model:";
            // 
            // UserControlDeport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productDetailsGroupbox);
            Controls.Add(productsGrid);
            Controls.Add(panelOperationsProduct);
            Name = "UserControlDeport";
            Size = new Size(1499, 730);
            panelOperationsProduct.ResumeLayout(false);
            panelOperationsProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            productDetailsGroupbox.ResumeLayout(false);
            productDetailsGroupbox.PerformLayout();
            productOperationsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperationsProduct;
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
        private CustomButton addProductBtn;
        private NumericUpDown numericUpDownStock;
        private Label lblStock;
        private CustomButton updateProductBtn;
        private CustomButton removeProductBtn;
    }
}
