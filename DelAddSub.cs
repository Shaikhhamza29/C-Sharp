class DelegatesAddSub
{
	delegate void AdditionCall(int no,int no1);
	delegate void subtractionCall(int no1,int no2);
	public void Func()
	{
		System.Console.WriteLine("Enter Two Number For Addition & Subtraction : ");
		int num1 = System.Convert.ToInt32(System.Console.ReadLine());
		int num2 = System.Convert.ToInt32(System.Console.ReadLine());
	
		AdditionCall add = new AdditionCall(Addition);
		
		subtractionCall sub = new subtractionCall(Subtraction);
		add(num1,num2);
		sub(num1,num2);
	}
	
	 public void Addition(int no1, int no2)
	{	
		int numresult = no1 + no2;
		System.Console.WriteLine("The addition of two number is " +numresult );
	}
	public void Subtraction(int no1, int no2)
	{
		int numresult = no1 - no2;
		System.Console.WriteLine("The subtraction of two number is " +numresult );
	}

}

class DelAddSub
{
	public static void Main(string[] args)
	{
		DelegatesAddSub obj = new DelegatesAddSub();
		obj.Func();
	}
}