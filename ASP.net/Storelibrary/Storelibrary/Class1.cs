using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storelibrary
{
    public class VendorClass
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static string res = null;
        public static string VendorMaster(string vendor_name)
        {
            try
            {
                query = "insert into Vendor_mast values(@vendor_name)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@vendor_name", vendor_name);
                con.Open();
                command.ExecuteNonQuery();
                res =  "Successfully inserted in Vendor_mast";
                
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        public static string updateVendorMast(string vendor_name,int vendor_id)
        {
            try
            {
                query = "update Vendor_mast set vendor_name = @vendor_name where vendor_id = @vendor_id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@vendor_name", vendor_name);
                command.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                command.ExecuteNonQuery();
                res = "Updated successfully in Vendor_mast";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        public static string DeleteVendorMast(int vendor_id)
        {
            try
            {
                query = "delete from Vendor_mast where vendor_id = @vendor_id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                command.ExecuteNonQuery();
                res = "Deleted successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;
        }

        public static string GetVendorID()
        {
            try
            {
                query = "select max(Vendor_id) from Vendor_mast ";
                SqlCommand command = new SqlCommand(query, con);
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

        public static DataSet SearchVendor(int vendor_id)
        {
            query = "select * from Vendor_mast where vendor_id = @vendor_id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@vendor_id",vendor_id);
            da.Fill(ds, "Vendor_mast");
            return ds;

        }



    }
}
