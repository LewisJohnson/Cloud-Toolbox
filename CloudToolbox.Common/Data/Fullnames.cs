using System.Diagnostics.Metrics;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Data;

public static class Fullnames
{
	public static Dictionary<UnitOfLength, string> UNIT_OF_LENGTH = new Dictionary<UnitOfLength, string>()
	{
		{ UnitOfLength.Kilometre, "Kilometre" },
		{ UnitOfLength.Metre, "Metre" },
		{ UnitOfLength.Centimetre, "Centimetre" },
		{ UnitOfLength.Millimetre, "Millimetre" },
		{ UnitOfLength.Mile, "Mile" },
		{ UnitOfLength.Yard, "Yard" },
		{ UnitOfLength.Foot, "Foot" },
		{ UnitOfLength.Inch, "Inch" },
	};

	public static Dictionary<UnitOfMass, string> UNIT_OF_MASS = new Dictionary<UnitOfMass, string>()
	{
		{ UnitOfMass.Kilogram, "kg" },
		{ UnitOfMass.Stone, "st" },
		{ UnitOfMass.Pound, "lbs" },
		{ UnitOfMass.Tonne, "t" },
		{ UnitOfMass.Gram, "g" },
		{ UnitOfMass.Ounce, "oz" },
	};

	public static Dictionary<UnitOfSpeed, string> UNIT_OF_SPEED = new Dictionary<UnitOfSpeed, string>()
	{
		{ UnitOfSpeed.Mile_Per_Hour, "mph"},
		{ UnitOfSpeed.Kilometre_Per_Hour, "km/h"},
		{ UnitOfSpeed.Foot_Per_Second, "ft/sec"},
		{ UnitOfSpeed.Metre_Per_Second, "m/sec"},
		{ UnitOfSpeed.Knot, "kn" },
	};
}
