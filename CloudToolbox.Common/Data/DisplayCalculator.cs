using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data;

public class DisplayCalculator
{
	public DisplayCalculator(CalculatorCollection collection)
	{
		Collection = collection;
		Aliases ??= new List<string>();
	}

	public DisplayCalculator(CalculatorCollection collection, string displayName, string uri) : this(collection)
	{
		DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
		Uri = uri ?? throw new ArgumentNullException(nameof(uri));
	}

	public DisplayCalculator(CalculatorCollection collection, string displayName, string uri, List<string> aliases) : this(collection, displayName, uri)
	{
		Aliases = aliases ?? throw new ArgumentNullException(nameof(aliases));
	}

	public DisplayCalculator(CalculatorCollection collection, string displayName, string abbreviation, List<string> aliases, UnitTypes unitType, object unitValue) : this(collection, displayName, abbreviation, aliases)
	{
		UnitType = unitType;
		UnitValue = unitValue ?? throw new ArgumentNullException(nameof(unitValue));
	}

	public string DisplayName { get; set; }
	public List<string> Aliases { get; set; }
	public string Uri { get; set; }
	public CalculatorCollection Collection { get; set; }

	public string Abbreviation { get; }
	public object UnitValue { get; }
	public UnitTypes UnitType { get; }
}
