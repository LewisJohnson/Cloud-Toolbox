using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Helpers
{
	public static class UnitsHelper
	{

		public static Type GetUnitTypeValues(UnitTypes type) => type switch
		{
			UnitTypes.Speed => typeof(UnitOfSpeed),
			UnitTypes.Area => typeof(UnitOfArea),
			UnitTypes.Length => typeof(UnitOfLength),
			UnitTypes.Mass => typeof(UnitOfMass),
			UnitTypes.Time => typeof(UnitOfTime),
			_ => throw new NotImplementedException(),
		};
	}
}
//	new DisplayCalculator(this, "Kilometre", "km", new() { "Kilometer" }, UnitTypes.Length, UnitOfLength.Kilometre),
//	new DisplayCalculator(this, "Metre", "m", new() { "Meter" }, UnitTypes.Length, UnitOfLength.Metre),
//	new DisplayCalculator(this, "Centimetre", "cm", new() { "Centimeter" }, UnitTypes.Length, UnitOfLength.Centimetre),
//	new DisplayCalculator(this, "Millimetre", "mm", new() { "Millimeter" }, UnitTypes.Length, UnitOfLength.Millimetre),
//	new DisplayCalculator(this, "Mile", "mi", new() { }, UnitTypes.Length, UnitOfLength.Mile),
//	new DisplayCalculator(this, "Yard", "yd", new() { }, UnitTypes.Length, UnitOfLength.Yard),
//	new DisplayCalculator(this, "Foot", "ft", new() { "Feet" }, UnitTypes.Length, UnitOfLength.Foot),
//	new DisplayCalculator(this, "Inch", "in", new() { }, UnitTypes.Length, UnitOfLength.Inch),
