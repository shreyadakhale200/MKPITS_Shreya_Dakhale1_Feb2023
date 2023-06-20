using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DrivenITproject
{
    public partial class Transactionform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=DrivenIT");
        string query = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@itemid,@transtype,@transqty,@transdate)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                cmd.Parameters.AddWithValue("@transtype", transt);
                cmd.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@transdate", TextBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                //restrieve balqty from ItemMaster
                query = "select balqty from ItemMaster where itemid = @itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bqty = Convert.ToInt32(cmd.ExecuteScalar());
                if (transt == "I")
                {
                    bqty = bqty - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bqty = bqty + Convert.ToInt32(TextBox1.Text);
                }

                //update balqty from ItemMaster
                query = "update ItemMaster set balqty = @balqty where itemid = @itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@balqty", bqty);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                Label1.Text = "successfully added";
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}