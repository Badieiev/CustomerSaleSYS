using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerSaleSYS
{
    internal class Order
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public decimal Sum { get; set; }
        public char Status { get; set; }


        public Order (int id, int customerId, string date, decimal sum)
        {
            ID = id;
            CustomerId = customerId;
            Date = date;
            Sum = sum;
            Status = 'A';
        }
        public Order(int id, int customerId, string date, decimal sum, char status)
        {
            ID = id;
            CustomerId = customerId;
            Date = date;
            Sum = sum;
            Status = status;
        }





        public static int GetNextOrderID()
        {
            string sqlQuery = "SELECT MAX(OrderId) FROM Orders";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextId;
            dr.Read();
            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;
            dr.Close();
            return nextId;
        }

        public void AddOrder()
        {
            Debug.WriteLine(this);//displaying state of the Customer object
            string sqlQuery = "INSERT INTO Orders Values (" +
                ID + ",'" +
                CustomerId + "','" +
                Date + "','" +
                Sum + "','" +
                Status + "')";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindAllOrders()
        {
            string sqlQuery = "SELECT OrderId, CustomerId, OrderDate, OrderSum FROM Orders WHERE Status LIKE 'A'";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet FindOrderByID(int id)
        {
            string sqlQuery = "SELECT OrderId, CustomerId, OrderDate, OrderSum FROM Orders " +
                "WHERE OrderId LIKE '%" + id + "%' AND Status LIKE 'A'";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        //update order using an object or direct sql?
        public static void UpdateOrderCustomerDetails(int id, int custID, string date)
        {
            string sqlQuery = "UPDATE Orders SET " +
                "CustomerId = " + custID + "," +
                "OrderDate = '" + date + "' " +
                "WHERE OrderId = " + id;
            Database.ExecuteNonQuery(sqlQuery);
        }
    }
}
