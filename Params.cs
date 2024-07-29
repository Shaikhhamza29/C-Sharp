using  System;
class Params
{
	static void parray(params int [ ] arr)
	{
		System.Console.write("Array elements are : ");
		foreach(int i in arr)
			System.Console.Write(" " + i);
		System.Console.WriteLine();
	}
	public static void Main()
	{
		int [ ] x = {11,22,33};
		Parray(x);
		Parray();
		Parry(100,200);
	}
}