using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class DateAndTimeCalculatorCollection : CalculatorCollection
{
	public DateAndTimeCalculatorCollection()
	{
		Name = "DateAndTime";
		DisplayName = "Date & Time";
		Type = CalculatorAreaTypes.DateAndTime;
		Uri = Routes.AREA_DATE_AND_TIME;

		CssIcon = "bi bi-calendar-date";
		CssAccentColour = "#ed6e3c";
		CssHeaderBackgroundColour = "#ed6e3c";
		CssCalulatorHeaderBackgroundColour = "#ed6e3c";
		CssCalulatorPanelColour = "#ed6e3c38";

		Calculators = new()
		{
			new DisplayCalculator(this, "Duration Between Dates", Routes.DATE_AND_TIME_DURATION_BETWEEN_DATES),
			new DisplayCalculator(this, "Duration Between Times", Routes.DATE_AND_TIME_DURATION_BETWEEN_TIMES),
			new DisplayCalculator(this, "Duration Between Time And Date", Routes.DATE_AND_TIME_DURATION_BETWEEN_TIME_AND_DATE),
		};
	}
}
