class BankingSystem
{
int amt ;
	public void Withdrawal()
	{	
		
		int with;
		System.Console.WriteLine("Enter The Amount To Withdraw : ");
		with =System.Int32.Parse(System.Console.ReadLine());
		amt -= with;
		System.Console.WriteLine("Balance Amount  :" + amt );	

	}

	public void Credit()
	{	
		
		int cre;
		System.Console.WriteLine("Enter The Amount To Credit : ");
		cre = System.Int32.Parse(System.Console.ReadLine());
		amt += cre;
		System.Console.WriteLine("Balance Amount :  {0}\nCredited Amount :  {1}", amt ,cre);	

	}


	public void Show_Balance()
	{	
		int bal;
		bal = amt ;
		System.Console.WriteLine("Balance Amount :  {0}", bal);	

	
	}
	
	public static void Main(string[] args)
	{
		int ch;
		BankingSystem obj = new  BankingSystem();
		System.Console.WriteLine("Enter The Amount To Be Credited : ");
		obj.amt = System.Int32.Parse(System.Console.ReadLine());
		
		while(true)
		{
			System.Console.WriteLine("1.For Withdrawal\n2.For Credit \n3.Current amount \n4.Exit ");
			ch = System.Int32.Parse(System.Console.ReadLine());

				switch(ch)
				{
					case 1: obj.Withdrawal();
						break;
	
					case 2: obj.Credit();
						break;
				
					case 3: obj.Show_Balance();
						break;
					
					case 4: System.Console.WriteLine("EXITING ");
						return;

					default:System.Console.WriteLine(" Invalid input ");
						break; 
				}
		}

	}
}