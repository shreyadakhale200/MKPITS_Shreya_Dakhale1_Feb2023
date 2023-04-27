using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Heelo";
            int res = string.Compare(s1, s2);
            if(res == 0)
            {
                Console.WriteLine("Both strings are equal");
            }
            else if(res == 1)
            {
                Console.WriteLine(s1 + " First string is greater than second string " + s2);
            }
            else
            {
                Console.WriteLine(s2 + " Second string is greater than first string "+ s1);
            }
            //Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
