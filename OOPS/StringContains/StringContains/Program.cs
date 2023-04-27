using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rupali";
            string s2 = "Shreya";
            bool res  = s1.Contains(s2);
            bool res1  = s2.Contains(s1);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadKey();
        }
    }
}
