using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CustomerSaleSYS
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void FormCreateOrderLoad(object sender, EventArgs e)
        {
            textID.Text = Order.GetNextOrderID().ToString("0000");

            grdOrderItems.Columns.Add("ProducID", "ProductID");
            grdOrderItems.Columns.Add("ProductQuantity", "Quantity");
            grdOrderItems.Columns.Add("ProductCost", "Cost");

            DataSet dsCustomer = Customer.GetCustomerFullName();
            cboCustomer.Items.Clear();
            for (int i = 0; i < dsCustomer.Tables[0].Rows.Count; i++)
            {
                cboCustomer.Items.Add(dsCustomer.Tables[0].Rows[i][0] + " - " + dsCustomer.Tables[0].Rows[i][1] + " " + dsCustomer.Tables[0].Rows[i][2]);
            }
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;

            DataSet dsProduct = Product.GetActiveProductName();
            cboProduct.Items.Clear();
            cboProduct.DataSource = dsProduct.Tables[0];
            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductId";
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCreateOrder_Click(object sender, EventArgs e)
        {
            if (cboCustomer.Text == "")
            {
                MessageBox.Show("Specify customer");
            }
            else if (grdOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product to place an order.");
            }
            else
            {
                int orderId = Convert.ToInt32(textID.Text);
                int customerId = Convert.ToInt32(cboCustomer.Text.Split(' ')[0]);
                string orderDate = String.Format("{0:dd-MMM-yy}", dateTimePicker.Value);
                decimal total = Convert.ToDecimal(textTotal.Text);
                Order order = new Order(orderId, customerId, orderDate, total);
                order.AddOrder();

                foreach (DataGridViewRow row in grdOrderItems.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    int quantity = Convert.ToInt32(row.Cells[1].Value.ToString());
                    decimal cost = Convert.ToDecimal(row.Cells[2].Value.ToString());
                    Order_item order_Item = new Order_item(orderId, productId, quantity, cost);
                    order_Item.AddOrder_item();

                    Product.UpdateProductQuantity(productId, Product.GetProductQuantity(productId) - quantity);
                }

                MessageBox.Show("Order added");
                this.Close();
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (textQuantity.Text == "")
            {
                MessageBox.Show("Please indicate the quantity");
            }
            else if (!Validation.IsValidQuantity(textQuantity.Text))
            {
                MessageBox.Show("Incorrect data entered in the quantity field.");
            }
            else
            {
                int productID = int.Parse(cboProduct.SelectedValue.ToString());
                if (Product.GetProductQuantity(productID) < Convert.ToInt32(textQuantity.Text))
                {
                    MessageBox.Show("Unfortunately, the specified quantity is not available.");
                    return;
                }

                foreach (DataGridViewRow row in grdOrderItems.Rows)
                {
                    if (grdOrderItems.Rows.Count > 0)
                    {
                        string productIDinGRD = row.Cells[0].Value.ToString();
                        if (productID == int.Parse(productIDinGRD)) {
                            MessageBox.Show("It is not possible to add the same product multiple times.");
                            return;
                        }
                    }
                }

                decimal productPrice = Product.GetProductPrice(productID);
                grdOrderItems.Rows.Add(productID.ToString(), textQuantity.Text, ((int.Parse(textQuantity.Text))*productPrice).ToString());

                decimal total = 0;
                foreach (DataGridViewRow row in grdOrderItems.Rows)
                {
                    total += decimal.Parse(row.Cells[2].Value.ToString());
                }
                textTotal.Text = total.ToString();
                textQuantity.Clear();
            }
        }
    }
}
