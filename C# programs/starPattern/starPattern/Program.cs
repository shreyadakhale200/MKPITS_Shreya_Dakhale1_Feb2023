using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*
            //* *
            //* * *
            int row, column;
            for(row=1; row<=3;row++)
            {
                for(column=1; column<=row;column++)
                {
                    Console.Write("*" + " ");
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
