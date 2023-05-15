using System;
using System.Data.SqlClient;

namespace StudentsDatabase
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=.\\sqlexpress;integrated security = true;database = MKPITS";

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

        public static string InputValue(string Name, string Course, string Address, int Age)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO studentsDetails (Name, Course, Address, Age) VALUES (@Name, @Course, @Address, @Age)";

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Course", Course);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Age", Age);

                command.ExecuteNonQuery();
                return "Successfully inserted";
            }
            catch (SqlException ex)
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
