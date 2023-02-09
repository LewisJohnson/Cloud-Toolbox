namespace CloudToolbox.Data;

public class DisplayCalculator
{
	public DisplayCalculator()
	{
		Aliases = new List<string>();
	}

	public DisplayCalculator(Area area)
	{
		Area = area;
		Aliases = new List<string>();
	}

	public string DisplayName { get; set; }
	public List<string> Aliases { get; set; }
	public string Uri { get; set; }
	public Area Area { get; set; }
}
