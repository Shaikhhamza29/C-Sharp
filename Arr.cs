using System;
using System.Collections;
class Demo
{
	public void Func()
	{
		ArrayList arrlst = new ArrayList();
				

		while(true)
		{
			System.Console.WriteLine("1. Add");
			System.Console.WriteLine("2. INSERT");
			System.Console.WriteLine("3. Listing");
			System.Console.WriteLine("4. Reverse");
			System.Console.WriteLine("5. Sort");
			System.Console.WriteLine("6. Remove");
			System.Console.WriteLine("7. Exiting ");
			
			System.Console.WriteLine("Enter the Number");
			int choice = System.Convert.ToInt32(Console.ReadLine());

			switch(choice)
			{
				case 1: System.Console.WriteLine("Enter the String");
					string str = System.Console.ReadLine();
					arrlst.Add(str);
					System.Console.WriteLine("Added Successfully");
					break;

				case 2: System.Console.WriteLine("Enter the String to Insert");
					string str1 = System.Console.ReadLine();
					System.Console.WriteLine("Enter the Index value to Store the String");
					int idx = System.Convert.ToInt32(Console.ReadLine());
					arrlst.Insert(idx, str1);
					System.Console.WriteLine("Inserted at {0} Sucessfully",idx);
					break;

				case 3:	System.Console.WriteLine("The Elements in the Array are : ");
					foreach ( string obj in arrlst)
					{
         					int index = arrlst.IndexOf(obj);
						Console.Write( "   {0} {1}", index,obj );
 
					}
					Console.WriteLine();
					break;
					 
				case 4:	System.Console.WriteLine("Reverse of the Array");
					arrlst.Reverse();
					break;

				case 5: System.Console.WriteLine("Sorted Array is : ");
					arrlst.Sort();
					break;
					
				case 6: System.Console.WriteLine("Enter the index value of the String to Remove");
					int i = System.Convert.ToInt32(Console.ReadLine());
					arrlst.RemoveAt(i);
					System.Console.WriteLine("Removed Successfully");
					break;
				
				case 7 :System.Console.WriteLine("Exiting ..........");
					return;
					
			default:System.Console.WriteLine("!!!!!!!!!!!Invalid Number !!!!!!!!!!");
				break;

				 
			}
		}
		
					
	} 
}

class Arr
{
	public static void Main(string[] args)
	{
		Demo obj = new Demo();
		obj.Func();
	}
}