using System;
using System.Collections.Generic;

/*SaddlePoints finds dips and peaks in a 2D matrix*/
public class SaddlePoints {
	private int[,] matrix;
	private Dictionary<int, int> MaxRowCache = new Dictionary<int, int> ();
	private Dictionary<int, int> MinColCache = new Dictionary<int, int> ();

	/*SaddlePoints creates a new 2D matrix*/
	public SaddlePoints(int[,] matrix) {
		this.matrix = matrix;
	}

	/*Calculate finds all points that are the minimum in their column and maximum in their row*/
	public List<Tuple<int, int>> Calculate() {
		/*value, row/col, cols*/
		var saddlePoints = new List<Tuple<int, int>>();

		for (int row = 0; row < matrix.GetLength (0); row++) {
			for (int col = 0; col < matrix.GetLength (1); col++) {
				if(MaxInRow(row) == matrix[row, col] && MinInCol(col) == matrix[row,col])
					saddlePoints.Add(new Tuple<int,int>( row, col));
			}
		}
		return saddlePoints;
	}

	/*MaxInRow finds the largest element in a row*/
	private int MaxInRow(int row) {
		if (!MaxRowCache.ContainsKey (row)) {
			int maxElement = matrix [row, 0]; 
			for (int c = 1; c < matrix.GetLength (1); c++) {
				if (maxElement < matrix [row, c])
					maxElement = matrix [row, c];
			}
			MaxRowCache [row] = maxElement;
		}
		return MaxRowCache [row];
	}

	/*MinInCol finds eh smallest element in a column*/
	private int MinInCol(int col) {
		if (!MinColCache.ContainsKey (col)) {
			int minElement = matrix [0, col];
			for (int r = 1; r < matrix.GetLength (0); r++) {
				if (matrix [r, col] < minElement)
					minElement = matrix [r, col];
			}
			MinColCache [col] = minElement;
		}
		return MinColCache [col];
	}
}