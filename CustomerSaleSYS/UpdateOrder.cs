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

        private void FormUpdateOrderLoad(object sender, EventArgs e)
        {
            textOrderId.ReadOnly = true;

            DataSet dsCustomer = Customer.GetCustomerFullName();
            cboCustomer.Items.Clear();
            for (int i = 0; i < dsCustomer.Tables[0].Rows.Count; i++)
            {
                cboCustomer.Items.Add(dsCustomer.Tables[0].Rows[i][0] + " - " + dsCustomer.Tables[0].Rows[i][1] + " " + dsCustomer.Tables[0].Rows[i][2]);
            }
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;

            DataSet dsProduct = Product.GetProductName();
            cboProduct.Items.Clear();
            for (int i = 0; i < dsProduct.Tables[0].Rows.Count; i++)
            {
                cboProduct.Items.Add(dsProduct.Tables[0].Rows[i][0] + " - " + dsProduct.Tables[0].Rows[i][1]);
            }
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSearchOrder_Click(object sender, EventArgs e)
        {
            if (textSearchOrder.Text.Trim() == "")
            {
                grdOrders.DataSource = Order.FindAllOrders().Tables[0];
            }
            else if (!Validation.IsValidQuantity(textSearchOrder.Text))
            {
                MessageBox.Show("Incorrect data entered in the ID field.");
            }
            else
            {
                grdOrders.DataSource = Order.FindOrderByID(Convert.ToInt32(textSearchOrder.Text)).Tables[0];
            }

            //
            if (grdOrders.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void GrdOrdersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            textQuantity.Clear();

            int orID = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value);
            textOrderId.Text = orID.ToString();
            dateTimePicker.Value = (DateTime)grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[2].Value;
            int custId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[1].Value);
            foreach (string item in cboCustomer.Items)
            {
                if (custId == Convert.ToInt32(item.Split(' ')[0])) 
                {
                    cboCustomer.SelectedItem = item;
                }
            }

            grdOrder_items.DataSource = Order_item.FindOrder_itemsByID(orID).Tables[0];
        }

        private void BtnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (textOrderId.Text == "")
            {
                MessageBox.Show("Select the order you want to change");
            }
            else
            {
                foreach (DataGridViewRow row in grdOrders.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(textOrderId.Text))
                    {
                        if ((Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(cboCustomer.SelectedItem.ToString().Split(' ')[0])) &&
                            (DateTime.Parse(row.Cells[2].Value.ToString()) == dateTimePicker.Value.Date))
                        {
                            MessageBox.Show("You have not changed the customer or date, so the order will remain unchanged.");
                        }
                        else
                        {
                            //update order using an object or direct sql?
                            int orderID = Convert.ToInt32(textOrderId.Text);
                            int customerID = Convert.ToInt32(cboCustomer.SelectedItem.ToString().Split(' ')[0]);
                            string date = String.Format("{0:dd-MMM-yy}", dateTimePicker.Value);
                            
                            Order.UpdateOrderCustomerDetails(orderID, customerID, date);
                            MessageBox.Show("Order updated");
                        }
                    }
                }
            }
        }

        private void GrdOrder_itemsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int prId = Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[1].Value);
            foreach (string item in cboProduct.Items)
            {
                if (prId == Convert.ToInt32(item.Split(' ')[0]))
                {
                    cboProduct.SelectedItem = item;
                }
            }

            int quantity = Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[2].Value);
            textQuantity.Text=quantity.ToString();
            /*
            int orID = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value);
            textProductId.Text = orID.ToString();
            dateTimePicker.Value = (DateTime)grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[2].Value;
            int custId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[1].Value);
            foreach (string item in cboCustomer.Items)
            {
                if (custId == Convert.ToInt32(item.Split(' ')[0]))
                {
                    cboCustomer.SelectedItem = item;
                }
            }

            grdOrder_items.DataSource = Order_item.FindOrder_itemsByID(orID).Tables[0];
            */
        }

        private void BtnUpdateOrder_item_Click(object sender, EventArgs e)
        {
            //
            if (cboCustomer.Text == "" || textQuantity.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                MessageBox.Show("Order_item updated");
                this.Close();
            }
        }
    }
}
