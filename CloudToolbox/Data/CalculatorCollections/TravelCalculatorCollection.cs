using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class TravelCalculatorCollection
{
	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			MpgCalculator,
			KmlCalculator,
			FuelRequired
		};
	}


	public static Calculator MpgCalculator = new()
	{
		Area = Areas.Travel,
		DisplayName = "MPG Calculator",
		Aliases = new List<string>() { "Miles per gallon" },
		Uri = Routes.TRAVEL_MPG_CALCULATOR
	};

	public static Calculator KmlCalculator = new()
	{
		Area = Areas.Travel,
		DisplayName = "km/L Calculator",
		Aliases = new List<string>() { "KML", "Kilometers per liter" },
		Uri = Routes.TRAVEL_KML_CALCULATOR
	};

	public static Calculator FuelRequired = new()
	{
		Area = Areas.Travel,
		DisplayName = "Fuel Required",
		Uri = Routes.TRAVEL_FUEL_REQUIRED
	};
}

