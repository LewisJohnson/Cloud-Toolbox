using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfMassConverter : IConverter<double>
	{
		private (UnitOfMass, UnitOfMass) Units;

		public UnitOfMassConverter((UnitOfMass, UnitOfMass) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfMass.Kilogram, UnitOfMass.Tonne) => val / 1000,
			(UnitOfMass.Kilogram, UnitOfMass.Gram) => val * 1000,
			(UnitOfMass.Kilogram, UnitOfMass.Stone) => val / 6.35,
			(UnitOfMass.Kilogram, UnitOfMass.Pound) => val * 2.205,
			(UnitOfMass.Kilogram, UnitOfMass.Ounce) => val * 35.274,

			(UnitOfMass.Gram, UnitOfMass.Tonne) => val / 1000000,
			(UnitOfMass.Gram, UnitOfMass.Kilogram) => val / 1000,
			(UnitOfMass.Gram, UnitOfMass.Stone) => val / 6350,
			(UnitOfMass.Gram, UnitOfMass.Pound) => val / 453.6,
			(UnitOfMass.Gram, UnitOfMass.Ounce) => val / 28.35,

			(UnitOfMass.Tonne, UnitOfMass.Kilogram) => val * 1000,
			(UnitOfMass.Tonne, UnitOfMass.Gram) => val * 1000000,
			(UnitOfMass.Tonne, UnitOfMass.Stone) => val * 157.5,
			(UnitOfMass.Tonne, UnitOfMass.Pound) => val * 2205,
			(UnitOfMass.Tonne, UnitOfMass.Ounce) => val * 35270,

			(UnitOfMass.Stone, UnitOfMass.Tonne) => val / 157.5,
			(UnitOfMass.Stone, UnitOfMass.Kilogram) => val * 6.35,
			(UnitOfMass.Stone, UnitOfMass.Gram) => val * 6350,
			(UnitOfMass.Stone, UnitOfMass.Pound) => val * 14,
			(UnitOfMass.Stone, UnitOfMass.Ounce) => val * 224,

			(UnitOfMass.Pound, UnitOfMass.Tonne) => val / 2205,
			(UnitOfMass.Pound, UnitOfMass.Kilogram) => val / 2.205,
			(UnitOfMass.Pound, UnitOfMass.Gram) => val * 453.6,
			(UnitOfMass.Pound, UnitOfMass.Stone) => val / 14,
			(UnitOfMass.Pound, UnitOfMass.Ounce) => val * 16,

			(UnitOfMass.Ounce, UnitOfMass.Tonne) => val / 35270,
			(UnitOfMass.Ounce, UnitOfMass.Kilogram) => val / 35.274,
			(UnitOfMass.Ounce, UnitOfMass.Gram) => val * 28.35,
			(UnitOfMass.Ounce, UnitOfMass.Stone) => val / 224,
			(UnitOfMass.Ounce, UnitOfMass.Pound) => val / 16,
			_ => 1,
		};
	}
}
