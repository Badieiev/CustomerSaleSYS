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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (comboCustomer.Text == "" || comboProduct.Text == "" || textQuantity.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else if (!Validation.IsValidQuantity(textQuantity.Text))
            {
                MessageBox.Show("Incorrect data entered in the quantity field.");
            }
            else
            {
                MessageBox.Show("Order added");
                this.Close();
            }
        }
    }
}
