using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationandSession
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string companyName = (string)Application["companyname"].ToString();
            Label1.Text = companyName;
            int counter = (int)Application["counter"];
            counter = counter + 1;
            Application["counter"] = counter;
            Label2.Text = "Number of People visited the site " + counter.ToString();
        }
    }
}