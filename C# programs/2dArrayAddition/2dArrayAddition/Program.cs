using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3;
            arr3 = ArrayAddition(arr1, arr2);
            //Console.WriteLine(arr3);
            int[,] ArrayD = AdditionDiagram(arr1, arr2);
           
            Console.ReadKey();

        }
        static int[,] ArrayAddition(int[,] arr1,int[,] arr2)
        {
            int[,] arr3 = new int[3,3];
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.Write("\nrow " + (row+1) + " ");
                    Console.Write("column " + (col+1));
                    Console.Write("\nEnter arr1 " + "(" + row + "," + col + ") = " );
                    arr1[row,col] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter arr2 : " + "(" + row + "," + col + ") = " );
                    arr2[row,col] = Convert.ToInt32(Console.ReadLine());
                    //arr3[row,col] = arr1[row,col] + arr2[row,col];
                    //arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            for(int row = 0;row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    arr3[row,col] = arr1[row, col] + arr2[row,col];
                }
            }

            for(int row = 0; (row < 3); row++)
            {
                for(int col = 0;col < 3; col++)
                {
                    //Console.WriteLine(arr3[row,col]);
                }
            }
                return arr3;
                return arr1;
                return arr2;
        }

        static int[,] ValuesOfArray(int[,] arr1, int[,] arr2)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    return arr1;
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    return arr2;
                }
            }
            return null;
        }
        static int[,] AdditionDiagram(int[,] arr1, int[,] arr2)
        {
            int[,] Array_values = ValuesOfArray(arr1, arr2);
            int[,] arr3 = new int[3, 3];
            Console.Write("\nArray1 : \n");
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0;col< 3; col++)
                {
                    arr3[row,col] = arr1[row, col] + arr2[row,col];
                    Console.Write(arr1[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nArray2 : \n");
            for (int row = 0; row < 3; row++)
            {
                for(int col = 0;col< 3; col++)
                {
                    Console.Write(arr2[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nArray3 : \n");
            for (int row = 0; row < 3; row++)
            {
                for(int col = 0;col< 3; col++)
                {
                    Console.Write(arr3[row, col] + "\t");
                }
                Console.WriteLine();
            }
            return arr3;
        }
    }
}
