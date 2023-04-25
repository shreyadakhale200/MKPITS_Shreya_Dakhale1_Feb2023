using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Account           //class account
    {
        public int actno;   //public field
        public string name; //public field
        public static float RateofInterest = 4.5f;  //public field

        public Account(int actno, string name)        //creating a Constructor of Account
        { 
            this.actno = actno;     //accessing the feilds declared in the class
            this.name = name;       //accessing the feilds declared in the class
        }

        public void Display()       //Display method
        {
            Console.WriteLine("Account no : " +  actno);    //printing the Account no
            Console.WriteLine("Name : " + name);            //printing the Name
            Console.WriteLine("Rate of Interest : " +  RateofInterest); //printing the rate of interest
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(21, "Shreya"); //instantiating an object named a1
            Account a2 = new Account(54, "Rupali"); //instantiating an obejct named a2
            //here RateofInterest field is static which is not required to to create an object while accessing its value,
            //it helps saving the memory.
            //static field is used on those fields which common to all the classes
            a1.Display();   //calling a1
            a2.Display();   //calling a2
            Console.ReadKey();
        }
    }
}
