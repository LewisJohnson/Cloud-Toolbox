using CloudToolbox.Common.Enums;

namespace CloudToolbox.Data;

public class Area
{
	private string displayName;

	public string Name { get; set; }
	public string DisplayName { get => string.IsNullOrWhiteSpace(displayName) ? Name : displayName; set => displayName = value; }
	public string CssIcon { get; set; }
	public string Uri { get; set; }
	public AreaTypes Type { get; set; }
	public List<Calculator> Calculators { get; set; }
}
