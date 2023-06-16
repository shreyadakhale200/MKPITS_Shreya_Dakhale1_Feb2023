using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storelibrary
{
    public class Department
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static SqlCommand command;
        static string res = null;
        public static string InsertDepartment(string department_name)
        {
            try
            {
                query = "insert into Department_mast values(@department_name)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@department_name", department_name);
                con.Open();
                command.ExecuteNonQuery();
                res = "Inserted Successfully";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally { con.Close(); }
            return res;
        }
        public static string getDepartmentID()
        {
            try
            {
                query = "  select max(department_id) from Department_mast ";
                command = new SqlCommand(query, con);
                con.Open();
                int compare = Convert.ToInt32(command.ExecuteScalar());
                res = compare.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;

           
        }

        public static string updateDepartment(string department_name,int department_id)
        {
            query = "select count(*) from Department_mast where department_id=@department_id";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@department_id", department_id);
            con.Open();
            int cnt = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "update  Department_mast set department_name=@department_name where department_id=@department_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@department_name", department_name);
                    command.Parameters.AddWithValue("@department_id", department_id);
                    con.Open();
                    command.ExecuteNonQuery();

                    res = "record updated in department master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;

        }

        public static string deleteDepartment(int department_id)
        {

            query = "select count(*) from Department_mast where department_id = @department_id";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@department_id", department_id);
            con.Open();
            int cnt = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Department_mast where department_id = @department_id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@department_id", department_id);
                    con.Open();
                    command.ExecuteNonQuery();
                    res = "deleted successfully";
                }
                catch (Exception ex)
                {
                    res = ex.Message;
                }
                finally { con.Close(); }
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }

        public static DataSet SearchDepartment(int department_id)
        {
            query = "select * from Department_mast where department_id = @department_id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            da.SelectCommand.Parameters.AddWithValue("@department_id",department_id);
            da.Fill(ds, "Department_mast");
            return ds;
        }

    }

}
