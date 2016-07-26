using System;
using System.Collections.Generic;
	
public class Multiples{
	
	public static void Main(){
		List<int> multiples = new List<int>();
		for(int x = 0; x < 1000; x ++){
			if(x % 3 == 0 && !multiples.Contains(x)){
				multiples.Add(x);
			}
			if(x % 5 == 0 && !multiples.Contains(x)){
				multiples.Add(x);
			}
		}
		int answer = 0;
		foreach(int num in multiples){
			answer = answer + num;
		}
		Console.WriteLine(answer);
		Console.ReadKey();
	}
	
}	