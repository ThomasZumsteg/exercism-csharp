using System.Text.RegularExpressions;

/*PhoneNumber is a telephone number*/
public class PhoneNumber {
	public string Number;

	/*PhoneNumber parses a phone number*/
	public PhoneNumber(string number) {
		number = Regex.Replace (number, "[^0-9]", "");
		if (number.Length == 10) {
			this.Number = number;
		} else if (number.Length == 11 && number.Substring(0, 1) == "1") {
			this.Number = number.Substring(1,10);
		} else {
			this.Number = "0000000000";
		}
	}

	/*AreaCode gets the area code of the phone number*/
	public string AreaCode {
		get { return Number.Substring (0, 3); }
	}

	/*ToString converts the phone number to a string*/
	override public string ToString() {
		return string.Format ("({0}) {1}-{2}", 
			AreaCode, Number.Substring (3, 3), Number.Substring (6, 4));
	}
}