class IfElseNesting
{
	public static void Main(string[] args)
	{
		int a = 325 , b = 712 , c = 478;
		System.Console.WriteLine("Largest Value is : ");
		if(a>c)
		{
			if(a>c)
			{
				System.Console.WriteLine(a);
			}
			else
			{
				System.Console.WriteLine(c);
			}
		}
		else
		{
			if(c>b)
			{
				System.Console.WriteLine(c);
			}
			else
			{
				System.Console.WriteLine(b);
			}
		}
	}
}