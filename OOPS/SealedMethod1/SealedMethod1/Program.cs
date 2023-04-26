using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod1
{
    class Account
    {
        public string accountName;
        public double Accountno;
        public int bal = 34000; 

        public virtual void CheckAcc()
        {
            Console.WriteLine("Account name : " + accountName);
            Console.WriteLine("Account Number : " +  Accountno);
        }
    }
    class Saving:Account
    {
        public sealed override void CheckAcc()
        {
            bal = bal + 300;
            Console.WriteLine(bal);
        }
    }
    class Current:Saving
    {
        //public override void CheckAcc()
        //{
            //Current.CheckAcc() cannot override inherited member 'Saving.CheckAcc()' because it is sealed
        //}
        public void display()
        {
            bal = bal - 3000;
            Console.WriteLine(bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.CheckAcc();

            Current c = new Current();
            c.display();

            Console.ReadKey();
        }
    }
}
