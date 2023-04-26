using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticVariablesAndMethods
{
    class House
    {
        public static int cupboard = 1;
        public static int OldHouseRenovationFees = 340000; 
        public static void HouseRenovation(int cupboard,int OldHouseRenovationFees)
        {
            Console.WriteLine("Number of Cupboards : " + cupboard);
            Console.WriteLine("Old House Renovation Fees : " + OldHouseRenovationFees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            House.HouseRenovation(4,500000);
            Console.ReadKey();
        }
    }
}
