using System;
//system is a namespace
//namespace is a unit to group related classes, packages

namespace HelloProgram
{
	class Program
	{
		static void Main()
		{
			//console is a class in system namespace 
			//writeline is a method in console class
			//Console.WriteLine("Hello from C# class ;");
			//Console.Write("Hello from mkpits");

			int a;
			a = hello();

			Console.ReadKey();
		}
		static int hello()
		{
			Console.WriteLine("Hello C#");
			return 1;
		}
	}
}