using System;

public class Class1
{
	public Class1()
	{
		int x = 3;
		myfunc(x);
		Console.ReadKey();
	}

	static void myfunc(int x)
	{
		if(x>0)
		{
			Console.WriteLine(x);
		}
		myfunc(x-1);	// recursion
	}
}
