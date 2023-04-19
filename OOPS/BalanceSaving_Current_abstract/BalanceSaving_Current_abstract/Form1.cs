namespace BalanceSaving_Current_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox2.Text);
            Account act = null;
            if(comboBox1.Text == "Saving")
            {
                act = new Saving();
                label4.Text = act.deposit(amount).ToString();
            }
            else if(comboBox1.Text == "Current")
            {
                act = new Current();
                label4.Text=act.deposit(amount).ToString();
            }
        }
    }
}