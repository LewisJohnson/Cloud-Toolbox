using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class TravelDisplayCalculatorCollection : CalculatorCollection
{
	//private static CalculatorCollection Collection { get; } = CalculatorAreas.Travel;

	//public static List<ResultDisplayCalculator> GetCalculators()
	//{
	//	List<ResultDisplayCalculator> calculators =
	//		typeof(TravelDisplayCalculatorCollection)
	//		.GetFields(BindingFlags.Static | BindingFlags.Public)
	//		.Where(x => x.FieldType == typeof(ResultDisplayCalculator))
	//		.Select(x => (ResultDisplayCalculator)x.GetValue(null))
	//		.ToList();

	//	return calculators;
	//}


	//public static ResultDisplayCalculator MpgCalculator = new(Collection)
	//{
	//	DisplayName = "MPG Calculator",
	//	Aliases = new List<string>() { "Miles per gallon" },
	//	Uri = Routes.TRAVEL_MPG_CALCULATOR
	//};

	//public static ResultDisplayCalculator KmlCalculator = new(Collection)
	//{
	//	DisplayName = "km/L Calculator",
	//	Aliases = new List<string>() { "KML", "Kilometers per liter" },
	//	Uri = Routes.TRAVEL_KML_CALCULATOR
	//};

	//public static ResultDisplayCalculator FuelRequired = new(Collection)
	//{
	//	DisplayName = "Fuel Required",
	//	Uri = Routes.TRAVEL_FUEL_REQUIRED
	//};

	//public static ResultDisplayCalculator JourneyCost = new(Collection)
	//{
	//	DisplayName = "Journey Cost",
	//	Uri = Routes.TRAVEL_JOURNEY_COST
	//};
}

