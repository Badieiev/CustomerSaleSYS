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
            MessageBox.Show("Product deleted");
            this.Close();
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            if (textSearchProduct.Text == "")
            {
                MessageBox.Show("Fill in the search field");
            }
            else
            {
                labelProductId.Visible = true;
                textProductId.Visible = true;
                labelName.Visible = true;
                textName.Visible = true;
                labelQuantity.Visible = true;
                textQuantity.Visible = true;
                labelPrice.Visible = true;
                textPrice.Visible = true;
                buttonDeleteProduct.Visible = true;
            }
        }
    }
}
