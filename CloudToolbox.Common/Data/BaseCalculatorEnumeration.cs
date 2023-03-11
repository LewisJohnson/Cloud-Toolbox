namespace CloudToolbox.Common.Data
{
	public abstract class BaseCalculatorEnumeration<T> : Enumeration
	{
		public string Abbreviation { get; private set; }
		public string AbbreviationInBrackets => string.IsNullOrWhiteSpace(Abbreviation) ? string.Empty : $"({Abbreviation})";
		public List<string> Aliases { get; private set; }
		public object? Unit { get; private set; }
		public string UriName => Name.Replace(' ', '_');
		public T CalcType { get; private set; }

		public BaseCalculatorEnumeration(int id, string name, string abbreviation, List<string> aliases, object? unit, T type) : base(id, name)
		{
			Abbreviation = abbreviation ?? throw new ArgumentNullException(nameof(abbreviation));
			Aliases = aliases ?? new List<string> { };
			Unit = unit;
			CalcType = type;
		}

		public BaseCalculatorEnumeration(int id, string name, T type) : base(id, name)
		{
			Abbreviation = name;
			Aliases = new List<string> { };
			CalcType = type;
		}
	}
}
