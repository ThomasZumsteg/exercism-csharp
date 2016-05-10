using System;
using System.Collections.Generic;

/*Crypto encrypts a message using the crypto square method*/
public class Crypto {
	private string text;

	/*Crypto creates a crypto square*/
	public Crypto(string clearText) {
		text = clearText;
	}

	/*NormalizePlaintext converts clear text to lower cases and 
	 * removes characters that are not alphanumeric*/
	public string NormalizePlaintext {
		get { 
			string normalizePlaintext = "";
			foreach( var letter in text ) {
				if ('a' <= letter && letter <= 'z' || 
					'0' <= letter && letter <= '9')
					normalizePlaintext += letter;
				else if ('A' <= letter && letter <= 'Z')
					normalizePlaintext += (char)(letter - 'A' + 'a');
			}
			return normalizePlaintext;
		}
	}

	/*Size calculates the smallest square that holds all the letters*/
	public int Size {
		get {
			var sqrt = Math.Sqrt (NormalizePlaintext.Length);
			return (int)Math.Ceiling(sqrt);
		}
	}

	/*PlaintextSegments breaks the text into rows for the cryptosquare*/  
	public string[] PlaintextSegments() {
		List<string> segments = new List<string> ();
		for(var i = 0; i < NormalizePlaintext.Length; i += Size) {
			var sliceSize = i + Size <= NormalizePlaintext.Length ? Size : NormalizePlaintext.Length - i; 
			segments.Add(NormalizePlaintext.Substring(i, sliceSize));
		}
		return segments.ToArray();
	}

	/*Ciphertext scrambles the cryptosquare by reading rows*/
	public string Ciphertext() {
		return NormalizeCiphertext().Replace(" ", "");
	}

	/*NormalizeCiphertext adds spaces based on the square size*/
	public string NormalizeCiphertext() {
		string[] segments = PlaintextSegments ();
		string ciphertext = "";
		for (var i = 0; i < segments [0].Length; i++) {
			for (var j = 0; j < segments.Length; j++) {
				if (i < segments [j].Length)
					ciphertext += segments [j] [i];
			}
			ciphertext += " ";
		}
		return ciphertext.Trim();
	}
}