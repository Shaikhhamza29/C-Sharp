using System;
class ImplicitConv{
	int b = 10;
	
	public static void Main(string[] args){
		ImplicitConv obj = new ImplicitConv();
		
		int i = obj.b;
		Console.WriteLine("Integer : "+i);	
		
		float f = obj.b;
		Console.WriteLine("Float : "+f);

		double d = obj.b;
		Console.WriteLine("Double : "+d);

		//short s = obj.b;
		//Console.WriteLine("Short : "+s);

		//sbyte sb = obj.b;
		//Console.WriteLine(sb);
		
		decimal dm = obj.b;
		Console.WriteLine(dm);

		//nint ni = obj.b;
		//Console.WriteLine(ni);
	}
}