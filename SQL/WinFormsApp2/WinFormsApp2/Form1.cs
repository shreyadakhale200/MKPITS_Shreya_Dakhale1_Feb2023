using Microsoft.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.GetConnection();
            if(con!=null)
            {
                label1.Text = "connected successfully";
                con.Close();
            }
            else
            {
                label1.Text = "unable to connect";
            }

        }
    }
}