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
    public partial class Department : System.Web.UI.Page
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
            query = "insert into Department_mast values(@department_name)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@department_name",TextBox5.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Inserted Successfully";
            TextBox5.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Department_mast set Department_name = @Department_name where Department_id = @Department_id";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@Department_name", TextBox5.Text);
            command.Parameters.AddWithValue("@Department_id", TextBox6.Text);
            con.Open(); 
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Updated Successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Department_mast where Department_id = @Department_id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Department_id", Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Delted Successfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select * from Department_mast where Department_id = @Department_id";
            da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_id",Convert.ToInt32(TextBox6.Text));
            da.Fill(ds, "Department_mast");
            TextBox5.Text = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();
        }
    }
}