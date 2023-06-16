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
    public class ItemMaster
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string res = null;
        static string query = null;
        static SqlCommand command = null;
        public static string insertItem(string item_name, string category, double rate, int balance_quantity)
        {
            try
            {
                query = "insert into Item_master values(@item_name,@category,@rate,@balance_quantity)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@item_name", item_name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@rate", rate);
                command.Parameters.AddWithValue("@balance_quantity", balance_quantity);
                con.Open();
                command.ExecuteNonQuery();
                res = "inserted successfully";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally { con.Close(); }
            return res;
        }

        public static string getItemId()
        {
            try
            {
                query = "select max(Item_id) from Item_master";
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
    public static string updateItem(int item_id,string item_name,string category,double rate,int balance_quantity)
        {
            query = "select count(*) from Item_master where item_id = @item_id";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@item_id", item_id);
            con.Open();
            int cnt = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "update Item_master set item_name = @item_name,category = @category,rate = @rate,balance_quantity = @balance_quantity where item_id = @item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_name", item_name);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@rate", rate);
                    command.Parameters.AddWithValue("@balance_quantity", balance_quantity);
                    command.Parameters.AddWithValue("@item_id", item_id);
                    con.Open(); command.ExecuteNonQuery();
                    res = "Updated successfully";
                }
                catch(Exception ex)
                {
                    res = ex.Message;
                }
                finally { con.Close(); }
            }
            else
            {
                res = "record does not exist";
            }
            return res;
        }

        public static string DeleteItem(int item_id)
        {
            query = "select Item_Id from Item_master where Item_Id = @item_id";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@item_id", item_id);
            con.Open();
            int cnt = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Item_master where item_id = @item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", item_id);
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
                res = "record does not exist";
            }
            return res;
        }

        public static DataSet SearchItem(int item_id)
        {
            query = "select * from Item_master where item_id = @item_id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@item_id", item_id);
            da.Fill(ds, "Item_master");
            return ds;

        }
    }

}
