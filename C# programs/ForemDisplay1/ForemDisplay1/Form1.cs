namespace ForemDisplay1
{
    public partial class Form1 : Form
    {
        
        int[] arr = new int[5];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                arr[i] = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                i = i + 1;
            }
            if(i == 5)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                label2.Text += " " + arr[i] + " ";
            }
        }
    }
}