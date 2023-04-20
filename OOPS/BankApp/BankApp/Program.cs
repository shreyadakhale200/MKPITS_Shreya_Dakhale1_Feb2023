using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface IAccount
    {
        string deposit(int amt);    
    }
    abstract class Account : IAccount
    {
        public int bal = 1000;
        public abstract string deposit(int amt);
        public string showbalance()
        {
            return bal.ToString();
        }
    }
    class saving : Account
    {
        int interest = 500;
        public override string deposit(int amt)
        {
            bal = amt + bal + interest;
            return "Bal is : " + bal.ToString();
        }
    }
    class current : Account
    {
        public override string deposit(int amt)
        {
            bal = amt + bal;
            return "balance is : " + bal.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Account account = null;

            string AccType;
            Console.WriteLine("Enter Account type : ");
            AccType = Console.ReadLine();

            if (AccType == "Saving")
            {
                account = new saving();
            }
            else if (AccType == "Current")
            {
                account = new current();
            }
            string res = account.deposit(amount);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
