using CloudToolbox.Common.Enums;

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
			(UnitOfSpeed.MilePerHour, UnitOfSpeed.KilometrePerHour) => val * 1.609,
			(UnitOfSpeed.MilePerHour, UnitOfSpeed.FootPerSecond) => val * 1.467,
			(UnitOfSpeed.MilePerHour, UnitOfSpeed.MetrePerSecond) => val / 3.281,
			(UnitOfSpeed.MilePerHour, UnitOfSpeed.Knot) => val / 1.688,

			(UnitOfSpeed.KilometrePerHour, UnitOfSpeed.MilePerHour) => val / 1.609,
			(UnitOfSpeed.KilometrePerHour, UnitOfSpeed.FootPerSecond) => val / 1.097,
			(UnitOfSpeed.KilometrePerHour, UnitOfSpeed.MetrePerSecond) => val / 3.6,
			(UnitOfSpeed.KilometrePerHour, UnitOfSpeed.Knot) => val / 1.852,

			(UnitOfSpeed.FootPerSecond, UnitOfSpeed.MilePerHour) => val / 1.467,
			(UnitOfSpeed.FootPerSecond, UnitOfSpeed.KilometrePerHour) => val / 1.097,
			(UnitOfSpeed.FootPerSecond, UnitOfSpeed.MetrePerSecond) => val / 3.281,
			(UnitOfSpeed.FootPerSecond, UnitOfSpeed.Knot) => val / 1.688,

			(UnitOfSpeed.MetrePerSecond, UnitOfSpeed.MilePerHour) => val * 2.237,
			(UnitOfSpeed.MetrePerSecond, UnitOfSpeed.KilometrePerHour) => val * 3.6,
			(UnitOfSpeed.MetrePerSecond, UnitOfSpeed.FootPerSecond) => val * 3.281,
			(UnitOfSpeed.MetrePerSecond, UnitOfSpeed.Knot) => val * 1.944,

			(UnitOfSpeed.Knot, UnitOfSpeed.MilePerHour) => val * 1.151,
			(UnitOfSpeed.Knot, UnitOfSpeed.KilometrePerHour) => val * 1.852,
			(UnitOfSpeed.Knot, UnitOfSpeed.FootPerSecond) => val * 1.688,
			(UnitOfSpeed.Knot, UnitOfSpeed.MetrePerSecond) => val / 1.944,
			_ => 1,
		};
	}
}
