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
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            if (textSearchCustomer.Text == "")
            {
                MessageBox.Show("Fill in the search field");
            }
            else
            {
                labelProductId.Visible = true;
                textProductId.Visible = true;
                labelCustomer.Visible = true;
                comboCustomer.Visible = true;
                labelProduct.Visible = true;
                comboProduct.Visible = true;
                labelQuantity.Visible = true;
                textQuantity.Visible = true;
                labelDate.Visible = true;
                dateTimePicker1.Visible = true;
                labelSum.Visible = true;
                textSum.Visible = true;
                labelStatus.Visible = true;
                comboBoxStatus.Visible = true;
                buttonUpdateOrder.Visible = true;
            }
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (comboCustomer.Text == "" || comboProduct.Text == "" || textQuantity.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                MessageBox.Show("Product updated");
                this.Close();
            }
        }
    }
}
