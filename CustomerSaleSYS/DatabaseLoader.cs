using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
