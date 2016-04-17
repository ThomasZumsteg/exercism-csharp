using System;
using System.Collections.Generic;

public class Anagram {

	private char[] letters;
	private string word;

	/* Anagram finds words that have the same letters but are not the same word */
	public Anagram(string word) {
		this.word = word.ToLower ();
		letters = word.ToLower ().ToCharArray();
		Array.Sort (letters);
	}

	/* Match selects words from a list of words that have the same letters
	 * as the anagram but are not the same word */
	public string[] Match(string[] words) {
		var matches = new List<string>(); 
		foreach(string word in words) {
			var letters = word.ToLower ().ToCharArray();
			Array.Sort (letters);
			if (this.letters == letters && this.word != word.ToLower()) {
				matches.Add(word);
			}
		}
		return matches.ToArray();
	}
}

