using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    
    class Account
    {
        public int balance = 5000;
        int a = 40;
        public void deposit(int amt)
        {
            Console.WriteLine("Deposit method of Account class");
        }
    }
    class Savings:Account
    {
        public int balance = 10000;

        public void deposit(int amount)
        {
            int interest = 10;
            balance = balance + amount + interest;
            Console.WriteLine(balance);
            Console.WriteLine("Deposit method of Savings class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Savings s = new Savings();
            s.deposit(500);
            Console.ReadKey();
        }
    }
}
