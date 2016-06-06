using System;
using System.Collections.Generic;

/*Palindrome does operations on numbers that are the same forward and backward*/
public class Palindrome {

	// Value is the number that is a palindrome
	public int Value;

	// Factors are pairs of numbers that multiplied together equal the value 
	public List<Tuple<int,int>> Factors = new List<Tuple<int, int>> ();

	/*Palindrome creates a new palindrome*/
	private Palindrome(int value) {
		this.Value = value;
	}

	/*Largest finds the largest palindrome using factors in some range*/
	public static Palindrome Largest(int minFactor, int maxFactor) {
		return FindPalindrome (minFactor, maxFactor, (a, b) => a < b);
	}

	/*Largest finds the largest palindrome using factors up to some maximum number*/
	public static Palindrome Largest(int maxFactor) {
		return Largest(1, maxFactor);
	}

	/*Smallest finds the smallest factor using factors up to some maximum number*/
	public static Palindrome Smallest(int maxfactor) {
		return Smallest (1, maxfactor);
	}

	/*Smallest finds the smallest factor using factors in some range*/
	public static Palindrome Smallest(int minFactor, int maxFactor) {
		return FindPalindrome (minFactor, maxFactor, (a, b) => a > b);
	}

	/*FindPalindrome finds some paildrome in a range that compares best*/ 
	private static Palindrome FindPalindrome(int minFactor, int maxFactor, Func<int, int, bool> compare) {
		Palindrome bestPailindrome = null;
		for(int smallFactor = minFactor; smallFactor <= maxFactor; smallFactor ++) {
			for (int largeFactor = smallFactor; largeFactor <= maxFactor; largeFactor++) {
				int product = smallFactor * largeFactor;
				if (isPalindrome (product.ToString())) {
					if (bestPailindrome == null || compare (bestPailindrome.Value, product)) {
						bestPailindrome = new Palindrome (product);
						bestPailindrome.Factors.Add (Tuple.Create (smallFactor, largeFactor));
					} else if (bestPailindrome.Value == product)
						bestPailindrome.Factors.Add (Tuple.Create (smallFactor, largeFactor));
			
				}
			}
		}
		return bestPailindrome;
	}

	/*isPalindrome determines if a string is the same forward  and backward*/
	private static bool isPalindrome(string word) {
		for (int i = 0; i < word.Length; i++) {
			if (word [i] != word [word.Length - i - 1])
				return false;
		}
		return true;
	}
}