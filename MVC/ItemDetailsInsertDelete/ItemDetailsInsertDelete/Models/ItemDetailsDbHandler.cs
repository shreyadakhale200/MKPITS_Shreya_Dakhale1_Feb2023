using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace ItemDetailsInsertDelete.Models
{
    public class ItemDetailsDbHandler
    {
        SqlConnection con = null;

        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=ItemDetails";
            con = new SqlConnection(constr);
        }

        public List<ItemModel> GetItemList()
        {
            connection();

            List<ItemModel> list = new List<ItemModel>();

            string query = "select * from Item_List";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new ItemModel
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }

            return list;
        }

        public bool InsertDetails(ItemModel iList)
        {
            connection();

            string query = "insert into ItemDetails values('"+iList.Name+"','"+iList.Category+"','"+iList.Price+"')";
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();

            if(i >= 1)
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