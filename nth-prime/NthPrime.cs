using System.Collections.Generic;

/*NthPrime finds prime numbers in order*/
public class NthPrime {

	/*Nth calculates the nth prime number*/
	public static int Nth(int n) {
		List<int> primes = new List<int> () { 2, 3, 5, 7, 11, 13 };
		int num = 17;

		while(primes.Count < n) {
			foreach(int prime in primes){
				if( num % prime == 0)
					break;
				else if(prime * prime > num) {
					primes.Add(num);
					break;
				}
			}
			num += 2;
		}
		return primes[n - 1];
	}
}
					