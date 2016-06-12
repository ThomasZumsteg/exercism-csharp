using System;

/*Queens tracks the position of two queens on a chess board*/
public class Queens
{
	private Queen white;
	private Queen black;

	/*Queens places and tracks two queens on a chess board*/
	public Queens(Queen white, Queen black)
	{
		if (white.x == black.x && white.y == black.y)
			throw new ArgumentException();
		this.white = white;
		this.black = black;
	}

	/*CanAttack checks if the queens can attack eachother*/
	public bool CanAttack()
	{
		bool horizontal = white.x == black.x;
		bool vertical = white.y == black.y;
		bool diagonal = Math.Abs(white.x - black.x) == Math.Abs(white.y - black.y);
		return horizontal || vertical || diagonal;
	}
}

/*Queen stores the position of a queen on a chess board*/
public class Queen
{
	public int x { get; private set; }
	public int y { get; private set; }

	/*Queen places a queen on the chess board*/
	public Queen(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
}