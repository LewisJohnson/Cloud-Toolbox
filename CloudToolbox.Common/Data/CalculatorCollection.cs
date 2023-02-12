using System.ComponentModel;
using System.Linq;
using CloudToolbox.Common.Data.DisplayCalculatorCollections;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data;

public abstract class CalculatorCollection
{
	private string displayName;
	private List<DisplayCalculator> calculators;

	public string Name { get; protected set; }
	public string DisplayName
	{
		get => string.IsNullOrWhiteSpace(displayName) ? Name : displayName;
		set => displayName = value;
	}

	public string Uri { get; protected set; }
	public CalculatorAreaTypes Type { get; protected set; }
	public CalculatorAreaSubTypes SubType { get; protected set; }
	public List<DisplayCalculator> Calculators
	{
		get => calculators
			.OrderBy(x => x.UnitType)
			.ThenBy(x => x.DisplayName)
			.ToList();

		protected set => calculators = value;
	}

	public string CssIcon { get; protected set; }
	public string CssAccentColour { get; protected set; }
	public string CssHeaderBackgroundColour { get; protected set; }
	public string CssCalulatorHeaderBackgroundColour { get; protected set; }
	public string CssCalulatorPanelColour { get; protected set; }

	public DisplayCalculator? MatchParamToCalculator(string input)
	{

		input = input.ToLower();

		try
		{
			return Calculators.FirstOrDefault(x =>
				x.DisplayName.ToLower() == input ||
				x.Abbreviation.ToLower() == input ||
				x.Aliases.Any(x => x.ToLower() == input));
		}
		catch (Exception e)
		{

		}

		return null;
	}

	public List<DisplayCalculator> Search(string searchTerm)
	{
		return Calculators.Where(x => 
				x.DisplayName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
				x.Abbreviation.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) || 
				x.Aliases.Any(x => x.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
			)
			.OrderBy(x => x.UnitType)
			.ThenBy(x => x.DisplayName)
			.ToList();
	}

	public CalculatorCollection()
	{
		CssAccentColour = "#cdd8d5";
		CssHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorPanelColour = "#cdd8d5";
		Calculators = new List<DisplayCalculator>();
	}
}
