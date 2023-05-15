using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PicnicDatabase
{
    public static class DatabaseConnection
    {
        private static string constr = "server=.\\sqlexpress;integrated security = true;database=Student_MKPITS";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(constr);
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

        public static string InputValues(string firstName,string lastName,long Parents_Number,string Pickup_Point,string Drop_point)
        {
            SqlConnection con = GetConnection();
            string query = "insert into Picnic(firstName,lastName,Parents_Number,Pickup_Point,Drop_point) values(@firstName,@lastName,@Parents_Number,@Pickup_Point,@Drop_point)";

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@Parents_Number", Parents_Number);
                command.Parameters.AddWithValue("@Pickup_Point", Pickup_Point);
                command.Parameters.AddWithValue("@Drop_point", Drop_point);

                command.ExecuteNonQuery();
                return "Saved Successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }
            //firstName varchar(30),
            //lastName varchar(30),
            //Parents_Number bigint,
            //Pickup_Point varchar(25),
            //Drop_point varchar(25)

    }
}
