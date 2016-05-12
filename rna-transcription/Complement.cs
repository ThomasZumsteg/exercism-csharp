using System.Collections.Generic;

/*Complement computes a matching dna and rna sequence*/
public class Complement {
	private static Dictionary<char, char> dnaToRna = new Dictionary<char, char>() {
		{'C', 'G'},
		{'G', 'C'},
		{'T', 'A'},
		{'A', 'U'},
	};

	/*OfDna computes a matching rna strand from a dna strand*/
	public static string OfDna(string dna) {
		string rna = "";
		foreach (char nucleotide in dna) {
			rna += dnaToRna [nucleotide];
		}
		return rna;
	}
}