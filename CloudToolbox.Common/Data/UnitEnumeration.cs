using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data
{
	public abstract class UnitEnumeration : BaseCalculatorEnumeration<string>
	{
		public string? AmericanEnglishSpelling { get; private set; }
		public string? PluralSpelling { get; private set; }
		public UnitOf UnitOf { get; private set; }
		public UnitSystem UnitSystem { get; private set; }

		public UnitEnumeration(int id, string name, string? americanEnglishSpelling, string? plural, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem, string insightText) : base(id, name, abbreviation, aliases, unit, "", insightText, null)
		{
			UnitOf = unitOf;
			UnitSystem = unitSystem;
			AmericanEnglishSpelling = americanEnglishSpelling;
			PluralSpelling = plural;
		}

		public UnitEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem, string insightText, string insightLinkOverride) : base(id, name, abbreviation, aliases, unit, "", insightText, insightLinkOverride)
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
