using System;
namespace AreaOfRectangle
{
	class Program
	{
		static void Main()
		{
			int length, breadth, areaOfRectangle;
			Console.WriteLine("Enter length of Rectangle : ");
			length = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter breadth of Rectangle : ");
			breadth = Convert.ToInt32(Console.ReadLine());

			areaOfRectangle = length * breadth;

			Console.WriteLine("Area of Rectangle is : " + areaOfRectangle);
			Console.ReadKey();

		}
	}
}