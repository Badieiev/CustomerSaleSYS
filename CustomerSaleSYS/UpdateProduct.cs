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
    public partial class UpdateProduct : Form
    {
        private Product product;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            grdProducts.DataSource = Product.FindAllProducts(textSearchProduct.Text).Tables[0];

            if (grdProducts.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                textSearchProduct.Focus();
                return;
            }
            textId.Enabled = false;
            grdProducts.Visible = true;
        }

        private void GrdProductsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdProducts.Rows[grdProducts.CurrentCell.RowIndex].Cells[0].Value);
            product = Product.GetProduct(id);
            textId.Text = product.ID.ToString();
            textName.Text = product.Name;
            textQuantity.Text = product.Quantity.ToString("000");
            textPrice.Text = product.Price.ToString("###0.00");
            cboStatus.Items.Clear();
            cboStatus.Items.Add(product.Status);
            cboStatus.Items.Add(Product.AddCboItem(product.Status));
            cboStatus.SelectedIndex = 0;
            if (product.Status == 'A')
            {
                cboStatus.Visible = false;
                labelStatus.Visible = false;
                textName.Enabled = true;
                textQuantity.Enabled = true;
                textPrice.Enabled = true;
            }
            else
            {
                cboStatus.Visible = true;
                labelStatus.Visible = true;
                textName.Enabled = false;
                textQuantity.Enabled = false;
                textPrice.Enabled = false;
            }
            grpProduct.Visible = true;
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textQuantity.Text == "" || textPrice.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else if (!Validation.IsNonNegativeNumber(textQuantity.Text))
            {
                MessageBox.Show("Incorrect data entered in the quantity field.");
            }
            else if (!Validation.IsValidDecimal(textPrice.Text))
            {
                MessageBox.Show("Incorrect data entered in the price field.");
            }
            else if (!Product.IsUniqNameForUpdate(Convert.ToInt32(textId.Text), textName.Text))
            {
                MessageBox.Show("Update not possible. A product with this name already exists in the database.");
            }
            else
            {
                product.Name = textName.Text;
                product.Quantity = Convert.ToInt32(textQuantity.Text);
                product.Price = Convert.ToDecimal(textPrice.Text);
                product.Status = cboStatus.Text[0];
                product.UpdateProduct();
                MessageBox.Show("Product updated");
                this.Close();
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
