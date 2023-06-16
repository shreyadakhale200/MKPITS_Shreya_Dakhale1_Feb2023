using Storelibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreDLL
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayItemID();
            }
        }
        string res = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            displayItemID();
            res = Storelibrary.ItemMaster.insertItem(TextBox2.Text, DropDownList1.SelectedValue, Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text));
            Label1.Text = res;
        }
        public void displayItemID()
        {
            int res = Convert.ToInt32(Storelibrary.ItemMaster.getItemId());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            Button3.Enabled = true;
            Button4.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == " ")
            {
                Label1.Text = "record is empty";
            }
            else
            {
                res = Storelibrary.ItemMaster.updateItem(Convert.ToInt32(TextBox1.Text), TextBox2.Text, DropDownList1.SelectedValue, Convert.ToDouble(TextBox3.Text), Convert.ToInt32(TextBox4.Text));
                Label1.Text = res;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == " ")
            {
                Label1.Text = "record is empty";
            }
            else
            {
                res = Storelibrary.ItemMaster.DeleteItem(Convert.ToInt32(TextBox1.Text));
                Label1.Text = res;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Storelibrary.ItemMaster.SearchItem(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables["Item_master"].Rows.Count > 0)
            {
                TextBox2.Text = ds.Tables["Item_master"].Rows[0].ItemArray[1].ToString();
                DropDownList1.SelectedValue = ds.Tables["Item_master"].Rows[0].ItemArray[2].ToString();
                TextBox3.Text = ds.Tables["Item_master"].Rows[0].ItemArray[3].ToString();
                TextBox4.Text = ds.Tables["Item_master"].Rows[0].ItemArray[4].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}