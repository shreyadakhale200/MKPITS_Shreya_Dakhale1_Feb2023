using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Storelibrary
{
    internal class ConnectionDB
    {
        public static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=TrustProject";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
           
            return con;
        }
    }
}
