using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationandSession
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int counter = (int)Session["counter"];
            counter = counter + 1;
            Session["counter"] = counter;
            Response.Write("Counter is " +  counter);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Label1.Text = "value stored in variable";
        }
    }
}