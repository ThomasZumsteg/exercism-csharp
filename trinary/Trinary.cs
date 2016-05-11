
/*Trinary converts a trinary number to decimal*/
public class Trinary {
	/*digits are the valid trinary digits*/
	private static string digits = "012";

	/*ToDecimal converts a trinary number to decimal,
	or zero if any characters are invalid*/
	public static int ToDecimal(string trinary) {
		int decimal_val = 0;
		foreach( char digit in trinary ) {
			int value = digits.IndexOf(digit);
			if (value == -1)
				return 0;
			decimal_val = decimal_val * digits.Length + value;
		}
		return decimal_val;
	}
}