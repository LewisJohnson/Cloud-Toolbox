using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class TravelCalculatorCollection : CalculatorCollection
{
	public TravelCalculatorCollection()
	{
		Name = "Travel";
		Type = CalculatorAreaTypes.Travel;
		Uri = Routes.AREA_TRAVEL;

		CssIcon = "bi bi-globe-europe-africa";
		CssHeaderBackgroundColour = "linear-gradient(to top, #65e36c 0%, #0d6efd 100%)";
		CssAccentColour = "#65e36c";
		CssCalulatorHeaderBackgroundColour = "#65e36c90";
		CssCalulatorPanelColour = "#65e36c40";

		Calculators = new()
		{
			new DisplayCalculator(this, "Mpg Calculator", Routes.TRAVEL_MPG_CALCULATOR, new() { "Miles per gallon" }),
			//new DisplayCalculator(this, "Km/L Calculator", Routes.TRAVEL_KML_CALCULATOR, new() { "Kilometres per litre", "Kilometers per liter" }),
			new DisplayCalculator(this, "Fuel Required", Routes.TRAVEL_FUEL_REQUIRED, new() { "Feul Required" }),
			new DisplayCalculator(this, "Journey Cost", Routes.TRAVEL_JOURNEY_COST),
		};
	}
}

