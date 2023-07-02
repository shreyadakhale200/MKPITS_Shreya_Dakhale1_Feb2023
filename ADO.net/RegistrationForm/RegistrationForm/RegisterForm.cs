namespace RegistrationForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void MobilenotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AgetextBox_SizeChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AgetextBox.Text) < 1 && Convert.ToInt32(AgetextBox) > 100)
            {
                MessageBox.Show("Age is invalid", "Age Restriction");
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            DisplayDetails form = new DisplayDetails(); // Create an instance of the form
            form.Show(); // Show the form

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            if (NametextBox == null)
            {
                MessageBox.Show("Enter Name", "Name");
                Savebutton.Enabled = false;
            }
            else
            {
                Savebutton.Enabled = true;
            }
        }

        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
            if (NametextBox == null)
            {
                MessageBox.Show("Enter Name", "Name");
                Savebutton.Enabled = false;
            }
            else
            {
                Savebutton.Enabled = true;
            }
        }
    }
}