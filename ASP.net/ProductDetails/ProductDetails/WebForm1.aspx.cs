using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductDetails
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ItemName = TextBox1.Text;
            double price = Convert.ToDouble(TextBox2.Text);
            int quantity = Convert.ToInt32(TextBox3.Text);

            double result = price * quantity;
            Label1.Text = result.ToString();
        }
    }
}