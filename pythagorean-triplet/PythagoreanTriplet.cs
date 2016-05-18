using System;
using System.Collections.Generic;
using System.Linq;

/*Triplet is a set of three numbers*/
public class Triplet {
	private int[] triplet;

	/*Triplet creates a new triplet from values*/
	public Triplet(int a, int b, int c) {
		triplet = new int[] {a, b, c};
		Array.Sort (triplet);
	}

	/*Product multiplies all three values together*/
	public int Product() {
		return triplet.Aggregate (1, (total, n) => total * n);
	}

	/*Sum adds all three values*/
	public int Sum() {
		return triplet.Sum ();
	}

	/*IsPythagorean determines if the three numbers are a pythagorean triplet*/
	public bool IsPythagorean() {
		double[] squared = triplet.Select(n => Math.Pow(n, 2)).ToArray();
		return squared [0] + squared [1] == squared [2];
	}

	/*Where finds all pythagorean triplets in a range*/
	public static List<Triplet> Where(int maxFactor, int minFactor = 1) {
		var triplets = new List<Triplet>{};
		for (int a = minFactor; a <= maxFactor; a++) {
			for (int b = a; b <= maxFactor; b++) {
				for (int c = b; c <= maxFactor; c++) {
					Triplet triplet = new Triplet (a, b, c);
					if (triplet.IsPythagorean ())
						triplets.Add (triplet);
				}
			}
		}
		return triplets;
	}

	/*Where finds all pythagorean triplets in a range with a specific sum*/
	public static List<Triplet> Where(int maxFactor, int sum, int minFactor = 1) {
		var triplets = new List<Triplet>{};
		foreach(Triplet t in Where (maxFactor, minFactor)) {
			if( t.Sum() == sum )
				triplets.Add(t);
		}
		return triplets;
	}
}

