using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Storelibrary
{
    public class Transaction
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static string res = null;
        static SqlCommand command = null;
        public static string InsertDepartment(int item_id,string transaction_date,int department_id, int quantity)
        {

            try
            {
                query = "INSERT INTO Transaction_Proces (item_id, transaction_date, Department_id, quantity) VALUES (@item_id, @transaction_date, @department_id, @quantity)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@item_id", item_id);
                command.Parameters.AddWithValue("@transaction_date", transaction_date);
                command.Parameters.AddWithValue("@department_id", department_id);
                command.Parameters.AddWithValue("@quantity", quantity);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                int balance_quantity = 0;
                query = "select balance_quantity from Item_master where item_id = @item_id";
                command = new SqlCommand (query, con);
                command.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    balance_quantity = Convert.ToInt32(reader[0].ToString());
                    // Process the balance_quantity value as needed
                }
                reader.Close();
                con.Close();
              
                int qty = balance_quantity - quantity;
                query = "update Item_master set balance_quantity = @balance_quantity where item_id = @item_id";
                command = new SqlCommand(query,con);
                command.Parameters.AddWithValue("@balance_quantity", qty);
                command.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                command.ExecuteNonQuery ();
                con.Close();
                res = "updated";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;
                   
        }

        public static string InsertDepartmentPurchase(int item_id, string transaction_date, int vendor_id, int quantity)
        {

            try
            {
                query = "INSERT INTO Transaction_Proces (item_id, transaction_date, vendor_id, quantity) VALUES (@item_id, @transaction_date, @vendor_id, @quantity)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@item_id", item_id);
                command.Parameters.AddWithValue("@transaction_date", transaction_date);
                command.Parameters.AddWithValue("@vendor_id", vendor_id);
                command.Parameters.AddWithValue("@quantity", quantity);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                int balance_quantity = 0;
                query = "select balance_quantity from Item_master where item_id = @item_id";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    balance_quantity = Convert.ToInt32(reader[0].ToString());
                    // Process the balance_quantity value as needed
                }
                reader.Close();
                con.Close();

                int qty = balance_quantity + quantity;
                query = "update Item_master set balance_quantity = @balance_quantity where item_id = @item_id";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balance_quantity", qty);
                command.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                res = "updated";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;

        }

    }
}
