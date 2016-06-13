using System;
using System.Collections.Generic;
using System.Linq;

/*OcrNumbers recognizes representations of digits*/
public class OcrNumbers
{
	/*digits maps from an OCR digit to an ascii digit*/
	private static Dictionary<string, string> digits = 
		new Dictionary<string, string>() {
		{  " _ " + "\n" +
	       "| |" + "\n" +
	       "|_|" + "\n" +
		   "   ", "0" },
		{  "   " + "\n" +
	       "  |" + "\n" +
	       "  |" + "\n" +
		   "   ", "1" },
		{  " _ " + "\n" +
           " _|" + "\n" +
           "|_ " + "\n" +
		   "   ", "2" },
		{  " _ " + "\n" +
           " _|" + "\n" +
           " _|" + "\n" +
		   "   ", "3" },
		{  "   " + "\n" +
           "|_|" + "\n" +
           "  |" + "\n" +
		   "   ", "4" },
		{  " _ " + "\n" +
           "|_ " + "\n" +
           " _|" + "\n" +
		   "   ", "5" },
		{  " _ " + "\n" +
           "|_ " + "\n" +
           "|_|" + "\n" +
		   "   ", "6" },
		{  " _ " + "\n" +
           "  |" + "\n" +
           "  |" + "\n" +
		   "   ", "7" },
		{  " _ " + "\n" +
           "|_|" + "\n" +
           "|_|" + "\n" +
		   "   ", "8" },
		{  " _ " + "\n" +
           "|_|" + "\n" +
           " _|" + "\n" +
		   "   ", "9" },
	};

	/*Convert reads a sequnce of OCR digits and converts them to ascii*/
	public static string Convert(string lines)
	{
		string[] rows = lines.Split('\n');
		string characters = "";
		for (int l = 0; l < rows.Length; l += 4)
		{
			for (int c = 0; c < rows[l].Length; c += 3)
			{
				string[] charLines = rows.Skip(l).Take(4).ToArray();
				string[] charRows = charLines.Select(row => row.Substring(c,3)).ToArray();
				characters += ConvertDigit(String.Join("\n", charRows));
			}
		}
		return characters;
	}

	/*ConvertDigit converts a single OCR digit to an ascii digit*/
	public static string ConvertDigit(string digit)
	{
		return digits.ContainsKey(digit) ? digits[digit] : "?";
	}
}