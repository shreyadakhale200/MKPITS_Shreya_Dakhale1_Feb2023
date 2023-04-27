namespace calculate_operator
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
            char op = Convert.ToChar(comboBox1.Text);
            Calculate_operator c = new Calculate_operator(num1, num2, op);
            //int result = c.calculateResult(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToChar(comboBox1.Text));


            //(int num1, int num2, char op)
            int result = c.calculateResult(num1, num2, op);
            label4.Text = "Result = " + result.ToString();
            //label4.Text = "result = " + result.ToString();
        }
    }
}