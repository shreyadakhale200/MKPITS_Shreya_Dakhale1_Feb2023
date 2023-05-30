using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteCourseRegistration
{
    internal class RegistrationCourseDatabase
    {
        private static string ConnectionString = "server = .\\sqlexpress;integrated security = true;database = CourseRegistration2";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                return con;
            }
            catch(Exception ex)
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
            da.Fill(ds, "TableNation");
            return ds;
        }
        public static DataSet GetState(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateName,s.StateID from TableState s inner join TableNation n on s.NationID = n.NationID where NationName = @NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@NationName",NationName);
            da.Fill(ds, "TableState");
            return ds;
        }
        public static DataSet GetCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityName,c.CityID from TableCity c inner join TableState s on c.StateID = s.StateId where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }

        public static string SaveTableCourseRegDetail(int categoryid,string fullname,int genderid)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetail values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@categoryid", categoryid);
            command.Parameters.AddWithValue("@fullname", fullname);
            command.Parameters.AddWithValue("@genderid", genderid);
            command.ExecuteNonQuery();
            con.Close();
            return "saved records in the table TableCourseRegDetail";            
        }
        static int courseregid = 0;
        public static string SaveTableRegAddress(int nationid,int stateid ,int cityid)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "select top 1 CourseRegID from TableRegAddress order by courseregid desc";
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

        public static string InsertTableFeeDetail(int totalamount,double minper,int paidamount,int balamount,DateTime paiddate)
        {
            SqlConnection con = GetConnection();
            con.Open();
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
            return "save in the table TableFeeDetail";
        }
    }
}
