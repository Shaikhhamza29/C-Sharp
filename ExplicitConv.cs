using System;
class ExplicitConv{
	long b = 10;
	
	public static void Main(string[] args){
		ExplicitConv obj = new ExplicitConv();
		
		int i = (int)obj.b;
		Console.WriteLine("Integer : "+i);	
		
		float f = (float)obj.b;
		Console.WriteLine("Float : "+f);

		double d = (double)obj.b;
		Console.WriteLine("Double : "+d);

		short s = (short)obj.b;
		Console.WriteLine("Short : "+s);

		sbyte sb = (sbyte)obj.b;
		Console.WriteLine("Sbyte : "+sb);
		
		decimal dm = (decimal)obj.b;
		Console.WriteLine("Decimal : "+dm);

		ushort us = (ushort)obj.b;
		Console.WriteLine("Ushort : "+us);

		uint ui = (uint)obj.b;
		Console.WriteLine("Uint : "+ui);

		//nint ni = (nint)obj.b;
		//Console.WriteLine("Nint : "+ni);
	
		//nuint nui = (nuint)obj.b;
		//Console.WriteLine("Nuint : "+nui);

		ulong ul = (ulong)obj.b;
		Console.WriteLine("Ulong : "+ul);
	}
}