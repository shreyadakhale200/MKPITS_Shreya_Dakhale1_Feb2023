using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class PopUpDisplay : Form
    {
        public string Name;
        public int Age;
        public string Mobile;
        public PopUpDisplay(string Name, int Age, string Mobile)
        {
            InitializeComponent();
            this.Name = Name;
            this.Age = Age;
            this.Mobile = Mobile;
        }

        private void PopUpDisplay_Load(object sender, EventArgs e)
        {
            this.labelNameDisplay.Text = this.Name;
            this.labelAgeDisplay.Text = this.Age.ToString();
            this.labelMobileNoDisplay.Text = this.Mobile.ToString();

        }
    }
}
