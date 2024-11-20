using System;
using System.Collections;

public class GFG
{
	public static public void Main ()
	{
		Console.WriteLine($"Is it Prime Number? {IsPrimeNumber(7)}");
		Console.WriteLine($"Is it Prime Number? {IsPrimeNumber(8)}");
	}
	public static bool IsPrimeNumber(int num)
	{
	    if(num <= 1) {return false;} //not a prime Number
	    if(num == 2) {return true;} // 2 is prime Number
		 // taking square root is an optimisation
	    for(int i=2; i*i <= num; i++){
	       Console.WriteLine($"{i} and {num}");
	       if (num % i == 0) return false;
	    }
	    return true;
	}
}
