class Product_Four_Value
{
	private int a,b,c,d;
	private int Result;
	public void Product(int a , int b, int c ,int d)
	{
		Result = a * b * c * d;
		System.Console.WriteLine("The Product of {0} {1} {2} {3} is {4}",a,b,c,d,Result);
	}
	public static void Main(string[] args)
	{
		Product_Four_Value obj = new Product_Four_Value();
		obj.a = System.Convert.ToInt32(args[0]);
		obj.b = System.Convert.ToInt32(args[1]);
		obj.c = System.Convert.ToInt32(args[2]);
		obj.d = System.Convert.ToInt32(args[3]); 
		obj.Product(obj.a,obj.b,obj.c,obj.d);	
	}
}