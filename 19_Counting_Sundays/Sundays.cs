/*
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901(Monday) to 31 Dec 2000)?
*/
using System;

public class Sundays{

	public static void Main(){
		DateTime day = new DateTime(1901, 01, 01);
		DateTime endDay = new DateTime(2000, 12, 02);
		int counter = 0;
		while(day < endDay){
			if((day.DayOfWeek).ToString() == "Sunday"){
				counter ++;
			}
			day = day.AddMonths(1);
			Console.WriteLine(day.ToString());
		}

		Console.WriteLine(counter); //171
		Console.ReadKey();
	}

}