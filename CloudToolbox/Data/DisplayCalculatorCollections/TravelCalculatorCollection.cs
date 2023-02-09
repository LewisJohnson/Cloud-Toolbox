using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public static class TravelCalculatorCollection
{
	private static CalculatorArea Area { get; } = CalculatorAreas.Travel;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(TravelCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}


	public static DisplayCalculator MpgCalculator = new(Area)
	{
		DisplayName = "MPG Calculator",
		Aliases = new List<string>() { "Miles per gallon" },
		Uri = Routes.TRAVEL_MPG_CALCULATOR
	};

	public static DisplayCalculator KmlCalculator = new(Area)
	{
		DisplayName = "km/L Calculator",
		Aliases = new List<string>() { "KML", "Kilometers per liter" },
		Uri = Routes.TRAVEL_KML_CALCULATOR
	};

	public static DisplayCalculator FuelRequired = new(Area)
	{
		DisplayName = "Fuel Required",
		Uri = Routes.TRAVEL_FUEL_REQUIRED
	};

	public static DisplayCalculator JourneyCost = new(Area)
	{
		DisplayName = "Journey Cost",
		Uri = Routes.TRAVEL_JOURNEY_COST
	};
}

