using System;
using System.Text.RegularExpressions;

/*Cipher encodes a message using a shift cipher*/
class Cipher {
	private static Random generator = new Random ();
	public string Key;

	/*Cipher creates a random key if none is provided*/
	public Cipher() : this(createRandomKey()) { }
		
	/*Cipher only allows lowercase alphabetic keys*/
	public Cipher(string key) {
		if (key == "" || Regex.IsMatch (key, "[^a-z]"))
			throw new ArgumentException ();
		Key = key;
	}

	/*Encode encodes plaintext*/
	public string Encode(string plaintext) {
		string cipherText = "";
		for (int i = 0; i < plaintext.Length; i++)
			cipherText += shift (plaintext [i], Key [i % Key.Length] - 'a');
		return cipherText;
	}

	/*Decode decodes ciphertext*/ 
	public string Decode(string ciphertext) {
		string plainText = "";
		for (int i = 0; i < ciphertext.Length; i++)
			plainText += shift (ciphertext [i], 'a' - Key [i % Key.Length]);
		return plainText;
	}

	/*shift shifts a letter by some distance with wrap around*/
	private static char shift(char letter, int distance) {
		int shifted = letter - 'a' + distance;
		shifted += shifted < 0 ? 26 : 0;
		shifted %= 26;
		return (char)(shifted + 'a');
	}

	/*createRandomKey generates a random key*/
	private static string createRandomKey() {
		string key = "";
		for (int i = 0; i < 100; i++)
			key += (char)('a' + generator.Next (0, 26));
		return key;
	}
}