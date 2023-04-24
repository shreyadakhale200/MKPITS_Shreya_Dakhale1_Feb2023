using CalculatorFormUsingclass;
using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num;
        cal cal = new cal();
        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 1;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 2;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.Modulus_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Power_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.Power_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Three_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 3;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 4;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 5;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 6;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 7;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 8;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 9;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
                num = Convert.ToInt32(textBox1.Text);
            }
        }


        private void Add_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = cal.Plus_Click(num).ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            textBox1.Text = cal.Minus_Click(num).ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            textBox1.Text = cal.Divide_Click(num).ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = cal.Multiply_Click(num).ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double result = cal.calculateResult(Convert.ToSingle(textBox1.Text));
            textBox1.Text = result.ToString();
            num = result;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 0;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
                num = Convert.ToInt32(textBox1.Text);
            }
        }
    }
}