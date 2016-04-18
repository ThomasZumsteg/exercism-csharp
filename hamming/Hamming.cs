using System;
using System.Linq;

/* Hamming copmutes the hamming distance between two strings of dna */
public class Hamming {

	/* Compute counts the differences in two strings of dna */
	public static int Compute(string dna1, string dna2) {
		return dna1
			.Zip (dna2, Tuple.Create)
			.Aggregate (0, (total, pair) => 
				pair.Item1 == pair.Item2 ? total : total + 1
		);
	}
}