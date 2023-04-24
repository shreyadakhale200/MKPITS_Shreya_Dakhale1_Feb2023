using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class game
    {
        public int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // numbers to shuffle
        public int n = numbers.Length;

        public void RandomArray(int[] numbers, int n)
        {
            this.numbers = numbers;
            this.n = n;
            for (int i = n - 1; i > 0; i--)
            {
                Random rng = new Random();
                int j = rng.Next(i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;

                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
    internal class Game
    {
        game g1 = new game();
        //g1.RandomArray();


    //Fisher Yates shuffel algorithm

}
}
