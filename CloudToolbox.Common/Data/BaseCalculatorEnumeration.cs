namespace CloudToolbox.Common.Data
{
	public abstract class BaseCalculatorEnumeration : Enumeration
	{
		public string Abbreviation { get; private set; }
		public List<string> Aliases { get; private set; }
		public object Unit { get; private set; }
		public string UriName => Name.Replace(' ', '_');

		public BaseCalculatorEnumeration(int id, string name, string abbreviation, List<string> aliases, object unit) : base(id, name)
		{
			Abbreviation = abbreviation ?? throw new ArgumentNullException(nameof(abbreviation));
			Aliases = aliases ?? new List<string> { };
			Unit = unit;
		}
	}
}
