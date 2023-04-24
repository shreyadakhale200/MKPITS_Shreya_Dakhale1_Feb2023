using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedNumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 1 1 1 1
            //2 2 2 2 2
            //3 3 3 3 3
            int row, column;
            for(row=1; row<=3;row++)
            {
                for(column=1; column<=5;column++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
