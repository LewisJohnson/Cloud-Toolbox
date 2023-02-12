using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class MathsCalculatorCollection : CalculatorCollection
{
	public MathsCalculatorCollection()
	{
		Name = "Maths";
		CssIcon = "bi bi-calculator";
		CssAccentColour = "#fff2fb";
		CssHeaderBackgroundColour = "linear-gradient(to top, #fbc2eb 0%, #a6c1ee 100%)";
		Type = CalculatorAreaTypes.Maths;
		Uri = Routes.AREA_MATHS;

		Calculators = new()
		{
			new DisplayCalculator(this, "Percentage Calculator", Routes.MATHS_PERCENTAGE_CALCULATOR),
			new DisplayCalculator(this, "Times Table", Routes.MATHS_TIMES_TABLE, new() {"Multiplication Table"}),
			new DisplayCalculator(this, "Times Table (Grid)", Routes.MATHS_TIMES_TABLE_GRID, new() {"Multiplication Table (Grid)"}),
			new DisplayCalculator(this, "Division Table", Routes.MATHS_DIVISION_TABLE),
		};
	}
}

