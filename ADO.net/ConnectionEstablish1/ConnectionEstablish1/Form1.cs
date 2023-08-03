using System.Data.SqlClient;

namespace ConnectionEstablish1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectingDatabase.GetSqlConnection();
            if(con != null)
            {
                label1.Text = "Successfully Connected";
                con.Close();
            }
            else
            {
                label1.Text = "Failed to Connect";
                con.Close();
            }
        }
    }
}