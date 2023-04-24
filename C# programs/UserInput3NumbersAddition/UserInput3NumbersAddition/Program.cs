//wap to accept 3 no and print addition of 3 no.
using System;
namespace Program
{
	class Program
	{
		static void Main()
		{
			int number1, number2, number3, sum;
			Console.WriteLine("Enter number 1 : ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number 2 : ");
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number 3 : ");
			number3 = Convert.ToInt32(Console.ReadLine());

			sum = number1 + number2 + number3;
			Console.WriteLine("Addition of " + number1 + " + " + number2 + " + " + number3 + " is : " + sum);
			Console.ReadKey();
		}
	}
}