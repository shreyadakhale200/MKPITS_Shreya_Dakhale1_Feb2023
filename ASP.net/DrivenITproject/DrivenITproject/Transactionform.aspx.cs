using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace DrivenITproject
{
    public partial class Transactionform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=DrivenIT");
        string query = null;
        SqlCommand cmd = null;
        static int oldqty = 0;
        static int updateqty = 0;
        static int transid = 0;
        static int bal = 0;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                query = "update Transactions set itemid = @itemid,transtype = @transtype,transqty = @transqty,transdate = @transdate where transid = @transid";
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
                cmd.Parameters.AddWithValue("@transqty", TextBox1.Text);
                cmd.Parameters.AddWithValue("@transdate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@transid", transid);
                con.Open();
                cmd.ExecuteNonQuery();

                //retrieve balqty from ItemMaster
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bal = Convert.ToInt32(cmd.ExecuteScalar());

                updateqty = Convert.ToInt32(TextBox1.Text) - oldqty;
                Response.Write("bal " + bal.ToString());
                Response.Write("updateqty " + updateqty.ToString());
                if (transt == "I")
                    bal = bal - updateqty;
                if (transt == "R")
                    bal = bal + updateqty;

                if (bal < 0)
                {
                    Label1.Text = "Stock is unavailable";
                    if(IsPostBack)
                    {
                        oldqty =  (Convert.ToInt32(TextBox1.Text) * 0) + oldqty;
                    }
                }
                else
                {
                    //update balqty from ItemMaster
                    query = "update ItemMaster set balqty = @balqty where itemid = @itemid";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@balqty", bal);
                    cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "updated successfully";
                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            string type = GridView1.SelectedRow.Cells[3].Text;
            if(type == "I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            else if(type == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;
            }
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;

            oldqty = Convert.ToInt32(GridView1.SelectedRow.Cells[4].Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }
    }
}