using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace EmployeeRegistration__DataAdapter_
{
    public static class EmployeeDatabase
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=EmployeeDetails1";
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

        public static DataSet GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from City";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "City");
            return ds;
        }

        public static string InputData(int employeeId, string employeeName, string gender, string email, long mobileNumber, string city, DateTime DOB)
        {
            SqlConnection con = GetConnection();
            try
            {
                string query = "insert into Employee values(@employeeId, @employeeName, @gender, @email, @mobileNumber, @city, @DOB)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.ExecuteNonQuery();
                return "Successfully Saved";
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

        public static string UpdateData(string Name, string Gender, string Email, long MobileNumber, string city, DateTime DateOfBirth, int EmployeeNumber)
        {
            SqlConnection con = GetConnection();
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

        public static string DeleteData(int employeeId)
        {
            SqlConnection con = GetConnection();
            try
            {
                string query = "delete from Employee where employeeId = @employeeId";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@employeeId", employeeId);
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
