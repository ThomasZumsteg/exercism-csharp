using System.Collections.Generic;

/*PrimeFactors computes the prime factors*/
class PrimeFactors {
	
	/*For calculates the prime factors for a composite number*/
	public static int[] For(long composite) {
		var factors = new List<int>();
		for (var factor = 2; factor <= composite;) {
			if (composite % factor == 0) {
				factors.Add (factor);
				composite /= factor;
			} else
				factor += factor == 2 ? 1 : 2;
		}
		return factors.ToArray ();
	}
}