using System;

/*Raindrops converts a number to raindrop sounds*/
class Raindrops {
	private static Tuple<int, string>[] prime_sounds = new Tuple<int, string>[] {
		Tuple.Create(3, "Pling"),
		Tuple.Create(5, "Plang"),
		Tuple.Create(7, "Plong"),
	};

	/*Convert makes raindrop sounds based on the prime factors of a number*/
	public static string Convert(int number) {
		string sounds = "";
		foreach (var factor in prime_sounds) {
			if (number % factor.Item1 == 0)
				sounds += factor.Item2;
		}
		return sounds != "" ? sounds : number.ToString ();
	}
}