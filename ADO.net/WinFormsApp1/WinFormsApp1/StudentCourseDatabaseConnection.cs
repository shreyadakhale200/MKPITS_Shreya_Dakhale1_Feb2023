using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class StudentCourseDatabaseConnection
    {
        //create a vsariable to save the connection
        public static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=MKPITS";

        //create a method to setup a connection
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

        public static string insertValues(string name, string address, int courseid, int age, int studentid)
        {
                SqlConnection con = GetConnection();
            string query = "insert into student (name, address, courseid, age, studentid) values (@name, @address, @courseid, @age, @studentid)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@studentid", studentid);
                command.ExecuteNonQuery();
                return "successfully inserted";
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

        public static string UpdateValues(string name, string address, int courseid, int age, int studentid)
        {
            SqlConnection con = GetConnection();
            string query = "update student set name = @name, address = @address, courseid = @courseid, age = @age where studentid = @studentid";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@studentid", studentid);
                command.ExecuteNonQuery();
                return "Successfully Updated";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }

        }

        public static string DeleteValues(int studentid)
        {
            SqlConnection con = GetConnection();
            string query = "delete from student where studentid = @studentid";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@studentid", studentid);
                command.ExecuteNonQuery();
                return "Deleted Successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }

        }

        public static DataSet FindStudents(int studentid)
        {
            SqlConnection con  = GetConnection();
            string query = "select * from student where studentid = @studentid";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@studentid", studentid);
            da.Fill(ds, "student");
            return ds;
        }

        public static DataSet CourseDetails()
        {
            SqlConnection con = GetConnection();
            string query = "select name,courseid from courseDetails";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "courseDetails");
            return ds;
        }

    }
}
