
namespace WinFormsApp5
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
            result = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);
            label3.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}