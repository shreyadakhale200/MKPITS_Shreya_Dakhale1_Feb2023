using System;
namespace UserInput
{
	class Prgoram
	{
		static void Main()
		{
			int number1, square;
			Console.WriteLine("Enter number 1 : ");
			number1 = Convert.ToInt32 (Console.ReadLine());

			square = number1 * number1;

			Console.WriteLine("Square of " + number1 + " is : " + square);
			Console.ReadKey();
		}
	}
}