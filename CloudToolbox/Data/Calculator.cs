namespace CloudToolbox.Data;

public class Calculator
{
	public Calculator()
	{
		Aliases = new List<string>();
	}

	public string DisplayName { get; set; }
	public List<string> Aliases { get; set; }
	public string Uri { get; set; }
	public Area Area { get; set; }
}
