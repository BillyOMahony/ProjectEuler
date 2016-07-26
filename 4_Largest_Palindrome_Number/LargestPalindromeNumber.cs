using System;

public class PalindromeNumbers{

	public static bool IsPalindrome(string input){
		var charArray = input.ToCharArray();

		string reverse = "";
		for(int x = (charArray.Length - 1); x >=0; x--){
			reverse = reverse + charArray[x];
		}

		if(input == reverse){
			return true;
		}else{
			return false;
		}
	}

	public static void Main(){
		
		int result = 0;

		for(int x = 900; x < 1000; x++){

			for(int y = 900; y < 1000; y++){

				if(IsPalindrome(Convert.ToString(x*y))){
					result = x*y;
				}

			}
		}
		Console.WriteLine(result);
		Console.ReadKey();
	}
}