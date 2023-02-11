using CloudToolbox.Common.Data.DisplayCalculatorCollections;
using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Data;

public abstract class CalculatorCollection
{
	private string displayName;

	public string Name { get; protected set; }
	public string DisplayName
	{
		get => string.IsNullOrWhiteSpace(displayName) ? Name : displayName;
		set => displayName = value;
	}

	public string Uri { get; protected set; }
	public CalculatorAreaTypes Type { get; protected set; }
	public CalculatorAreaSubTypes SubType { get; protected set; }
	public List<DisplayCalculator> Calculators { get; protected set; }

	public string CssIcon { get; protected set; }
	public string CssAccentColour { get; protected set; }
	public string CssHeaderBackgroundColour { get; protected set; }
	public string CssCalulatorHeaderBackgroundColour { get; protected set; }
	public string CssCalulatorPanelColour { get; protected set; }

	public CalculatorCollection()
	{
		CssAccentColour = "#cdd8d5";
		CssHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorPanelColour = "#cdd8d5";
		Calculators = new List<DisplayCalculator>();
	}
}
