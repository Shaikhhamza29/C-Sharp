class BankingSystem
{
	int amt; // Encapsulate the amt variable

    public void Withdrawal()
    {
        if (amt <= 100)
        {
            System.Console.WriteLine("Insufficient funds! Minimum balance required is 100.");
            return;
        }
 		int with;

        System.Console.Write("Enter the amount to withdraw: ");
        with =System.Int32.Parse(System.Console.ReadLine()); 
      
            if (with < 100)
            {
                System.Console.WriteLine("Minimum withdrawal amount is 100.");
                return;
            }

            if (with > amt)
            {
                System.Console.WriteLine("Insufficient balance for withdrawal.");
                return;
            }

            amt -= with;
            System.Console.WriteLine("Withdrawal successful!");
            System.Console.WriteLine("New balance: " + amt);

    }

    public void Credit()
    {
	    int cre;
        System.Console.Write("Enter the amount to credit: ");
        cre =System.Int32.Parse(System.Console.ReadLine()); 


            amt += cre;
            System.Console.WriteLine("Amount credited: " + cre);
            System.Console.WriteLine("New balance: " + amt);

    }

    public void ShowBalance()
    {
        System.Console.WriteLine("Current balance: " + amt);
    }

    public static void Main(string[] args)
    {
		int choice;
        BankingSystem obj = new BankingSystem();

        System.Console.Write("Enter the initial amount to be credited: ");
        obj.amt =System.Int32.Parse(System.Console.ReadLine()); 
        

        while (true)
        {
            System.Console.WriteLine("1. Withdrawal");
            System.Console.WriteLine("2. Credit");
            System.Console.WriteLine("3. Show Balance");
            System.Console.WriteLine("4. Exit");
            System.Console.Write("Enter your choice: ");
			choice = System.Int32.Parse(System.Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.Withdrawal();
                        break;
                    case 2:
                        obj.Credit();
                        break;
                    case 3:
                        obj.ShowBalance();
                        break;
                    case 4:
                        System.Console.WriteLine("Exiting...");
                        return;
                    default:
                        System.Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
        }
    }
}
