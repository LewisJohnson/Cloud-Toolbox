using System.Linq;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class UnitsCalculatorCollection : CalculatorCollection
{
	public UnitsCalculatorCollection()
	{
		Name = "Units";
		DisplayName = "Units";
		Type = CalculatorAreaTypes.Units;
		Uri = Routes.AREA_UNITS;

		CssIcon = "bi bi-graph-up";
		CssAccentColour = "#3cb3ed";
		CssHeaderBackgroundColour = "linear-gradient(to top, #3cb3ed 0%, #0d6efd 100%)";
		CssCalulatorHeaderBackgroundColour = "#3cb3ed90";
		CssCalulatorPanelColour = "#3cb3ed40";

		var calcs = new List<DisplayCalculator>();

		var types = Enum.GetValues(typeof(UnitOf));

		foreach (UnitOf unitType in types)
		{
			var units = Enumeration.GetAll<UnitCalculatorsEnum>()
				.Where(x => x.UnitOf == unitType);

			foreach (var from in units)
			{
				foreach (var to in units)
				{
					if (from != to)
					{
						string displayName = from.Name + " to " + to.Name;
						string uri = "/Toolbox/Units/" + from.UriName + "-to-" + to.UriName;
						string abrv = from.Abbreviation + " to " + to.Abbreviation;
						List<string> aliases = from.Aliases.Concat(to.Aliases).ToList();

						calcs.Add(new DisplayCalculator(this, displayName, uri, aliases, abrv, unitType, from, to));
					}
				}
			}
		}

		Calculators = calcs;
	}
}
