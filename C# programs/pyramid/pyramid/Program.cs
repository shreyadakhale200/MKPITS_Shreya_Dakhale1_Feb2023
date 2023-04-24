using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1                     //1
            //123                   //12(-2)
            //12345                 //123(-3)(-3)
            //1234567               //1234(-4)(-4)(-4)
            //123456789             //12345(-5)(-5)(-5)(-5)

            //    1
            //   121
            //  12312
            // 1234123
            //123451234

            int row, col,num=1;
            for (row = 1; row <= 5; row++)
            {
                for (col = 1; col <= row * 2 - 1; col++)
                {
                    if (col <= row)
                    {
                        Console.Write(col);
                    }
                    else if (col > row)
                    {
                        Console.Write(col - num);
                    }
                }
                Console.WriteLine();
                num++;
            }

            Console.ReadKey();
        }
    }
}
