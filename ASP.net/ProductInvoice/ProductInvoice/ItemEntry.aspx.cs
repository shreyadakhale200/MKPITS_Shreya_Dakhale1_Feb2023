using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductInvoice
{
    public partial class ItemEntry : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=TrustProject");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "insert into Item_master values(@Item_Name,@Category,@rate,@balance_quantity)";
            SqlCommand command = new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@Item_Id", Convert.ToInt32(TextBox6.Text));
            command.Parameters.AddWithValue("@Item_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Category", ListBox1.SelectedValue);
            command.Parameters.AddWithValue("@rate", Convert.ToDecimal(TextBox3.Text));
            command.Parameters.AddWithValue("@balance_quantity",Convert.ToInt32(TextBox4.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Inserted Successfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Item_master set Item_Name = @Item_Name,Category = @Category,rate = @rate,balance_quantity = @balance_quantity where Item_id = @Item_id";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@Item_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Category", ListBox1.SelectedValue);
            command.Parameters.AddWithValue("@rate", Convert.ToDecimal(TextBox3.Text));
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@Item_Id", Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Updated Successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Item_master where Item_id = @Item_id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Item_id", Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery(); 
            con.Close();
            Label1.Text = "Delete Successfully";
            TextBox6.Text = "";
            TextBox4.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select * from Item_master where Item_id = @Item_id";
            da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Item_id", Convert.ToInt32(TextBox6.Text));
            da.Fill(ds, "Item_master");

            TextBox6.Text = ds.Tables["Item_master"].Rows[0].ItemArray[0].ToString();
            TextBox2.Text = ds.Tables["Item_master"].Rows[0].ItemArray[1].ToString();
            ListBox1.SelectedValue = ds.Tables["Item_master"].Rows[0].ItemArray[2].ToString();
            TextBox3.Text = ds.Tables["Item_master"].Rows[0].ItemArray[3].ToString();
            TextBox4.Text = ds.Tables["Item_master"].Rows[0].ItemArray[4].ToString();
        }
    }
}