namespace WinFormsApp1Prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int counter = 2;
            bool primeCheck = false;
            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    primeCheck = true;
                    break;
                }
            }
            if (num == 0)
                label2.Text = num + " is neither prime nor composite";
            else if (primeCheck == false)
                label2.Text = num + " is prime";
            else
                label2.Text = num + " is not prime";
        }
    }
}