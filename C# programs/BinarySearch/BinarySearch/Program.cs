using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp=0;
            int low, high,mid=0;
            Console.Write("Enter size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            low = 0; high = arr.Length-1;


            for(int outer_loop=0;outer_loop<arr.Length;outer_loop++)
            {
                Console.Write("Enter number " + (outer_loop+1) + " : ");
                arr[outer_loop] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter target : ");
            int target = Convert.ToInt32(Console.ReadLine());
            
            SortingArray(arr, temp);


            int result = BinarySearch(low, high, mid, arr, target);
            if(result == -1)
            {
                Console.Write("\nno {0} was not found", target);
            }
            else
            {
                Console.Write("\nno {0} is found at index {1}",target,result);
            }
            Console.ReadKey();
        }

        static int BinarySearch(int low,int high,int mid, int[] arr,int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        static void SortingArray(int[] arr, int temp)
        {
            for (int outer_loop = 0; outer_loop < arr.Length; outer_loop++)
            {
                for (int inner_loop = outer_loop + 1; inner_loop < arr.Length; inner_loop++)
                {
                    if (arr[outer_loop] > arr[inner_loop])
                    {
                        temp = arr[outer_loop];
                        arr[outer_loop] = arr[inner_loop];
                        arr[inner_loop] = temp;
                    }
                }
            }
            Console.Write("Sorted Array : ");
            for (int display_arr = 0; display_arr < arr.Length; display_arr++)
            {
                Console.Write(arr[display_arr] + " ");
            }
            int[] arr1 = (int[])arr.Clone();
        }

    }
}
