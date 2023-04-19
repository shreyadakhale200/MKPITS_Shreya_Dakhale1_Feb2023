using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoChocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chocolate;
            Console.WriteLine("Do you have a chocolate : ");
            chocolate = Convert.ToString(Console.ReadLine());
            if (chocolate == "yes") goto yes;
            Console.WriteLine("No I dont have a chocolate");
            goto end;

            yes:
            Console.WriteLine("Thanks for giving me chocolate");
            goto end;

            end:
            Console.WriteLine("ok BYE");

            Console.ReadKey();

        }
    }
}
