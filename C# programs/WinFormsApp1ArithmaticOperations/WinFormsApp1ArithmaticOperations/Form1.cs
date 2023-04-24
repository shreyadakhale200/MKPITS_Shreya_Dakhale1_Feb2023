namespace WinFormsApp1ArithmaticOperations
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
            int Addition = num1 + num2;
            label3.Text = "Add : " + Addition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int Substraction = num1 - num2;
            label4.Text = "Subtract : " + Substraction;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int Multiplication = num1 * num2;
            label5.Text = "Multiply : " + Multiplication;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float Division = num1 / num2;
            label6.Text = "Divide : " + Division;
        }
    }
}