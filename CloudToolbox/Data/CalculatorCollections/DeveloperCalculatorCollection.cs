using CloudToolbox.Common.Routes;

namespace CloudToolbox.Data.CalculatorCollections;

public static class DeveloperCalculatorCollection
{
	public static List<Calculator> GetCalculators()
	{
		return new List<Calculator>()
		{
			ToBase64,
			FromBase64,
			ToHex,
			FromHex,
			ToBinary,
			FromBinary
		};
	}

	public static Calculator ToBase64 = new()
	{
		Area = Areas.Developer,
		DisplayName = "To Base64",
		Uri = Routes.DEVELOPER_TO_BASE64
	};

	public static Calculator FromBase64 = new()
	{
		Area = Areas.Developer,
		DisplayName = "From Base64",
		Uri = Routes.DEVELOPER_FROM_BASE64
	};

	public static Calculator ToHex = new()
	{
		Area = Areas.Developer,
		DisplayName = "To Hex",
		Aliases = new() { "Hexadecimal" },
		Uri = Routes.DEVELOPER_TO_HEX
	};

	public static Calculator FromHex = new()
	{
		Area = Areas.Developer,
		DisplayName = "From Hex",
		Aliases = new() { "Hexadecimal" },
		Uri = Routes.DEVELOPER_FROM_HEX
	};

	public static Calculator ToBinary = new()
	{
		Area = Areas.Developer,
		DisplayName = "To Binary",
		Uri = Routes.DEVELOPER_TO_BINARY
	};

	public static Calculator FromBinary = new()
	{
		Area = Areas.Developer,
		DisplayName = "From Binary",
		Uri = Routes.DEVELOPER_FROM_BINARY
	};

}

