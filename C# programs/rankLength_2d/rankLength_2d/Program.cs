using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankLength_2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {{1, 2, 3 }, {4, 5, 6}, {7, 8, 9}};
            for(int row = 0;row<3;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.WriteLine("Enter number : ");
                    arr[row,col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row = 0; row<3;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.Write(arr[row,col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length of array : " + arr.Length);
            Console.WriteLine("Rank of array : " + arr.Rank);
            Console.ReadKey();
        }
    }
}
