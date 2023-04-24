namespace AccountFormClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Deposit, Withdrawal;
        int Amount;
        int balance = 1000;
        account acc1 = new account();
        private void button2_Click(object sender, EventArgs e)
        {

            Amount = Convert.ToInt32(textBox2.Text);
            label3.Text = acc1.Deposit(Convert.ToInt32(textBox2.Text),balance).ToString();              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Amount = Convert.ToInt32(textBox2.Text);
            if (balance < 500)
            {
                label3.Text = "Insufficient balance";
            }
            else
            {
                label3.Text = acc1.Withdrawl(Convert.ToInt32(textBox2.Text)).ToString();
            }
        }
    }
}