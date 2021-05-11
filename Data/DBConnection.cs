using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBConnection
    {
        static protected SqlConnection _conn;
        public static SqlCommand _cmd;
        static protected string _connString = @"Data Source=.;Initial Catalog=BankPride;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            _conn = new SqlConnection(_connString);
            return _conn;
        }

        public static bool QueryExecute(string statement)
        {
            GetConnection();
            using (_cmd = new SqlCommand(statement, _conn))
            {
                if (_conn == null)
                {
                    throw new Exception("Unable to connect");
                }
                _conn.Open();
                _cmd.ExecuteNonQueryAsync();
            }
            _conn.Close();
            return true;
        }
    }
}
