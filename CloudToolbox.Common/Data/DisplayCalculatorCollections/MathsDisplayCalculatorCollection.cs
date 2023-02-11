using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class MathsDisplayCalculatorCollection : CalculatorCollection
{
	//private static CalculatorCollection Collection { get; } = CalculatorAreas.Maths;

	//public static List<ResultDisplayCalculator> GetCalculators()
	//{
	//	List<ResultDisplayCalculator> calculators =
	//		typeof(MathsDisplayCalculatorCollection)
	//		.GetFields(BindingFlags.Static | BindingFlags.Public)
	//		.Where(x => x.FieldType == typeof(ResultDisplayCalculator))
	//		.Select(x => (ResultDisplayCalculator)x.GetValue(null))
	//		.ToList();

	//	return calculators;
	//}


	//public static ResultDisplayCalculator PercentageCalculator = new(Collection)
	//{
	//	DisplayName = "Percentage Calculator",
	//	Uri = Routes.MATHS_PERCENTAGE_CALCULATOR
	//};

	//public static ResultDisplayCalculator TimesTable = new(Collection)
	//{
	//	DisplayName = "Times Table",
	//	Aliases = new List<string>() { "Multiplication Table" },
	//	Uri = Routes.MATHS_TIMES_TABLE
	//};

	//public static ResultDisplayCalculator TimesTableGrid = new(Collection)
	//{
	//	DisplayName = "Times Table (Grid)",
	//	Aliases = new List<string>() { "Multiplication Table (Grid)" },
	//	Uri = Routes.MATHS_TIMES_TABLE_GRID
	//};

	//public static ResultDisplayCalculator DivisionTable = new()	
	//{
	//	DisplayName = "Division Table",
	//	Uri = Routes.MATHS_DIVISION_TABLE
	//};
}

