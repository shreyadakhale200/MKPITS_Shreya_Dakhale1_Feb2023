using System.Collections.Generic;
using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;


namespace ItemDatabaseConnectionMVC.Models
{
    public class ItemDetailsDbHandler
    {
        SqlConnection con = null;

        public void connection()
        {
            //string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ItemDetails"].ToString();
            string constr = "server=.\\sqlexpress;integrated security=true;database=ItemDetails";

            con = new SqlConnection(constr);

        }

        public bool InsertItem(ItemModel ilist)
        {
            connection(); // Call the connection method to initialize the connection

            string query = "insert into Item_List values('" + ilist.name + "','" + ilist.category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, con);

            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
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
