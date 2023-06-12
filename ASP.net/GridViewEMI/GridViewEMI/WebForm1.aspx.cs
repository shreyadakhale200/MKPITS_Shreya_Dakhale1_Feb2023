using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace GridViewEMI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); //create an instance of Dataset 
            DataTable dt = new DataTable("Details"); //create an instance of Databtable
            DataRow dr; //create a table row

            //Add columns in the table 
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Name",typeof(string)));
            dt.Columns.Add(new DataColumn("DOB",typeof(DateTime)));

            //add rows in the table
            //1st row
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Shreya";
            dr[2] = DateTime.Now;
            //add datarow in datatable
            dt.Rows.Add(dr);

            //2nd row
            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Mahima";
            dr[2] = DateTime.Now;
            //add datarow in datatable
            dt.Rows.Add(dr);

            //3rd row
            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "Rupali";
            dr[2] = DateTime.Now;
            //add datarow in datatable
            dt.Rows.Add(dr);
            
            //add datatable in dataset
            ds.Tables.Add(dt);

            //view in gridview
            GridView1.DataSource = ds.Tables["Details"].DefaultView;

            //Data bind
            GridView1.DataBind();


        }

        string pname = "mouse";
        protected void Button2_Click(object sender, EventArgs e)
        {
            int totalamount = Convert.ToInt32(TextBox1.Text);
            int paidamount = Convert.ToInt32(TextBox2.Text);

            if (RadioButton1.Checked)
            {
                TextBox2.Text = TextBox1.Text;
                Label1.Text = "Please Pay Full amount";
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("SrNo", typeof(int)));
                dt.Columns.Add(new DataColumn("Product Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Amount", typeof(decimal)));

                dr = dt.NewRow();
                dr[0] = 1;
                dr[1] = pname;
                dr[2] = totalamount;
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

                GridView2.DataSource = ds.Tables["emitable"].DefaultView;
                GridView2.DataBind();
            }
            else if (RadioButton2.Checked)
            {
                TextBox2.Enabled = true;
                int remainingAmount = totalamount - paidamount;
                double emiAmount = remainingAmount / 3.0;
                DataSet ds1 = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("SrNo", typeof(int)));
                dt.Columns.Add(new DataColumn("Product Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Amount", typeof(decimal)));

                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;
                    dr[2] = emiAmount;
                    dt.Rows.Add(dr);
                }
                ds1.Tables.Add(dt);
                GridView2.DataSource = ds1.Tables["emitable"].DefaultView;
                GridView2.DataBind();
            }

        }
    }
}