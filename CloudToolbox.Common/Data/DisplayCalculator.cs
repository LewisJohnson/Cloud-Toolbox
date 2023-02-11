using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data;

public class DisplayCalculator
{
	public DisplayCalculator(CalculatorCollection collection)
	{
		Collection = collection;
		Aliases ??= new List<string>();
	}


	public DisplayCalculator(CalculatorCollection collection, string displayName, string abbreviation, List<string> aliases, UnitTypes unitType, object unitValue) : this(collection)
	{
		DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
		Abbreviation = abbreviation ?? throw new ArgumentNullException(nameof(abbreviation));
		Aliases = aliases ?? new List<string>();
		UnitType = unitType;
		UnitValue = unitValue;
	}

	public string DisplayName { get; set; }
	public List<string> Aliases { get; set; }
	public string Uri { get; set; }
	public CalculatorCollection Collection { get; set; }

	public string Abbreviation { get; }
	public object UnitValue { get; }
	public UnitTypes UnitType { get; }
}
