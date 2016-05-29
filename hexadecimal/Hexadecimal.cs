/*Hexadecimal is a base sixteen number*/
public class Hexadecimal {
	/*hexDigits are the valid digits in increasing value*/
	private static string hexDigits = "0123456789abcdef";

	/*ToDecimal converts a hex number to a decimal number*/
	public static int ToDecimal(string hex) {
		int decimalValue = 0;
		int d;
		foreach(char hexDigit in hex) {
			if((d = hexDigits.IndexOf(hexDigit)) != -1)
				decimalValue = (decimalValue << 4) | d;
			else
				return 0;
		}
		return decimalValue;
	}
}