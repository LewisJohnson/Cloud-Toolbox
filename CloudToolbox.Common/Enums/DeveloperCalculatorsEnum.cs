using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums
{
	public class DeveloperCalculatorsEnum : BaseCalculatorEnumeration<DeveloperCalculatorType>
	{

		// Area
		public static DeveloperCalculatorsEnum Binary = new(1, nameof(Binary), nameof(Binary), new() { }, null, DeveloperCalculatorType.Binary);
		public static DeveloperCalculatorsEnum Hexadecimal = new(2, nameof(Hexadecimal), nameof(Hexadecimal), new() { "Hex" }, null, DeveloperCalculatorType.Hexadecimal);
		public static DeveloperCalculatorsEnum Base64 = new(3, nameof(Base64), nameof(Base64), new() { }, null, DeveloperCalculatorType.Base64);

		public DeveloperCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, DeveloperCalculatorType type) : base(id, name, abbreviation, aliases, unit, type)
		{
		}

		public static DeveloperCalculatorsEnum? MatchFromUri(string term)
		{
			term = term.ToLower();

			return
				typeof(DeveloperCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(DeveloperCalculatorsEnum))
				.Select(x => (DeveloperCalculatorsEnum)x.GetValue(null))
				.First(x =>
					x.UriName.ToLower() == term
				);

		}
	}
}
