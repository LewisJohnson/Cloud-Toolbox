using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Routes;

namespace CloudToolbox.Common.Data.DisplayCalculatorCollections;

public class DeveloperDisplayCalculatorCollection : CalculatorCollection
{
	//private static CalculatorCollection Collection { get; } = CalculatorAreas.Developer;

	//public static List<ResultDisplayCalculator> GetCalculators()
	//{
	//	List<ResultDisplayCalculator> calculators =
	//		typeof(DeveloperDisplayCalculatorCollection)
	//		.GetFields(BindingFlags.Static | BindingFlags.Public)
	//		.Where(x => x.FieldType == typeof(ResultDisplayCalculator))
	//		.Select(x => (ResultDisplayCalculator)x.GetValue(null))
	//		.ToList();

	//	return calculators;
	//}

	//public static ResultDisplayCalculator ToBase64 = new(Collection)
	//{
	//	DisplayName = "To Base64",
	//	Uri = Routes.DEVELOPER_TO_BASE64
	//};

	//public static ResultDisplayCalculator FromBase64 = new(Collection)
	//{
	//	DisplayName = "From Base64",
	//	Uri = Routes.DEVELOPER_FROM_BASE64
	//};

	//public static ResultDisplayCalculator ToHex = new(Collection)
	//{
	//	DisplayName = "To Hex",
	//	Aliases = new() { "Hexadecimal" },
	//	Uri = Routes.DEVELOPER_TO_HEX
	//};

	//public static ResultDisplayCalculator FromHex = new(Collection)
	//{
	//	DisplayName = "From Hex",
	//	Aliases = new() { "Hexadecimal" },
	//	Uri = Routes.DEVELOPER_FROM_HEX
	//};

	//public static ResultDisplayCalculator ToBinary = new(Collection)
	//{
	//	DisplayName = "To Binary",
	//	Uri = Routes.DEVELOPER_TO_BINARY
	//};

	//public static ResultDisplayCalculator FromBinary = new(Collection)
	//{
	//	DisplayName = "From Binary",
	//	Uri = Routes.DEVELOPER_FROM_BINARY
	//};

}

