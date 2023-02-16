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
		CssHeaderBackgroundColour = "#39913e";
		CssAccentColour = "#39913e";
		CssCalulatorHeaderBackgroundColour = "#39913e54";
		CssCalulatorPanelColour = "#39913e36";

		Calculators = new()
		{
			new DisplayCalculator(this, "Mpg Calculator", Routes.TRAVEL_MPG_CALCULATOR, new() { "Miles per gallon" }),
			new DisplayCalculator(this, "Km/L Calculator", Routes.TRAVEL_KML_CALCULATOR, new() { "Kilometres per litre", "Kilometers per liter" }),
			new DisplayCalculator(this, "Fuel Required", Routes.TRAVEL_FUEL_REQUIRED, new() { "Feul Required" }),
			new DisplayCalculator(this, "Journey Cost", Routes.TRAVEL_JOURNEY_COST),
		};
	}
}

