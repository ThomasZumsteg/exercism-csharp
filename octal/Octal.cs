
/*Octal is an octal number*/
public class Octal {
	/*ToDecimal converts an octal number to a decimal number*/
	public static int ToDecimal(string octalNum) {
		string octalDigits = "01234567";
		int decimalNum = 0;
		foreach (char digit in octalNum) {
			int value = octalDigits.IndexOf (digit);
			if (value < 0)
				return 0;
			decimalNum = decimalNum << 3 | value;
		}
		return decimalNum;
	}
}