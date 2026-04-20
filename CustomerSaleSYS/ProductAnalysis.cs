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
    public partial class ProductAnalysis : Form
    {
        public ProductAnalysis()
        {
            InitializeComponent();
        }

        private void FormProductAnalysisLoad(object sender, EventArgs e)
        {
            DataSet dsOrder = Analysis.GetYearFromOrders();
            cboYear.Items.Clear();
            for (int i = 0; i < dsOrder.Tables[0].Rows.Count; i++)
            {
                cboYear.Items.Add(dsOrder.Tables[0].Rows[i][0]);
            }
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
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
                Analysis.PopulateProductChartByYear(chtData, Convert.ToInt32(cboYear.SelectedItem));
            }
        }
    }
}
