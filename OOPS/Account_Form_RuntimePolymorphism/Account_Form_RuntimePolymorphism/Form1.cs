namespace Account_Form_RuntimePolymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            //amount = s.deposit(amount)Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            //amount = current.deposit(Convert.ToInt32(textBox2.Text));
            //string AccType = null;
            Account account1 = null;
            if (comboBox1.Text == "Saving")
            {
                account = new Saving();
                label4.Text = account.deposit(amount).ToString();
            }
            else if (comboBox1.Text == "Current")
            {
                account = new Current();
                label4.Text = account.deposit(amount).ToString();
            }

        }
    }
}