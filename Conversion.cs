class Money
{
	private int amount;
	private double result;
	public void Func()
	{
		while(true)
		{
			System.Console.WriteLine("Select The Conversion");
			System.Console.WriteLine("1. Dollar To INR");
			System.Console.WriteLine("2. INR To Dollar");
			System.Console.WriteLine("3. AED To INR");
			System.Console.WriteLine("4. INR To AED");
			System.Console.WriteLine("5. Exit");
			int option = System.Convert.ToInt32(System.Console.ReadLine());

			switch(option)
			{
				case 1: System.Console.WriteLine("Enter the Amount for the Conversion");
					amount = System.Convert.ToInt32(System.Console.ReadLine());
					result = amount * 83.74;
					System.Console.WriteLine("Conversion of Dollar to INR : "+result);
					break;

				case 2: System.Console.WriteLine("Enter the Amount for the Conversion");
					amount = System.Convert.ToInt32(System.Console.ReadLine());
					result = amount / 83.74;
					System.Console.WriteLine("Conversion of INR To Dollar: "+result);
					break;

				case 3: System.Console.WriteLine("Enter the Amount for the Conversion");
					amount = System.Convert.ToInt32(System.Console.ReadLine());
					result = amount * 22.80;
					System.Console.WriteLine("Conversion of AED To INR: "+result);
					break;

				case 4: System.Console.WriteLine("Enter the Amount for the Conversion");
					amount = System.Convert.ToInt32(System.Console.ReadLine());
					result = amount / 22.80;
					System.Console.WriteLine("Conversion of INR To AED: "+result);
					break;

				case 5 :System.Console.WriteLine("Exiting .....");
					return;
			
				default :System.Console.WriteLine("Invalid Input! ");
					 break;
			}

		}
	}
}
class Conversion
{
	public static void Main(string[] args)
	{
		Money obj = new Money();
		obj.Func();
	}
}