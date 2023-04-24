using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_12_123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //1 2
            //1 2 3
            int row, cloumn;
            for(row=1; row<=3;row++)
            {
                for(cloumn=1; cloumn<=row;cloumn++)
                {
                    Console.Write(cloumn);
                }
                Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
