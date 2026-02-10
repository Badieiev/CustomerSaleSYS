using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace CustomerSaleSYS
{
    public partial class CustomerSaleSystem : Form
    {
        private Dropdown dropdown1;
        private Dropdown dropdown2;
        private Dropdown dropdown3;
        private Dropdown dropdown4;
        public CustomerSaleSystem()
        {
            InitializeComponent();

            dropdown1 = new Dropdown
            {
                Container = dropdownContainer1,
                IsExpanded = false,
                Timer = new Timer()
            };
            dropdown2 = new Dropdown
            {
                Container = dropdownContainer2,
                IsExpanded = false,
                Timer = new Timer()
            };
            dropdown3 = new Dropdown
            {
                Container = dropdownContainer3,
                IsExpanded = false,
                Timer = new Timer()
            };
            dropdown4 = new Dropdown
            {
                Container = dropdownContainer4,
                IsExpanded = false,
                Timer = new Timer()
            };
            dropdown1.Timer.Interval = 30;
            dropdown2.Timer.Interval = 30;
            dropdown3.Timer.Interval = 30;
            dropdown4.Timer.Interval = 30;

            dropdown1.Timer.Tick += (s, e) => AnimateDropdown(dropdown1);
            dropdown2.Timer.Tick += (s, e) => AnimateDropdown(dropdown2);
            dropdown3.Timer.Tick += (s, e) => AnimateDropdown(dropdown3);
            dropdown4.Timer.Tick += (s, e) => AnimateDropdown(dropdown4);
        }

        private void customer_Click(object sender, EventArgs e)
        {
            if (!dropdown1.Timer.Enabled)
            {
                dropdown1.Timer.Start();
            }
        }
        private void product_Click(object sender, EventArgs e)
        {
            if (!dropdown2.Timer.Enabled)
            {
                dropdown2.Timer.Start();
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (!dropdown3.Timer.Enabled)
            {
                dropdown3.Timer.Start();
            }
        }

        private void admin_Click(object sender, EventArgs e)
        {
            if (!dropdown4.Timer.Enabled)
            {
                dropdown4.Timer.Start();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void AnimateDropdown(Dropdown dropdown)
        {
            if (!dropdown.IsExpanded)
            {
                dropdown.Container.Height += 15;
                if (dropdown.Container.Height >= dropdown.Container.MaximumSize.Height)
                {
                    dropdown.Timer.Stop();
                    dropdown.IsExpanded = true;
                }
            }
            else
            {
                dropdown.Container.Height -= 15;
                if (dropdown.Container.Height <= dropdown.Container.MinimumSize.Height)
                {
                    dropdown.Timer.Stop();
                    dropdown.IsExpanded = false;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //
        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            AddCustomer newForm2 = new AddCustomer();
            newForm2.ShowDialog();
        }
        private void update_customer_Click(object sender, EventArgs e)
        {
            UpdateCustomer newForm3 = new UpdateCustomer();
            newForm3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void remove_customer_Click(object sender, EventArgs e)
        {
            RemoveCustomer newForm3 = new RemoveCustomer();
            newForm3.ShowDialog();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            AddProduct newForm4 = new AddProduct();
            newForm4.ShowDialog();
        }

        private void update_product_Click(object sender, EventArgs e)
        {
            UpdateProduct newForm5 = new UpdateProduct();
            newForm5.ShowDialog();
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            DeleteProduct newForm6 = new DeleteProduct();
            newForm6.ShowDialog();
        }

        private void create_order_Click(object sender, EventArgs e)
        {
            CreateOrder newForm7 = new CreateOrder();
            newForm7.ShowDialog();
        }

        private void update_order_Click(object sender, EventArgs e)
        {
            UpdateOrder newForm8 = new UpdateOrder();
            newForm8.ShowDialog();
        }

        private void delete_order_Click(object sender, EventArgs e)
        {
            DeleteOrder newForm9 = new DeleteOrder();
            newForm9.ShowDialog();
        }

        private void revenue_analysis_Click(object sender, EventArgs e)
        {
            RevenueAnalysis newForm10 = new RevenueAnalysis();
            newForm10.ShowDialog();
        }

        private void product_analysis_Click(object sender, EventArgs e)
        {
            ProductAnalysis newForm11 = new ProductAnalysis();
            newForm11.ShowDialog();
        }
    }
}
