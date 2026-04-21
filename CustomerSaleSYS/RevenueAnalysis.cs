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
    public partial class RevenueAnalysis : Form
    {
        public RevenueAnalysis()
        {
            InitializeComponent();
        }

        private void FormRevenueAnalysisLoad(object sender, EventArgs e)
        {
            DataSet dsOrder = Analysis.GetYearFromOrders();
            cboYear.Items.Clear();
            for (int i = 0; i < dsOrder.Tables[0].Rows.Count; i++)
            {
                cboYear.Items.Add(dsOrder.Tables[0].Rows[i][0]);
            }
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;

            lsbOutput.Visible = false;
            chtData.Visible = false;
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonShowGraph_Click(object sender, EventArgs e)
        {
            if (cboYear.Items.Count == 0)
            {
                MessageBox.Show("Data not found, please check the contents of the order table.");
            }
            else if (cboYear.SelectedItem == null)
            {
                MessageBox.Show("Select a year from the drop-down list.");
            }
            else
            {
                int year = Convert.ToInt32(cboYear.SelectedItem);
                var monthlyRevenue = Analysis.GetRenevuePerMonth(year);
                lsbOutput.Items.Clear();
                lsbOutput.Items.Add("Monthly revenue for " + year);
                foreach (var item in monthlyRevenue)
                {
                    lsbOutput.Items.Add(item.Key + ": " + item.Value + " €");
                }
                lsbOutput.Visible = true;

                Analysis.PopulateRevenueChartByYear(chtData, year);
                chtData.Visible = true;
            }
        }
    }
}
