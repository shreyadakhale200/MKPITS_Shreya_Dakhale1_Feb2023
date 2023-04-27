using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Shreya";
            string MiddleName = " Kishor";
            string LastName = " Dakhale";
            string res = string.Concat(FirstName, MiddleName, LastName);
            Console.WriteLine("Full Name : " + res);
            Console.ReadKey();
        }
    }
}
