using System;

public class Number_Letter_Count{

	public static string GetNumString(int inputNumber){

		string valueNum = "";

		switch (inputNumber){
		    case 1:
		        valueNum = "One";
		        break;
		    case 2:
		        valueNum = "Two";
		        break;
		    case 3:
		        valueNum = "Three";
		        break;
		    case 4:
		    	valueNum = "Four";
		    	break;
		    case 5:
		    	valueNum = "Five";
		    	break;
		    case 6:
		    	valueNum = "Six";
		    	break;
		    case 7:
		    	valueNum = "Seven";
		    	break;
		    case 8:
		    	valueNum = "Eight";
		    	break;
		    case 9:
		    	valueNum = "Nine";
		    	break;
		    case 10:
		    	valueNum = "Ten";
		    	break;
		    case 11:
		    	valueNum = "Eleven";
		    	break;
		    case 12:
		    	valueNum = "Twelve";
		    	break;
		    case 13:
		    	valueNum = "Thirteen";
		    	break;
		    case 14:
		    	valueNum = "Fourteen";
		    	break;
		    case 15:
		    	valueNum = "Fifteen";
		    	break;
		    case 16:
		    	valueNum = "Sixteen";
		    	break;
		    case 17:
		    	valueNum = "Seventeen";
		    	break;
		    case 18:
		    	valueNum = "Eighteen";
		    	break;
		    case 19:
		    	valueNum = "Nineteen";
		    	break;
		}

		return valueNum;

	}

	public static string GetNumTensString(int inputNumber){
		string valueNum = "";

		switch (inputNumber){
		    case 2:
		        valueNum = "Twenty";
		        break;
		    case 3:
		    	valueNum = "Thirty";
		    	break;
		    case 4:
		    	valueNum = "Forty";
		    	break;
		    case 5:
		    	valueNum = "Fifty";
		    	break;
		    case 6:
		    	valueNum = "Sixty";
		    	break;
		    case 7:
		    	valueNum = "Seventy";
		    	break;
		    case 8:
		    	valueNum = "Eighty";
		    	break;
		    case 9:
		    	valueNum = "Ninety";
		    	break;
		}

		return valueNum;

	}


	public static string NumToText(int inputNumber){
		string outputNumber = "";
		int num = inputNumber;
		int divisor;
		bool hundredFlag = false;
		bool tensFlag = false;

		while(num != 0){
			//Hundreds
			if(num < 1000 && num >= 100){
				divisor = num / 100;
				num = num % 100;

				outputNumber += GetNumString(divisor) + " Hundred";

				hundredFlag = true;
			}

			//Tens
			if(num < 100 && num >= 20){

				if(hundredFlag){
					outputNumber += " and ";
					hundredFlag = false;
				}

				divisor = num / 10;
				num = num % 10;

				
				tensFlag = true;
				
				outputNumber += GetNumTensString(divisor);
			}

			//1 - 20
			if(num > 0 && num < 20){
				if(hundredFlag){
					outputNumber += " and ";
				}
				if(tensFlag){
					outputNumber += " ";
				}
				outputNumber += GetNumString(num);
				num = 0;
			}
			


			if(num == 1000){
				outputNumber = "One Thousand";
			}

		}

		return outputNumber;
	}

	public static void Main(){

		int count = 0;

		for(int x = 1; x <= 999; x++){
			Console.WriteLine(NumToText(x));
			count += NumToText(x).Replace(" ", "").Length;
		}
		Console.WriteLine(count + 11); //+11 for "One Thousand"
		Console.ReadKey();

	}

}