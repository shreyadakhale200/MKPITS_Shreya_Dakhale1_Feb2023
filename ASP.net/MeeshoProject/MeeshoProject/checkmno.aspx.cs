using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeeshoProject
{
    public partial class checkmno : System.Web.UI.Page
    {
            //making a connection to retrieve information
            string prodid;
            SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meeshodb");
            SqlCommand command;
            string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToInt32(Session["prodid"]).ToString();
            Response.Write(prodid);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int res = Convert.ToInt32(TextBox1.Text);
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            string prodimage = null;
            if (res == 123456)
            {
                try
                {
                    query = "select * from meeshoStore where prodid = @prodid";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@prodid", prodid);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        prodname = reader["prodname"].ToString();
                        prodprice = Convert.ToInt32(reader["prodprice"]);
                        qty = 1;
                        sessionid = Session.SessionID;
                        prodimage = reader["prodimage"].ToString();
                    }
                    Response.Write("prodname " + prodname + "<br>");
                    Response.Write("prodprice " + prodprice + "<br>");
                    Response.Write("quantity " + qty + "<br>");
                    Response.Write("session id " + sessionid + "<br>");
                    Response.Write("product image " + prodimage + "<br>");

                    reader.Close();
                    query = "insert into cart values(@prodname,@prodprice,@qty,@sessionid,@prodimage)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@prodname", prodname);
                    command.Parameters.AddWithValue("@prodprice", prodprice);
                    command.Parameters.AddWithValue("@qty", qty);
                    command.Parameters.AddWithValue("@sessionid", sessionid);
                    command.Parameters.AddWithValue("@prodimage", prodimage);
                    command.ExecuteNonQuery();
                    Label1.Text = "Added successfully";
                }
                catch (Exception ex) 
                {
                    Label1.Text = ex.ToString();
                }
                finally { con.Close(); }

            }
            else
            {
                Label1.Text = "Invalid OTP";
            }

            
        }
    }
}