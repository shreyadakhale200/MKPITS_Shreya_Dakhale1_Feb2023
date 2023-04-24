using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 6;
            for (int outer_loop = 1; outer_loop <= height; outer_loop++)
            {
                for (int inner_loop = height - outer_loop; inner_loop >= 1; inner_loop--)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= outer_loop; star++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = height-i+1; k >= 1; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
