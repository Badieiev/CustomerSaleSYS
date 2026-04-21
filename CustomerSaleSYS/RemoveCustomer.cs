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
    public partial class RemoveCustomer : Form
    {
        private Customer customer;
        public RemoveCustomer()
        {
            InitializeComponent();
        }

        private void ButtonSearchCustomer_Click(object sender, EventArgs e)
        {
            grdCustomers.DataSource = Customer.FindActiveCustomers(textSearchCustomer.Text).Tables[0];

            if (grdCustomers.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                textSearchCustomer.Focus();
                return;
            }
            grdCustomers.Visible = true;
        }
        private void GrdCustomersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value);
            customer = Customer.GetCustomer(id);
            textCustomerId.Text = customer.Id.ToString();
            textName.Text = customer.FirstName;
            textSurname.Text = customer.LastName;
            textPhone.Text = customer.Phone;
            textEmail.Text = customer.Email;
            grpCustomer.Visible = true;
        }

        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(textCustomerId.Text);
            if (Order.CheckCustomerInOrders(customerId) > 0)
            {
                MessageBox.Show("It is impossible to delete a user while an order involving this user has been created.");
            }
            else
            {
                customer.FirstName = textName.Text;
                customer.LastName = textSurname.Text;
                customer.Phone = textPhone.Text;
                customer.Email = textEmail.Text;
                customer.Status = 'I';
                customer.UpdateCustomer();
                MessageBox.Show("Profile deleted");
                this.Close();
            }
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
