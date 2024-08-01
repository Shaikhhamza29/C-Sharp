class Loop1
{
	private int Fact;
	public void Func()
	{
		Fact = 1;
		int[] Factarr = {1,2,3,4,5,6};
		foreach (int i in Factarr)
		{
			Fact = Fact * i;
		}
	}
	public void show()
	{
		System.Console.WriteLine("The Factorial of the Number : "+Fact);
	}
}

class Loop
{
	public static void Main(string[] args)
	{
		Loop1 obj = new Loop1();
		obj.Func();
		obj.show();

	}
}