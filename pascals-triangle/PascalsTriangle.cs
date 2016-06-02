using System.Collections.Generic;

/*PascalsTriangle is a mathmatical triangle where each element in a row is created by
 * adding the two numbers above it*/ 
public class PascalsTriangle {

	/*Calculate generates the triangle*/
	public static List<List<int>> Calculate(int numRows) {
		List<List<int>> triangle = new List<List<int>> (){
			new List<int>() {1}, // Special case
		};

		for (int r = 1; r < numRows; r++) {
			List<int> row = new List<int> ();
			row.Add( 1 );
			for (int c = 1; c < r; c++)
				row.Add (triangle [r - 1] [c - 1] + triangle [r - 1] [c]);
			row.Add (1);
			triangle.Add (row);
		}

		return triangle;
	}
}