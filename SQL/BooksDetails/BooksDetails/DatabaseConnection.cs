using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BooksDetails
{
    public static class DatabaseConnection
    {
        private static string constr = "server=.\\sqlexpress;integrated security = true;database=BookStore";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(constr);
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

        public static string InputValues(string Book_name,int Price,int Quantity)
        {
            SqlConnection con = GetConnection();
            string query = "insert into BookDetails(Book_name,Price,Quantity) values(@Book_Name,@Price,@Quantity)";

            try
            {
            SqlCommand command = new SqlCommand(query,con);
                command.Parameters.AddWithValue("@Book_Name", Book_name);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.ExecuteNonQuery();
                return "Successfully Saved";
            }
            catch (SqlException ee)
            {
                return ee.ToString();
            }
            finally { con.Close(); }
        }
            //Book_Name varchar(20),
            //Price int,
            //Quantity int

    }
}
