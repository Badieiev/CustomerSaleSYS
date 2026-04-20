using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerSaleSYS
{
    internal class DatabaseLoader
    {
        public static void IsCustomerTableExists()
        {
            try
            {
                string sql = "CREATE TABLE Customers (" +
                    "CustomerID number(4), " + 
                    "Forename varchar2(20), " + 
                    "Surname varchar2(20), " +
                    "Phone varchar2(20), " +
                    "Email varchar2(20), " + 
                    "Status char(1), " +
                    "CONSTRAINT pk_Customers PRIMARY KEY (CustomerID))";
                Database.ExecuteNonQuery(sql);
            }
            catch (OracleException e)
            {
            //https://docs.oracle.com/en/error-help/db/ora-00955/?r=26ai
                if (e.Number != 955)
                    throw;
            }
        }

        public static void IsProductTableExists()
        {
            try
            {
                string sql = "CREATE TABLE Products (" +
                    "ProductID number(4), " +
                    "ProductName varchar2(50), " +
                    "Quantity number(10), " +
                    "Price number(10,2), " +
                    "Status char(1), " +
                    "CONSTRAINT pk_Products PRIMARY KEY(ProductID))";
                Database.ExecuteNonQuery(sql);
            }
            catch (OracleException e)
            {
                //https://docs.oracle.com/en/error-help/db/ora-00955/?r=26ai
                if (e.Number != 955)
                    throw;
            }
        }
    }
}
