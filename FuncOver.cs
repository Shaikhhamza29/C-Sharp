class FuncOver1
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
}
class FuncOver
{

	public static void Main(string[] args)
	{
		FuncOver1 obj = new FuncOver1();
		obj.Multiply(2,6);
		obj.Multiply(2.9,2.6);

	}	
}