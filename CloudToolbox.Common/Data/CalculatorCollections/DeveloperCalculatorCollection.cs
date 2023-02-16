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
		CssHeaderBackgroundColour = "linear-gradient(to top, #84fab0 0%, #8fd3f4 100%)";
		CssCalulatorHeaderBackgroundColour = "#84fab0";
		CssCalulatorPanelColour = "#84fab03d";

		var calcs = new List<DisplayCalculator>();
		var devCalcs = Enumeration.GetAll<DeveloperCalculatorsEnum>();

		foreach (DeveloperCalculatorsEnum calc in devCalcs)
		{
			for (int i = 0; i < 2; i++)
			{
				string dir = i == 0 ? "To" : "From";
				var displayName = $"{dir} {calc.Name}";
				var uri = $"/Toolbox/Developer/{dir}-{calc.UriName}";

				calcs.Add(new DisplayCalculator(this, displayName, uri, new() { }, calc.Abbreviation) { DeveloperType = calc.DevCalcType });
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
