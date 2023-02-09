using CloudToolbox.Common.Enums;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfLengthConverter
	{
		private (UnitOfLength, UnitOfLength) Units;

		public UnitOfLengthConverter((UnitOfLength, UnitOfLength) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfLength.Kilometre, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Kilometre, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Meter, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Meter, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Centimetre, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Centimetre, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Millimetre, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Millimetre, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Mile, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Mile, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Yard, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Foot) => val * 1,
			(UnitOfLength.Yard, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Foot, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Foot, UnitOfLength.Inch) => val * 1,

			(UnitOfLength.Inch, UnitOfLength.Kilometre) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Meter) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Centimetre) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Millimetre) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Mile) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Yard) => val * 1,
			(UnitOfLength.Inch, UnitOfLength.Foot) => val * 1,
			_ => 1,
		};
	}
}
