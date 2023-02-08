using CloudToolbox.Common.Enums;

namespace CloudToolbox.Data;

public class Area
{
	private string displayName;

	public string Name { get; set; }
	public string DisplayName
	{
		get => string.IsNullOrWhiteSpace(displayName) ? Name : displayName;
		set => displayName = value;
	}

	public string Uri { get; set; }
	public AreaTypes Type { get; set; }
	public List<Calculator> Calculators { get; set; }

	public string CssIcon { get; set; }
	public string CssAccentColour { get; set; }
	public string CssHeaderBackgroundColour { get; set; }
	public string CssCalulatorHeaderBackgroundColour { get; set; }
	public string CssCalulatorPanelColour { get; set; }

	public Area()
	{
		CssAccentColour = "#cdd8d5";
		CssHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorHeaderBackgroundColour = "#cdd8d5";
		CssCalulatorPanelColour = "#cdd8d5";
	}
}
