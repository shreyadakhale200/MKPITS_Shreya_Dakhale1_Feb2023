using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivenITProject
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=DrivenIT");
        SqlCommand command = null;
        string query = null;
        static int updateqty = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions  values(@itemid,@transtype,@transqty,@transdate)";
                command = new SqlCommand(query, con);
                string transt = null;
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                if(RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if(RadioButton2.Checked) 
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", TextBox2.Text);
                command.Parameters.AddWithValue("@transdate", TextBox3.Text);
                con.Open();
                command.ExecuteNonQuery();

                //To retrieve balqty from itemmaster
                query = "select max(balqty) from ItemMaster where itemid = @itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid",DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if(transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox2.Text);
                }
                else if(transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox2.Text);
                }

                //updating bal qty on item master table
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
        static int oldbalanceqty = 0;
        static int transid = 0;
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update Transactions set ItemId=@ItemId,Transtype=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransId=@TransId";
                command = new SqlCommand(query, con);
                string trans = null;
                if (RadioButton1.Checked)
                {
                    trans = "I";

                }
                else if (RadioButton2.Checked)
                {
                    trans = "R";
                }
                command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@TransType", trans);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox2.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox3.Text);
                command.Parameters.AddWithValue("@TransId", transid);
                con.Open();
                command.ExecuteNonQuery();


                //getting the balqty from itemmaster table for particular itemid
                query = "select max(Balqty) from Itemmaster where ItemId=@ItemId";
                command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bqt = Convert.ToInt32(command.ExecuteScalar());
                updateqty = Convert.ToInt32(TextBox2.Text) - oldbalanceqty;


                if (RadioButton1.Checked)
                {
                    bqt = bqt - updateqty;
                }
                else if (RadioButton2.Checked)
                {
                    bqt = bqt + updateqty;
                }

                if (bqt < 0)
                {
                    Label1.Text = "Stock is unavailable";
                }
                else
                {
                    //updating bal qty on item master
                    query = "update Itemmaster set Balqty=@Balqty where ItemId=@ItemId";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Balqty", bqt);
                    command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    command.ExecuteNonQuery();
                    Label1.Text = "record updated successfully";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {

                con.Close();
            }

        }

       

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
            oldbalanceqty = Convert.ToInt32(TextBox2.Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox3.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if (res == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;

            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }
    }
}

