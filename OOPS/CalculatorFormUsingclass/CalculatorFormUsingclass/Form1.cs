namespace CalculatorFormUsingclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num;

        calculator calc = new calculator();
        private void One_Click(object sender, EventArgs e)
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

        private void Three_Click(object sender, EventArgs e)
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

        private void Add_Click(object sender, EventArgs e)
        {
            textBox1.Text = calc.Plus_Click(num).ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Minus_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Multiply_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Divide_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double result = calc.calculateResult(Convert.ToSingle(textBox1.Text));
            textBox1.Text = result.ToString();
            num = result;
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Modulus_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Power_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Power_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}