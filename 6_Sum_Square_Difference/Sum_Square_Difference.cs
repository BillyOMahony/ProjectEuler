using System;

public class SoSDifference{

	public static int SumOfSquares(int end){
		int answer = 0;
		for(int i = 1; i <= end; i++){
			answer += Convert.ToInt32(Math.Pow(i, 2));
		}
		return answer;
	}

	public static int SquareOfSums(int end){
		int answer = 0;
		for(int i = 1; i <= end; i++){
			answer = answer + i;
		}

		return Convert.ToInt32(Math.Pow(answer, 2));
	}

	public static void Main(){
		Console.WriteLine(SquareOfSums(100) - SumOfSquares(100));
		Console.ReadLine();
	}

}