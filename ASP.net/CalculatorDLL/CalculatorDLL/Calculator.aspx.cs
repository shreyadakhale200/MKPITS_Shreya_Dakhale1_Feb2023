using calculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using calculatorLibrary;
namespace CalculatorDLL
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Class1 c = new Class1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = c.addition(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = c.multiplication(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = c.subtraction(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = c.division(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }
    }
}