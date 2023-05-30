using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArithmeticOperations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

            
        protected void Button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int result = 0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox2.Text);
            result = number1 + number2;
            Label1.Text = result.ToString();    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int number1=0;
            int number2=0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox2.Text);
            int result = 0;
            result = number2 - number1;
            Label1.Text = result.ToString();    
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int number1=0;
            int number2=0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox2.Text);
            int result = 0;
            result = number1 * number2; 
            Label1.Text = result.ToString();    
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int number1=0;
            int number2=0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox2.Text);
            int result = 0;
            result = number1 / number2;
            Label1.Text = result.ToString();    
        }
    }
}