using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Program
    {
        class Animal
        {
            public void Action()
            {
                Console.WriteLine("Animal is eating");
            }
        }
        class dog:Animal
        {
            public void Action()
            {
                Console.WriteLine("Animal is barking");
                base.Action();
            }
        }
        class babyDog:dog
        {
            public void Action()
            {
                Console.WriteLine("Animal is Weeping");
                base.Action();
            }
        }

        static void Main(string[] args)
        {
            babyDog bbd1 = new babyDog();
            bbd1.Action();
            Console.ReadKey();
        }
    }
}
