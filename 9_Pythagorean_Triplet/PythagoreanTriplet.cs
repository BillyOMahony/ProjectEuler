using System;

public class PythagoreanTriplets{

	public static void Main(){
		int a, b, c;
		long a2, b2, c2;

		c = 0;
		a = 1;
		b = 1;


		for(a = 1; a < 333; a++){
			for(b = 1; b < 500; b++){
				a2 = a*a;
				b2 = b*b;
				c2 = a2 + b2;

				if(Math.Sqrt(c2) % 1 == 0){
					if( a + b + Math.Sqrt(c2) == 1000){
						c = Convert.ToInt32(Math.Sqrt(c2));
						Console.WriteLine("{0}, {1}, {2}", a, b, c);
					}
				}
			}

		}
		Console.ReadLine();
	}

}