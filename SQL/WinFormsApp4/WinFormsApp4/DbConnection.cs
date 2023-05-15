using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace WinFormsApp4
{
    public static class DbConnection
    {
        private static string constr = "server=.\\sqlexpress;integrated security = true;database=civica";

        public static SqlConnection GetSqlConnection()
        {

        }
    }
}
