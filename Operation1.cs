using System;
class Demo
{
		public void Trial()
		{
		int reverse = 0;
		int value;
		int sum = 0;
		System.Console.WriteLine("Enter the Number");
		int num = System.Convert.ToInt32(Console.ReadLine());
		while(num!= 0)
		{
			value = num % 10;
			reverse = reverse * 10 + value;
			sum = sum + value;
			num = num/10;
		}
		System.Console.WriteLine("Reverse of a Number : "+reverse);
		System.Console.WriteLine("The sum of Digit is : "+sum);
		}
}    


class Operation1
{
	public static void Main(string[] args)
	{
		Demo demo = new Demo();
		demo.Trial();	
	}
}                                                                                          