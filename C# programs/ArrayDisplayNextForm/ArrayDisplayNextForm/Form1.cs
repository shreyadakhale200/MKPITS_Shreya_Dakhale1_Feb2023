using System.Text;

namespace ArrayDisplayNextForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row, col;
        int i = 0, j = 0;
        int[,] arr;
        private void button1_Click(object sender, EventArgs e)
        {
            row = Convert.ToInt32(textBox1.Text);
            col = Convert.ToInt32(textBox2.Text);
            arr = new int[row, col];
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < row)
            {
                if (j < col)
                {
                    arr[i, j] = Convert.ToInt32(textBox3.Text);
                    textBox3.Clear();
                    textBox3.Focus();
                    j = j + 1;
                }
                if (j == col)
                {
                    i = i + 1;
                    j = 0;
                }
                if (i == row)
                {
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int outer_loop = 0; outer_loop < row; outer_loop++)
            {
                for (int inner_loop = 0; inner_loop < col; inner_loop++)
                {
                    sb.Append(arr[outer_loop, inner_loop] + " ");
                }
                sb.Append('\n');
            }
            label4.Text = sb.ToString();
        }
    }
}