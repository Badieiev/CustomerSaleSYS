using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSaleSYS
{
    internal class Order_item
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public char Status { get; set; }

        public Order_item (int orderID, int productID, int quantity, decimal cost)
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Cost = cost;
            Status = 'A';
        }

        public Order_item (int orderID, int productID, int quantity, decimal cost, char status) 
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Cost = cost;
            Status = status;
        }

        public void AddOrder_item()
        {
            Debug.WriteLine(this);//displaying state of the Customer object
            string sqlQuery = "INSERT INTO Order_items Values (" +
                OrderID + ",'" +
                ProductID + "','" +
                Quantity + "','" +
                Cost + "','" +
                Status + "')";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindOrder_itemsByID(int id)
        {
            string sqlQuery = "SELECT * FROM Order_items " +
                              "WHERE OrderId LIKE " + id;
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static void UpdateOrder_itemStatus(int orderId, int productId, char x)
        {
            string sqlQuery = "UPDATE Order_items SET " +
                "Status = '" + x + "' " +
                "WHERE OrderId = " + orderId + " AND ProductId = " +productId;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static void UpdateOrder_itemDetails(int orderId, int productId, int quantity, decimal cost)
        {
            string sqlQuery = "UPDATE Order_items SET " +
                "Quantity = " + quantity + "," +
                "Cost = '" + cost + "' " +
                "WHERE OrderId = " + orderId + " AND ProductId = " + productId;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static bool IsUniqOrder_item(int orderId, int productId)
        {
            string sqlQuery = "SELECT MAX(OrderId) FROM Order_items WHERE OrderId = " + orderId + " AND ProductId = " + productId;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            if (dr.IsDBNull(0))
                return true;
            else
                return false;
            dr.Close();
        }

        public static decimal GetOrderSum(int orderId)
        {
            string sqlQuery = "SELECT SUM(Cost) FROM Order_items WHERE Status = 'A' AND OrderId = " + orderId;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            decimal sum;
            dr.Read();
            if (dr.IsDBNull(0))
                sum=0;
            else
                sum =dr.GetDecimal(0);
            dr.Close();
            return sum;
        }

        public static char AddCboItem(char status)
        {
            if (status == 'A')
                return 'I';
            else
                return 'A';
        }

        public static int CountActiveOrder_Items(int id)
        {
            string sqlQuery = "SELECT COUNT(Status) FROM Order_items WHERE Status LIKE 'A' AND OrderId = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int num;
            dr.Read();
            if (dr.IsDBNull(0))
                num = 0;
            else
                num = dr.GetInt32(0);
            dr.Close();
            return num;
        }

        public static int CheckProductInOrder_items(int productId)
        {
            string sqlQuery = "SELECT COUNT(ProductId) " +
                              "FROM Order_items " +
                              "WHERE ProductId = " + productId;
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
