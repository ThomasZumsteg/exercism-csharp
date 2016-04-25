using System.Linq;

/*SumOfMultiples calcualtes the sum of the multiples of a given set of numbers*/
class SumOfMultiples {
	/* To calcualtes the sum of multiples in a range from zero to a limit
	 * that are a multiples of any one of a number of factors */
	public static int To(int[] factors, int limit) {
		return Enumerable
			.Range(0, limit)
			.Aggregate(0, (sum, n) =>
				factors.Any( (m) => n % m == 0 ) ? sum + n : sum
			);
	}
}