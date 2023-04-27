using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_time_Polymorphism
{
    class Account
        {
            public int bal = 1000;
            public virtual void deposit(int amt)
            {
                Console.WriteLine("Deposit method of Account class");
            }
        }
        class Saving : Account
        {
            public int interest = 500;
            public override void deposit(int amount)
            {
                bal = amount + bal + interest;
                Console.WriteLine("Deposited balance with interest = "+bal);
            }
        }

        class Current : Account
        {
            public override void deposit(int amt)
            {
                bal = amt + bal;
                Console.WriteLine("Deposited balance without interest = "+bal);
            }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                int amount;
                Console.WriteLine("Enter amount : ");
                amount = Convert.ToInt32(Console.ReadLine());

                Account act = null; 
                string AcctType;
                Console.WriteLine("Enter Account Type (Current or Saving) : ");
                AcctType = Console.ReadLine();
                
                if(AcctType == "Saving")
                {
                    act = new Saving(); //calling child class object using base class object
            }
                else if(AcctType == "Current")
                {
                    act = new Current(); //calling child class object using base class object
            }
                act.deposit(amount);
                //Account act = new Saving(); 
                Console.ReadKey();
            }
        }
    }
