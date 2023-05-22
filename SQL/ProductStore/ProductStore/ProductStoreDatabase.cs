using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;

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

       //public static string GetTableInvoiceDetails(string CustomerName,long CustomerContact,int Product_Category_ID,int Product_ID,)
       // {
       //    
       // }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }
        public static DataSet GetTableProductData(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select t.ProductName from TableProduct t inner join TableProductCategory t1 on t1.Product_Category_ID = t.ProductTypeID where Product_Type_Name = @Product_Type_Name";
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
