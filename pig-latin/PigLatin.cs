using System.Text.RegularExpressions;

/*PigLatin speak in a different language*/
public class PigLatin {
	
	/*Translate converts a phrase to pig latin*/
	public static string Translate(string phrase) {
		string pigLatin = "";
		foreach (string word in phrase.Split()) {
			pigLatin += TranslateWord (word) + " ";
		}
		return pigLatin.Trim ();
	}

	/*TranslateWord converts a word to piglatin*/
	private static string TranslateWord(string word) {
		Match quWord = new Regex (@"([^aeiou]*?qu)(.*)").Match (word);
		if(quWord.Success)
			return quWord.Groups[2].Value + quWord.Groups[1].Value + "ay";

		Match yWord = new Regex (@"^y[^aeiou]").Match (word);
		if (yWord.Success)
			return word + "ay";

		Match regularWord = new Regex (@"(.*?)([aeiou].*)").Match(word);
		if (regularWord.Success) {
			if (regularWord.Groups [1].Value + "ay" == word)
				return word + "ay";
			else
				return regularWord.Groups [2].Value + regularWord.Groups [1].Value + "ay";
		}
		return word;
	}
}