namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate c = new calculate();
            
            int result = c.calculateResult( Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToChar(comboBox1.Text) );
            //(int num1, int num2, char op)

            label4.Text = "result = " + result.ToString();
            
        }
    }
}