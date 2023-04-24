using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            for(int row = 0;row< 2;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.WriteLine("Enter number : ");
                    arr[row,col] = Convert.ToInt32(Console.ReadLine()); 
                }
            }
            for(int row = 0; row< 2;row++)
            {
                for(int col=0;col<3;col++)
                {
                    Console.Write(arr[row,col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length of array  : " + arr.Length);
            Console.WriteLine("Rank of array  : " + arr.Rank);
            Console.ReadKey();
        }
    }
}
