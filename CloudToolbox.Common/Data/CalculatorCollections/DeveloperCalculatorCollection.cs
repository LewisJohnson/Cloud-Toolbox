using System.Reflection;
using System.Xml.Linq;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class DeveloperCalculatorCollection : CalculatorCollection
{
	public DeveloperCalculatorCollection()
	{
		Name = "Developer";
		CssIcon = "bi bi-code-slash";
		CssAccentColour = "#84fab0";
		CssHeaderBackgroundColour = "linear-gradient(to top, #84fab0 0%, #8fd3f4 100%)";
		Type = CalculatorAreaTypes.Developer;
		Uri = Routes.AREA_DEVELOPER;

		Calculators = new()
		{
			new DisplayCalculator(this, "Base64", Routes.DEVELOPER_TO_BASE64),
			new DisplayCalculator(this, "Hexadecimal", Routes.DEVELOPER_TO_HEX, new() {"Hex"}),
			new DisplayCalculator(this, "Binary", Routes.DEVELOPER_TO_BINARY),
		};
	}

}
