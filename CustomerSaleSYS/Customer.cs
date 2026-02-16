using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSaleSYS
{
    internal class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer(int id, string firstName, string lastName, string phone, string email) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }

        public override string ToString() 
        {
            return "Customer ID: " + Id + "\tName: " + FirstName + "\tSurname: " + LastName + 
                "\tPhone: " + Phone + "\tEmail: " + Email;
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
            dr.Close();
            
            return new Customer(id, firstName, lastName, phone, email); 
        }

        public static DataSet FindCustomers(String name) 
        {
            string sqlQuery = "SELECT CustomerID, Forename, Surname, Email FROM Customers " +
                "WHERE Forename LIKE '%" + name + "%' ORDER BY Forename";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
