using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDanceChampionship
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=Championship";

        public static SqlConnection GetConnection() //to create a connection betwene application and SQL server
        {
            SqlConnection con = new SqlConnection(connectionString);
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

        public static string InputValues(string firstName,string lastName,int age,string country,string city)
        {
            SqlConnection con = GetConnection();
            string query = "insert into WDC(firstName,lastName,age,country,city) values(@firstName,@lastName,@age,@country,@city)";

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@city", city);
                command.ExecuteNonQuery();

                return "Successfully inserted";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }

        public static string UpdateValues(string firstName,string lastName)
        {
            SqlConnection con = GetConnection();
            string query = "update WDC set firstName = @firstName where lastName = @lastName";

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.ExecuteNonQuery();
                return "Values Updated Successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }
        public static string DeleteValues(string firstName,string lastName) 
        {
            SqlConnection con = GetConnection();
            string query = "delete from WDC where firstName = @firstName and lastName = @lastName";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.ExecuteNonQuery();
                return "Deleted successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }

        public static DataSet GetEmployeeDetails()
        {
            SqlConnection con = GetConnection();
            string query = "select * from WDC";
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "WDC");
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
