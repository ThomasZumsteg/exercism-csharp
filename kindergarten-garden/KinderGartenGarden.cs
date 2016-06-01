using System;
using System.Collections.Generic;
using System.Linq;

/*Garden is a map of a kindergarden garden*/
public class Garden {
	private string[] students;
	private char[][] rows;

	/*Garden creates a new kindergarten Garden with a list of students*/
	public Garden(string[] students, string garden) {
		this.students = students;
		Array.Sort (this.students);
		this.rows = garden.Split('\n')
			.Select(row => row.ToCharArray())
			.ToArray();
	}

	/*DefaultGarden creates a garden with a default list of students*/
	public static Garden DefaultGarden(string garden) {
		string[] defaultStudents = new string[] {
			"Alice",
			"Bob",
			"Charlie",
			"David",
			"Eve",
			"Fred",
			"Ginny",
			"Harriet",
			"Ileana",
			"Joseph",
			"Kincaid",
			"Larry",
		};
		return new Garden(defaultStudents, garden);
	}

	/*GetPlants selects the plants that belong to a student*/
	public Plant[] GetPlants(string student) {
		int studentIndex = Array.FindIndex(students, s => s == student);
		List<Plant> plants = new List<Plant>{};
		foreach(char[] row in rows) {
			if (0 <= studentIndex * 2 && studentIndex * 2 + 1 <= row.Length) {
				plants.Add ((Plant)row [studentIndex * 2 + 0]);
				plants.Add ((Plant)row [studentIndex * 2 + 1]);
			}
		}
		return plants.ToArray ();
	}
}

/*Plant are the different types of plants in the garden*/
public enum Plant {
	Clover = 'C',
	Grass = 'G',
	Radishes = 'R',
	Violets = 'V',
}