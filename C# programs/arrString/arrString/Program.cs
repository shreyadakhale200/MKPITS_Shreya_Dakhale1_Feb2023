using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[3] { "Shreya","me","myself" };
            string[] str1 = new string[3];
            str1[0] = "Shival";
            str1[1] = "Ronav";
            str1[2] = "Shreya";
            Console.WriteLine("str");
            foreach(string val in str)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\nstr1");
            foreach(string val in str1)
            {
                Console.Write(val + " ");
            }
            Console.ReadKey();
        }
    }
}
