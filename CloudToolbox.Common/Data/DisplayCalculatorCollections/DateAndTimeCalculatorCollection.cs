using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class DateAndTimeCalculatorCollection : CalculatorCollection
{
	//public static List<ResultDisplayCalculator> GetCalculators()
	//{
	//	List<ResultDisplayCalculator> calculators =
	//		typeof(DateAndTimeCalculatorCollection)
	//		.GetFields(BindingFlags.Static | BindingFlags.Public)
	//		.Where(x => x.FieldType == typeof(ResultDisplayCalculator))
	//		.Select(x => (ResultDisplayCalculator)x.GetValue(null))
	//		.ToList();

	//	return calculators;
	//}

	//public static ResultDisplayCalculator DurationBetweenDates = new()
	//{
	//	DisplayName = "Duration Between Dates",
	//	Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_DATES
	//};

	//public static ResultDisplayCalculator DurationBetweenTime = new()
	//{
	//	DisplayName = "Duration Between Times",
	//	Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIMES
	//};

	//public static ResultDisplayCalculator DurationBetweenTimeAndDate = new()
	//{
	//	DisplayName = "Duration Between Time And Date",
	//	Uri = Routes.DATE_AND_TIME_DURATION_BETWEEN_TIME_AND_DATE
	//};
}
