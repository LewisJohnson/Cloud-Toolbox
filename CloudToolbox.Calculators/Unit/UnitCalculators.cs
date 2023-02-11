namespace CloudToolbox.Calculators.Unit
{

	public static class UnitCalculators
	{

		public static double LitreToImperialGallon(double litre) => litre / 4.54609;
		public static double ImperialGallonToLitre(double gallon) => gallon * 4.54609;

		public static double MilesPerHourToKilometersPerHour(double mph) => mph * 1.609344;
		public static double KilometersPerHourToMilesPerHour(double kmh) => kmh / 1.609344;
	}
}
