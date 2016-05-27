using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

/*Tournament tracks the win/loss record of teams in a tournament*/
public class Tournament {

	/*Tally calculates, sorts and displays the record of each team*/ 
	public static void Tally(MemoryStream inStream, MemoryStream outStream) {
		var encoding = new UTF8Encoding ();
		var teams = new Dictionary<string, Record> ();

		using (var reader = new StreamReader (inStream, encoding)) {
			string game;
			while ((game = reader.ReadLine ()) != null) {
				if (game.Trim() == "" || game.StartsWith ("#"))
					continue;
				updateScores (teams, game.ToString());
			}
		}

		var sortedTeams = from team in teams
			orderby team.Value.points descending, team.Key 
			select team;

		string header = "Team                           | MP |  W |  D |  L |  P";
		var writer = new StreamWriter (outStream);
		writer.Write (header);

		foreach (KeyValuePair<string, Record> team in sortedTeams) {
			writer.Write ("\n" + team.Value.ToString ());
		}
		writer.Flush ();
	}

	/*updateScores updates the season with an individual game*/
	private static void updateScores(Dictionary<string, Record> season, string game) {
		string[] fields = game.Split (';');

		if (fields.Length != 3)
			return;
	
		Record homeTeam = season.ContainsKey(fields[0]) ?
			season[fields[0]] :
			new Record(fields[0]);
		Record awayTeam = season.ContainsKey (fields [1]) ?
			season [fields [1]] :
			new Record (fields [1]);

		switch(fields[2]) {
		case "win":
			homeTeam.wins++;
			awayTeam.losses++;
			break;
		case "loss":
			homeTeam.losses++;
			awayTeam.wins++;
			break;
		case "draw":
			homeTeam.draws++;
			awayTeam.draws++;
			break;
		default:
			return;
		}

		season [homeTeam.teamName] = homeTeam;
		season [awayTeam.teamName] = awayTeam;
	}		

	/*Record is the win/loss/draw record of a team*/
	private class Record {
		public readonly string teamName;
		private string format = "{0,-30} | {1,2} | {2,2} | {3,2} | {4,2} | {5,2}";
		public decimal wins = 0;
		public decimal draws = 0;
		public decimal losses = 0;

		public Record(string teamName) {
			this.teamName = teamName;
		}

		public decimal matches {
			get { return wins + losses + draws; }
		}

		public decimal points {
			get { return wins * 3 + draws; }
		}

		/*ToString prints the teams record*/
		public override string ToString() {
			return string.Format (format, teamName, matches, wins, draws, losses, points);
		}
	}
}