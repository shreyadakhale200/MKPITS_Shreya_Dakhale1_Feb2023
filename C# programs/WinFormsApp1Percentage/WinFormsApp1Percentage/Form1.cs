namespace WinFormsApp1Percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Subject1 = Convert.ToInt32(textBox1.Text);
            int Subject2 = Convert.ToInt32(textBox2.Text);
            int Subject3 = Convert.ToInt32(textBox3.Text);
            int Subject4 = Convert.ToInt32(textBox4.Text);
            int total = Subject1 + Subject2 + Subject3 + Subject4;
            label5.Text = "Total : " + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Subject1 = Convert.ToInt32(textBox1.Text);
            int Subject2 = Convert.ToInt32(textBox2.Text);
            int Subject3 = Convert.ToInt32(textBox3.Text);
            int Subject4 = Convert.ToInt32(textBox4.Text);
            int total = Subject1 + Subject2 + Subject3 + Subject4;
            float Percent = (total / 400f) * 100f;
            label6.Text = "Percent : " + Percent + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Subject1 = Convert.ToInt32(textBox1.Text);
            int Subject2 = Convert.ToInt32(textBox2.Text);
            int Subject3 = Convert.ToInt32(textBox3.Text);
            int Subject4 = Convert.ToInt32(textBox4.Text);
            int total = Subject1 + Subject2 + Subject3 + Subject4;
            float Percent = (total / 400f) * 100f;
            if (Percent >= 90)
                label7.Text = "Grade : " + "A";
            else if (Percent >= 80 && Percent < 90)
                label7.Text = "Grade : " + "B";
            else if (Percent >= 70 && Percent < 80)
                label7.Text = "Grade : " + "C";
            else
                label7.Text = "You Failed!!";
        }
    }
}