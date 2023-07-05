using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ProductDetailsMVC.Models
{
    public class ProductDBHandler
    {
        SqlConnection con = null;

        public void connection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=ProductDetails");
        }

        public List<ProductModel> GetProductList()
        {
            connection();
            List<ProductModel> list = new List<ProductModel>();
            string query = "select * from Product_List";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ProductModel
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Quantity = Convert.ToInt32(dr["Quantity"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            //In the line Name = Convert.ToString(dr["Name"]), the string "Name" represents the column name.
            //This should match the actual column name in your database table.
            return list;
        }

        public bool InsertProduct(ProductModel ilist)
        {
            connection();
            string query = "insert into Product_List values('"+ilist.Name+"','"+ilist.Quantity+"','"+ilist.Price+"')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();

            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(ProductModel ilist)
        {
            connection();
            string query = "update Product_List set Name = '"+ilist.Name+"',Quantity = '"+ilist.Quantity+"',Price = '"+ilist.Price+"'";
            SqlCommand command = new SqlCommand (query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else { return false;}
        }

        public bool DeleteProduct(ProductModel ilist)
        {
            connection();
            string query = "delete from Product_List where ID = '" + ilist.Id + "'";
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}