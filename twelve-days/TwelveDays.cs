using System.Linq;
/*TwelveDaysSong sings "The Twelve Days of Christmas" */
public class TwelveDaysSong {
	/*nth coverts an integer to string number*/
	private string[] nth = ("zeroth,first,second,third,fourth,fifth,sixth," +
		"seventh,eighth,ninth,tenth,eleventh,twelfth").Split(',');
	/*verses lists the verses for "The Twelve Days of Christmas"*/
	private string[] verses = {
		"and a Partridge in a Pear Tree.",
		"two Turtle Doves", 
		"three French Hens", 
		"four Calling Birds", 
		"five Gold Rings", 
		"six Geese-a-Laying", 
		"seven Swans-a-Swimming", 
		"eight Maids-a-Milking",
		"nine Ladies Dancing",
		"ten Lords-a-Leaping",
		"eleven Pipers Piping",
		"twelve Drummers Drumming",
	};
	/*opening is the first line in "The Twelve Days of Christmas"*/
	private string opening = "On the {0} day of Christmas my true love gave to me, ";

	/*Verse sings a single verse*/
	public string Verse (int v)
	{
		string verse = string.Format(opening, nth[v]);
		if (v == 1)
			return verse + "a Partridge in a Pear Tree.\n";
		return verse + string.Join (", ", verses.Take(v).Reverse()) + "\n";
	}

	/*Verses sings a range of verses*/
	public string Verses(int start, int stop) {
		return Enumerable.Range(start, stop)
			.Aggregate("", (song, num) =>
				song + Verse(num) + "\n"
			);
	}

	/*Sing sings the whole song*/
	public string Sing() {
		return Verses (1, 12);
	}
}