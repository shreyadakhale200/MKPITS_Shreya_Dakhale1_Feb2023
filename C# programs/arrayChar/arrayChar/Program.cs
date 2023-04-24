using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[5] {'a','e','i','o','u'};
            char[] d = { 'd', 'e', 'f', 'g', 'h' };
            Console.WriteLine("c");
            foreach(char val in c)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\nd");
            foreach(char val in d)
            {
                Console.Write(val + " ");
            }Console.ReadKey();
        }
    }
}
