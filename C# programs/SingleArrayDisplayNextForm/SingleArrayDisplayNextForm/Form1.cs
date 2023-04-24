using System.Globalization;
using System.Text;

namespace SingleArrayDisplayNextForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size;
        int[] arr;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox2.Text);
            arr = new int[size];
            if (i < size)
            {
                arr[i] = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                i = i + 1;
            }
            if (i == size)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i] + " ");
            }
            label3.Text = sb.ToString();
        }
}
}