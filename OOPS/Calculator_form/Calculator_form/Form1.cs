namespace Calculator_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation;
        int number1;
        int prev_num;
        int counter = 0;
        int flag = 0;

        private void one_Click(object sender, EventArgs e)
        {
            one.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 1;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Two.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 2;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Three.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 3;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Four_Click(object sender, EventArgs e)
        {
            Four.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 4;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }


        private void Five_Click(object sender, EventArgs e)
        {
            Five.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 5;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Six_Click(object sender, EventArgs e)
        {   
            Six.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 6;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            Seven.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 7;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            Eight.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 8;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            Nine.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 9;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Zero.Focus();
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "X" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 0;
                    number1 = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
                number1 = Convert.ToInt32(textBox1.Text);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            operation = "+";
            prev_num = number1;
            textBox1.Text = "+";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operation = "-";
            prev_num = number1;
            textBox1.Text = "-";
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            operation = "X";
            prev_num = number1;
            textBox1.Text = "X";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            prev_num = number1;
            textBox1.Text = "/";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            int add = 0, subtract = 0, multiply = 1, divide = 1;
            if (operation == "+")
            {
                add = (prev_num + number1);
                textBox1.Text = add.ToString();
                //prev_num = 11, number1 = 22       11 + 22 = 33
                number1 = add;
                //counter++;
            }
            if (operation == "-")
            {
                subtract = (prev_num - number1);
                textBox1.Text = subtract.ToString();
                number1 = subtract;
            }
            if (operation == "X")
            {
                multiply = (prev_num * number1);
                textBox1.Text = multiply.ToString();
                number1 = multiply;
            }
            if (operation == "/")
            {
                divide = (prev_num / number1);
                textBox1.Text = divide.ToString();
                number1 = divide;
            }
        }

        //1245+789-90= 2034

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


    }
}