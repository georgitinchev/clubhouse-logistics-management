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
        public addProductForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var model = addModelTextBox.Text;
            var brand = addBrandTextBox.Text;
            var price = addPriceNumeric.Value;
            var description = descriptionTextBox.Text;
            var weight = addWeightNumeric.Value;
            var height = addHeightNumeric.Value;
            var width = addWidthNumeric.Value;
            var depth = addDepthNumeric.Value;
            var category = (ProductCategoryEum)addCategoryCombo.SelectedIndex;

            var product = new Product(0, model, brand, price, description, weight, height, width, depth, category);
            var productManager = new ProductManager();
            productManager.AddProduct(product);
        }
    }
}
