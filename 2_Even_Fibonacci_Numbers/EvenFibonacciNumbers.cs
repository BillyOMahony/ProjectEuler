using System;
using System.Collections.Generic;

public class EvenFibonacci{

	public static void Main(){
		int numTwo = 1;
		int numOne = 0;
		int current = 0;
		int sum = 0;

		while(current < 4000000){
			current = numOne + numTwo;
			if(current % 2 == 0){
				sum = sum + current;
			}
			numOne = numTwo;
			numTwo = current;
		}

		Console.WriteLine(sum);
		Console.ReadKey();
	}
	
}