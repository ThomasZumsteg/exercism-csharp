using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using function = System.Func<decimal, decimal>;

/*WordProblems solves a mathmatical word problem*/
public class WordProblem {
	/*operators are the operations allowed in a word problem*/
	static Dictionary<string, Func<decimal,function>> operators = new Dictionary<string, Func<decimal,function>> {
		{"plus", b => (a => a + b)},
		{"minus", b => (a => a - b)},
		{"multiplied by", b => (a => a * b)}, 
		{"divided by", b => (a => a / b)},
	};

	/*Solve calculates the value of a word problem*/ 
	public static decimal Solve(string problem) {
		List<function> tokens = makeTokens (problem);
		decimal result = 0; 
		foreach (var token in tokens) {
			result = token.Invoke (result);
		}
		return result;
	}

	/*makeTokens parses to word problem into a series of partial function tokens*/
	private static List<function> makeTokens(string phrase) {
		List<function> tokens = new List<function> ();

		string operation = string.Format (@"({0}) (-?\d+)", string.Join ("|", operators.Keys));
		string pattern = string.Format (@"^What is (-?\d+(?: {0})+)\?", operation);
		Match match = Regex.Match( phrase, pattern );

		if (!match.Success)
			throw new ArgumentException ();

		foreach (Match token in Regex.Matches ("plus " + match.Groups [1].Value, operation)) {
			decimal num = Convert.ToDecimal (token.Groups [2].Value);
			Func<decimal, function> f = operators [token.Groups [1].Value];
			tokens.Add (f.Invoke (num));
		}
		return tokens;
	}
}