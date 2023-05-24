using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSTORE1
{
    internal class ProductDatabase
    {
        private static string ConnectionStringSettings = "server = .\\sqlexpress;integrated security = true;database = ProductStore";

        public static SqlConnection GetConnection()
        {
           SqlConnection con  = new SqlConnection(ConnectionStringSettings);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "TableCategoryDetails");
            return ds;
        }

        public static DataSet GetTableProduct(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID where Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet GetPrice(string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "\r\nselect p.price from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID where ProductName = @ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetTableGSTDetails(string Gst_Detail_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory t on a.Product_Gst_ID = t.Product_Gst_ID where Gst_Detail_Name = @Gst_Detail_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Gst_Detail_Name", Gst_Detail_Name);
            da.Fill(ds, "TableProductGSTDetails");
            return ds;
        }
    }
}
