using System;
using System.Collections.Generic;

/*Strain filters items from a collection based on a test*/
public static class Strain {
	/*Keep includes items from the collection that pass the test*/
	public static List<T> Keep<T>(this ICollection<T> collection, Func<T, bool> test) {
		var kept = new List<T>();

		foreach (var item in collection) {
			if (test (item))
				kept.Add (item);
		}
		return kept;
	}

	/*Discard removes items from the colletion that pass the test*/
	public static List<T> Discard<T>(this ICollection<T> collection, Func<T, bool> test) {
		return collection.Keep(x => !test(x));
	}
}