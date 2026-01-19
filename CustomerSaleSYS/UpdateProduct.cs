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
        public UpdateProduct()
        {
            InitializeComponent();
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
                buttonUpdateProduct.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textQuantity.Text == "" || textPrice.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
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
