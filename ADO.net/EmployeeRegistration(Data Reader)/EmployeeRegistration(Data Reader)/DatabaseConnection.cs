using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.NetworkInformation;

namespace EmployeeRegistration_Data_Reader_
{
    public static class DatabaseConnection
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=EmployeeDetails1";

        public static SqlConnection GetSqlConnection()
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
         public static SqlDataReader GetCity()
         {
            try
            {
               SqlConnection con = GetSqlConnection();
                string query = "select * from City";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch(Exception ex)
            {
                return null;
            }
         }

        //public static string SaveData(int employeenumber,string name,string gender,string email,string mobilenumber,int cityid,DateTime dateofbirth)
        //{
        //    SqlConnection con = GetSqlConnection();
        //    try
        //    {
        //        string query = "insert into Employee values(@employeenumber,@name,@gender,@email,@mobilenumber,@cityid,@dateofbirth)";
        //        SqlCommand command = new SqlCommand(query, con);
        //        command.Parameters.AddWithValue("@employeenumber", employeenumber);
        //        command.Parameters.AddWithValue("@name", name);
        //        command.Parameters.AddWithValue("@gender", gender);
        //        command.Parameters.AddWithValue("@email", email);
        //        command.Parameters.AddWithValue("@mobilenumber", mobilenumber);
        //        command.Parameters.AddWithValue("@cityid", cityid);
        //        command.Parameters.AddWithValue("@dateofbirth", dateofbirth);
        //        command.ExecuteNonQuery();
        //        return "Saved Successfully";
        //    }
        //    catch(Exception e)
        //    {
        //        return e.Message;
        //    }
        //    finally { con.Close(); }
        //}

        public static string SaveData(int EmployeeNumber, string Name, string Gender, string Email, string MobileNumber, string city, DateTime DateOfBirth)
        {
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "insert into Employee(EmployeeNumber, Name, Gender, Email, MobileNumber, city, DateOfBirth) values(@EmployeeNumber, @Name, @Gender, @Email, @MobileNumber, @city, @DateOfBirth)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                command.Parameters.AddWithValue("@city", city); // Corrected column name here
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.ExecuteNonQuery();
                return "Saved Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally { con.Close(); }
        }

        public static string UpdateData(string Name, string Gender, string Email, string MobileNumber, string city, DateTime DateOfBirth, int EmployeeNumber)
        {
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "update Employee set  Name = @Name, Gender = @Gender, Email = @Email, MobileNumber = @MobileNumber, city = @city, DateOfBirth = @DateOfBirth where EmployeeNumber = @EmployeeNumber";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                command.Parameters.AddWithValue("@city", city); // Corrected column name here
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                command.ExecuteNonQuery();
                return "Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally { con.Close(); }
        }

        public static string DeleteData(int EmployeeNumber)
        {
            SqlConnection con = GetSqlConnection();
            try
            {
                string query = "delete from Employee where EmployeeNumber = @EmployeeNumber";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                command.ExecuteNonQuery();
                return "Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally { con.Close(); }

        }

    }

}
