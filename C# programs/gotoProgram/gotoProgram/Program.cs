using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gotoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) goto even;

            Console.WriteLine("odd");
            goto end;

            even:
            Console.WriteLine("even");
            goto end;

        end:
            Console.WriteLine("bye");

        Console.ReadKey();
        }
    }
}
