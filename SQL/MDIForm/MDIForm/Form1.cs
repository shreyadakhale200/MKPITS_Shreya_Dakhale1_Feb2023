namespace MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = null;
        Form3 f3 = null;
        private void invoiceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }
            f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }
            f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}