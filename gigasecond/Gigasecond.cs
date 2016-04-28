using System;

/*Gigasecond finds dates 10^9 seconds in the future*/
class Gigasecond {
	/*GIGASECOND is 10^9 seconds*/
	private static TimeSpan GIGASECOND 
		= new TimeSpan(0, 0, 1000000000);

	/*Date calculates a day one gigasecond from today*/
	public static DateTime Date(DateTime today) {
		return today.Add (GIGASECOND);
	}
}