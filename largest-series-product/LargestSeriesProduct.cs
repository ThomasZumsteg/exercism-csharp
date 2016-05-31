using System;
using System.Collections.Generic;

/*LargestSeriesProduct is a series of digits*/
public class LargestSeriesProduct {
	private List<int> digits = new List<int>();

	/*LargestSeriesProduct creates a new series of digits*/
	public LargestSeriesProduct(string digits) {
		foreach(char c in digits.ToCharArray())
			this.digits.Add((int)(c - '0'));
	}

	/*GetLargestProduct calculates the largest product of some length of digits*/
	public int GetLargestProduct(int length) {
		if(digits.Count < length)
			throw new ArgumentException();

		int largestProduct = 0;

		for (int i = 0; i <= digits.Count - length; i++) {
			int product = 1; 
			for (int j = i; j < i + length; j++)
				product *= digits [j];
			largestProduct = largestProduct > product ? largestProduct : product;
		}
		return largestProduct;
	}
}