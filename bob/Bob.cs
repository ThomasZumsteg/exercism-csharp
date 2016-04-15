using System.Text.RegularExpressions;

public class Bob {
	public static string Hey(string greeting) {
		greeting = greeting.Trim ();
		if (greeting == "") {
			return "Fine. Be that way!";
		} else if (Regex.IsMatch(greeting, "[A-Z]") &&
			!Regex.IsMatch(greeting, "[a-z]")) {
			return "Whoa, chill out!";
		} else if (greeting.Substring (greeting.Length - 1) == "?") {
			return "Sure.";
		}
		return "Whatever.";
	}
}
