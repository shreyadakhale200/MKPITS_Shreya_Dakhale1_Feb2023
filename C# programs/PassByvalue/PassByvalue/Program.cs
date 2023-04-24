using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByvalue
{
    internal class Program
    {
   static void Main(string[] args)
        {
            int num = 5,n1;
            Console.WriteLine(num);
            display(num);
            Console.WriteLine(num);
            Console.ReadKey();

        }
        static void display(int num)
        {
            num = num + 2;
            Console.WriteLine(num);
        }
    }
}
