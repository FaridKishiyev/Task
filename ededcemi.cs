using System;
					
public class Program
{
	public static void Main()
	{
		double[] num = {1,5,8,};
		
		Console.WriteLine(cem(num));
		 
		
	}
	
	static double cem ( double[] num){
		double topla = 0;
		for(int i=0; i<num.Length;i++){
			topla += num[i] ;
		}
		return topla;
	}
}