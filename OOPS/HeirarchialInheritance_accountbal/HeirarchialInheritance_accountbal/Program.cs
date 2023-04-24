using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirarchialInheritance_accountbal
{
    internal class Program
    {
        class Account
        {
            public int account_no;
            public int bal = 1000;

            public void deposit(int amount)
            {
                Console.WriteLine("This is deposit method of account class");
            }
        }
        class saving:Account
        {
            public void deposit(int amount)
            {
                int interest = 500;
                bal = bal + amount + interest;
                Console.WriteLine("")
            }
        }
        class current
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
