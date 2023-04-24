using System.Text;

namespace WinFormsAppEvenPyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int height = Convert.ToInt32(textBox1.Text);
            for (int outer_loop = 1; outer_loop <= height; outer_loop++)
            {
                for (int inner_loop = height - outer_loop; inner_loop >= 1; inner_loop--)
                {
                    sb.Append(" ");
                }
                for (int star = 1; star <= outer_loop; star++)
                {
                    sb.Append(" *");
                }
                    sb.Append("\n");
            }
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    sb.Append(" ");
                }
                for (int k = height - i + 1; k >= 1; k--)
                {
                    sb.Append(" *");
                }
                    sb.Append("\n");
            }
            label2.Text = sb.ToString();
        }
    }
}