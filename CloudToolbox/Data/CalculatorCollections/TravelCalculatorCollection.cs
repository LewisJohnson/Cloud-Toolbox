using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class TravelCalculatorCollection
{
	private static Area Area { get; } = Areas.Travel;

	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			MpgCalculator,
			KmlCalculator,
			FuelRequired,
			JourneyCost
		};
	}


	public static Calculator MpgCalculator = new(Area)
	{
		DisplayName = "MPG Calculator",
		Aliases = new List<string>() { "Miles per gallon" },
		Uri = Routes.TRAVEL_MPG_CALCULATOR
	};

	public static Calculator KmlCalculator = new(Area)
	{
		DisplayName = "km/L Calculator",
		Aliases = new List<string>() { "KML", "Kilometers per liter" },
		Uri = Routes.TRAVEL_KML_CALCULATOR
	};

	public static Calculator FuelRequired = new(Area)
	{
		DisplayName = "Fuel Required",
		Uri = Routes.TRAVEL_FUEL_REQUIRED
	};

	public static Calculator JourneyCost = new(Area)
	{
		DisplayName = "Journey Cost",
		Uri = Routes.TRAVEL_JOURNEY_COST
	};
}

