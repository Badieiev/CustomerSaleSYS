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
            string sqlQuery = "SELECT OrderId, ProductId, Quantity, Cost FROM Order_items " +
                "WHERE Status LIKE 'A' AND OrderId LIKE " + id;
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
