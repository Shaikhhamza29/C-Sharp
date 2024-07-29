class ConsOver
{

	public ConsOver(int a , int b)
	{
		int result = a * b;
		System.Console.WriteLine("the Multiplication of {0} * {1} = {2}",a,b,result);
	}

	public ConsOver(double c , double d)
	{
		double result = c * d ;
		System.Console.WriteLine("the Mutiplcation of "+c+" * "+d+ " = "+result);
	}

	public static void Main(string[] args)
	{

		ConsOver obj1 = new ConsOver(5,8);
		ConsOver obj2 = new ConsOver(5.9,8.6);

	}	
}