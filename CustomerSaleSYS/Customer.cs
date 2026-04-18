using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace CustomerSaleSYS
{
    internal class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public char Status {  get; set; }


        public Customer(int id, string firstName, string lastName, string phone, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Status = 'A';
        }

        public Customer(int id, string firstName, string lastName, string phone, string email, char status) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Status = status;
        }

        public static Customer GetCustomer(int id)
        {
            string sqlQuery = "SELECT * FROM Customers WHERE CustomerId = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            string firstName = dr.GetString(1);
            string lastName = dr.GetString(2);
            string phone = dr.GetString(3);
            string email = dr.GetString(4);
            char status = dr.GetString(5)[0];
            dr.Close();
            
            return new Customer(id, firstName, lastName, phone, email, status); 
        }

        public static DataSet FindAllCustomers(String name) 
        {
            string sqlQuery = "SELECT CustomerID, Forename, Surname, Email FROM Customers WHERE ";
            if (name.Trim() == "")
            {
                sqlQuery += "Forename LIKE '%" + name + "%' ORDER BY Forename";
            }
            else {
                //https://learn.microsoft.com/en-us/dotnet/api/system.stringsplitoptions?view=net-10.0
                string[] check = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < check.Length; i++)
                {
                    check[i] = check[i].ToLower();
                }
                List<string> strings = new List<string>();
                for (int i = 0; i < check.Length; i++)
                {
                    strings.Add($"(LOWER(Forename) LIKE '%{check[i]}%' OR LOWER(Surname) LIKE '%{check[i]}%')");
                }
                sqlQuery += string.Join(" OR ", strings);
                sqlQuery += " ORDER BY Forename";
            }

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet FindActiveCustomers(String name)
        {
            string sqlQuery = "SELECT CustomerID, Forename, Surname, Email FROM Customers WHERE ";
            if (name.Trim() == "")
            {
                sqlQuery += "Status = 'A' AND Forename LIKE '%" + name + "%' ORDER BY Forename";
            }
            else
            {
                //https://learn.microsoft.com/en-us/dotnet/api/system.stringsplitoptions?view=net-10.0
                string[] check = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < check.Length; i++)
                {
                    check[i] = check[i].ToLower();
                }
                List<string> strings = new List<string>();
                for (int i = 0; i < check.Length; i++)
                {
                    strings.Add($"Status = 'A' AND ((LOWER(Forename) LIKE '%{check[i]}%' OR LOWER(Surname) LIKE '%{check[i]}%'))");
                }
                sqlQuery += string.Join(" OR ", strings);
                sqlQuery += " ORDER BY Forename";
            }

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public void AddCustomer()
        {
            Debug.WriteLine(this);//displaying state of the Customer object
            string sqlQuery = "INSERT INTO Customers Values (" +
                Id + ",'" +
                FirstName + "','" +
                LastName + "','" +
                Phone + "','" +
                Email + "','" +
                Status + "')";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateCustomer()
        {
            string sqlQuery = "UPDATE Customers SET " + 
                "CustomerID = " + Id + "," +
                "Forename = '" + FirstName + "'," +
                "Surname = '" + LastName + "'," +
                "Phone = '" + Phone + "'," +
                "Email = '" + Email + "'," +
                "Status = '" + Status + "' " +
                "WHERE CustomerID = " + Id;
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int GetNextCustomerID()
        {
            string sqlQuery = "SELECT MAX(CustomerId) FROM Customers";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextId;
            dr.Read();
            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;
            dr.Close() ;
            return nextId;
        }

        public static bool IsUniqEmail(String email)
        {
            string sqlQuery = "SELECT COUNT(CustomerId) FROM Customers WHERE Email = '" + email + "'";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            if (dr.GetInt32(0) == 0)
            {
                return true;
            }
            else
                return false;

            dr.Close();
        }

        public static char AddCboItem (char status)
        {
            if (status == 'A')
            return 'I';
            else 
                return 'A';
        }

        public static DataSet GetCustomerFullName()
        {
            String sqlQuery = "SELECT CustomerId, Forename, Surname " +
                                "FROM Customers " +
                                "WHERE Status LIKE 'A'";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static bool IsUniqEmailForUpdate(int id, String email)
        {
            string sqlQuery = "SELECT COUNT(CustomerId) FROM Customers WHERE Email = '" + email + "' AND CustomerId = " + id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            dr.Read();
            if (dr.GetInt32(0) == 1)
            {
                return true;
            }
            else
                return false;
            dr.Close();
        }
    }
}
