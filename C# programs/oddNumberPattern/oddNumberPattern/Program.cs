using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //1 3
            //1 3 5
            //1 3 5 7
            //1 3 5 7 9
            int row, column;
            for(row=1;row<=5;row++)
            {
                for(column=1;column<=row*2-1;column++)
                {
                        Console.Write(column);
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
