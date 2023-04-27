using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Form_RuntimePolymorphism
{
    class Account
    {
        public int balance = 1000;
        public string message;
        public virtual int deposit(int amount)
        {
            balance = balance;
            return balance;
        }
    }
    class Saving : Account
    {
        public override int deposit(int amount)
        {
            int interest = 500;
            balance = amount + balance + interest;
            return balance;
        }
    }
    class Current : Account
    {
        public override int deposit(int amount)
        {
            balance = amount + balance;
            //message = "" + balance;
            return balance;
        }
    }
 }
