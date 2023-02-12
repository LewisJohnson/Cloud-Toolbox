using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfAreaConverter
	{
		private (UnitOfArea, UnitOfArea) Units;

		public UnitOfAreaConverter((UnitOfArea, UnitOfArea) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfArea.Square_Kilometer, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Kilometer, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Square_Meter, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Meter, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Square_Mile, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Mile, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Square_Yard, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Yard, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Square_Foot, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Foot, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Square_Inch, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Hectare) => val * 1,
			(UnitOfArea.Square_Inch, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Hectare, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Hectare, UnitOfArea.Acre) => val * 1,

			(UnitOfArea.Acre, UnitOfArea.Square_Kilometer) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Square_Meter) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Square_Mile) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Square_Yard) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Square_Foot) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Square_Inch) => val * 1,
			(UnitOfArea.Acre, UnitOfArea.Hectare) => val * 1,
			_ => 1,
		};
	}
}
