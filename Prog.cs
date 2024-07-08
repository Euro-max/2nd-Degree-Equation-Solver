

using System;

public class EquationSolver
{
   
    public static void Main(string[] args)
    {
         bool isRunning=true;
        while(isRunning){
    Console.WriteLine("Enter your a,b,and c in the form of ax^2+bx+c=0");
    Console.WriteLine("What is your a");
    var a= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is your b");
    var b=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is your c");
    var c=Convert.ToDouble(Console.ReadLine());
    var d= Math.Pow(b,2)-4*a*c;
 var e=-b+Math.Sqrt(d)/2*a;
var f=-b-Math.Sqrt(d)/2*a;
var o=-b+Math.Sqrt(-d)/2*a;
var p=-b-Math.Sqrt(-d)/2*a;

double x = Math.Truncate(o* 100) / 100;
double y = Math.Truncate(p * 100) / 100;
double r = Math.Truncate(e* 100) / 100;
double t = Math.Truncate(f * 100) / 100;

var g = x +"i";
var h = y +"i";


    
  
    
    switch(d){
        case <0:
        Console.WriteLine($"Your Imaginary numbers are {g},{h}");
        break;
         case 0:
        Console.WriteLine($"Your number is {e}");
        break;
         case >0:
        Console.WriteLine($"Your 2 solutions are {r},{t}");
        break;
    }
    Console.WriteLine("Do you want to run again");
    string isRunningResponse=Console.ReadLine();
    if(isRunningResponse=="no"){
        isRunning=false;
    }
    }
    }
}
