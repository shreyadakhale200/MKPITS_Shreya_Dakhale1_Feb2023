namespace WinFormsApp1GreaterSmaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            if (num1 > num2)
            {
                label3.Text = num1 + " is greater than " + num2;
            }
            else if (num1 == num2)
            {
                label3.Text = num1 + " is equal to " + num2;
            }
            else
            {
                label3.Text = num2 + " is greater than " + num1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            if (num1 > num2)
                label3.Text = num2 + " is smaller than " + num1;
            else if (num1 == num2)
                label3.Text = num1 + " is equal to " + num2;
            else
                label3.Text = num1 + " is smaller than " + num2;
        }
    }
}