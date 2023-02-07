namespace CloudToolbox.Data;

public static class Calculators
{
	public static List<Calculator> GetCalculators()
	{
		return Areas.GetAreas().SelectMany(x => x.Calculators).ToList();
	}
}
