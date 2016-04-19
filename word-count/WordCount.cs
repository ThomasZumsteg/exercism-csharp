using System.Collections.Generic;
using System.Text.RegularExpressions;

using WordDict = System.Collections.Generic.Dictionary<string, int>;

public class Phrase {

	/* WordCount counts the number of times words appear in a sentance */
	public static WordDict WordCount(string words) {
		var counter = new WordDict (); 
		words = Regex.Replace (words.ToLower (), "[^a-z]", string.Empty);
		foreach(var word in words.Split(new char[] {' '})) {
			if (!counter.ContainsKey (word))
				counter [word] = 0;
			counter [word]++;
		}
		return counter;
	}

}