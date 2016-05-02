
/*Binary converts a binary number to other formats*/
class Binary {

	/*ToDecimal converts a binary number to an integer*/
	public static int ToDecimal( string binary ) {
		int total = 0;
		foreach (var digit in binary) {
			switch (digit) {
			case '0':
				total = total << 1;
				break;
			case '1':
				total = total << 1 | 1;
				break;
			default:
				return 0;
			}
		}
		return total;
	}
}