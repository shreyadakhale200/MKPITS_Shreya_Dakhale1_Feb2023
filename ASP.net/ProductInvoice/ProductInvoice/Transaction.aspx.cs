using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml.Linq;
using System.Collections;
using System.Drawing;
using System.Data.SqlClient;

namespace ProductInvoice
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlDataAdapter da;
        string query = null;

        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Panel2.Visible = false;
                Panel1.Visible = true;
            }


        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=TrustProject");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "INSERT INTO Transaction_Process (item_id, transaction_date, Department_id, quantity) VALUES (@item_id, @transaction_date, @department_id, @quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList6.SelectedValue);
                    command.Parameters.AddWithValue("@transaction_date", TextBox8.Text);
                    command.Parameters.AddWithValue("@department_id", DropDownList7.SelectedValue);
                    command.Parameters.AddWithValue("@quantity", TextBox9.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();



                    int bal_qty = 0;
                    query = "select balance_quantity from Item_master where Item_id = @Item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_id", DropDownList6.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    //  Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox9.Text);

                    query = "update Item_master set balance_quantity = @balance_quantity where Item_id = @Item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balance_quantity",qty);
                    command.Parameters.AddWithValue("@Item_id",DropDownList6.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery(); 
                    con.Close();
                    Label1.Text = "item issued to department successfully";
                }

                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }

            }

            else if(RadioButton2.Checked)
            {
                try
                {
                    query = "INSERT INTO Transaction_Process (item_id, transaction_date, Vendor_Id, Quantity) VALUES (@item_id, @transaction_date, @Vendor_Id, @quantity)"; command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList6.SelectedValue);
                    command.Parameters.AddWithValue("@transaction_date", TextBox8.Text);
                    command.Parameters.AddWithValue("@Vendor_Id", DropDownList8.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", TextBox9.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    int bal_qty = 0;
                    query = "select balance_quantity from Item_master where Item_id = @Item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_id",DropDownList6.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();

                    int qty = bal_qty + Convert.ToInt32(TextBox9.Text);

                    query = "update Item_master set balance_quantity = @balance_quantity where Item_Id = @Item_Id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balance_quantity",qty);
                    command.Parameters.AddWithValue("@Item_Id",DropDownList6.SelectedValue);
                    con.Open() ;
                    command.ExecuteNonQuery();
                    Label1.Text = "item purchased from department successfully";

                    loadpage();
                    
                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally { con.Close(); }

            }
        }

        public void loadpage()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Transaction_Process");
            DataRow dr;
            dt.Columns.Add(new DataColumn("TransID", typeof(int)));
            dt.Columns.Add(new DataColumn("ItemID", typeof(int)));
            dt.Columns.Add(new DataColumn("TransType", typeof(int)));
            dt.Columns.Add(new DataColumn("TransQty", typeof(int)));
            dt.Columns.Add(new DataColumn("TransDate", typeof(DateTime)));

            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = DropDownList6.SelectedValue;
            if (RadioButton1.Checked)
            {
                dr[2] = 1;
            }
            else if (RadioButton2.Checked)
            {
                dr[2] = 2;
            }
            dr[3] = TextBox9.Text;
            dr[4] = TextBox8.Text;
            dt.Rows.Add(dr);
            ds.Tables.Add(dt);

            GridView1.DataSource = ds.Tables["Transaction_Process"].DefaultView;
            GridView1.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}