using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSaving_Current_abstract
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract int deposit(int amount);
    }
    class Saving : Account
    {
        int interest = 500;
        public override int deposit(int amount)
        {
            bal = bal + amount + interest;
            return bal;
        }
    }

    class Current:Account
    {
        public override int deposit(int amount)
        {
            bal = bal + amount;
            return bal; 
        }
    }
   
}
