
/*Bearing are compass points*/
public enum Bearing {
	North,
	East,
	South,
	West,
}

/*Coordinate is a location on a 2D grid*/
public class Coordinate {
	public int x;
	public int y;

	public Coordinate(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public override bool Equals(object obj) {
		if (obj == null)
			return false;
		Coordinate c = obj as Coordinate;
		if ((object)c == null)
			return false;
		
		return x == c.x && y == c.y;
	}

	public override int GetHashCode() {
		return base.GetHashCode();
	}
}

/*RobotSimulator moves a robot in a virtual space*/
public class RobotSimulator {
	public Bearing Bearing { get; private set; }
	public Coordinate Coordinate { get; private set; }

	/*RobotSimulator starts a new robot*/
	public RobotSimulator(Bearing bearing, Coordinate coordinate) {
		Coordinate = coordinate;
		Bearing = bearing;
	}

	/*TurnLeft changes the robots bearing to the left*/
	public void TurnLeft() {
		Bearing = Bearing == Bearing.North ? Bearing.West : (Bearing - 1);
	}

	/*TurnRight changes the robots bearing to the right*/
	public void TurnRight() {
		Bearing = Bearing == Bearing.West ? Bearing.North : (Bearing + 1);
	}

	/*Advance moves the robot forward one space*/
	private void Advance() {
		switch(Bearing) {
		case Bearing.North:
			Coordinate.y++;
			break;
		case Bearing.East:
			Coordinate.x++;
			break;
		case Bearing.South:
			Coordinate.y--;
			break;
		case Bearing.West:
			Coordinate.x--;
			break;
		}
	}

	/*Simulate runs a series of instructions against the robot*/
	public void Simulate(string instructions) {
		foreach (char instruction in instructions.ToCharArray()) {
			switch (instruction) {
			case 'A':
				Advance ();
				break;
			case 'L':
				TurnLeft ();
				break;
			case 'R':
				TurnRight ();
				break;
			}
		}
	}
}