class Showroom
{
	public static void Main(string[] args)
	{
		int purchased_amt = System.Convert.ToInt32(args[0]);
		System.Console.WriteLine("1.purchased item btw 0 - 100\n2.purchased item btw 101 - 200\n3.purchased item btw 201 - 300\n4.purchased item above 300  \nSelect a Number : ");
		double final_amt;

		int switch_i = System.Convert.ToInt32(System.Console.ReadLine());	
		System.Console.WriteLine("1.millcloth \n2.handloom \n3.both");
		int cloth = System.Convert.ToInt32(System.Console.ReadLine());
		switch(switch_i)
		{
			case 1 : if(cloth == 1)
				{
					final_amt = purchased_amt ;
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else if(cloth == 2)
				{
					final_amt = purchased_amt /( 100*5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else
				{
					final_amt = purchased_amt/ ( 200*5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				
			case 2: if(cloth == 1)
				{
					final_amt = purchased_amt /( 100*5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else if(cloth == 2)
				{
					final_amt = purchased_amt/ (100*7.5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else
				{
					final_amt = (purchased_amt )/ (200)*(5*7.5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
			case 3: if(cloth == 1)
				{
					final_amt = purchased_amt/ ( 100*7.5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else if(cloth == 2)
				{
					final_amt = purchased_amt / (100*10);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else
				{
					final_amt = purchased_amt /( 200)*(7.5*10);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}

			case 4: if(cloth == 1)
				{
					final_amt = purchased_amt/ ( 100*10);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else if(cloth == 2)
				{
					final_amt = purchased_amt / (100*15);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
				else
				{
					final_amt = (purchased_amt)/ ( 200)*(10*15);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
				}
			default: System.Console.WriteLine("INVALID NUMBER");
				break;
		}
	}
}