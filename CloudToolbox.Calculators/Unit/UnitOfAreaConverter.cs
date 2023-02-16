using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfAreaConverter : IUnitOfConverter
	{
		private (UnitOfArea, UnitOfArea) Units;

		public UnitOfAreaConverter((UnitOfArea, UnitOfArea) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			
			(UnitOfArea.Square_Kilometre, UnitOfArea.Square_Metre) => val * 1e+6,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Square_Mile) => val / 2.59,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Square_Yard) => val * 1.196e+6,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Square_Foot) => val * 1.076e+7,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Square_Inch) => val * 1.55e+9,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Hectare) => val * 100,
			(UnitOfArea.Square_Kilometre, UnitOfArea.Acre) => val * 247.1,

			(UnitOfArea.Square_Metre, UnitOfArea.Square_Kilometre) => val / 1e+6,
			(UnitOfArea.Square_Metre, UnitOfArea.Square_Mile) => val / 2.59e+6,
			(UnitOfArea.Square_Metre, UnitOfArea.Square_Yard) => val * 1.196,
			(UnitOfArea.Square_Metre, UnitOfArea.Square_Foot) => val * 10.764,
			(UnitOfArea.Square_Metre, UnitOfArea.Square_Inch) => val * 1550,
			(UnitOfArea.Square_Metre, UnitOfArea.Hectare) => val / 10000,
			(UnitOfArea.Square_Metre, UnitOfArea.Acre) => val / 4047,

			(UnitOfArea.Square_Mile, UnitOfArea.Square_Kilometre) => val * 2.59,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Metre) => val * 2.59e+6,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Yard) => val * 2.59e+6,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Foot) => val * 2.788e+7,
			(UnitOfArea.Square_Mile, UnitOfArea.Square_Inch) => val * 4.014e+9,
			(UnitOfArea.Square_Mile, UnitOfArea.Hectare) => val * 259,
			(UnitOfArea.Square_Mile, UnitOfArea.Acre) => val * 640,

			(UnitOfArea.Square_Yard, UnitOfArea.Square_Kilometre) => val / 1.196e+6,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Metre) => val / 1.196,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Mile) => val / 3.098e+6,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Foot) => val * 9,
			(UnitOfArea.Square_Yard, UnitOfArea.Square_Inch) => val * 1296,
			(UnitOfArea.Square_Yard, UnitOfArea.Hectare) => val / 11960,
			(UnitOfArea.Square_Yard, UnitOfArea.Acre) => val / 4840,

			(UnitOfArea.Square_Foot, UnitOfArea.Square_Kilometre) => val / 1.076e+7,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Metre) => val / 10.764,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Mile) => val / 2.788e+7,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Yard) => val / 9,
			(UnitOfArea.Square_Foot, UnitOfArea.Square_Inch) => val * 144,
			(UnitOfArea.Square_Foot, UnitOfArea.Hectare) => val / 107600,
			(UnitOfArea.Square_Foot, UnitOfArea.Acre) => val / 43560,

			(UnitOfArea.Square_Inch, UnitOfArea.Square_Kilometre) => val / 1.55e+9,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Metre) => val / 1550,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Mile) => val / 4.014e+9,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Yard) => val / 1296,
			(UnitOfArea.Square_Inch, UnitOfArea.Square_Foot) => val / 144,
			(UnitOfArea.Square_Inch, UnitOfArea.Hectare) => val / 1.55e+7,
			(UnitOfArea.Square_Inch, UnitOfArea.Acre) => val / 6.273e+6,

			(UnitOfArea.Hectare, UnitOfArea.Square_Kilometre) => val / 100,
			(UnitOfArea.Hectare, UnitOfArea.Square_Metre) => val * 10000,
			(UnitOfArea.Hectare, UnitOfArea.Square_Mile) => val / 259,
			(UnitOfArea.Hectare, UnitOfArea.Square_Yard) => val * 11960,
			(UnitOfArea.Hectare, UnitOfArea.Square_Foot) => val * 107600,
			(UnitOfArea.Hectare, UnitOfArea.Square_Inch) => val * 1.55e+7,
			(UnitOfArea.Hectare, UnitOfArea.Acre) => val * 2.471,

			(UnitOfArea.Acre, UnitOfArea.Square_Kilometre) => val / 247.1,
			(UnitOfArea.Acre, UnitOfArea.Square_Metre) => val * 4047,
			(UnitOfArea.Acre, UnitOfArea.Square_Mile) => val / 640,
			(UnitOfArea.Acre, UnitOfArea.Square_Yard) => val * 4840,
			(UnitOfArea.Acre, UnitOfArea.Square_Foot) => val * 43560,
			(UnitOfArea.Acre, UnitOfArea.Square_Inch) => val * 6.273e+6,
			(UnitOfArea.Acre, UnitOfArea.Hectare) => val / 2.471,
			_ => 1,
		};
	}
}
