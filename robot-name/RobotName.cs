using System;
using System.Collections.Generic;

public class Robot {
	public string Name;
	private static Random rng = new Random ();
	private static HashSet<string> Names = new HashSet<string>();

	/*Robot creates a new robot*/
	public Robot() {
		Reset ();
	}

	/*Reset sets the name of the robot*/
	public void Reset() {
		while (Name == null || Names.Contains (Name)) {
			Name = "";
			Name += (char)('A' + rng.Next (26));
			Name += (char)('A' + rng.Next (26));
			Name += rng.Next (1000).ToString();
		}
		Names.Add (Name);
	}
}