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
                res = ex.Message;
            }
            finally { con.Close(); }
            return res;
        }
    }

}
