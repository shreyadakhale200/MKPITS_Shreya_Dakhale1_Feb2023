using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace RegisterUser
{
    public static class DatabaseConnection
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=RegisterUser";
        public static SqlConnection GetSqlConnection()
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
        public static string InsertData(string Username,string Password)
        {  
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "insert into Register values(@Username,@Password)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.ExecuteNonQuery();
                return "Successfully Inserted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
            
        }

        public static string UpdateData(string username,string password, int rollno)
        {
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "update Register set username=@username, password=@password where rollno=@rollno";
                //DataSet ds = new DataSet();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@rollno", rollno);
                command.ExecuteNonQuery();
                return "Successfully updated";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                  con.Close ();
            }

        }

        public static string DeleteData(int Rollno)
        {
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "delete from Register where Rollno = @Rollno";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Rollno", Rollno);
                command.ExecuteNonQuery();
                return "Deleted successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }

}
