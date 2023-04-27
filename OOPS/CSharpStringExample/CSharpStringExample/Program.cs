using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);


            string s3 = "Hello";
            char c1 = new char('s3');

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
