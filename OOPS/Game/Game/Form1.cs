namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n;
            Random random = new Random();
            List<int> ListNumbers = new List<int>();
            int number;
            /*for(int i=1;i<=10;i++)
            {
                do
                {
                    number = random.Next(1, 10);
                } while (ListNumbers.Contains(number));
                button1.Text = number.ToString(); 
                button2.Text = number.ToString(); 
                button3.Text = number.ToString(); 
              //button1.Text = onvert.ToInt32(ListNumbers.Add(number)).toString();
            }*/
            
            
            
            for(int i =1 ; i <= 10; i++)
            {            
                button1.Text = Convert.ToInt32(random.Next(1,10)).ToString();
                button2.Text = Convert.ToInt32(random.Next(1,10)).ToString();
                button3.Text = Convert.ToInt32(random.Next(1,10)).ToString();
                   // Console.WriteLine(random.Next());
            }
        }
    }
}