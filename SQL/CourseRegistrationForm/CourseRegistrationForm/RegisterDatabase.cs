using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationForm
{
    internal class RegisterDatabase
    {
        private static string ConnectionString = "server = .\\sqlexpress;integrated security = true;Database = InstituteCourseRegistration";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static DataSet GetNation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds,"TableNation");
            return ds;
        }
    }
}
