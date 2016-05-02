using System;
using System.Linq;

/*Roman converts an arabic number to the roman numeral equivalent*/
public static class Roman {
	/*digits represent all valid values and roman numeral pairs*/
	private static Tuple<int, string>[] digits = {
		Tuple.Create (    1, "I"), Tuple.Create (   4, "IV"), 
		Tuple.Create (    5, "V"), Tuple.Create (   9, "IX"),
		Tuple.Create (   10, "X"), Tuple.Create (  40, "XL"),
		Tuple.Create (   50, "L"), Tuple.Create (  90, "XC"),
		Tuple.Create (  100, "C"), Tuple.Create ( 400, "CD"), 
		Tuple.Create (  500, "D"), Tuple.Create ( 900, "CM"),
		Tuple.Create ( 1000, "M"),
	};

	/*ToRoman converts an arabic number to a roman number*/ 
	public static string ToRoman(this int arabic) {
		string roman = "";
		foreach (var digit in digits.Reverse<Tuple<int, string>>()) {
			int div = arabic / digit.Item1;
			roman += string.Concat (Enumerable.Repeat (digit.Item2, div));
			arabic = arabic % digit.Item1;
		}
		return roman;
	}
}