using System;
using System.Collections.Generic;
using System.Linq;

/*Series creates sequences of items*/
public class Series {
	private string items;

	/*Series creates a sequence from a string*/ 
	public Series(string items) {
		this.items = items;
	}
		
	/*Slices creates a set of slices of some size from the items*/ 
	public int[][] Slices(int size) {
		if (size > items.Length)
			throw new ArgumentException ();
		
		List<int[]> slices = new List<int[]>{};
		for( int i = 0; i + size <= items.Length; i++ ) {
			int[] slice = items.Substring (i, size)
				.Select (d => (int)(d - '0'))
				.ToArray ();
			slices.Add( slice );
		}
		return slices.ToArray();
	}
}