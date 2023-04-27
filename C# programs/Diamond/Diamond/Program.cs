using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 4;
            for (int outer_loop = 1; outer_loop <= height; outer_loop++)
            {
                for (int inner_loop = height - outer_loop; inner_loop >= 1; inner_loop--)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= 2*outer_loop-1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1;k<=(height+3)-2*i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine('\n');
            }
            Console.ReadKey();
        }
    }
}
