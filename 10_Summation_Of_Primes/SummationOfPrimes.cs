/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/

using System;

public class Prime{

	public static void Main(){

		long answer = 0;

		for(int x = 2; x <= 2000000; x++){

			bool prime = true;

			for(int y = 2; y <= x/2; y++){

				if(x % y == 0){
					prime = false;
					break;
				}
			}

			if(prime){
				Console.WriteLine(x);
				answer = answer + x;
			}
		}

		Console.WriteLine("Answer: {0}" ,answer);
		Console.ReadKey();
	}

}