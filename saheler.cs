using System;

namespace MyApplication
{
 public class Program
  {
   public static void Main(string[] args)
    {
	   
	 
		Console.WriteLine("Hansı fiqurun sahəsi olduğunu yazin?(Çevrə,düzbucaqlı,Üçbucaqlının daxilinə çəkilmiş çevrənin->Dçevrə)");
		string fiqur = Convert.ToString(Console.ReadLine());
		if(fiqur=="çevrə"){
			double p=3.14;
			double r = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(sahec(fiqur,r,p));
		}
		if(fiqur=="düzbucaqlı"){
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(sahed(fiqur,a,b));
		}
		if(fiqur=="dçevrə"){
			double p=3.14;
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double c = Convert.ToDouble(Console.ReadLine());
			double r = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(sahedc(fiqur,r,a,b,c));
		}
	   
		
		
	}
	
	static double sahec ( string fiqur,double r=1,double p=3.14){
		double s=0;
		if(fiqur=="çevrə"){
			s = p*r*r;
		}
		return s;
	} 
	 static double sahed ( string fiqur,double a,double b){
		double s=0;
		if(fiqur=="düzbucaqlı"){
			s = a*b;
		}
		return s;
	} 
	 
	 static double sahedc ( string fiqur,double r,double a,double b,double c){
		double s=0;
		 double t=0;
		if(fiqur=="dçevrə"){
			t=(a+b+c)/2;
			s=t*r; 
		}
		return s;
	} 
	   
    }
  }
