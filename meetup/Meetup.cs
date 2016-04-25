using System;
using System.Collections;

/*Schedule are relations descriptions for days in a month*/
enum Schedule {
	Teenth, First, Second, Third, Fourth, Last, 
};

/*Meetup finds date using relational schedule*/
class Meetup {
	private int month, year;

	public Meetup(int month, int year) {
		this.month = month;
		this.year = year;
	}

	/*Day finds the first week day that fits some type of schedule*/
	public DateTime Day(DayOfWeek weekDay, Schedule type) {
		int start=0;
		int stepSize=1;
		switch(type) {
		case Schedule.First:
			start = 1;
			break;
		case Schedule.Second:
			start = 8;
			break;
		case Schedule.Third:
			start = 15;
			break;
		case Schedule.Fourth:
			start = 22;
			break;
		case Schedule.Teenth:
			start = 13;
			break;
		case Schedule.Last:
			start = DateTime.DaysInMonth (year, month);
			stepSize = -1;
			break;
		default:
			// Error: Invalid Schedule type
			break;
		}

		foreach (DateTime day in DateRange(start, 7, stepSize)) {
			if (day.DayOfWeek == weekDay)
				return day;
		}

		// Error: Day doesn't exist
		return new DateTime (0, 0, 0);
	}

	private IEnumerable DateRange(int start, int steps, float stepSize) {
		var startDay = new DateTime (year, month, start);
		var stopDay = startDay.AddDays (steps * stepSize);
		for (var day = startDay; day != stopDay; day = day.AddDays (stepSize)) {
			yield return day;
		}
	}
}