using CloudToolbox.Common.Enums;

namespace CloudToolbox.Data;

public class CalculatorArea
{
	private string displayName;

	public string Name { get; set; }
	public string DisplayName
	{
		get => string.IsNullOrWhiteSpace(displayName) ? Name : displayName;
		set => displayName = value;
	}

	public string Uri { get; set; }
	public CalculatorAreaTypes Type { get; set; }
	public CalculatorAreaTypes SubType { get; set; }
	public List<DisplayCalculator> Calculators { get; set; }

	public string CssIcon { get; set; }
	public string CssAccentColour { get; set; }
	public string CssHeaderBackgroundColour { get; set; }
	public string CssCalulatorHeaderBackgroundColour { get; set; }
	public string CssCalulatorPanelColour { get; set; }

	public CalculatorArea()
	{
		CssAccentColour = "#cdd8d5";
		CssHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorPanelColour = "#cdd8d5";
	}
}
