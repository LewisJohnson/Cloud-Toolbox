using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data
{
	public abstract class UnitEnumeration : BaseCalculatorEnumeration<string>
	{
		public UnitOf UnitOf { get; private set; }
		public UnitSystem UnitSystem { get; private set; }

		public UnitEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem) : base(id, name, abbreviation, aliases, unit, "")
		{
			UnitOf = unitOf;
			UnitSystem = unitSystem;
		}

		public UnitEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf) : base(id, name, abbreviation, aliases, unit, "")
		{
			UnitOf = unitOf;
		}
	}
}
