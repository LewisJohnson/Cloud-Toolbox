using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfLengthConverter : IUnitOfConverter
	{
		private (UnitOfLength, UnitOfLength) Units;

		public UnitOfLengthConverter((UnitOfLength, UnitOfLength) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfLength.Kilometre, UnitOfLength.Metre) => val * 1000,
			(UnitOfLength.Kilometre, UnitOfLength.Centimetre) => val * 100000,
			(UnitOfLength.Kilometre, UnitOfLength.Millimetre) => val * 1000000,
			(UnitOfLength.Kilometre, UnitOfLength.Mile) => val / 1.609,
			(UnitOfLength.Kilometre, UnitOfLength.Yard) => val * 1097,
			(UnitOfLength.Kilometre, UnitOfLength.Foot) => val * 3281,
			(UnitOfLength.Kilometre, UnitOfLength.Inch) => val * 39370,

			(UnitOfLength.Metre, UnitOfLength.Kilometre) => val / 1000,
			(UnitOfLength.Metre, UnitOfLength.Centimetre) => val * 100,
			(UnitOfLength.Metre, UnitOfLength.Millimetre) => val * 1000,
			(UnitOfLength.Metre, UnitOfLength.Mile) => val / 1609,
			(UnitOfLength.Metre, UnitOfLength.Yard) => val * 1.094,
			(UnitOfLength.Metre, UnitOfLength.Foot) => val * 3.281,
			(UnitOfLength.Metre, UnitOfLength.Inch) => val * 39.37,

			(UnitOfLength.Centimetre, UnitOfLength.Kilometre) => val / 100000,
			(UnitOfLength.Centimetre, UnitOfLength.Metre) => val / 100,
			(UnitOfLength.Centimetre, UnitOfLength.Millimetre) => val * 10,
			(UnitOfLength.Centimetre, UnitOfLength.Mile) => val / 160900,
			(UnitOfLength.Centimetre, UnitOfLength.Yard) => val / 91.44,
			(UnitOfLength.Centimetre, UnitOfLength.Foot) => val / 30.48,
			(UnitOfLength.Centimetre, UnitOfLength.Inch) => val / 2.54,

			(UnitOfLength.Millimetre, UnitOfLength.Kilometre) => val / 1000000,
			(UnitOfLength.Millimetre, UnitOfLength.Metre) => val / 1000,
			(UnitOfLength.Millimetre, UnitOfLength.Centimetre) => val / 10,
			(UnitOfLength.Millimetre, UnitOfLength.Mile) => val / 1.609e+6,
			(UnitOfLength.Millimetre, UnitOfLength.Yard) => val / 914.4,
			(UnitOfLength.Millimetre, UnitOfLength.Foot) => val / 304.8,
			(UnitOfLength.Millimetre, UnitOfLength.Inch) => val / 25.4,

			(UnitOfLength.Mile, UnitOfLength.Kilometre) => val * 1.609,
			(UnitOfLength.Mile, UnitOfLength.Metre) => val * 1609,
			(UnitOfLength.Mile, UnitOfLength.Centimetre) => val * 160900,
			(UnitOfLength.Mile, UnitOfLength.Millimetre) => val * 1.609e+6,
			(UnitOfLength.Mile, UnitOfLength.Yard) => val * 1760,
			(UnitOfLength.Mile, UnitOfLength.Foot) => val * 5280,
			(UnitOfLength.Mile, UnitOfLength.Inch) => val * 63360,

			(UnitOfLength.Yard, UnitOfLength.Kilometre) => val / 1094,
			(UnitOfLength.Yard, UnitOfLength.Metre) => val / 1.094,
			(UnitOfLength.Yard, UnitOfLength.Centimetre) => val * 91.44,
			(UnitOfLength.Yard, UnitOfLength.Millimetre) => val * 914.4,
			(UnitOfLength.Yard, UnitOfLength.Mile) => val / 1760,
			(UnitOfLength.Yard, UnitOfLength.Foot) => val * 3,
			(UnitOfLength.Yard, UnitOfLength.Inch) => val * 36,

			(UnitOfLength.Foot, UnitOfLength.Kilometre) => val / 3281,
			(UnitOfLength.Foot, UnitOfLength.Metre) => val / 3.281,
			(UnitOfLength.Foot, UnitOfLength.Centimetre) => val * 30.48,
			(UnitOfLength.Foot, UnitOfLength.Millimetre) => val * 304.8,
			(UnitOfLength.Foot, UnitOfLength.Mile) => val / 5280,
			(UnitOfLength.Foot, UnitOfLength.Yard) => val / 3,
			(UnitOfLength.Foot, UnitOfLength.Inch) => val * 12,

			(UnitOfLength.Inch, UnitOfLength.Kilometre) => val / 39370,
			(UnitOfLength.Inch, UnitOfLength.Metre) => val / 39.37,
			(UnitOfLength.Inch, UnitOfLength.Centimetre) => val * 2.54,
			(UnitOfLength.Inch, UnitOfLength.Millimetre) => val * 25.4,
			(UnitOfLength.Inch, UnitOfLength.Mile) => val / 63360,
			(UnitOfLength.Inch, UnitOfLength.Yard) => val / 36,
			(UnitOfLength.Inch, UnitOfLength.Foot) => val / 12,
			_ => 1,
		};
	}
}
