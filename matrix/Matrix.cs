using System;
using System.Collections.Generic;

/*Matrix creates and accesses a 2D matrix*/
public class Matrix
{
	private List<int> matrix = new List<int>();
	public int Rows { get; private set; } = 0;
	public int Cols { get; private set; }

	/*Matrix creates a new matrix from a string*/
	public Matrix(string rows)
	{
		foreach (string row in rows.Split('\n'))
		{
			Rows++;
			foreach (string num in row.Split(' '))
			{
				matrix.Add(Int32.Parse(num));
			}
		}
		Cols = matrix.Count / Rows;
	}

	/*Row gets a specific row from the matrix*/
	public int[] Row(int row)
	{
		List<int> items = new List<int>();
		for (int r = row * Cols; r < (row + 1) * Cols; r++)
			items.Add(matrix[r]);
		return items.ToArray();
	}

	/*Col gets a specific column from the matrix*/
	public int[] Col(int column)
	{
		List<int> items = new List<int>();
		for (int col = column; col < matrix.Count; col += Cols)
			items.Add(matrix[col]);
		return items.ToArray();
	}
}