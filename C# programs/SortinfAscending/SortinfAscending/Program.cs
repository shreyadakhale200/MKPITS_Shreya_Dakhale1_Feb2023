using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortinfAscending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 13, 12, 11 };
            int temp;
            for(int outer_loop = 0; outer_loop < data.Length; outer_loop++)
            {
                for(int inner_loop = outer_loop+1;inner_loop < data.Length;inner_loop++)
                {
                    if(data[outer_loop] > data[inner_loop])
                    {
                        temp = data[outer_loop];
                        data[outer_loop] = data[inner_loop];
                        data[inner_loop] = temp;
                    }
                }
            }for(int display_array = 0;display_array < data.Length;display_array++)
            {
                Console.WriteLine(data[display_array]);
            }
            Console.ReadKey();  

        }
    }
}
