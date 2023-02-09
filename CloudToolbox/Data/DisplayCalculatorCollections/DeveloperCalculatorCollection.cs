using System.Reflection;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.DisplayCalculatorCollections;

public static class DeveloperCalculatorCollection
{
	private static CalculatorArea Area { get; } = CalculatorAreas.Developer;

	public static List<DisplayCalculator> GetCalculators()
	{
		List<DisplayCalculator> calculators =
			typeof(DeveloperCalculatorCollection)
			.GetFields(BindingFlags.Static | BindingFlags.Public)
			.Where(x => x.FieldType == typeof(DisplayCalculator))
			.Select(x => (DisplayCalculator)x.GetValue(null))
			.ToList();

		return calculators;
	}

	public static DisplayCalculator ToBase64 = new(Area)
	{
		DisplayName = "To Base64",
		Uri = Routes.DEVELOPER_TO_BASE64
	};

	public static DisplayCalculator FromBase64 = new(Area)
	{
		DisplayName = "From Base64",
		Uri = Routes.DEVELOPER_FROM_BASE64
	};

	public static DisplayCalculator ToHex = new(Area)
	{
		DisplayName = "To Hex",
		Aliases = new() { "Hexadecimal" },
		Uri = Routes.DEVELOPER_TO_HEX
	};

	public static DisplayCalculator FromHex = new(Area)
	{
		DisplayName = "From Hex",
		Aliases = new() { "Hexadecimal" },
		Uri = Routes.DEVELOPER_FROM_HEX
	};

	public static DisplayCalculator ToBinary = new(Area)
	{
		DisplayName = "To Binary",
		Uri = Routes.DEVELOPER_TO_BINARY
	};

	public static DisplayCalculator FromBinary = new(Area)
	{
		DisplayName = "From Binary",
		Uri = Routes.DEVELOPER_FROM_BINARY
	};

}

