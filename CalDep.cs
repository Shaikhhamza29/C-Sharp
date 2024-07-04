class CalDep
{
	public static void Main(string[] args)
	{
		int Depreciation;
		int purchased_price = System.Int32.Parse(args [0]);
		int salvage = System.Int32.Parse(args [1]);
		int year = System.Int32.Parse(args [2]);
		Depreciation = salvage - purchased_price / year;
		System.Console.WriteLine(Depreciation);
	}
}