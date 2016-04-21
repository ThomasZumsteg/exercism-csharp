using System.Collections.Generic;
using System;

/*DNA represents a stand of DNA nucleotides*/
public class DNA {
	private string nucleotides;
	private Dictionary<char, int> counts;

	public DNA(string nucleotides) {
		this.nucleotides = nucleotides;
	}

	/*NucleotideCounts counts how many of each nucleotide are in the strand*/
	public Dictionary<char, int> NucleotideCounts {
		get {
			if (counts == null) {
				counts = new Dictionary<char, int> {
					{ 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 }
				};
				foreach (char n in this.nucleotides) {
					counts [n]++;
				}
			}
			return counts;
		}
	}

	/*Count determines the number of a single nucleotide in the strand*/
	public int Count(char nucleotide) {
		if (!NucleotideCounts.ContainsKey (nucleotide))
			throw new InvalidNucleotideException ();
		return NucleotideCounts [nucleotide];
	}
}

/*InvalidNucleotideException indicates that a nuclidetide isn't valid*/
public class InvalidNucleotideException: Exception {
	public InvalidNucleotideException() {}
}