using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public static class MathsCalculatorCollection
{
	private static Area Area { get; } = Areas.Maths;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(MathsCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}


	public static DisplayCalculator PercentageCalculator = new(Area)
	{
		DisplayName = "Percentage Calculator",
		Uri = Routes.MATHS_PERCENTAGE_CALCULATOR
	};

	public static DisplayCalculator TimesTable = new(Area)
	{
		DisplayName = "Times Table",
		Aliases = new List<string>() { "Multiplication Table" },
		Uri = Routes.MATHS_TIMES_TABLE
	};

	public static DisplayCalculator TimesTableGrid = new(Area)
	{
		DisplayName = "Times Table (Grid)",
		Aliases = new List<string>() { "Multiplication Table (Grid)" },
		Uri = Routes.MATHS_TIMES_TABLE_GRID
	};

	public static DisplayCalculator DivisionTable = new()	
	{
		DisplayName = "Division Table",
		Uri = Routes.MATHS_DIVISION_TABLE
	};
}

