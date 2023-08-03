using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionEstablish1
{
    public static class ConnectingDatabase
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
            catch (Exception e)
            {
                return null;
            }
        }
    }
}



