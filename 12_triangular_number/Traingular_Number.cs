using System;
using System.Collections.Generic;

public class TriangularNumbers{

	public static int GetNumber(int i){
		int num = 0;
		for(int x = 1; x <= i; x ++){
			num += x;
		}
		Console.WriteLine(num);
		return num;
	}
	
	
	public static int Divisors(int num){
		
		//Starting counter at 2 because 1 and num will always be divisors of num
		int counter = 2; 
		for(int x = 2; x <= num/2; x++){
			if(num % x == 0){
				counter ++;
			}
		}

		return counter;
	}	

	public static void Main(){
		int counter = 0;
		int iteration = 1;
		int num = 0;

		while(counter <= 500){
			num = GetNumber(iteration);
			counter = Divisors(num);
			Console.WriteLine("Divisors: {0}" ,counter);
			iteration++;	
		}

		Console.ReadKey();
	}

}