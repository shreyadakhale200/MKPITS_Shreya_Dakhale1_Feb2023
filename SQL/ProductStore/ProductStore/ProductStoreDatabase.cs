using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.CodeDom;

namespace ProductStore
{
    internal class ProductStoreDatabase
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=ProductStore";

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

        public static string SaveTableInvoiceDetails(string customer_name, string customer_contact, int product_category_id, int product_id, int residential_type_id, DateTime invoice_date, decimal quantity, decimal price, decimal cgst, decimal sgst, decimal igst,decimal cgst_value,decimal sgst_value,decimal igst_value,decimal total_amount)
        {
            string result = null;
            SqlConnection con = GetConnection();
            string query = "insert into TableInvoiceDetails values(@customer_name,@customer_contact,@product_category_id,@product_id,@residential_type_id,@invoice_date,@quantity,@price,@cgst,@sgst,@igst,@cgst_value,@sgst_value,@igst_value,@total_amount)";
            
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@customer_name", customer_name);
                command.Parameters.AddWithValue("@customer_contact", customer_contact);
                command.Parameters.AddWithValue("@product_category_id", product_category_id);
                command.Parameters.AddWithValue("@product_id", product_id);
                command.Parameters.AddWithValue("@residential_type_id", residential_type_id);
                command.Parameters.AddWithValue("@invoice_date", invoice_date);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@cgst", cgst);
                command.Parameters.AddWithValue("@sgst", sgst);
                command.Parameters.AddWithValue("@igst", igst);
                command.Parameters.AddWithValue("@cgst_value", cgst_value);
                command.Parameters.AddWithValue("@sgst_value", sgst_value);
                command.Parameters.AddWithValue("@igst_value", igst_value);
                command.Parameters.AddWithValue("@total_amount", total_amount);
            try
            {
            command.ExecuteNonQuery();
                result = "value saved successfully";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }
        public static DataSet GetTableProductData(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select t.ProductName,t.ProductID from TableProduct t inner join TableProductCategory t1 on t1.Product_Category_ID = t.ProductTypeID where Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet(); 
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet GetTableProductGstDetails(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on a.Product_Gst_ID = b.Product_Gst_ID where Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name",Product_Type_Name);
            da.Fill(ds, "TableProductGSTDetails");
            return ds;
        }

        public static DataSet GetProductPrice(string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "select price from TableProduct where ProductName = @ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
    }
}
