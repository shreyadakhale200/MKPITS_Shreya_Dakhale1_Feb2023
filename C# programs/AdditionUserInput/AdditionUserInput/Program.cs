//wap to accept 2 no and print addiition of 2 number

using System;
namespace AdditionUserInput
{
	class Program
	{
		static void Main()
		{
			int number1, number2;
			Console.WriteLine("Enter number 1 : ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number 2 : ");
			number2 = Convert.ToInt32(Console.ReadLine());
			int sum;
			sum = number1 + number2;
			Console.WriteLine("Sum of " + number1 + " and " + number2 + " is : " + sum);
			Console.ReadKey();
		}
	}
}