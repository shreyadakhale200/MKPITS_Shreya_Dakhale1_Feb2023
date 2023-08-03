using System.Data.SqlClient;
namespace ConnectionEstablish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1connection_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectionDatabase.GetSqlConnection();
            if(con != null )
            {
                label1.Text = "Connection Established Successfully";
            }
            else
            {
                label1.Text = "Cannot connect";
            }
        }
    }
}