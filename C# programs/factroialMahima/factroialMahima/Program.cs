using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factroialMahima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int num=5;
            //Console.WriteLine("Enter num : ");
            //num = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter < num; counter++)
            {
                num = num * counter;
            }
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
