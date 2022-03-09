using System;
					
public class Program
{
	public static void Main()
	{
		string x = Convert.ToString(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
	
		Console.WriteLine(repeat(x,y));
		 
		
	}
	
	static string repeat (string x,int y){
		string cumle = "";
		int i=0;
		while(i<y){
			i++;
			cumle += x + " " ;
		}
		return cumle;
	}
}