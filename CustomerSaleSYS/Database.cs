using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CustomerSaleSYS
{
    internal class Database
    {
        public static string connectionString = FileReader.GetConnectionString();
        //public const string connectionString = "Data Source = localhost/orcl; User Id = xxxxxxxxx; Password = **********;";
        //public const string connectionString = "Data Source = studentoracle:1521/orcl; User Id = tnnnnnnnn; Password = **********;";

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
