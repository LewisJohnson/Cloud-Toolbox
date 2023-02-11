using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class TextDisplayCalculatorCollection : CalculatorCollection
{
	//private static CalculatorCollection Collection { get; } = TextDisplayCalculatorCollection.Instance;

	//public static List<ResultDisplayCalculator> GetCalculators()
	//{
	//	List<ResultDisplayCalculator> calculators =
	//		typeof(TextDisplayCalculatorCollection)
	//		.GetFields(BindingFlags.Static | BindingFlags.Public)
	//		.Where(x => x.FieldType == typeof(ResultDisplayCalculator))
	//		.Select(x => (ResultDisplayCalculator)x.GetValue(null))
	//		.ToList();

	//	return calculators;
	//}


	//public static ResultDisplayCalculator ToLowerCase = new(Collection)
	//{
	//	DisplayName = "To Lower Case",
	//	Uri = Routes.TEXT_TO_LOWER_CASE
	//};

	//public static ResultDisplayCalculator ToUpperCase = new(Collection)
	//{
	//	DisplayName = "To Upper Case",
	//	Uri = Routes.TEXT_TO_UPPER_CASE
	//};

	//public static ResultDisplayCalculator ToTitleCase = new(Collection)
	//{
	//	DisplayName = "To Title Case",
	//	Uri = Routes.TEXT_TO_TITLE_CASE
	//};
}

