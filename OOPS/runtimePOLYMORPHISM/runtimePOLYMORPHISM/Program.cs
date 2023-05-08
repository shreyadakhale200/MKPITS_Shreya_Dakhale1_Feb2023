using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimePOLYMORPHISM
{
    using System;

    abstract class Account
    {
        public float balance = 1000;
        public int amount;
        public abstract void deposit(int amount);
    }
    class Saving : Account
    {
        public float interest = 0.1f;
        public override void deposit(int amount)
        {
            float total = amount + balance;
            balance = total * interest;
            balance = total + balance;
            Console.WriteLine(balance);
        }
    }
    class Current : Account 
    {
        public override void deposit(int amount)
        {
            balance = amount + balance;
            Console.WriteLine(balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int Amount;
            Console.WriteLine("Enter amount = ");
            Amount = Convert.ToInt32(Console.ReadLine());

            Account acc = null;
            string AccType;
            Console.WriteLine("Enter Account Type : ");
            AccType = Console.ReadLine();
            if(AccType == "Saving")
            {
                acc = new Saving();
            }
            else if(AccType == "Current")
            {
                acc = new Current();
            }
        acc.deposit(Amount);
        Console.ReadKey();
        }
    }
}
