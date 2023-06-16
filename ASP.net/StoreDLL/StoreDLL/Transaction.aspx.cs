using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Storelibrary;
namespace StoreDLL
{
    public partial class Transaction : System.Web.UI.Page
    {
        enum mode { issue,purchase}
        mode Mode;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(RadioButton1.Checked)
            {
            Panel2.Visible = false;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
              Panel2.Visible = false;
              Panel1.Visible = true;
           }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }
        string res = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                res = Storelibrary.Transaction.InsertDepartment(Convert.ToInt32(DropDownList1.SelectedValue),TextBox2.Text,Convert.ToInt32(DropDownList2.SelectedValue),Convert.ToInt32(TextBox3.Text));
                Label1.Text = res;
            }
            else if(RadioButton2.Checked)
            {
                res = Storelibrary.Transaction.InsertDepartmentPurchase(Convert.ToInt32(DropDownList1.SelectedValue), TextBox2.Text, Convert.ToInt32(DropDownList3.SelectedValue), Convert.ToInt32(TextBox3.Text));
                Label1.Text= res;
            }
        }
    }
}