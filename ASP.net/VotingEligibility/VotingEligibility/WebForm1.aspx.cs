using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingEligibility
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(TextBox1.Text);
            string Result;
            if(age >= 18)
            {
                Result = "Eligible";
            }
            else
            {
                Result = "Not Eligible";
            }
            Label1.Text = Result;
        }
    }
}