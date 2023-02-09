namespace CloudToolbox.Calculators
{
	public static class UnitCalculators
	{
		public static double LitreToImperialGallon(double litre) => litre / 4.54609;
		public static double ImperialGallonToLitre(double gallon) => gallon * 4.54609;

		public static double CentimetresToInch(double cm) => cm / 2.54;
		public static double InchToCentimetres(double inch) => inch * 2.54;

		public static double KilogramToStone(double kg) => kg / 6.35;
		public static double StoneToKilogram(double st) => st * 6.35;

		public static double MilesPerHourToKilometersPerHour(double mph) => mph * 1.609344;
		public static double KilometersPerHourToMilesPerHour(double kmh) => kmh / 1.609344;
	}
}
