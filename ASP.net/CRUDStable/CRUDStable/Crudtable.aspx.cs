using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDStable
{
    public partial class Crudtable : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Championship");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            pageload();
        }

        public void pageload()
        {
            query = "select * from WDC";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds, "WDC");
            GridView1.DataSource = ds.Tables["WDC"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "insert into WDC values(@firstname,@lastname,@age,@country,@city,@student_id)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@firstname", TextBox1.Text);
            command.Parameters.AddWithValue("@lastname", TextBox2.Text);
            command.Parameters.AddWithValue("@age", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@country", TextBox4.Text);
            command.Parameters.AddWithValue("@city", TextBox5.Text);
            command.Parameters.AddWithValue("@student_id", TextBox6.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "inserted successfully";
            pageload();
            clear();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "update WDC set firstname = @firstname, lastname = @lastname, age = @age, country = @country, city = @city where student_id = @student_id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@firstname", TextBox1.Text);
            command.Parameters.AddWithValue("@lastname", TextBox2.Text);
            command.Parameters.AddWithValue("@age", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@country", TextBox4.Text);
            command.Parameters.AddWithValue("@city", TextBox5.Text);
            command.Parameters.AddWithValue("@student_id", TextBox6.Text);
            con.Open(); 
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "updated successfully";
            pageload();
            clear();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "delete from WDC where student_id = @student_id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@student_id", Convert.ToInt32(TextBox6.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Delted successfully";
            pageload();
            clear();
        }

        public void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox1.Focus();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            query = "select * from WDC where student_id = @student_id";
            da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@student_id", Convert.ToInt32(TextBox6.Text));
            da.Fill(ds, "WDC");
            GridView1.DataSource = ds.Tables["WDC"].DefaultView;
            GridView1.DataBind();

            TextBox1.Text = ds.Tables["WDC"].Rows[0].ItemArray[0].ToString();
            TextBox2.Text = ds.Tables["WDC"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["WDC"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["WDC"].Rows[0].ItemArray[3].ToString();
            TextBox5.Text = ds.Tables["WDC"].Rows[0].ItemArray[4].ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}