using System;

/*Triangle represents a triangle*/
class Triangle {

	/*TriangleKind check if a triangle is valid and classifies it*/
	public static TriangleKind Kind( decimal a, decimal b, decimal c) {
		decimal[] sides = {a, b, c};
		Array.Sort(sides);

		if (sides [0] <= 0 || sides [0] + sides [1] <= sides [2])
			throw new TriangleException ();

		if( sides[0] == sides[1] && sides[1] == sides[2] )
			return TriangleKind.Equilateral;
		else if( sides[0] == sides[1] || sides[1] == sides[2] )
			return TriangleKind.Isosceles;
		else
			return TriangleKind.Scalene;
	}
}

/*TriangleKind are the types of triangles*/
enum TriangleKind {
	Equilateral, 
	Isosceles, 
	Scalene,
}

/*TriangleException is thrown when a triangle is not valid*/
public class TriangleException: Exception {
}