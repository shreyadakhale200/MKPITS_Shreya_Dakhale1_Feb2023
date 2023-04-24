//Write a C# method that takes a string as a parameter and returns its length.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter string : ");
            str= Console.ReadLine();
            StringLength(str);
            Console.ReadKey();
        }
        static void StringLength(string str)
        {
            Console.WriteLine("Length of string is : " + str.Length);
        }
    }
}
