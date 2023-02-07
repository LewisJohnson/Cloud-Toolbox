using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class UnitsCalculatorCollection
{
	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			KgToStone,
			StoneToKg,
			MphToKmh,
			KmhToMph,
			InchToCm,
			CmToInch
		};
	}


	public static Calculator KgToStone = new()
	{
		Area = Areas.Units,
		DisplayName = "Kg to Stone",
		Aliases = new List<string>() { "Kg to St", "Kilogram to Stone" },
		Uri = Routes.UNITS_KG_TO_STONE
	};

	public static Calculator StoneToKg = new()
	{
		Area = Areas.Units,
		DisplayName = "Kg to Stone",
		Aliases = new List<string>() { "St to Kg", "Stone to Kilogram" },
		Uri = Routes.UNITS_STONE_TO_KG
	};

	public static Calculator MphToKmh = new()
	{
		Area = Areas.Units,
		DisplayName = "mph to km/h",
		Aliases = new List<string>() {
			"m.p.h. to km/h",
			"mi/h or km/h",
			"m.p.h. to kph",
			"mi/h or kph"
		},
		Uri = Routes.UNITS_MPH_TO_KMH
	};

	public static Calculator KmhToMph = new()
	{
		Area = Areas.Units,
		DisplayName = "km/h to Mph",
		Aliases = new List<string>() {
			"km/h to m.p.h.",
			"km/h to mi/h",
			"kph to m.p.h",
			"kph to mi/h"
		},
		Uri = Routes.UNITS_KMH_TO_MPH
	};

	public static Calculator InchToCm = new()
	{
		Area = Areas.Units,
		DisplayName = "Inch to Cm",
		Aliases = new List<string>() { "Inch to Centimeter" },
		Uri = Routes.UNITS_INCH_TO_CM
	};

	public static Calculator CmToInch = new()
	{
		Area = Areas.Units,
		DisplayName = "Cm to Inch",
		Aliases = new List<string>() { "Centimeter to Inch" },
		Uri = Routes.UNITS_CM_TO_INCH
	};


}

