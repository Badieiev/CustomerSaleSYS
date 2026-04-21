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
            string sqlQuery = "SELECT * FROM Orders ORDER BY OrderId";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet FindOrderByID(int id)
        {
            string sqlQuery = "SELECT * FROM Orders " +
                "WHERE OrderId = " + id;
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static void UpdateOrderDetails(int id, int custID, string date, char x)
        {
            string sqlQuery = "UPDATE Orders SET " +
                "CustomerId = " + custID + ", " +
                "OrderDate = '" + date + "'," +
                "Status = '" + x + "' " +
                "WHERE OrderId = " + id;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static decimal GetOrderSum(int id)
        {
            string sqlQuery = "SELECT OrderSum FROM Orders " +
                                "WHERE OrderId = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            decimal sum;
            dr.Read();
            sum = dr.GetDecimal(0);
            dr.Close();
            return sum;
        }

        public static void UpdateOrderSum(int id, decimal sum)
        {
            string sqlQuery = "UPDATE Orders SET " +
                "OrderSum = " + sum + " " +
                "WHERE OrderId = " + id;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindAllOrdersFullInfo()
        {
            string sqlQuery = "SELECT o.OrderId, c.Forename || ' ' || c.Surname AS Customer, o.OrderDate, o.OrderSum " +
                              "FROM Orders o JOIN Customers c ON o.CustomerId = c.CustomerId " +
                              "WHERE o.Status LIKE 'A' ORDER BY o.OrderId";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet FindOrderFullInfoByID(int id)
        {
            string sqlQuery = "SELECT o.OrderId, c.Forename || ' ' || c.Surname AS Customer, o.OrderDate, o.OrderSum " +
                              "FROM Orders o JOIN Customers c ON o.CustomerId = c.CustomerId " +
                              "WHERE o.Status LIKE 'A' AND o.OrderId = " + id;
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static void UpdateOrderStatus(int orderId, char x)
        {
            string sqlQuery = "UPDATE Orders SET " +
                "Status = '" + x + "' WHERE OrderId = " + orderId;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static Order GetOrder(int id)
        {
            string sqlQuery = "SELECT * FROM Orders WHERE OrderId = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            int cusomerId = dr.GetInt32(1);
            string date = dr.GetString(2);
            decimal sum = dr.GetDecimal(3);
            char status = dr.GetString(4)[0];
            dr.Close();

            return new Order(id, cusomerId, date, sum, status);
        }

        public static char AddCboItem(char status)
        {
            if (status == 'A')
                return 'I';
            else
                return 'A';
        }

        public static int CheckCustomerInOrders(int customerId)
        {
            string sqlQuery = "SELECT COUNT(CustomerId) " +
                              "FROM Orders " +
                              "WHERE CustomerId = " + customerId;
            DataSet dr = Database.ExecuteMultiRowQuery(sqlQuery);
            int check = 0;
            foreach (DataRow row in dr.Tables[0].Rows)
            {
                check += Convert.ToInt32(row[0].ToString());
            }
            return check;
        }
    }
}
