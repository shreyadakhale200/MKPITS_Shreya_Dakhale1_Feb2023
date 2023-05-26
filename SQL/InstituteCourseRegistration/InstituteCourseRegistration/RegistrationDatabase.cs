using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteCourseRegistration
{
    internal class RegistrationDatabase
    {
        private static string ConnectionString = "server = .\\sqlexpress;integrated security = true; database = InstituteCourseRegistration";

        //Method to Setup a Database Connection
        public static SqlConnection GetConnection()
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

        //Method to return Nation Name 
        public static DataSet GetTableNation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableNation");
            return ds;
        }

        //Method to return StateName from NationName
        //using JOIN
        public static DataSet GetTableState(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateName,s.StateID from TableState s inner join TableNation t on s.NationID = t.NationID where NationName = @NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds, "TableState");
            return ds;
        }

        //Mathod to return CityName from StateName 
        public static DataSet GetCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityName,c.CityID from TableCity c inner join TableState s on c.StateID = s.StateID where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }

        public static DataSet GetTotalAmount(string FullName)
        {
            SqlConnection con = GetConnection();
            string query = "select t.TotalAmount from TableFeeDetail t inner join TableCourseRegDetail r on t.CourseRegID = r.CourseRegID where FullName = @FullName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@FullName", FullName);
            da.Fill(ds, "TableFeeDetail");
            return ds;
        }
    }
}
