using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Storelibrary;
namespace StoreDLL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayID();
            }

        }
        string res = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label2.Visible = false;
            //TextBox1.Visible = false;
            displayID();
            if(TextBox2.Text == "")
            {
                Label1.Text = "Enter aproppriate values";
            }
            else
            {
                res = VendorClass.VendorMaster(TextBox2.Text);
                Label1.Text = res;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            res = VendorClass.updateVendorMast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
            getID();
        }

        public void getID()
        {
            int res = Convert.ToInt32(VendorClass.GetVendorID());
            if(Convert.ToInt32(TextBox1.Text) > res)
            {
                Label1.Text = "value does not exist";
            }
        }

        public void displayID()
        {
            int res = Convert.ToInt32(VendorClass.GetVendorID());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            res = VendorClass.DeleteVendorMast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
            getID();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.SearchVendor(Convert.ToInt32(TextBox1.Text));
            TextBox2.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int res = Convert.ToInt32(VendorClass.GetVendorID());
            if (Convert.ToInt32(TextBox1.Text) > res)
            {
                Label1.Text = "value does not exist";
                TextBox2.Enabled = false;
            }

        }
    }
}