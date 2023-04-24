using System.Text;

namespace WinFormsAppDiamond
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
                for (int inner_loop = 1; inner_loop <= height - outer_loop; inner_loop++)
                {
                    sb.Append("  ");
                }
                for (int star = 1; star < 2 * outer_loop; star++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            for (int outer_loopDown = 1; outer_loopDown <= height; outer_loopDown++)
            {
                for (int inner_loopDown = 0; inner_loopDown <= outer_loopDown - (2 - 1); inner_loopDown++)
                {
                    sb.Append("  ");
                }
                for (int star = 1; star <= (height - outer_loopDown) * 2 - 1; star++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label2.Text = sb.ToString();
        }
    }
}