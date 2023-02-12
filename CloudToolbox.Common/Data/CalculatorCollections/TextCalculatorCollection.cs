using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class TextCalculatorCollection : CalculatorCollection
{
	public TextCalculatorCollection()
	{
		Name = "Text";
		CssIcon = "bi bi-fonts";
		Type = CalculatorAreaTypes.Text;
		Uri = Routes.AREA_TEXT;

		Calculators = new()
		{
			new DisplayCalculator(this, "To Lower Case", Routes.TEXT_TO_LOWER_CASE),
			new DisplayCalculator(this, "To Upper Case", Routes.TEXT_TO_UPPER_CASE),
			new DisplayCalculator(this, "To Title Case", Routes.TEXT_TO_TITLE_CASE),
		};
	}
}

