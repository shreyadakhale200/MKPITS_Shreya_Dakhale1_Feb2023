using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObjectServer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome to Webform1.aspx");
            Server.Execute("Webform2.aspx" );
            Response.Write("Welcome Again in Webform1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome to Webform1.aspx");
            Server.Transfer("Webform2.aspx " );
            Response.Write(" Welcome Again in WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<h1>My name is Shreya</h1>"));
            Response.Write("<h1>My name is Shreya</h1>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("https://localhost:44383/WebForm1"));
            Response.Write(" https://localhost:44383/WebForm1");
        }
    }
}