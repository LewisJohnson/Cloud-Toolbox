using System.Reflection;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data
{
	public abstract class UnitEnumeration : Enumeration
	{
		public string Abbreviation { get; private set; }
		public List<string> Aliases { get; private set; }

		public object Unit { get; private set; }
		public UnitTypes UnitType { get; private set; }

		public string UriName => Name.Replace(' ', '_');

		public UnitEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, UnitTypes unitType) : base(id, name)
		{
			Abbreviation = abbreviation ?? throw new ArgumentNullException(nameof(abbreviation));
			Aliases = aliases ?? new List<string> { };
			Unit = unit;
			UnitType = unitType;
		}
	}
}
