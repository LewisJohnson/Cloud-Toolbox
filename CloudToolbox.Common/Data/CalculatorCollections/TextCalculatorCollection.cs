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

		Calculators = new()
		{
			new DisplayCalculator(this, "To Lower Case", Routes.TEXT_TO_LOWER_CASE),
			new DisplayCalculator(this, "To Upper Case", Routes.TEXT_TO_UPPER_CASE),
			new DisplayCalculator(this, "To Title Case", Routes.TEXT_TO_TITLE_CASE),
		};
	}
}

