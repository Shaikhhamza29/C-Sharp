class FuncOver
{
	public void Multiply(int a , int b)
	{
		int result = a * b;
		System.Console.WriteLine("the Multiplication of {0} * {1} = {2}",a,b,result);
	}

	public void Multiply(double a , double b)
	{
		double result = a * b ;
		System.Console.WriteLine("the Mutiplcation of "+a+" * "+b+ " = "+result);
	}

	public static void Main(string[] args)
	{
		FuncOver obj = new FuncOver();
		obj.Multiply(2,6);
		obj.Multiply(2.9,2.6);

	}	
}