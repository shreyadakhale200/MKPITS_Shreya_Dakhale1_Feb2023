using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transposeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            for(int row = 0; row < 3;row++) 
            {
                for(int col = 0; col < 3;col++)
                {
                    Console.WriteLine("(" + row + "," + col + ")");
                    arr1[row,col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row = 0;row < 3;row++)
            {
                for(int col = 0; col < 3;col++)
                {
                    Console.Write(arr1[row,col] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    arr2[row, col] = arr1[col, row];
                    Console.Write(arr2[row,col] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
