using System;
class ForeachTest1
{
	public void func()
	{
		int[] arrayInt = { 11, 22, 33, 44 };
		foreach (int m in arrayInt)
		{
			System.Console.Write(" " +m);
		}
		System.Console.WriteLine();
	}
}

class ForEachTest
{
	public static void Main(string[] args)
	{
		ForeachTest1 obj = new ForeachTest1();
		obj.func();
	}
}	