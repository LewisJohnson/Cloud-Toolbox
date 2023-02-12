using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class UnitsCalculatorCollection : CalculatorCollection
{
	public UnitsCalculatorCollection()
	{
		Name = "Units";
		DisplayName = "Units";
		CssIcon = "bi bi-graph-up";
		Type = CalculatorAreaTypes.Units;
		Uri = Routes.AREA_UNITS;

		Calculators = new()
		{
			new DisplayCalculator(this, "Kilometre", "km", new() { "Kilometer" }, UnitTypes.Length, UnitOfLength.Kilometre),
			new DisplayCalculator(this, "Metre", "m", new() { "Meter" }, UnitTypes.Length, UnitOfLength.Metre),
			new DisplayCalculator(this, "Centimetre", "cm", new() { "Centimeter" }, UnitTypes.Length, UnitOfLength.Centimetre),
			new DisplayCalculator(this, "Millimetre", "mm", new() { "Millimeter" }, UnitTypes.Length, UnitOfLength.Millimetre),
			new DisplayCalculator(this, "Mile", "mi", new() { }, UnitTypes.Length, UnitOfLength.Mile),
			new DisplayCalculator(this, "Yard", "yd", new() { }, UnitTypes.Length, UnitOfLength.Yard),
			new DisplayCalculator(this, "Foot", "ft", new() { "Feet" }, UnitTypes.Length, UnitOfLength.Foot),
			new DisplayCalculator(this, "Inch", "in", new() { }, UnitTypes.Length, UnitOfLength.Inch),
		};
	}
}
