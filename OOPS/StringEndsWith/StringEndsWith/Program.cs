using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEndsWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Shreya";
            Console.WriteLine("Enter the string you want to find whether it");
            bool res = s1.EndsWith("a");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
