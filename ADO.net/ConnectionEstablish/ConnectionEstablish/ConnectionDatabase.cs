using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConnectionEstablish
{
    public static class ConnectionDatabase
    {
        public static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=student";
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
