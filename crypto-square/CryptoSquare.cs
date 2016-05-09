using System;
using System.Collections.Generic;

/*Crypto encrypts a message using the crypto square method*/
public class Crypto {
	private string text;

	/*Crypto creates a crypto square*/
	public Crypto(string clearText) {
		text = clearText;
	}

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

	public int Size {
		get {
			var sqrt = Math.Sqrt (NormalizePlaintext.Length);
			return (int)Math.Ceiling(sqrt);
		}
	}

	public string[] PlaintextSegments() {
		List<string> segments = new List<string> ();
		for(var i = 0; i < NormalizePlaintext.Length; i += Size) {
			var sliceSize = i + Size <= NormalizePlaintext.Length ? Size : NormalizePlaintext.Length - i; 
			segments.Add(NormalizePlaintext.Substring(i, sliceSize));
		}
		return segments.ToArray();
	}

	public string Ciphertext() {
		string[] segments = PlaintextSegments ();
		string ciphertext = "";
		for (var i = 0; i < segments [0].Length; i++) {
			for (var j = 0; j < segments.Length; j++) {
				if (i < segments [j].Length)
					ciphertext += segments [j] [i];
			}
		}
		return ciphertext;
	}

	public string NormalizeCiphertext() {
		int stepSize = Size - 1;
		string ciphertext = Ciphertext ();
		string normalizedCiphertext = "";
		int i = ciphertext.Length;
		while(stepSize < i) {
			normalizedCiphertext = ciphertext.Substring (i - stepSize, stepSize) 
				+ " "
				+ normalizedCiphertext;
			i -= stepSize;
		}
		return normalizedCiphertext.Trim ();
	}
}