using System;

public class CollatzSequece{

	public static void Main(){

		int currentNum;
		int maxNum = 0;
		int chain;
		int maxChain = 0;

		for (currentNum = 2; currentNum <= 1000000; currentNum++){
			chain = 0;
			long num = currentNum;
			
			Console.WriteLine(num);


			while(num > 0){

				chain ++;

			//	Console.WriteLine("Num: {0}, {1}", num, chain);

				if(num == 1){
					break;
				}

				if(num % 2 == 0){//is even
					num = num/2;
				}else{//is odd
					num = (num * 3) + 1;
				}

			}

			chain ++; //arrived at 1

			if(chain > maxChain){
				maxNum = currentNum;
				maxChain = chain;
			}
		}

		Console.WriteLine("Highest Number: {0}", maxNum);
		Console.ReadKey();

	}

}