/*create a class account having fields acctno,bal=1000 and methods deposit , withdrawl and
showbalance
create a windows form and use the above classs
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFormClass
{
    internal class account
    {
        int balance = 1000;

        public int Deposit(int num,int balance)
        {
            this.balance = balance;
            balance = balance + num;
            return balance;
        }
        public int Withdrawl(int num,int balance)
        {
            this.balance = balance;
            balance = balance - num;
            return balance;
        }
    }
}
