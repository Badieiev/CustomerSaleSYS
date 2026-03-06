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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProductLoad(object sender, EventArgs e)
        {
            textID.Text = Product.GetNextProductID().ToString("0000");
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textQuantity.Text == "" || textPrice.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else if (!Validation.IsValidQuantity(textQuantity.Text))
            {
                MessageBox.Show("Incorrect data entered in the quantity field.");
            }
            else if (!Validation.IsValidDecimal(textPrice.Text))
            {
                MessageBox.Show("Incorrect data entered in the price field.");
            }
            else
            {
                if (!Product.IsUniqName(textName.Text))
                {
                    MessageBox.Show("This Product already exists in the system!");
                    return;
                }

                Product aProduct = new Product(Convert.ToInt32(textID.Text), textName.Text, Convert.ToInt32(textQuantity.Text), Convert.ToDecimal(textPrice.Text));
                aProduct.AddProduct();
                MessageBox.Show("Product added");
                this.Close();
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
