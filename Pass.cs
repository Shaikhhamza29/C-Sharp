using System;
class Pass
{
	static void change (int m)
	{
		m = m + 10;
	}
	public static void Main(string[] args)
	{
		int x = 100;
		change (x);
		System.Console.WriteLine( "x = "  + x);
	}
}