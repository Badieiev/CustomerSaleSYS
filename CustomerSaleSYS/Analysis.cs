using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CustomerSaleSYS
{
    internal class Analysis
    {
        public static void PopulateRevenueChartByYear(Chart chart, int year)
        {
            string query = "SELECT SUM(OrderSum), to_Char(OrderDate,'MM') " +
                            "FROM Orders " +
                            "WHERE EXTRACT(YEAR FROM OrderDate) = " + year +
                            "GROUP BY to_Char(OrderDate,'MM') " +
                            "ORDER BY to_Char(OrderDate,'MM')";
            DataSet ds = Database.ExecuteMultiRowQuery(query);

            //Initialise the arrays
            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            decimal[] amounts = new decimal[12]; //all set to zero

            //Next, save the amounts returned in query to the appropriate element in amounts[]
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                amounts[Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);

            //decide if you want grid lines on the chart (none at present)
            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart.Series[0].LegendText = "Income in €";
            //tie the arrays to the x and y axes of the chart
            chart.Series[0].Points.DataBindXY(months, amounts);
            //the amounts will appear atop the bars in the chart
            chart.Series[0].Label = "#VALY";
            chart.Titles.Add("Yearly Revenue " + year); //Chart title
            chart.ChartAreas[0].AxisX.Title = "Month"; //x-axis title
            chart.ChartAreas[0].AxisY.Title = "Income"; //y-axis title
            chart.ChartAreas[0].AxisX.Interval = 1; // Show every label
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.Visible = true;
        }

        public static DataSet GetYearFromOrders()
        {
            String sqlQuery = "SELECT to_Char(OrderDate,'YYYY') " +
                                "FROM Orders " +
                                "GROUP BY to_Char(OrderDate,'YYYY') " +
                                "ORDER BY to_Char(OrderDate,'YYYY')";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        /*
        public static void PopulateProductChartByYear(Chart chart, int year)
        {
            string query = "SELECT SUM(OrderSum), to_Char(OrderDate,'MM') " +
                            "FROM Orders " +
                            "WHERE EXTRACT(YEAR FROM OrderDate) = " + year +
                            "GROUP BY to_Char(OrderDate,'MM') " +
                            "ORDER BY to_Char(OrderDate,'MM')";
            DataSet ds = Database.ExecuteMultiRowQuery(query);

            //Initialise the arrays
            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            decimal[] amounts = new decimal[12]; //all set to zero

            //Next, save the amounts returned in query to the appropriate element in amounts[]
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                amounts[Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);

            //decide if you want grid lines on the chart (none at present)
            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart.Series[0].LegendText = "Income in €";
            //tie the arrays to the x and y axes of the chart
            chart.Series[0].Points.DataBindXY(months, amounts);
            //the amounts will appear atop the bars in the chart
            chart.Series[0].Label = "#VALY";
            chart.Titles.Add("Yearly Revenue " + year); //Chart title
            chart.ChartAreas[0].AxisX.Title = "Month"; //x-axis title
            chart.ChartAreas[0].AxisY.Title = "Income"; //y-axis title
            chart.ChartAreas[0].AxisX.Interval = 1; // Show every label
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.Visible = true;
        }*/
    }
}
