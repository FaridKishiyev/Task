using System;

namespace MyApplication
{
 public class Program
  {
   public static void Main(string[] args)
    {
	   
	 int[] number = {1,5,8,-8,-11,98,-45,69,37,-31,85};
				
		Console.WriteLine(num(number));
		
	}
	
	static string num (int[] number){
		string newnum = "";
		for(int i=0 ; i<number.Length ;i++)
		{
			if(number[i]<0){
				newnum +=  -1 * number[i] +" ";
			}
			else{
				newnum +=number[i]+" ";
			}
		}
		return  newnum; 
	}
	   
    }
  }
