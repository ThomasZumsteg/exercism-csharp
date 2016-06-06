using System;
using System.Collections.Generic;

public class Palindrome {
	public int Value;
	public List<Tuple<int,int>> Factors = new List<Tuple<int, int>> ();

	private Palindrome(int value) {
		this.Value = value;
	}

	public static Palindrome Largest(int minFactor, int maxFactor) {
		var palindromes = FindPalindromes (minFactor, maxFactor);
	}

	public static Palindrome Largest(int maxFactor) {
		return Largest(1, maxFactor);
	}

	public static Palindrome Smallest(int maxfactor) {
		return Smallest (1, maxfactor);
	}

	public static Palindrome Smallest(int minFactor, int maxFactor) {
		return Largest (minFactor, maxFactor);
	}

	private static FindPalindromes(int minFactor, int maxFactor) {
		var palindromes = new Dictionary<int, List<Tuple<int, int>>>();
		for(int smallFactor = minFactor; smallFactor <= maxFactor; smallFactor ++) {
			for(int largeFactor = smallFactor; largeFactor <= maxFactor; largeFactor++) {
				int product = smallFactor * largeFactor;
				if(isPalindrome(product)) {
					if(!palindromes.ContainsKey(product)) {
						palindromes[product] = new
					}
				}
			}
		}
	}

	private static bool isPalindrome(string word) {
		for (int i = 0; i < word.Length; i++) {
			if (word [i] != word [word.Length - i])
				return false;
		}
		return true;
	}
}