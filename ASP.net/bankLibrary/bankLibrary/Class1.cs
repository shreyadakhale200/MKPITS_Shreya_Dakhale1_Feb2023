using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankLibrary
{
    public class Class1
    {
        int balance = 1000;

        public string deposit(int amount)
        {
            balance = balance + amount;
            return "balance is " + balance;
        }
        public string withdrawal(int amount)
        {
            balance = balance - amount;
            return "balance is " + balance;
        }
    }
}
