using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class DateAndTimeCalculatorCollection
{
	private static Area Area { get; } = Areas.DateAndTime;

	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			DurationBetweenDates,
			DurationBetweenTime,
			DurationBetweenTimeAndDate
		};
	}

	public static Calculator DurationBetweenDates = new(Area)
	{
		DisplayName = "Duration Between Dates",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_DATES
	};

	public static Calculator DurationBetweenTime = new(Area)
	{
		DisplayName = "Duration Between Times",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIMES
	};

	public static Calculator DurationBetweenTimeAndDate = new(Area)
	{
		DisplayName = "Duration Between Time And Date",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIME_AND_DATE
	};
}
