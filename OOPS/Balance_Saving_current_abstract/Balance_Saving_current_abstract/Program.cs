using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance_Saving_current_abstract
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract void deposit(int amount);
        public string showbalance()
        {
            return "balance is : " + bal;
        } 
    }

    class Saving : Account
    {
        int interest = 500;
        public override void deposit(int amount)
        {
            bal = amount + interest + bal;
            Console.WriteLine("Deposited amount with Interest :" + bal);
        }
    }

    class Current : Account
    {
        public override void deposit(int amount)
        {
            bal = bal + amount;
            Console.WriteLine("Deposited amount without Interest :" + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter amount = ");
            amount = Convert.ToInt32(Console.ReadLine());
            Account act = null;
            string AcctType;
            Console.WriteLine("Enter Account type (Saving or Current) :");
            AcctType = Console.ReadLine();
            if(AcctType == "Saving")
            {
                act = new Saving();
            }
            else if(AcctType == "Current")
            {
                act = new Current();
            }
            act.deposit(amount);
            string res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
