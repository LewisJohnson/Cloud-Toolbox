using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public static class DateAndTimeCalculatorCollection
{
	private static CalculatorArea Area { get; } = CalculatorAreas.DateAndTime;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(DateAndTimeCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}

	public static DisplayCalculator DurationBetweenDates = new(Area)
	{
		DisplayName = "Duration Between Dates",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_DATES
	};

	public static DisplayCalculator DurationBetweenTime = new(Area)
	{
		DisplayName = "Duration Between Times",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIMES
	};

	public static DisplayCalculator DurationBetweenTimeAndDate = new(Area)
	{
		DisplayName = "Duration Between Time And Date",
		Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIME_AND_DATE
	};
}
