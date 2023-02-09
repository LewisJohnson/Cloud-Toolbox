using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class MathsCalculatorCollection
{
	private static Area Area { get; } = Areas.Maths;

	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			PercentageCalculator,
			TimesTable,
			TimesTableGrid,
			DivisionTable
		};
	}


	public static Calculator PercentageCalculator = new(Area)
	{
		DisplayName = "Percentage Calculator",
		Uri = Routes.MATHS_PERCENTAGE_CALCULATOR
	};

	public static Calculator TimesTable = new(Area)
	{
		DisplayName = "Times Table",
		Aliases = new List<string>() { "Multiplication Table" },
		Uri = Routes.MATHS_TIMES_TABLE
	};

	public static Calculator TimesTableGrid = new(Area)
	{
		DisplayName = "Times Table (Grid)",
		Aliases = new List<string>() { "Multiplication Table (Grid)" },
		Uri = Routes.MATHS_TIMES_TABLE_GRID
	};

	public static Calculator DivisionTable = new()	
	{
		DisplayName = "Division Table",
		Uri = Routes.MATHS_DIVISION_TABLE
	};
}

