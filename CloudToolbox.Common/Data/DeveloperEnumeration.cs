using System.Reflection;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data
{
	public abstract class DeveloperEnumeration : BaseCalculatorEnumeration
	{
		public DeveloperCalculatorType DevCalcType { get; private set; }

		public DeveloperEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit, DeveloperCalculatorType unitType) : base(id, name, abbreviation, aliases, unit)
		{
			DevCalcType = unitType;
		}
	}
}
