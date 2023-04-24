using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_repeated_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3,3,2,4,2,7,7    3+3+2+2+7+7 = 24
            int size;
            Console.Write("Enter size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            int[] arr = new int[size];
            int iterate = 0;
            int sum=0;
            int subtract=0;
            int num;
            int index = Array.IndexOf(arr, size-1);
            //int[] arr1 = (int[])arr.Clone();

            //intializing array
            for (int array_intialize =0;array_intialize<arr.Length;array_intialize++)
            {
                Console.Write("Enter number " + (array_intialize+1) + " = ");
                arr[array_intialize] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i < arr.Length; i++)
            {
                for(int j=0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (i > j || j > i)
                        {
                            sum += arr[i];
                            Console.Write(arr[i]);
                            //Console.Write("index" + index);
                            // 1,2,3,2,1        arr[5];
                            
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(" = " + sum);
            Console.ReadKey();
        }
                 
        /*static int[] AdditionOfRepeated_Numbers(int[] arr)
        {

        }*/
    }
}
