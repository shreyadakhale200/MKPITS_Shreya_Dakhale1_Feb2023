using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlour
{
    internal class Program
    {
        interface PriceIceCream
        {
            void Price(int amount);
        }

        abstract class FlavourIceCream
        {
            public abstract void Price(String Flavour);
        }
        class IceCream : PriceIceCream,F
        static void Main(string[] args)
        {
        }
    }
}
