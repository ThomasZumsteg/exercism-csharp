using System.Linq;
using System.Text.RegularExpressions;

/*Acronym makes an abbreviation for a phrase*/
public class Acronym {
	/*Abbreviate creates an acronum from a phrase*/
	public static string Abbreviate(string phrase) {
		string acronym = "";
		foreach (string word in Regex.Split (phrase, @"\W+")) {
			if (Regex.IsMatch (word, @"[a-z]")) {
				string casedWord = word.First ().ToString ().ToUpper () + word.Substring (1);
				acronym += Regex.Replace (casedWord, @"[^A-Z]", "");
			} else if (word != "")
				acronym += word.First ();
		}
		return acronym;
	}
}