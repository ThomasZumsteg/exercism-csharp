/*Clock tracks time*/
public class Clock {
	private int time;

	/*Clock creates a new clock*/
	public Clock(int hours, int minutes=0) {
		time = (60 * hours + minutes) % (24 * 60);
		while (time < 0)
			time += 24 * 60;
	}

	/*ToString prints the time*/
	override public string ToString() {
		return string.Format("{0:D2}:{1:D2}", hours, minutes);
	}

	/*Add increments the clock by an amount*/
	public Clock Add(int mintues) {
		return new Clock(0, time + mintues);
	}

	/*Subtrack decrements the clock by an amount*/
	public Clock Subtract(int minutes) {
		return Add (-minutes);
	}

	/*Equals compares two clocks*/
	public override bool Equals(System.Object obj) {
		var c = obj as Clock;
		if (c == null)
			return false;
		return c.ToString() == ToString();
	}

	/*GetHashCode generates a unique ID for the clock*/
	public override int GetHashCode() {
		return this.ToString ().GetHashCode ();
	}

	/*hours is the number of hours in time*/
	private int hours {
		get { return time / 60; }
	}

	/*minuts is the number of minutes in time*/
	private int minutes {
		get { return time % 60; }
	}
}