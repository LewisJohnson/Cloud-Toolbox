using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public static class TextCalculatorCollection
{
	private static Area Area { get; } = Areas.Text;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(TextCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}


	public static DisplayCalculator ToLowerCase = new(Area)
	{
		DisplayName = "To Lower Case",
		Uri = Routes.TEXT_TO_LOWER_CASE
	};

	public static DisplayCalculator ToUpperCase = new(Area)
	{
		DisplayName = "To Upper Case",
		Uri = Routes.TEXT_TO_UPPER_CASE
	};

	public static DisplayCalculator ToTitleCase = new(Area)
	{
		DisplayName = "To Title Case",
		Uri = Routes.TEXT_TO_TITLE_CASE
	};
}

