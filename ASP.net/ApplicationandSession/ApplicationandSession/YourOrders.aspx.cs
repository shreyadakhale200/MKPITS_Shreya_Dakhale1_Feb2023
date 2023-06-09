using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationandSession
{
    public partial class YourOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["PizzaToppings"] = DropDownList1.SelectedValue;
            Session["Pizza"] = DropDownList2.SelectedValue;
            Label1.Text = "Saved Successfully";
        }
    }
}