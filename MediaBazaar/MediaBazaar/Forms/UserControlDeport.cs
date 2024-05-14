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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MediaBazaar.Forms
{
    public partial class UserControlDeport : UserControl
    {
        public ProductManager productManager { get; private set; }
        private DataTable productData;
        public UserControlDeport(ProductManager _productManager)
        {
            InitializeComponent();
            this.productManager = _productManager;
            this.Resize += UserControlDeport_Resize;
            InitializeDataGridView();
            InitializeProductData();
        }
        internal void InitializeProductData()
        {
            productData = new DataTable();
            productData.Columns.Add("Model", typeof(string));
            productData.Columns.Add("Brand", typeof(string));
            productData.Columns.Add("Category", typeof(string));
            productData.Columns.Add("Price", typeof(decimal));
            productData.Columns.Add("Stock", typeof(int));
            PopulateProductDataTable(productData);
            productsGrid.DataSource = productData;
        }
        private void PopulateProductDataTable(DataTable productData)
        {
            productData.Clear();
            productManager.GetAllProducts();
            foreach (Product product in productManager.Products)
            {
                productData.Rows.Add(product.Model, product.Brand, product.Category, product.Price, product.Stock);
            }
        }

        private void UserControlDeport_Resize(object sender, EventArgs e)
        {
            int padding = 31;
            int groupBoxWidth = this.ClientSize.Width / 4;
            int otherControlsWidth = this.ClientSize.Width - groupBoxWidth - 2 * padding;

            panelOperationsProduct.Width = otherControlsWidth;
            panelOperationsProduct.Location = new Point(padding, 67);

            productsGrid.Size = new Size(otherControlsWidth, this.ClientSize.Height - 200);
            productsGrid.Location = new Point(padding, panelOperationsProduct.Bottom + 10);
            productDetailsGroupbox.Size = new Size(groupBoxWidth, this.ClientSize.Height - 100);
            productDetailsGroupbox.Location = new Point(this.ClientSize.Width - productDetailsGroupbox.Width - padding, padding);
        }

        private void InitializeDataGridView()
        {
            productsGrid.AutoGenerateColumns = false;
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.EnableHeadersVisualStyles = false;
            productsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            productsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGrid.DefaultCellStyle.BackColor = Color.White;
            productsGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            productsGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.RowHeadersVisible = false;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.Font = new Font("Segoe UI Semibold", 14);
            productsGrid.RowTemplate.Height = 70;
            productsGrid.EnableHeadersVisualStyles = false;
            productsGrid.BorderStyle = BorderStyle.None;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            productsGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33);
            productsGrid.BackgroundColor = Color.White;
            productsGrid.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            productsGrid.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
            productsGrid.ScrollBars = ScrollBars.Vertical;
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
