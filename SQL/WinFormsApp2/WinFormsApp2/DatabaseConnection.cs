using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp2
{
    public static class DatabaseConnection
    {
        //creating a static variable
        private static string connectionString = "server=.\\sqlexpresss;integrated security = true;database = civica";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ee)
            {
                return null;
            }
        }
    }
}
