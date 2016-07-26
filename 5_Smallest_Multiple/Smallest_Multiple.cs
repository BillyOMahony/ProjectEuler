using System;

public class SmallestMultiple{

	//Greatest Common Divisor. 
	public static long Gcd(long a, long b){
		
		long num1, num2, rem;

		rem = 0;

		if(a>b){
			num1 = a;
			num2 = b;
		}else{
			num1 = b;
			num2 = a;
		}

		Console.WriteLine("Num1 {0}, Num2 {1}", num1, num2);

		if(num1 % num2 == 0){
			rem = num2;
		}

		while(num1 % num2 != 0){
			rem = num1 % num2;
			num1 = num2;
			num2 = rem;
		}	

		return rem;

	}

	public static long Lcm(long a, long b){
		return (a*b)/Gcd(a,b);
	}

	public static void Main(){

		long answer = 1;

		//answer = Lcm(10, Lcm(9, Lcm(8, Lcm(7, Lcm(6, Lcm(5, Lcm(4, Lcm(3, Lcm(2, 1)))))))));

		for(long x = 2; x <= 20; x++){
			answer = Lcm(x, answer);
		}

		Console.WriteLine(answer);
		
		Console.ReadKey();

	}

}