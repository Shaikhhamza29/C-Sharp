using System;
class First{
	public void field1(){
		Second scnd = new Second();
		string str1 = "C#";
		Console.WriteLine(str1 + scnd.str2);
	}
}
class Second{
	public string str2 = "Programming";
	
}

class Display{
	public static void Main(string[] args){
		First fst = new First();
		fst.field1();
		//Second scnd = new Second();
		//Console.WriteLine();		
	}
}