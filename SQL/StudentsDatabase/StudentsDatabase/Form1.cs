namespace StudentsDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection.InputValue(textBox1.Text, comboBox1.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            label5.Text = result;
            textBox1.Clear();
            comboBox1.Text = " ";
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}