using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class TextCalculatorCollection
{
	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			ToLowerCase,
			ToUpperCase,
			ToTitleCase,
		};
	}


	public static Calculator ToLowerCase = new()
	{
		Area = Areas.Text,
		DisplayName = "To Lower Case",
		Uri = Routes.TEXT_TO_LOWER_CASE
	};

	public static Calculator ToUpperCase = new()
	{
		Area = Areas.Text,
		DisplayName = "To Upper Case",
		Uri = Routes.TEXT_TO_UPPER_CASE
	};

	public static Calculator ToTitleCase = new()
	{
		Area = Areas.Text,
		DisplayName = "To Title Case",
		Uri = Routes.TEXT_TO_TITLE_CASE
	};
}

