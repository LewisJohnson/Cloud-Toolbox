using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data;

public static class CalculatorAreas
{
	public static List<CalculatorCollection> GetAreas()
	{
		return new List<CalculatorCollection>()
		{
			//DateAndTime,
			//Developer,
			//Maths,
			//Text,
			//Travel,
			//Units
		};
	}

	//public static CalculatorCollection DateAndTime = new()
	//{
	//	Name = "DateAndTime",
	//	DisplayName = "Date & Time",
	//	CssIcon = "bi bi-calendar-date",
	//	Type = CalculatorAreaTypes.DateAndTime,
	//	Uri = Routes.AREA_DATE_AND_TIME,
	//	Calculators = DateAndTimeCalculatorCollection.GetCalculators(),
	//};

	//public static CalculatorCollection Developer = new()
	//{
	//	Name = "Developer",
	//	CssIcon = "bi bi-code-slash",
	//	CssAccentColour = "#84fab0",
	//	CssHeaderBackgroundColour = "linear-gradient(to top, #84fab0 0%, #8fd3f4 100%)",
	//	Type = CalculatorAreaTypes.Developer,
	//	Uri = Routes.AREA_DEVELOPER,
	//	Calculators = DeveloperDisplayCalculatorCollection.GetCalculators(),
	//};

	//public static CalculatorCollection Maths = new()
	//{
	//	Name = "Maths",
	//	CssIcon = "bi bi-calculator",
	//	CssAccentColour = "#fff2fb",
	//	CssHeaderBackgroundColour = "linear-gradient(to top, #fbc2eb 0%, #a6c1ee 100%)",
	//	Type = CalculatorAreaTypes.Maths,
	//	Uri = Routes.AREA_MATHS,
	//	Calculators = MathsDisplayCalculatorCollection.GetCalculators(),
	//};

	//public static CalculatorCollection Text = new()
	//{
	//	Name = "Text",
	//	CssIcon = "bi bi-fonts",
	//	Type = CalculatorAreaTypes.Text,
	//	Uri = Routes.AREA_TEXT,
	//	Calculators = TextDisplayCalculatorCollection.GetCalculators(),
	//};

	//public static CalculatorCollection Travel = new()
	//{
	//	Name = "Travel",
	//	CssIcon = "bi bi-globe-europe-africa",
	//	Type = CalculatorAreaTypes.Travel,
	//	Uri = Routes.AREA_TRAVEL,
	//	Calculators = TravelDisplayCalculatorCollection.GetCalculators(),
	//};
}
