using System;
using System.Collections.Generic;

/*Accumulator changes every item in a collection*/
public static class Accumulateor {

	/*Accumulate applies a function to every item in a collection*/
	public static IEnumerable<T> Accumulate<T>(this ICollection<T> items, Func<T, T> function) {
		foreach( var item in items ) {
			yield return function(item);
		}
	}
}