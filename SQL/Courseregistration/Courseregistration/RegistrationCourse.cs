using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Courseregistration
{
    internal class RegistrationCourse
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=CourseRegistration2";
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

        public static DataSet GetTableNation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "TableNation");
            return ds;
        }

        public static DataSet GetTableState(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateName,s.StateId from TableState s inner join TableNation n on s.NationID = n.NationID where NationName = @NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds, "TableState");
            return ds;
        }

        public static DataSet GetTableCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityName,c.CityId from TableCity c inner join TableState s on c.StateID = s.StateID where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }

        public static string GetTableCourseRegDetail(int categoryid,string fullname,int genderid)
        {
            SqlConnection con = GetConnection();
            string query = "insert into TableCourseRegDetail values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@categoryid", categoryid);
            command.Parameters.AddWithValue("@fullname", fullname);
            command.Parameters.AddWithValue("@genderid", genderid);
            command.ExecuteNonQuery();
            con.Close();
            return "saved in the table TableCourseRegDetail";
        }
        static int courseregid = 0;
        public static string GetTableRegAddress(int nationid,int stateid,int cityid)
        {
            SqlConnection con = GetConnection();
            
            string query = "select top 1 CourseRegID from TableRegAddress order by CourseRegId desc";
            SqlCommand command = new SqlCommand(query,con);
            courseregid = Convert.ToInt32(command.ExecuteScalar());
            query = "insert into TableRegAddress values(@courseregid,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@courseregid", courseregid);
            command.Parameters.AddWithValue("@nationid", nationid);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@cityid", cityid);
            command.ExecuteNonQuery();
            con.Close();
            return "saved in the table TableRegAddress";
        }

        public static string GetTableFeeDetail(double totalamount,double minper,double paidamount,double balamount,DateTime paiddate)
        {
            SqlConnection con = GetConnection();
            
            string query = "insert into TableFeeDetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@courseregid", courseregid);
            command.Parameters.AddWithValue("@totalamount", totalamount);
            command.Parameters.AddWithValue("@minper", minper);
            command.Parameters.AddWithValue("@paidamount", paidamount);
            command.Parameters.AddWithValue("@balamount", balamount);
            command.Parameters.AddWithValue("@paiddate", paiddate);
            command.ExecuteNonQuery();
            con.Close();
            return "saved in the table TableFeeDetail";
        }
    }
}
