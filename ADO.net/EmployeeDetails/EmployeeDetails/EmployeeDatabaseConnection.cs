using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeDetails
{
    internal class EmployeeDatabaseConnection
    {
        public static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=civica";

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
        public static string InsertEmployeeDetails(int empnumber, string name, string gender, string email, long mobileno, int cityid, DateTime date)
        {
            SqlConnection con = GetConnection();
            string query = "insert into employee_civica values(@empnumber, @name, @gender, @email, @mobileno, @cityid, @date)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@empnumber", empnumber);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@cityid", cityid);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();
                return "Successfully Inserted";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }

        public static string UpdateEmployee(int empno,string empname, string gender, string email, long mobileno, int cityid, DateTime dob)
        {
            SqlConnection con = GetConnection();
            string query = "update employee_civica set empname = @empname, gender = @gender, email = @email, mobileno = @mobileno, cityid = @cityid, dob = @dob where empno = @empno";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@empname", empname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@cityid", cityid);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@empno", empno);
                command.ExecuteNonQuery();
                return "Successfully Updated";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
            
        }

        public static string DeleteEmployee(int empno)
        {
            SqlConnection con = GetConnection();
            string query = "delete from employee_civica where empno = @empno";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@empno", empno);
                command.ExecuteNonQuery();
                return "Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }


        public static DataSet GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select name,cityid from CityDetails";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds,"CityDetails");
            return ds;
        }

        public static DataSet SearchEmployee(int empno)
        {
            SqlConnection con = GetConnection();
            string query = "select * from employee_civica where empno = @empno";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@empno", empno);
            da.Fill(ds, "employee_civica");
            return ds;
        }
    }

}
