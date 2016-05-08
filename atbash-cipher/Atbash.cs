using System;

/*Atbash encodes a string using an replacement cipher*/
class Atbash {

	/*Encode converts plain text into cipher text*/ 
	public static string Encode(string plainText) {
		string cipherText = "";

		foreach (char character in plainText) {
			// Add space every 5 characters
			if ((cipherText.Length + 1) % 6 == 0)
				cipherText += " ";

			// Keep only letter and numbers, and convert to lower case
			if ('a' <= character && character <= 'z')
				cipherText += (char)('z' + 'a' - character);
			else if ('A' <= character && character <= 'Z')
				cipherText += (char)('Z' + 'a' - character);
			else if ('0' <= character && character <= '9')
				cipherText += character;
		}
		return cipherText.Trim();
	}
}