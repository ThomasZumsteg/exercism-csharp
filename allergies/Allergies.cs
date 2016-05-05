using System.Collections.Generic;
using System;

/*Allergies tracks what someone is allergic to based on a code*/
class Allergies {
	private int code;
	private List<string> allergies = new List<string> ();
	private static List<string> allergy_list = new List<string> {
		"eggs",
		"peanuts",
		"shellfish",
		"strawberries",
		"tomatoes",
		"chocolate",
		"pollen",
		"cats",
	};

	/*Allergies creates a new record*/
	public Allergies(int code) {
		this.code = code;
		foreach (var allergy in allergy_list) {
			if (AllergicTo (allergy))
				allergies.Add (allergy);
		}
	}

	/*AllergicTo checks if a person is allergic to an item*/
	public bool AllergicTo(string item) {
		var index = allergy_list.IndexOf (item);
		return (1 << index & code) != 0;
	}

	/*List is all the items a person is allergic to*/
	public List<string> List() {
		return allergies;
	}
}