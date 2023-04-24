using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number for multiplication table :");
            num = Convert.ToInt32(Console.ReadLine());
            int multiply = Multiplication(num, 1);
            Console.WriteLine(multiply);
            Console.ReadKey();
        }

        static int Multiplication(int num,int loop)
        {
            if(loop == 10)
            {
                Console.Write(num  + " X " + loop + " = ");
                return num*loop;
            }
            else
            {
                Console.WriteLine(num  + " X " + loop + " = " + num * loop);
                return Multiplication(num, loop + 1);

            }
        }
    }

}

