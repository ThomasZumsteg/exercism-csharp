using System;

/*Squares preforms square mathmatics on a number*/
public class Squares {
	private decimal limit;

	/*Squares creates a new number to do operations on*/
	public Squares(decimal limit) {
		if (limit < 0)
			throw new ArgumentException ();
		this.limit = limit;
	}

	/*SquareOfSums calculates the sum of all integer numbers up to 
	 * the limit and squares it*/ 
	public decimal SquareOfSums() {
		return DecPow(limit * (limit + 1) / 2, 2);
	}

	/*SumOfSquares calculates the square all integer numbers up to
	 * the limit then sums them*/
	public decimal SumOfSquares() {
		return (2 * DecPow (limit, 3) + 3 * DecPow (limit, 2) + limit) / 6;
	}

	/*DifferenceOfSquares calcualtes the difference between the
	 * square of sums and sum of squares*/
	public decimal DifferenceOfSquares() {
		return SquareOfSums () - SumOfSquares ();
	}

	private decimal DecPow(decimal number, decimal power) {
		return (decimal)Math.Pow ((double)number, (double)power);
	}
}