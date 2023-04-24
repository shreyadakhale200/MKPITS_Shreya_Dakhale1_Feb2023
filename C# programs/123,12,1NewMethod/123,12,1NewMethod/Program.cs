using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123_12_1NewMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 
            //1 2 
            //1
            int row, column;
            for (row = 3; row >= 1; row--)
            {
                for (column = 1; row >= column; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
