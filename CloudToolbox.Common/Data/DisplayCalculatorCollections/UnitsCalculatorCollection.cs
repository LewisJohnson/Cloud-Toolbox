using System.Linq;
using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class UnitsCalculatorCollection : CalculatorCollection
{
	public UnitsCalculatorCollection()
	{
		CssAccentColour = "red";
		CssCalulatorHeaderBackgroundColour = "red";
		CssCalulatorPanelColour = "red";
		CssHeaderBackgroundColour = "red";

		Calculators = new()
		{
			new DisplayCalculator(this, "Kilometre", "Km", new() { "Kilometer" }, UnitTypes.Length, UnitOfLength.Kilometre),
			new DisplayCalculator(this, "Yard", "Yd", new() { }, UnitTypes.Length, UnitOfLength.Yard)
		};
	}


	public DisplayCalculator? MatchParamToCalculator(string input)
	{
		input = input.ToLower();

		try
		{
			return Calculators.FirstOrDefault(x =>
				x.DisplayName.ToLower() == input ||
				x.Abbreviation.ToLower() == input ||
				x.Aliases.Any(x => x.ToLower() == input));
		}
		catch (Exception e)
		{

		}

		return null;
	}
}
