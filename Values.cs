class Value
{
	public void Demo(string[] args)
	{
	int Product;
	int val1 = System.Convert.ToInt32(args[0]);
	int val2 = System.Convert.ToInt32(args[1]);
	int val3 = System.Convert.ToInt32(args[2]);
	int val4 = System.Convert.ToInt32(args[3]);

	Product = val1 * val2 * val3 * val4;
	System.Console.WriteLine("The Product of the Four Values : "+Product);
	}
}

class Values
{
	public static void Main(string[] args)
	{
		
		Value obj = new Value();
		obj.Demo(args);
	}
}