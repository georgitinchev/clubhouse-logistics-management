using BusinessLogicLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
    public partial class addProductForm : Form
    {
        public ProductManager productManager { get; private set; }
        public addProductForm(ProductManager _productManager)
        {
            InitializeComponent();
            productManager = _productManager;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var model = addModelTextBox.Text.Trim();
            var brand = addBrandTextBox.Text.Trim();
            var price = addPriceNumeric.Value;
            var description = descriptionTextBox.Text.Trim();
            var weight = addWeightNumeric.Value;
            var height = addHeightNumeric.Value;
            var width = addWidthNumeric.Value;
            var depth = addDepthNumeric.Value;
            var category = (ProductCategoryEum)addCategoryCombo.SelectedIndex;
            var stock = Decimal.ToInt32(addStockNumeric.Value);

            // Validate inputs
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Model cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Brand cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (weight <= 0)
            {
                MessageBox.Show("Weight must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (height <= 0)
            {
                MessageBox.Show("Height must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (width <= 0)
            {
                MessageBox.Show("Width must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (depth <= 0)
            {
                MessageBox.Show("Depth must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new product and add it to the product manager
            var product = new Product(0, model, brand, price, description, weight, height, width, depth, category, stock);
            productManager.AddProduct(product);

            // Inform the user that the product was successfully added
            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
