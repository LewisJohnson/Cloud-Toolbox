using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data;

public class DisplayCalculator
{
	public DisplayCalculator(CalculatorCollection collection)
	{
		Collection = collection;
		Aliases ??= new List<string>();
	}

	public DisplayCalculator(CalculatorCollection collection, string displayName, string uri, List<string> aliases = null, string abbreviation = "", UnitTypes? unitType = null, object? fromType = null, object? toType = null) : 
		this(collection)
	{
		DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
		Uri = uri ?? throw new ArgumentNullException(nameof(uri));
		Aliases = aliases ?? new List<string>();
		Abbreviation = abbreviation;
		UnitType = unitType;
		FromType = fromType;
		ToType = toType;
	}

	public string DisplayName { get; set; }
	public List<string> Aliases { get; set; }
	public string Uri { get; set; }
	public CalculatorCollection Collection { get; set; }

	public string Abbreviation { get; }
	public object FromType { get; }
	public object ToType { get; }
	public UnitTypes? UnitType { get; }
}
