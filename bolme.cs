using System;
					
public class Program
{
	public static void Main()
	{
		double x = Convert.ToDouble(Console.ReadLine());
		double y = Convert.ToDouble(Console.ReadLine());
	
		Console.WriteLine(bol(x,y));
		 
		
	}
	
	static double bol (double x,double y){
		double cem = x/y;
		return cem;
	}
}