namespace WinFormsApp1BalanceAmount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int balance = 2000;
        private void button1_Click(object sender, EventArgs e)
        {
            long accountNo = Convert.ToInt64(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            if (balance > 0)
            {
                balance += amount;
            }
            label3.Text = "balance = " + balance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long accountNo = Convert.ToInt64(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            if (amount <= balance)
            {
                balance -= amount;
            label3.Text = "balance = " + balance;
            }
            //else if (amount > balance)
            else
            {
                label3.Text = "Insufficient balance";
            }
        }
    }
}