using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthWindow.Scripts
{
    internal class DataBase
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SH70RM_DESKTOP; Initial Catalog = text; Integrated Security = True");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
