namespace CloudToolbox.Calculators
{
	public static class TravelCalculators
	{
		public static double JourneyCost(double miles, double mpg, double pencePerLitre) => mpg == 0 ? 0 : UnitCalculators.ImperialGallonToLitre(miles / mpg) * (pencePerLitre / 100);
		public static double FuelRequired(double miles, double mpg) => mpg == 0 ? 0 : miles / mpg;
		public static double Mpg(double price, double totalSpent, double miles) => price == 0 ? 0 : miles / ((totalSpent * 100) / price / 4.54609188);
		public static double ImperialGallonsUsed(double price, double totalSpent) => price == 0 ? 0 : (totalSpent * 100 / price / 4.54609188);
	}
}
