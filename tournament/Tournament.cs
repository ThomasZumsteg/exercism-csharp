using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Tournament {
	
	public static void Tally(MemoryStream inStream, MemoryStream outStream) {
		var encoding = new UTF8Encoding ();
		var season = new Dictionary<string, Record> ();

		using (var reader = new StreamReader (inStream, encoding)) {
			string game;
			while ((game = reader.ReadLine ()) != null) {
				updateScores (season, game.ToString());
			}
		}

		string[] teams = season.Keys.ToArray ();
		Array.Sort (teams);
		foreach (string team in teams) {
			Console.Write (team);
		}
	}

	private static void updateScores(Dictionary<string, Record> season, string game) {
		string[] fields = game.Split (';');
		string homeTeam = fields [0];
		string awayTeam = fields [1];
		if (!season.ContainsKey (homeTeam))
			season [homeTeam] = new Record ();
		if (!season.ContainsKey (awayTeam))
			season [awayTeam] = new Record ();
		switch(fields[2]) {
		case "win":
			season [homeTeam].wins++;
			season [awayTeam].losses++;
			break;
		case "loss":
			season [awayTeam].wins++;
			season [homeTeam].losses++;
			break;
		case "draw":
			season [homeTeam].draws++;
			season [awayTeam].draws++;
			break;
		}
	}		

	private class Record {
		public decimal wins = 0;
		public decimal draws = 0;
		public decimal losses = 0;

		public decimal matches {
			get { return wins + losses + draws; }
		}

		public decimal points {
			get { return wins * 3 + draws; }
		}
	}
}