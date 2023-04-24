using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5
            //1 2 3 4 5
            int row, column;
            for(row = 1;row<=2; row++)
            {
                for(column = 1;column<=5;column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
