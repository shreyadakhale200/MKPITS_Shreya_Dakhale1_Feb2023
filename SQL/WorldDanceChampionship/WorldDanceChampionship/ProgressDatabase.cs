using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WorldDanceChampionship
{
    internal class ProgressDatabase
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security = true;database=Championship";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
    }
}
