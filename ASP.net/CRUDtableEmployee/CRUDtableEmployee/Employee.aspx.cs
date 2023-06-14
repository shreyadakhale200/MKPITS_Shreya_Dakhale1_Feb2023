using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDtableEmployee
{
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Championship");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the minimum date of the Calendar control to January 1, 2000
                Calendar1.VisibleDate = new DateTime(2000, 1, 1);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loadpage();
        }

        public void loadpage()
        {
            query = "select * from Employee";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Employee");
            GridView1.DataSource = ds.Tables["Employee"].DefaultView;
            GridView1.DataBind();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //DateTime selectedDate = Calendar1.SelectedDate;

            //// Perform additional validations or actions if needed

            //// For example, you can check if the selected date is before the minimum date
            //if (selectedDate < new DateTime(2015, 1, 1))
            //{
            //    // Display an error message or take appropriate action
            //    // You can also reset the selected date if desired
            //    Calendar1.SelectedDate = DateTime.MinValue;
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "insert into Employee values(@Employeeid,@employeename,@gender,@email,@mobilenumber,@city,@dob)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Employeeid",Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@employeename",TextBox2.Text);
            if(RadioButton1.Checked)
            {
            command.Parameters.AddWithValue("@gender", "Male");
            }
            else if(RadioButton2.Checked) 
            {
            command.Parameters.AddWithValue("@gender", "Female");
            }
            command.Parameters.AddWithValue("@email", TextBox3.Text);
            command.Parameters.AddWithValue("@mobilenumber", Convert.ToInt64(TextBox4.Text));
            command.Parameters.AddWithValue("@city", TextBox5.Text);
            command.Parameters.AddWithValue("@dob", Calendar1.SelectedDate);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Successfully Inserted";
            loadpage();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "update Employee set employeename = @employeename, gender = @gender,email = @email,mobilenumber = @mobilenumber,city = @city,dob = @dob where Employeeid = @Employeeid";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@employeename", TextBox2.Text);
            if (RadioButton1.Checked)
            {
                command.Parameters.AddWithValue("@gender", "Male");
            }
            else if (RadioButton2.Checked)
            {
                command.Parameters.AddWithValue("@gender", "Female");
            }
            command.Parameters.AddWithValue("@email", TextBox3.Text);
            command.Parameters.AddWithValue("@mobilenumber", Convert.ToInt64(TextBox4.Text));
            command.Parameters.AddWithValue("@city", TextBox5.Text);
            command.Parameters.AddWithValue("@dob", Calendar1.SelectedDate);
            command.Parameters.AddWithValue("@Employeeid",Convert.ToInt32(TextBox1.Text));
            con.Open() ;
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Successfully Updated";
            loadpage();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "delete from Employee where Employeeid = @Employeeid";
            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.AddWithValue("@Employeeid", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Deleted Successfully";
            loadpage();
        }
    }
}