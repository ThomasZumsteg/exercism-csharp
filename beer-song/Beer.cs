using System;

/*Beer sings the beer song*/
public class Beer {
	/*Verse sings a single verse from the beer song*/
	public static string Verse(int verse) {
		switch( verse ) {
		case 0:
			return "No more bottles of beer on the wall, " +
				"no more bottles of beer.\n" +
				"Go to the store and buy some more, " +
				"99 bottles of beer on the wall.\n";
		case 1:
			return "1 bottle of beer on the wall, " +
				"1 bottle of beer.\n" +
				"Take it down and pass it around, " +
				"no more bottles of beer on the wall.\n";
		case 2:
			return "2 bottles of beer on the wall, " +
				"2 bottles of beer.\n" +
				"Take one down and pass it around, " +
				"1 bottle of beer on the wall.\n";
		default:
			return String.Format ("{0} bottles of beer on the wall, " +
				"{0} bottles of beer.\n" +
				"Take one down and pass it around, " +
				"{1} bottles of beer on the wall.\n", verse, verse - 1);
		}
	}

	/*Sing sings a range of verses from the beer song*/
	public static string Sing(int start, int stop) {
		string song = "";
		for(int verse = start; stop <= verse; verse--) {
			song += Verse (verse) + "\n";
		}
		return song;
	}
}
			