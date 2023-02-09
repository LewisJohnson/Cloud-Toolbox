using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Routes;
using CloudToolbox.Data.CalculatorCollections;

namespace CloudToolbox.Data;

public static class Areas
{

	public static List<Area> GetAreas()
	{
		return new List<Area>()
		{
			DateAndTime,
			Developer,
			Maths,
			Text,
			Travel,
			Units
		};
	}

	public static Area DateAndTime = new()
	{
		Name = "DateAndTime",
		DisplayName = "Date & Time",
		CssIcon = "bi bi-calendar-date",
		Type = AreaTypes.DateAndTime,
		Uri = Routes.AREA_DATE_AND_TIME,
		Calculators = DateAndTimeCalculatorCollection.GetCalculators(),
	};

	public static Area Developer = new()
	{
		Name = "Developer",
		CssIcon = "bi bi-code-slash",
		CssAccentColour = "#84fab0",
		CssHeaderBackgroundColour = "linear-gradient(to top, #84fab0 0%, #8fd3f4 100%)",
		Type = AreaTypes.Developer,
		Uri = Routes.AREA_DEVELOPER,
		Calculators = DeveloperCalculatorCollection.GetCalculators(),
	};

	public static Area Maths = new()
	{
		Name = "Maths",
		CssIcon = "bi bi-calculator",
		CssAccentColour = "#fff2fb",
		CssHeaderBackgroundColour = "linear-gradient(to top, #fbc2eb 0%, #a6c1ee 100%)",
		Type = AreaTypes.Maths,
		Uri = Routes.AREA_MATHS,
		Calculators = MathsCalculatorCollection.GetCalculators(),
	};

	public static Area Text = new()
	{
		Name = "Text",
		CssIcon = "bi bi-fonts",
		Type = AreaTypes.Text,
		Uri = Routes.AREA_TEXT,
		Calculators = TextCalculatorCollection.GetCalculators(),
	};

	public static Area Travel = new()
	{
		Name = "Travel",
		CssIcon = "bi bi-globe-europe-africa",
		Type = AreaTypes.Travel,
		Uri = Routes.AREA_TRAVEL,
		Calculators = TravelCalculatorCollection.GetCalculators(),
	};

	public static Area Units = new()
	{
		Name = "Units",
		CssIcon = "bi bi-graph-up",
		Type = AreaTypes.Units,
		Uri = Routes.AREA_UNITS,
		Calculators = UnitsCalculatorCollection.GetCalculators(),
	};
}
