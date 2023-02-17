using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class TextCalculatorCollection : CalculatorCollection
{
	public TextCalculatorCollection()
	{
		Name = "Text";
		Type = CalculatorAreaTypes.Text;
		Uri = Routes.AREA_TEXT;

		CssIcon = "bi bi-fonts";
		CssAccentColour = "#fd7f97";
		CssHeaderBackgroundColour = "#fd7f97";
		CssCalulatorHeaderBackgroundColour = "#fd7f9790";
		CssCalulatorPanelColour = "#fd7f9740";

		var calcs = new List<DisplayCalculator>();
		var textCalcs = Enumeration.GetAll<TextCalculatorsEnum>();

		foreach (TextCalculatorsEnum calc in textCalcs)
		{
			var uri = $"/Toolbox/Text/To-{calc.UriName}";

			calcs.Add(new DisplayCalculator(this, calc.Name, uri, calc.Aliases, calc.Abbreviation) { TextType = calc.CalcType });
		}

		Calculators = calcs;
	}
}

