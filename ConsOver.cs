class ConsOver1
{

	public ConsOver1(int a , int b)
	{
		int result = a * b;
		System.Console.WriteLine("the Multiplication of {0} * {1} = {2}",a,b,result);
	}

	public ConsOver1(double c , double d)
	{
		double result = c * d ;
		System.Console.WriteLine("the Mutiplcation of "+c+" * "+d+ " = "+result);
	}
}

class ConsOver
{
	public static void Main(string[] args)
	{

		ConsOver1 obj1 = new ConsOver1(5,8);
		ConsOver1 obj2 = new ConsOver1(5.9D,8.6D);

	}	
}