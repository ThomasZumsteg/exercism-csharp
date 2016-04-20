using System;
using System.Collections.Generic;

public class School {
	public Dictionary<int, List<string>> Roster = new Dictionary<int, List<string>>{};

	public School() {
	}

	public void Add(string student, int grade) {
		if( !Roster.ContainsKey(grade) )
			Roster[grade] = new List<string>();
		Roster[grade].Add (student);
		Roster[grade].Sort();
	}

	public List<string> Grade(int grade) {
		if (!Roster.ContainsKey (grade))
			return new List<string>();
		return Roster [grade];
	}


}