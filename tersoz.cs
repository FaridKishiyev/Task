using System;
					
public class Program
{
	public static void Main()
	{
		string word = Convert.ToString(Console.ReadLine());
		
		Console.WriteLine(wrd(word));
	}
	
	static string wrd (string word){
		string soz = "";
		 
		for(int i = word.Length-1; i>-1; i--){
			soz += word[i];
		}
			
		return soz;
	}
}