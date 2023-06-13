using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProductInvoice
{
    public partial class VendorMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=TrustProject");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public void loadpage()
        //{
        //    query = "select * from Vendor_mast";
        //    da = new SqlDataAdapter(query, con);
        //    da.Fill(ds, "Vendor_mast");
    
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            query = "insert into Vendor_mast values(@Vendor_mast)";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@Vendor_mast",TextBox5.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Inserted Successfully";
            TextBox5.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Vendor_mast set Vendor_name = @Vendor_name where Vendor_id = @Vendor_id";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@Vendor_name",TextBox5.Text);
            command.Parameters.AddWithValue("@Vendor_id",Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Updated Successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Vendor_mast where Vendor_id = @Vendor_id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Deleted Successfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select * from Vendor_mast where Vendor_id = @Vendor_id";
            da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox6.Text));
            da.Fill(ds, "Vendor_mast");
            TextBox5.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
        }
    }
}