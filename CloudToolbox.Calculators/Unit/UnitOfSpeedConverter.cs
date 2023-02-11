using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfSpeedConverter
	{
		private (UnitOfSpeed, UnitOfSpeed) Units;

		public UnitOfSpeedConverter((UnitOfSpeed, UnitOfSpeed) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfSpeed.Mile_Per_Hour, UnitOfSpeed.Kilometre_Per_Hour) => val * 1.609,
			(UnitOfSpeed.Mile_Per_Hour, UnitOfSpeed.Foot_Per_Second) => val * 1.467,
			(UnitOfSpeed.Mile_Per_Hour, UnitOfSpeed.Metre_Per_Second) => val / 3.281,
			(UnitOfSpeed.Mile_Per_Hour, UnitOfSpeed.Knot) => val / 1.688,

			(UnitOfSpeed.Kilometre_Per_Hour, UnitOfSpeed.Mile_Per_Hour) => val / 1.609,
			(UnitOfSpeed.Kilometre_Per_Hour, UnitOfSpeed.Foot_Per_Second) => val / 1.097,
			(UnitOfSpeed.Kilometre_Per_Hour, UnitOfSpeed.Metre_Per_Second) => val / 3.6,
			(UnitOfSpeed.Kilometre_Per_Hour, UnitOfSpeed.Knot) => val / 1.852,

			(UnitOfSpeed.Foot_Per_Second, UnitOfSpeed.Mile_Per_Hour) => val / 1.467,
			(UnitOfSpeed.Foot_Per_Second, UnitOfSpeed.Kilometre_Per_Hour) => val / 1.097,
			(UnitOfSpeed.Foot_Per_Second, UnitOfSpeed.Metre_Per_Second) => val / 3.281,
			(UnitOfSpeed.Foot_Per_Second, UnitOfSpeed.Knot) => val / 1.688,

			(UnitOfSpeed.Metre_Per_Second, UnitOfSpeed.Mile_Per_Hour) => val * 2.237,
			(UnitOfSpeed.Metre_Per_Second, UnitOfSpeed.Kilometre_Per_Hour) => val * 3.6,
			(UnitOfSpeed.Metre_Per_Second, UnitOfSpeed.Foot_Per_Second) => val * 3.281,
			(UnitOfSpeed.Metre_Per_Second, UnitOfSpeed.Knot) => val * 1.944,

			(UnitOfSpeed.Knot, UnitOfSpeed.Mile_Per_Hour) => val * 1.151,
			(UnitOfSpeed.Knot, UnitOfSpeed.Kilometre_Per_Hour) => val * 1.852,
			(UnitOfSpeed.Knot, UnitOfSpeed.Foot_Per_Second) => val * 1.688,
			(UnitOfSpeed.Knot, UnitOfSpeed.Metre_Per_Second) => val / 1.944,
			_ => 1,
		};
	}
}
