using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerSaleSYS
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public char Status { get; set; }

        public Product (int iD, string name, int quantity, decimal price)
        {
            ID = iD;
            Name = name;
            Quantity = quantity;
            Price = price;
            Status = 'A';
        }

        public Product(int iD, string name, int quantity, decimal price, char status)
        {
            ID = iD;
            Name = name;
            Quantity = quantity;
            Price = price;
            Status = status;
        }



        public void AddProduct()
        {
            Debug.WriteLine(this);//displaying state of the Product object
            string sqlQuery = "INSERT INTO Products Values (" +
                ID + ",'" +
                Name + "','" +
                Quantity + "','" +
                Price + "','" +
                Status + "')";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int GetNextProductID()
        {
            string sqlQuery = "SELECT MAX(ProductId) FROM Products";
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

        public static bool IsUniqName(String name)
        {
            string sqlQuery = "SELECT MAX(ProductID) FROM Products WHERE ProductName = '" + name + "'";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            if (dr.IsDBNull(0))
            {
                return true;
            }
            else
                return false;

            dr.Close();
        }

        public static DataSet FindAllProducts(String name)
        {
            string sqlQuery = "SELECT ProductID, ProductName, Quantity, Price FROM Products " +
                "WHERE LOWER(ProductName) LIKE '%" + name.ToLower() + "%' ORDER BY ProductName";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet FindActiveProducts(String name)
        {
            string sqlQuery = "SELECT ProductID, ProductName, Quantity, Price FROM Products " +
                "WHERE Status = 'A' AND LOWER(ProductName) LIKE '%" + name.ToLower() + "%' ORDER BY ProductName";
            Console.WriteLine(sqlQuery);
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Product GetProduct(int id)
        {
            string sqlQuery = "SELECT * FROM Products WHERE ProductID = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            string name = dr.GetString(1);
            int quantity = dr.GetInt32(2);
            decimal price = dr.GetDecimal(3);
            char status = dr.GetString(4)[0];
            dr.Close();

            return new Product(id, name, quantity, price, status);
        }

        public void UpdateProduct()
        {
            string sqlQuery = "UPDATE Products SET " +
                "ProductID = " + ID + "," +
                "ProductName = '" + Name + "'," +
                "Quantity = '" + Quantity + "'," +
                "Price = '" + Price + "'," +
                "Status = '" + Status + "' " +
                "WHERE ProductID = " + ID;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static char AddCboItem(char status)
        {
            if (status == 'A')
                return 'I';
            else
                return 'A';
        }
    }
}
