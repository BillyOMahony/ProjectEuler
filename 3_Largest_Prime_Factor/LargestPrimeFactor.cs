using System;
using System.Collections.Generic;

public class LargestPrimeFactor{
	public static bool IsPrime(long num){
		bool value;	

		value = true;
		
		for (long x = 2; x < (num/2); x ++){
			if(num % x == 0){
				value = false;
				return value;
			}
		}

		return value;
	}

	public static void Main(){
		List<long> primeFactors = new List<long>();
		long number = 600851475143;

		for(long x = 2; x < Math.Ceiling(Math.Sqrt(number)); x ++){
			number = 600851475143;
			
			if(number % x == 0 && IsPrime(x)){
				primeFactors.Add(x);

				while(number % x == 0){
					number = number / x;
				}
			}
		}

		long largestPrimeFactor = 0;

		foreach(long num in primeFactors){
			Console.WriteLine(num);
			if(num > largestPrimeFactor){
				largestPrimeFactor = num;
			}
		}

		Console.WriteLine("Largest Prime Factor = " + largestPrimeFactor);

		Console.ReadKey();
	}
}