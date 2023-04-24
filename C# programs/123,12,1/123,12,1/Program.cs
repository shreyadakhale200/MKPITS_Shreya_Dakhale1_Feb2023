using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 
            //1 2 
            //1
            int row, column;
            for(row=1; row<=3;row++)
            {
                for(column=1; column<=4-row;column++)
                {
                    Console.Write(column + " ");
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
