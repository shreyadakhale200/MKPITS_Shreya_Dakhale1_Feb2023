using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.GetConnection();
            if (con != null)
            {
                label1.Text = "Connected Successfully";
            }
            else
            {
                label1.Text = "Unable to Connect";
            }
        }
    }
}