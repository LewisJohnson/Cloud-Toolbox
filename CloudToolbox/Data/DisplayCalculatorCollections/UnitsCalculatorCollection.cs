using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public class UnitsCalculatorCollection
{
	private static Area Area { get; } = Areas.Units;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(UnitsCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}

	public static DisplayCalculator KgToStone = new(Area) { DisplayName = "Kilogram to Stone", Uri = Routes.UNITS_KG_TO_STONE, Aliases = new List<string>() { "Kg to St" } };
	public static DisplayCalculator KgToPound = new(Area) { DisplayName = "Kilogram to Pound", Uri = Routes.UNITS_KG_TO_POUND, Aliases = new List<string>() { "Kg to Pound", "Kg to lbs" } };
	public static DisplayCalculator KgToTonne = new(Area) { DisplayName = "Kilogram to Tonne", Uri = Routes.UNITS_KG_TO_TONNE, Aliases = new List<string>() { "Kg to Tonne" } };
	public static DisplayCalculator KgToGram = new(Area) { DisplayName = "Kilogram to Gram", Uri = Routes.UNITS_KG_TO_GRAM, Aliases = new List<string>() { "Kg to Gram" } };
	public static DisplayCalculator KgToOunce = new(Area) { DisplayName = "Kilogram to Ounce", Uri = Routes.UNITS_KG_TO_OUNCE, Aliases = new List<string>() { "Kg to Ounce" } };

	public static DisplayCalculator StoneToKg = new(Area) { DisplayName = "Stone to Kilogram", Uri = Routes.UNITS_STONE_TO_KG, Aliases = new List<string>() { "St to Kg", "Stone to Kilogram" } };
	public static DisplayCalculator StoneToPound = new(Area) { DisplayName = "Stone to Pound", Uri = Routes.UNITS_STONE_TO_POUND, Aliases = new List<string>() { "Kg to lbs" } };
	public static DisplayCalculator StoneToTonne = new(Area) { DisplayName = "Stone to Tonne", Uri = Routes.UNITS_STONE_TO_TONNE, Aliases = new List<string>() { "Stone to Stone" } };
	public static DisplayCalculator StoneToGram = new(Area) { DisplayName = "Stone to Gram", Uri = Routes.UNITS_STONE_TO_GRAM, Aliases = new List<string>() { "Stone to Gram" } };
	public static DisplayCalculator StoneToOunce = new(Area) { DisplayName = "Stone to Ounce", Uri = Routes.UNITS_STONE_TO_OUNCE, Aliases = new List<string>() { "Stone to Ounce" } };

	public static DisplayCalculator PoundToKg = new(Area) { DisplayName = "Pound to Kilogram", Uri = Routes.UNITS_POUND_TO_KG, Aliases = new List<string>() { "St to Kg", "Stone to Kilogram" } };
	public static DisplayCalculator PoundToStone = new(Area) { DisplayName = "Pound to Pound", Uri = Routes.UNITS_POUND_TO_POUND, Aliases = new List<string>() { "Kg to lbs" } };
	public static DisplayCalculator PoundToTonne = new(Area) { DisplayName = "Pound to Tonne", Uri = Routes.UNITS_POUND_TO_TONNE, Aliases = new List<string>() { "Kg to Tonne" } };
	public static DisplayCalculator PoundToGram = new(Area) { DisplayName = "Pound to Gram", Uri = Routes.UNITS_POUND_TO_GRAM, Aliases = new List<string>() { "Kg to Gram" } };
	public static DisplayCalculator PoundToOunce = new(Area) { DisplayName = "Pound to Ounce", Uri = Routes.UNITS_POUND_TO_OUNCE, Aliases = new List<string>() { "Kg to Ounce" } };

	public static DisplayCalculator TonneToKg = new(Area) { DisplayName = "Tonne to Kilogram", Uri = Routes.UNITS_TONNE_TO_KG, Aliases = new List<string>() { "Kg to Tonne" } };
	public static DisplayCalculator TonneToStone = new(Area) { DisplayName = "Tonne to Stone", Uri = Routes.UNITS_TONNE_TO_STONE, Aliases = new List<string>() { "Kg to St" } };
	public static DisplayCalculator TonneToPound = new(Area) { DisplayName = "Tonne to Pound", Uri = Routes.UNITS_TONNE_TO_POUND, Aliases = new List<string>() { "Kg to Pound", "Kg to lbs" } };
	public static DisplayCalculator TonneToGram = new(Area) { DisplayName = "Tonne to Gram", Uri = Routes.UNITS_TONNE_TO_GRAM, Aliases = new List<string>() { "Kg to Gram" } };
	public static DisplayCalculator TonneToOunce = new(Area) { DisplayName = "Tonne to Ounce", Uri = Routes.UNITS_TONNE_TO_OUNCE, Aliases = new List<string>() { "Kg to Ounce" } };

	public static DisplayCalculator GramToKg = new(Area) { DisplayName = "Gram to Kilogram", Uri = Routes.UNITS_GRAM_TO_KG, Aliases = new List<string>() { "Gram to Kg" } };
	public static DisplayCalculator GramToStone = new(Area) { DisplayName = "Gram to Stone", Uri = Routes.UNITS_GRAM_TO_STONE, Aliases = new List<string>() { "Gram to St" } };
	public static DisplayCalculator GramToPound = new(Area) { DisplayName = "Gram to Pound", Uri = Routes.UNITS_GRAM_TO_POUND, Aliases = new List<string>() { "Kg to lbs" } };
	public static DisplayCalculator GramToTonne = new(Area) { DisplayName = "Gram to Tonne", Uri = Routes.UNITS_GRAM_TO_TONNE, Aliases = new List<string>() { "Gram to Tonne" } };
	public static DisplayCalculator GramToOunce = new(Area) { DisplayName = "Gram to Ounce", Uri = Routes.UNITS_GRAM_TO_OUNCE, Aliases = new List<string>() { "Gram to Ounce" } };

	public static DisplayCalculator OunceToKg = new(Area) { DisplayName = "Ounce to Kilogram", Uri = Routes.UNITS_OUNCE_TO_KG, Aliases = new List<string>() { "Ounce to Ounce" } };
	public static DisplayCalculator OunceToStone = new(Area) { DisplayName = "Ounce to Stone", Uri = Routes.UNITS_OUNCE_TO_STONE, Aliases = new List<string>() { "Ounce to St" } };
	public static DisplayCalculator OunceToPound = new(Area) { DisplayName = "Ounce to Pound", Uri = Routes.UNITS_OUNCE_TO_POUND, Aliases = new List<string>() { "Kg to lbs" } };
	public static DisplayCalculator OunceToTonne = new(Area) { DisplayName = "Ounce to Tonne", Uri = Routes.UNITS_OUNCE_TO_TONNE, Aliases = new List<string>() { "Ounce to Tonne" } };
	public static DisplayCalculator OunceToGram = new(Area) { DisplayName = "Ounce to Gram", Uri = Routes.UNITS_OUNCE_TO_GRAM, Aliases = new List<string>() { "Ounce to Gram" } };


	public static DisplayCalculator MphToKmh = new(Area)
	{
		DisplayName = "mph to km/h",
		Aliases = new List<string>() {
			"m.p.h. to km/h",
			"mi/h or km/h",
			"m.p.h. to kph",
			"mi/h or kph"
		},
		Uri = Routes.UNITS_MPH_TO_KMH
	};

	public static DisplayCalculator KmhToMph = new(Area)
	{
		DisplayName = "km/h to mph",
		Aliases = new List<string>() {
			"km/h to m.p.h.",
			"km/h to mi/h",
			"kph to m.p.h",
			"kph to mi/h"
		},
		Uri = Routes.UNITS_KMH_TO_MPH
	};

	public static DisplayCalculator InchToCm = new(Area)
	{
		DisplayName = "Inch to Cm",
		Aliases = new List<string>() { "Inch to centimetre" },
		Uri = Routes.UNITS_INCH_TO_CM
	};

	public static DisplayCalculator CmToInch = new(Area)
	{
		DisplayName = "Cm to Inch",
		Aliases = new List<string>() { "centimetre to Inch" },
		Uri = Routes.UNITS_CM_TO_INCH
	};


}

