using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPITSAdmission
{
    internal class AdmissionDatabase
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=StudentAdmissionProcess";
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

        public static DataSet GetCountry()
        {
            SqlConnection con = GetConnection();
            string query = "select CountryName from TableCountry";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableCountry");
            return ds;
        }
        public static DataSet GetState(string CountryName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateName from TableState s inner join TableCountry t on s.CountryId = t.CountryId where CountryName = @CountryName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@CountryName", CountryName);
            da.Fill(ds, "TableState");
            return ds;
        }

        public static DataSet GetCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityName from TableCity c inner join TableState t on c.StateId = t.StateId where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }

        public static DataSet GetCourse()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableCourse";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableCourse");
            return ds;
        }

        public static DataSet GetFees(string CourseName)
        {
            SqlConnection con = GetConnection();
            string query = "select fees from TableCourse where CourseName = @CourseName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@CourseName", CourseName);
            da.Fill(ds, "TableCourse");
            return ds;
        }

        public static string InsertAdmissionDetails(string studentname,string gender,string contact,string country,string state,string city,DateTime date,int courseid,int fees,double amountpaid,double balance)
        {
            SqlConnection con = GetConnection();
            string query = "insert into TableAdmissionDetails values(@studentname,@gender,@contact,@country,@state,@city,@date,@courseid,@fees,@amountpaid,@balance)";
            string result = null;
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@studentname", studentname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@fees", fees);
                command.Parameters.AddWithValue("@amountpaid", amountpaid);
                command.Parameters.AddWithValue("@balance", balance);
                command.ExecuteNonQuery();
                result = "Saved successfully";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally { con.Close(); }
            return result;
        }
    }
}
