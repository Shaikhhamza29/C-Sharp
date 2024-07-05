class Real
{
	public static void Main(string[] args)
	{
		int time = System.Convert.ToInt32(args[0]);
		int velocity = System.Convert.ToInt32(args[1]);
		int accl = System.Convert.ToInt32(args[2]);
		System.Console.WriteLine("TIME = "+time);
		System.Console.WriteLine("VELOCITY = "+velocity);	
		System.Console.WriteLine("ACCLERATION = "+accl);
		int displacment = ((velocity*time)+(accl*time^2))/2;
		System.Console.WriteLine(displacment);
	}
}