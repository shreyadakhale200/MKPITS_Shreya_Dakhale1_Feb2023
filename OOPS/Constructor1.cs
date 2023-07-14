using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Friend Friend1 = new Friend("Sakshi", "Ahemdabad", 23);
            Console.WriteLine("Welcome to Best Friend Finder");
            Console.Write("Do you want to find a friend ? ");
            string FriendFinder = Console.ReadLine();
            while(FriendFinder == "Yes")
            {
                Console.Write("enter Name :");
                string Name = Console.ReadLine();

                Console.Write("enter Address :");
                string Address = Console.ReadLine();

                Console.Write("enter Age :");
                int Age = Convert.ToInt32(Console.ReadLine());

                Friend Friend1 = new Friend(Name, Address,Age);
                Console.Write("Do you want to find a friend ? ");
                FriendFinder = Console.ReadLine();
            }
            Console.WriteLine("Try again tomorrow");
            Console.ReadKey();
        }
    }
}
