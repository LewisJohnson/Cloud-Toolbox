using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data
{
	public abstract class UnitEnumeration : BaseCalculatorEnumeration
	{
		public UnitTypes UnitType { get; private set; }

		public UnitEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, UnitTypes unitType) : base(id, name, abbreviation, aliases, unit)
		{
			UnitType = unitType;
		}
	}
}
