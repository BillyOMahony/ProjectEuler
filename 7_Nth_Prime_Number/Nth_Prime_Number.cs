using System;

public class Prime{

	public static void Main(){

		int i = 2;

		for(int x = 1; x <= 10001; x++){
			
			bool foundPrime = false;
			
			while(!foundPrime){
				bool prime = true;
				for(int y = 2; y <= i/2; y++){

					if(i % y == 0){
						prime = false;
					}

				}
				if(prime){
					
					foundPrime = true;
				}
				i++;
			}
		}
		Console.WriteLine(i);
		Console.ReadKey();
	}

}