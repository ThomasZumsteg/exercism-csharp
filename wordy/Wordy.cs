using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using function = System.Func<decimal, decimal>;

public class WordProblem {
	static Dictionary<string, Func<decimal,function>> operators = new Dictionary<string, Func<decimal,function>> {
		{"plus", b => (a => a + b)},
		{"minus", b => (a => a - b)},
		{"multiplied by", b => (a => a * b)}, 
		{"divided by", b => (a => a / b)},
	};

	public static decimal Solve(string problem) {
		List<function> tokens = makeTokens (problem);
		decimal result = 0; 
		foreach (var token in tokens) {
			result = token.Invoke (result);
		}
		return result;
	}

	private static List<function> makeTokens(string phrase) {
		if (!(phrase.StartsWith ("What is ") && phrase.EndsWith ("?")))
			throw new ArgumentException ();
		phrase = "plus " + phrase.Substring (8, phrase.Length - 9);
		string regexFormat = string.Format(@"({0}) (-?\d+)", String.Join("|", operators.Keys));
		MatchCollection tokens = Regex.Matches(phrase, regexFormat);
		return new List<function> {
			operators["plus"].Invoke(1),
			operators["plus"].Invoke(1),
		};
	}
}