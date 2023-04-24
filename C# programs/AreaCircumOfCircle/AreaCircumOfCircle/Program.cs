using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircumOfCircle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int radius;
			const float pi = 3.14f;
			Console.WriteLine("Enter radius : ");
			radius = Convert.ToInt32(Console.ReadLine());
			float area = pi * radius * radius;
			Console.WriteLine("area = " + area);
			float Circumference = 2 * pi * radius;
			Console.WriteLine("Circumference = " + Circumference);
			Console.ReadKey();
		}
	}
}
