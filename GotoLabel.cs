class GotoLabel
{
	public static void Main(string[] args)
	{
		for (int i = 1;i < 100; i++)
		{
			System.Console.WriteLine(" ");
			if(i >= 10)
				break;
			for (int j = 1; j < 100; j++)
			{
				System.Console.Write(" * ");
				if (j == i)
					goto loop1;
				}
				loop1:continue;
			}
			System.Console.WriteLine("Termination By BREAK");
		}
	}
