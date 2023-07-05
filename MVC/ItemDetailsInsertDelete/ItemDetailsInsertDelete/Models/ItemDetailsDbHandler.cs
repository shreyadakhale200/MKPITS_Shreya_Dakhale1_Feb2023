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

            string query = "insert into Item_List values('"+iList.Name+"','"+iList.Category+"','"+iList.Price+"')";
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

        //Update Item
        //--------------------------Update Item Method-------------------------------
        public bool UpdateDetails(ItemModel iList) 
        { 
            connection ();

            string query = "update Item_List set Name = '"+iList.Name+"',Category = '"+iList.Category+"',Price = '"+iList.Price+"' where ID = '"+iList.Id+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
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

        public bool DeleteDetails(ItemModel iList)
        {
            connection ();
            string query = "delete from Item_List where ID = '" +iList.Id+"'";
            SqlCommand command = new SqlCommand (query,con);
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