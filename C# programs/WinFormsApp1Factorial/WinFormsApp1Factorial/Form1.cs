namespace WinFormsApp1Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int num = Convert.ToInt32(textBox1.Text);
            for (int number = num;number >= 1;number--)
            {
                factorial = factorial * number;
            }
            label2.Text = "Factorial : " +  factorial;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}