using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationOfMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = Arrayvalues(array1, array2);
            int[,] array4 = Multiply(array1, array2);
            Console.ReadKey();
        }
        static int[,] Arrayvalues(int[,] array1, int[,] array2) 
        {
           //Array1 and Array2 initialization
            for(int row = 0;row<3;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.WriteLine("\n" + row + "," + col);
                    Console.WriteLine("Array 1 : ");
                    array1[row, col] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Array 2 : ");
                    array2[row, col] = Convert.ToInt32(Console.ReadLine());
                } 
            }

            //Array1 Display
            Console.WriteLine("\nARRAY 1");
            for(int row = 0;row<3;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.Write(array1[row,col] + "\t");
                } 
                Console.WriteLine();
            }
          Console.WriteLine() ;


            Console.WriteLine("ARRAY 2");
            //Array2 Display
            for(int row = 0;row<3;row++)
            {
                for(int col = 0;col<3;col++)
                {
                    Console.Write(array2[row,col] + "\t");
                } 
                Console.WriteLine();
            }
            return array1;
            return array2;
        }

        static int[,] Multiply(int[,] array1, int[,] array2)
        {
            
        }
    }
}

