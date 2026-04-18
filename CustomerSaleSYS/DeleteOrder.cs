using System;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSearchCustomer_Click(object sender, EventArgs e)
        {
            if (textSearchOrder.Text.Trim() == "")
            {
                grdOrders.DataSource = Order.FindAllOrdersFullInfo().Tables[0];
            }
            else if (!Validation.IsPositiveInteger(textSearchOrder.Text))
            {
                MessageBox.Show("Incorrect data entered in the ID field.");
            }
            else 
            {
                grdOrders.DataSource = Order.FindOrderFullInfoByID(Convert.ToInt32(textSearchOrder.Text)).Tables[0];
            }
            textOrderId.Clear();
            textCustomer.Clear();
            dateTimePicker.Value = DateTime.Now;
            textSum.Clear();    
        }

        private void GrdOrdersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orID = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value);
            textOrderId.Text = orID.ToString();
            textCustomer.Text = Convert.ToString(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[1].Value);
            dateTimePicker.Value = (DateTime)grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[2].Value;
            decimal orSum = Convert.ToDecimal(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[3].Value);
            textSum.Text = orSum.ToString();
        }

        private void ButtonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (textOrderId.Text == "")
            {
                MessageBox.Show("Select the order you want to delete.");
                return;
            }
            Order.UpdateOrderStatus(Convert.ToInt32(textOrderId.Text), 'I');
            MessageBox.Show("Order deleted");
            this.Close();
        }
    }
}
