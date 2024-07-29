using System;
class Method1
{
	
	
		public int Cube( int x)
		{
			return ( x * x * x);
		}

	
}

class MethodTest
{
	public static void Main(string[] args)
	{
		Method1 obj = new Method1();
		int y = obj.Cube(5);
		
		System.Console.WriteLine(y);
	}
}

