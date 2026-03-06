using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public partial class DeleteProduct : Form
    {
        private Product product;
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            product.Name = textName.Text;
            product.Quantity = Convert.ToInt32(textQuantity.Text);
            product.Price = Convert.ToDecimal(textPrice.Text);
            product.Status = 'I';
            product.UpdateProduct();
            MessageBox.Show("Product deleted");
            this.Close();
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            grdProducts.DataSource = Product.FindActiveProducts(textSearchProduct.Text).Tables[0];

            if (grdProducts.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                textSearchProduct.Focus();
                return;
            }
            grdProducts.Visible = true;
        }

        private void GrdProductsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdProducts.Rows[grdProducts.CurrentCell.RowIndex].Cells[0].Value);
            product = Product.GetProduct(id);
            textProductId.Text = product.ID.ToString();
            textName.Text = product.Name;
            textQuantity.Text = Convert.ToString(product.Quantity);
            textPrice.Text = Convert.ToString(product.Price);
            grpProduct.Visible = true;
        }
    }
}
