using System;
using System.Data;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public partial class UpdateOrder : Form
    {
        private Order order;
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
            cboOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductStatus.DropDownStyle = ComboBoxStyle.DropDownList;
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
        }

        private void GrdOrdersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            textQuantity.Clear();
            int orID = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value);
            order = Order.GetOrder(orID);
            textOrderId.Text = order.ID.ToString();
            dateTimePicker.Value = DateTime.Parse(order.Date);
            int custId = order.CustomerId;

            foreach (string item in cboCustomer.Items)
            {
                if (custId == Convert.ToInt32(item.Split(' ')[0])) 
                {
                    cboCustomer.SelectedItem = item;
                }
            }

            cboOrderStatus.Items.Clear();
            cboOrderStatus.Items.Add(order.Status);
            cboOrderStatus.Items.Add(Order.AddCboItem(order.Status));
            cboOrderStatus.SelectedIndex = 0;
            if (order.Status == 'A')
            {
                cboOrderStatus.Visible = false;
                labelOrderStatus.Visible = false;
                cboCustomer.Enabled = true;
                dateTimePicker.Enabled = true;
                grdOrder_items.DataSource = Order_item.FindOrder_itemsByID(orID).Tables[0];
            }
            else
            {
                cboOrderStatus.Visible = true;
                labelOrderStatus.Visible = true;
                cboCustomer.Enabled = false;
                dateTimePicker.Enabled = false;
                grdOrder_items.DataSource = null;
            }
        }

        private void BtnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (textOrderId.Text == "")
            {
                MessageBox.Show("Select the order you want to change");
            }
            else if (cboOrderStatus.Text == "I")
            {
                MessageBox.Show("The order is currently inactive, you can change its status.");
            }
            else
            {
                foreach (DataGridViewRow row in grdOrders.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(textOrderId.Text))
                    {
                        if ((Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(cboCustomer.SelectedItem.ToString().Split(' ')[0])) &&
                            (DateTime.Parse(row.Cells[2].Value.ToString()) == dateTimePicker.Value.Date) &&
                            cboOrderStatus.Visible == false)
                        {
                            MessageBox.Show("You have not changed the customer or date, so the order will remain unchanged.");
                        }
                        else
                        {
                            int orderID = Convert.ToInt32(textOrderId.Text);
                            int customerID = Convert.ToInt32(cboCustomer.SelectedItem.ToString().Split(' ')[0]);
                            string date = String.Format("{0:dd-MMM-yy}", dateTimePicker.Value);
                            char status = cboOrderStatus.SelectedItem.ToString()[0];

                            Order.UpdateOrderDetails(orderID, customerID, date, status);
                            MessageBox.Show("Order updated");
                            this.Close();
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

            cboProductStatus.Items.Clear();
            char status = Convert.ToChar(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[4].Value);
            cboProductStatus.Items.Add(status);
            cboProductStatus.Items.Add(Order_item.AddCboItem(status));
            cboProductStatus.SelectedIndex = 0;
            if (status == 'A')
            {
                cboProductStatus.Visible = false;
                labelProductStatus.Visible=false;
                cboProduct.Enabled = true;
                textQuantity.Enabled = true;
            }
            else
            {
                cboProductStatus.Visible = true;
                labelProductStatus.Visible = true;
                cboProduct.Enabled = false;
                textQuantity.Enabled = false;
            }
        }

        private void BtnDeleteOrder_item_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedItem == null || textQuantity.Text == "")
            {
                MessageBox.Show("Select an item from your order");
            }
            else if (cboProductStatus.SelectedItem.ToString()[0] == 'I')
            {
                MessageBox.Show("The product has already been removed, product status I");
            }
            else if (Order_item.CountActiveOrder_Items(Convert.ToInt32(textOrderId.Text)) == 1)
            {
                MessageBox.Show("It is not possible to remove the last item from the order. But you can delete the order.");
            }
            else if (Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[2].Value) != Convert.ToInt32(textQuantity.Text) ||
                    Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[1].Value) != Convert.ToInt32(cboProduct.Text.Split(' ')[0]))
            {
                MessageBox.Show("The product or quantity of the product does not match the selected one");
            }
            else
            {
                int orderId = Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[0].Value);
                int productId = Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[1].Value);
                int quantity = Convert.ToInt32(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[2].Value);
                decimal cost = Convert.ToDecimal(grdOrder_items.Rows[grdOrder_items.CurrentCell.RowIndex].Cells[3].Value);

                decimal total = Order.GetOrderSum(orderId);
                Order.UpdateOrderSum(orderId, total - cost);

                Order_item.UpdateOrder_itemStatus(orderId, productId, 'I');
                Product.UpdateProductQuantity(productId, Product.GetProductQuantity(productId) + quantity);
                MessageBox.Show("You have removed the selected product from order.");
                this.Close();

            }
        }

        private void BtnAddOrder_item_Click(object sender, EventArgs e)
        {
            if(textOrderId.Text == "")
            {
                MessageBox.Show("You haven't selected an order yet.");
            }
            else if (cboProduct.SelectedItem == null || textQuantity.Text == "")
            {
                MessageBox.Show("Select the product you want to add to your order and the quantity.");
            }
            else if (Product.GetProductQuantity(Convert.ToInt32(cboProduct.Text.Split(' ')[0])) < Convert.ToInt32(textQuantity.Text))
            {
                MessageBox.Show("Unfortunately, the specified quantity is not available.");
            }
            else if (!Order_item.IsUniqOrder_item(Convert.ToInt32(textOrderId.Text), Convert.ToInt32(cboProduct.Text.Split(' ')[0])))
            {
                MessageBox.Show("This order already contains this product. Please select a product from the drop-down list that is not yet in your order. " + 
                                "\n\nThe list is available for selection if you are on the line with active status A.");
            }
            else
            {
                int productId = Convert.ToInt32(cboProduct.Text.Split(' ')[0]);
                foreach (DataGridViewRow row in grdOrder_items.Rows)
                {
                    if (grdOrder_items.Rows.Count > 0)
                    {
                        string productIDinGRD = row.Cells[0].Value.ToString();
                        if (productId == Convert.ToInt32(productIDinGRD))
                        {
                            MessageBox.Show("It is not possible to add the same product multiple times.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Data Found");
                        return;
                    }
                }

                decimal productPrice = Product.GetProductPrice(productId);
                int quantity = Convert.ToInt32(textQuantity.Text);
                decimal cost = productPrice * quantity;
                int orderId = Convert.ToInt32(textOrderId.Text);
                decimal total = Order.GetOrderSum(orderId) + cost;
                Order.UpdateOrderSum(orderId, total);

                Order_item order_Item = new Order_item(orderId, productId, quantity, cost);
                order_Item.AddOrder_item();
                Product.UpdateProductQuantity(productId, Product.GetProductQuantity(productId) - quantity);

                MessageBox.Show("You have added the product to order.");
                this.Close();
            }
                
        }

        private void BtnUpdateOrder_item_Click(object sender, EventArgs e)
        {
            if (textOrderId.Text == "")
            {
                MessageBox.Show("You haven't selected an order yet.");
            }
            else if (cboProduct.SelectedItem == null || textQuantity.Text == "")
            {
                MessageBox.Show("Select the product you want to change in order and quantity.");
            }
            else if (cboProductStatus.Text == "I")
            {
                MessageBox.Show("The product in order is currently inactive, you can change its status.");
            }
            else
            {
                bool checkProduct = false;
                int grdQuantity =0;
                decimal tableCost =0;
                foreach (DataGridViewRow row in grdOrder_items.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(cboProduct.Text.Split(' ')[0]))
                    {
                        grdQuantity = Convert.ToInt32(row.Cells[2].Value);
                        tableCost = Convert.ToDecimal(row.Cells[3].Value);
                        checkProduct = true;
                        break;
                    }
                }

                if (checkProduct) 
                {
                    int orderId = Convert.ToInt32(textOrderId.Text);
                    int productId = Convert.ToInt32(cboProduct.Text.Split(' ')[0]);
                    int inputQuantity = Convert.ToInt32(textQuantity.Text);
                    int stockQuantity = Product.GetProductQuantity(productId);
                    decimal cost = Product.GetProductPrice(productId) * inputQuantity;
                    decimal total = Order.GetOrderSum(orderId);

                    if (cboProductStatus.Text == "A" && cboProductStatus.Visible == true)
                    {
                        if (stockQuantity < inputQuantity)
                        {
                            MessageBox.Show("Unfortunately, the specified quantity is not available.");
                            return;
                        }
                        Product.UpdateProductQuantity(productId, Product.GetProductQuantity(productId) - inputQuantity);
                        Order.UpdateOrderSum(orderId, total + cost);
                        Order_item.UpdateOrder_itemStatus(orderId, productId, 'A');
                        MessageBox.Show("The status of the product in the order has been updated.");
                        this.Close();
                    }
                    else if (grdQuantity == inputQuantity) 
                    {
                        MessageBox.Show("The quantity of product has not changed.");
                    }
                    else
                    {
                        if (stockQuantity < (inputQuantity - grdQuantity))
                        {
                            MessageBox.Show("Unfortunately, the specified quantity is not available.");
                            return;
                        }
                        Product.UpdateProductQuantity(productId, stockQuantity + grdQuantity - inputQuantity);
                        Order_item.UpdateOrder_itemDetails(orderId, productId, inputQuantity, cost);
                        Order.UpdateOrderSum(orderId, Order_item.GetOrderSum(orderId));
                        MessageBox.Show("The quantity of product in the order has been changed");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("It is not possible to change the quantity of a product that is not included in the order.");
                }
            }
        }
    }
}
