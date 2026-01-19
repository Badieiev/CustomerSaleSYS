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
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
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
                buttonDeleteOrder.Visible = true;
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order deleted");
            this.Close();
        }
    }
}
