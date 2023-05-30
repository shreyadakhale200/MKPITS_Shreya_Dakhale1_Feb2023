using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Operator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            int result = 0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox2.Text);
            string Operator = TextBox3.Text;

            switch(Operator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2; 
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default: Label1.Text = "Invalid operator"; break;
            }
            Label1.Text = result.ToString();
        }
    }
}