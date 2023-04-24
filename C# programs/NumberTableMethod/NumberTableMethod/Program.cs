//Create a method table with one parameter tp display table of a number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTableMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = int.Parse(Console.ReadLine());
            Table(num);
            Console.ReadKey();
        }

        static void Table(int n1)
        {
            for(int i = 1; i <= 10;i++)
            {
                int table = n1 * i;
                Console.WriteLine(n1 + " X " + i + " = " + table);
            }
        }
    }
}
