using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class DateTimeCalculatorCollection
{
	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			DurationBetweenDays,
			DurationBetweenTime
		};
	}


	public static Calculator DurationBetweenDays = new()
	{
		Area = Areas.DateAndTime,
		DisplayName = "Duration Between Days",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_DAYS
	};

	public static Calculator DurationBetweenTime = new()
	{
		Area = Areas.DateAndTime,
		DisplayName = "Duration Between Times",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIMES
	};
}
