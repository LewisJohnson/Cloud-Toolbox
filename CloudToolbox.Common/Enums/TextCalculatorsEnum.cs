using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums
{
	public class TextCalculatorsEnum : BaseCalculatorEnumeration<TextCalculatorType>
	{

		// Area
		public static TextCalculatorsEnum TitleCase = new(1, "Title case", TextCalculatorType.Title_Case);
		public static TextCalculatorsEnum UpperCase = new(2, "Upper case", TextCalculatorType.Upper_Case);
		public static TextCalculatorsEnum LowerCase = new(3, "Lower case", TextCalculatorType.Lower_Case);
		public static TextCalculatorsEnum RandomCase = new(4,"Random case", TextCalculatorType.Random_Case);

		public TextCalculatorsEnum(int id, string name, TextCalculatorType type) : base(id, name, type)
		{
		}

		public static TextCalculatorsEnum? MatchFromUri(string term)
		{
			term = term.ToLower();

			return
				typeof(TextCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(TextCalculatorsEnum))
				.Select(x => (TextCalculatorsEnum)x.GetValue(null))
				.FirstOrDefault(x =>
					x.UriName.ToLower() == term
				);

		}
	}
}
