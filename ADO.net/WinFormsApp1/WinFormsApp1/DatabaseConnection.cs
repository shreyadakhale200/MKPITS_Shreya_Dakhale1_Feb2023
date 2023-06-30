using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    internal class DatabaseConnection
    {
        //creating a variable to store connection 
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=Movies";

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                return con;
            }
            catch(SqlException ex)
            {
                return null;
            }
        }

    }
}
