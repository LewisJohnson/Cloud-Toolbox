using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class DeveloperCalculatorCollection : CalculatorCollection
{
	public DeveloperCalculatorCollection()
	{
		Name = "Developer";
		Type = CalculatorAreaTypes.Developer;
		Uri = Routes.AREA_DEVELOPER;

		CssIcon = "bi bi-code-slash";
		CssAccentColour = "#84fab0";
		CssHeaderBackgroundColour = "linear-gradient(to top, #84fab0 0%, #0d6efd 100%)";
		CssCalulatorHeaderBackgroundColour = "#84fab090";
		CssCalulatorPanelColour = "#84fab040";

		var calcs = new List<DisplayCalculator>();
		var devCalcs = Enumeration.GetAll<DeveloperCalculatorsEnum>();

		foreach (DeveloperCalculatorsEnum calc in devCalcs)
		{
			for (int i = 0; i < 2; i++)
			{
				string dir = i == 0 ? "To" : "From";
				var displayName = $"{dir} {calc.Name}";
				var uri = $"/Toolbox/Developer/{dir}-{calc.UriName}";

				calcs.Add(new DisplayCalculator(this, displayName, uri, calc.Aliases, calc.Abbreviation) { DeveloperType = calc.CalcType });
			}
		}

		Calculators = calcs;
	}

	private List<DisplayCalculator> calculators;
	public override List<DisplayCalculator> Calculators
	{
		get => calculators
			.OrderBy(x => x.DeveloperType)
			.ThenBy(x => x.DisplayName)
			.ToList();

		protected set => calculators = value;
	}
}
