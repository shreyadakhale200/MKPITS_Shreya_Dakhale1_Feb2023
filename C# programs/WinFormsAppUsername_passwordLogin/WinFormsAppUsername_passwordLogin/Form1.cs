namespace WinFormsAppUsername_passwordLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            const string name1 = "Mahima";
            const string password1 = "Mahim@IsAgreatGirlNOT";
            if(name.Equals(name1) && password.Equals(password1))
            {
                label3.Text = "Successful LOGIN";
            }
            else
            {
                label3.Text = "Invalid ";
            }
        }
    }
}