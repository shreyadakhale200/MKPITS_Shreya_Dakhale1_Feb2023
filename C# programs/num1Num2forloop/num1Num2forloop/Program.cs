using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1Num2forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            for (num1 = 1, num2 = 1;num2 <= 10;num1++,num2++)
            {
                Console.WriteLine("num1 : " + num1);
                Console.WriteLine("num2 : " + num2);
            }
            Console.ReadKey();
        }
    }
}
