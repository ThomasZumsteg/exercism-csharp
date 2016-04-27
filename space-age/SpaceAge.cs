using System;

class SpaceAge {
	public long Seconds;

	/*SpaceAge calculates your age on other planets*/
	public SpaceAge(long age) {
		Seconds = age;
	}

	/*OnEarth calcuates your age on Earth*/
	public double OnEarth() {
		return Math.Round(Seconds / (31557600.0 * 1), 2);
	}

	/*OnMercury calculates your age on Mercury*/
	public double OnMercury() {
		return Math.Round(Seconds / (31557600.0 * 0.2408467),2);
	}

	/*OnVenus calculates your age on Venus*/
	public double OnVenus() {
		return Math.Round(Seconds / (31557600.0 * 0.61519726), 2);
	}

	/*OnMars calculates your age on Mars*/
	public double OnMars() {
		return Math.Round(Seconds / (31557600.0 * 1.8808158),2);
	}

	/*OnJupiter calculates your age on Jupiter*/
	public double OnJupiter() {
		return Math.Round(Seconds / (31557600.0 * 11.862615),2);
	}

	/*OnSaturn calculates your age on Saturn*/
	public double OnSaturn() {
		return Math.Round(Seconds / (31557600.0 * 29.447498),2);
	}

	/*OnUranus calcuates your age on Uranus*/
	public double OnUranus() {
		return Math.Round(Seconds / (31557600.0 * 84.016846),2);
	}

	/*OnNeptune calcuates your age on Neptune*/
	public double OnNeptune() {
		return Math.Round(Seconds / (31557600.0 * 164.79132),2);
	}
}