using System.Collections.Generic;

using oldFormat = System.Collections.Generic.Dictionary<int, 
	System.Collections.Generic.IList<string>>;
using newFormat = System.Collections.Generic.Dictionary<string, int>;

public class ETL {
	public static newFormat Transform(oldFormat old) {
		newFormat new_dict = new newFormat();
		foreach( KeyValuePair<int, IList<string>> entry in old) {
			foreach( string val in entry.Value ) {
				new_dict[val.ToLower()] = entry.Key;
			}
		}

		return new_dict;
	}
}