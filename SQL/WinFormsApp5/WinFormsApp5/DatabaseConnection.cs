using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp5
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=.\\sqlexpress;integrated security = true;database = civica";
        //Information nedded for Database Connection    (1)

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }

        public static string InsertRecord(string username,string password)  //creating a method to insert the values    (3)
        {
            SqlConnection con = GetConnection(); //GetSqlConnection returns the SqlConnection object which is con    (4)
            //creatig insert command

            string query = "insert into users values(@username,@password)";        //(5)
            //@username and @password are sqlparameters
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                //creating an object of SQL command class

                //defining SQL parameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //Executing the command with ExecuteNonQuery
                command.ExecuteNonQuery();

                return "record inserted successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally 
            { 
               con.Close();
            }

        }
    }
}
