class FtoC
{
	public static void Main(string[] args)
	{
		float f = System.Single.Parse(args [0]);
		float C = (float)((f - 32)/1.8);
		System.Console.WriteLine("C = "+C);
	}
}