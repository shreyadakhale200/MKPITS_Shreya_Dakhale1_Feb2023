using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationandSession
{
    public partial class ViewInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["username"].ToString();
            Label2.Text = Session["email"].ToString();
            Label3.Text = Session["Pizza"].ToString();
            Label4.Text = Session["PizzaToppings"].ToString();
        }
    }
}