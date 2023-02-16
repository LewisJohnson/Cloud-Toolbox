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
		CssAccentColour = "#ed3c5d";
		CssHeaderBackgroundColour = "#ed3c5d";
		CssCalulatorHeaderBackgroundColour = "#ed3c5d";
		CssCalulatorPanelColour = "#ed3c5d1f";

		var calcs = new List<DisplayCalculator>();
		var textCalcs = Enumeration.GetAll<TextCalculatorsEnum>();

		foreach (TextCalculatorsEnum calc in textCalcs)
		{
			var uri = $"/Toolbox/Text/To-{calc.UriName}";

			calcs.Add(new DisplayCalculator(this, calc.Name, uri, new() { }, calc.Abbreviation) { TextType = calc.CalcType });
		}

		Calculators = calcs;
	}
}

