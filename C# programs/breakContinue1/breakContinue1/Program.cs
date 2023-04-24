using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace breakContinue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money,month=31,odd_days,counter=0,remaining_days=0, remaining_days_pay=1;
            Console.WriteLine("Enter your pocket Money : ");
            money = int.Parse(Console.ReadLine());
            for(odd_days=1;odd_days<=month;odd_days++)
            {
                if(odd_days%2 !=0)
                {
                    money -= 50;
                    Console.WriteLine("You have " + money + " left!!" + odd_days + " days is spent");
                    if (money == 0)
                    {
                        remaining_days = odd_days;
                        while(odd_days <= 31) 
                        {
                            odd_days += 2;
                            counter++;
                            //Console.WriteLine("counter :" +counter);
                        }
                        //counter *= 50;
                        remaining_days_pay = counter * 50;
                        break;
                    }
                    continue;
                    
                }
            }
            
            Console.WriteLine("you spent your money in " + remaining_days + " days" + " you have " + (counter) + " days remaining with no money");
            Console.WriteLine("take " + remaining_days_pay + " to spend for " + counter + " days");
            Console.ReadKey();
        }
    }
}
