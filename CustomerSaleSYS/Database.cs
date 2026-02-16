using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSaleSYS
{
    internal class Database
    {
        public const string connectionString = "Data Source = localhost/orcl; User Id = C##andrii; Password = A104Oracle;";

        public static OracleConnection OpenConnection() {
            OracleConnection conn = new OracleConnection(Database.connectionString);
            conn.Open();
            return conn;
        }

        public static DataSet ExecuteMultiRowQuery(string query) { 
            OracleConnection conn = OpenConnection();
            //DB request
            OracleCommand cmd = new OracleCommand(query, conn);
            //OracleDataAdapter as a bridge between DB and DataSet
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public static OracleDataReader ExecuteSingleRowQuery(string query) {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static void ExecuteNonQuery(string query) {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
