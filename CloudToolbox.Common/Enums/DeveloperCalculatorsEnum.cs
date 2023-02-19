using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums
{
	public class DeveloperCalculatorsEnum : BaseCalculatorEnumeration<DeveloperCalculatorType>
	{

		// Area
		public static DeveloperCalculatorsEnum Binary = new(1, nameof(Binary), nameof(Binary), new() { }, DeveloperCalculatorType.Binary);
		public static DeveloperCalculatorsEnum Hexadecimal = new(2, nameof(Hexadecimal), nameof(Hexadecimal), new() { "Hex" }, DeveloperCalculatorType.Hexadecimal);
		public static DeveloperCalculatorsEnum Base64 = new(3, nameof(Base64), nameof(Base64), new() { }, DeveloperCalculatorType.Base64);

		public DeveloperCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, DeveloperCalculatorType type) : base(id, name, abbreviation, aliases, null, type)
		{
		}

		public static DeveloperCalculatorsEnum? MatchFromUri(string term)
		{
			term = term.ToLower();

			return
				typeof(DeveloperCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(DeveloperCalculatorsEnum))
				.Where(x => x.GetValue(null) != null)
				.Select(x => x.GetValue(null) as DeveloperCalculatorsEnum)
				.FirstOrDefault(x =>
					x.UriName.ToLower() == term
				);

		}
	}
}
