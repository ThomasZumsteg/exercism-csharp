using System.Collections.Generic;

/*Sieve implements a Sieve of Eratosthenes to find prime numbers*/ 
public class Sieve {
	/*Primes finds all prime numbers up to some limit*/
	public static int[] Primes(int limit) {
		List<int> primes = new List<int> ();

		// Defaults to false
		bool[] isMultiple = new bool[limit+1];

		for (int num = 2; num <= limit; num += (num == 2 ? 1 : 2)) {
			if (!isMultiple [num]) {
				primes.Add (num);
				for (int multiple = num * num; multiple < limit; multiple += num)
					isMultiple [multiple] = true;
			}
		}
		return primes.ToArray();
	}
}