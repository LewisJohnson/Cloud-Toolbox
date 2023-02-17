using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums.Units
{
	public class UnitCalculatorsEnum : UnitEnumeration
	{

		// Area
		public static UnitCalculatorsEnum SquareKilometer = new(1, "Square Kilometre", "km²", new() { "Square Kilometer" }, UnitOfArea.Square_Kilometre, UnitTypes.Area);
		public static UnitCalculatorsEnum SquareMeter = new(2, "Square Metre", "m²", new() { "Square Meter" }, UnitOfArea.Square_Metre, UnitTypes.Area);
		public static UnitCalculatorsEnum SquareMile = new(3, "Square Mile", "sq mi", new() { "mi²" }, UnitOfArea.Square_Mile, UnitTypes.Area);
		public static UnitCalculatorsEnum SquareYard = new(4, "Square Yard", "sq yard", new() { }, UnitOfArea.Square_Yard, UnitTypes.Area);
		public static UnitCalculatorsEnum SquareFoot = new(5, "Square Foot", "sq. ft", new() { "sq. ft", "sf" }, UnitOfArea.Square_Foot, UnitTypes.Area);
		public static UnitCalculatorsEnum SquareInch = new(6, "Square Inch", "sq inch", new() { }, UnitOfArea.Square_Inch, UnitTypes.Area);
		public static UnitCalculatorsEnum Hectare = new(7, nameof(Hectare), "ha", new() { }, UnitOfArea.Hectare, UnitTypes.Area);
		public static UnitCalculatorsEnum Acre = new(8, nameof(Acre), "acre", new() { "ac" }, UnitOfArea.Acre, UnitTypes.Area);

		// Data Transfer
		public static UnitCalculatorsEnum BitPerSecond = new(9, "Bit Per Second", "bit/s", new() { }, UnitOfDataTranser.Bit_Per_Second, UnitTypes.DataTransfer);

		public static UnitCalculatorsEnum KilobitPerSecond = new(10, "Kilobit Per Second", "kb/s", new() { "kbit/s", "kbps" }, UnitOfDataTranser.Kilobit_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum KilobytePerSecond = new(11, "Kilobyte Per Second", "KB/s", new() { "kBps" }, UnitOfDataTranser.Kilobyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum KibibitPerSecond = new(12, "Kibibit Per Second", "Kibit/s", new() { }, UnitOfDataTranser.Kibibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitCalculatorsEnum MegabitPerSecond = new(13, "Megabit Per Second", "Mbit/s", new() { "Mbit/s", "Mbps" }, UnitOfDataTranser.Megabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum MegabytePerSecond = new(14, "Megabyte Per Second", "MB/s", new() { "MBps" }, UnitOfDataTranser.Megabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum MebibitPerSecond = new(15, "Mebibit Per Second", "Mibit/s", new() { }, UnitOfDataTranser.Mebibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitCalculatorsEnum GigabitPerSecond = new(16, "Gigabit Per Second", "Gbit/s", new() { "Gbit/s", "Gbps" }, UnitOfDataTranser.Gigabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum GigabytePerSecond = new(17, "Gigabyte Per Second", "GB/s", new() { "GBps" }, UnitOfDataTranser.Gigabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum GibibitPerSecond = new(18, "Gibibit Per Second", "Gibit/s", new() { }, UnitOfDataTranser.Gibibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitCalculatorsEnum TerabitPerSecond = new(19, "Terabit Per Second", "Tbit/s", new() { "Tbit/s", "Tbps" }, UnitOfDataTranser.Terabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum TerabytePerSecond = new(20, "Terabyte Per Second", "TB/s", new() { "TBps" }, UnitOfDataTranser.Terabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitCalculatorsEnum TebibitPerSecond = new(21, "Tebibit Per Second", "Tibit/s", new() { }, UnitOfDataTranser.Tebibit_Per_Second, UnitTypes.DataTransfer);

		// Energy
		public static UnitCalculatorsEnum Joule = new(22, nameof(Joule), "J", new() { }, UnitOfEnergy.Joule, UnitTypes.Energy);
		public static UnitCalculatorsEnum Kilojoule = new(23, nameof(Kilojoule), "KJ", new() { }, UnitOfEnergy.Kilojoule, UnitTypes.Energy);
		public static UnitCalculatorsEnum Gramcalorie = new(24, "Calorie", "Cal", new() { "Gramcalorie" }, UnitOfEnergy.Gramcalorie, UnitTypes.Energy);
		public static UnitCalculatorsEnum Kilocalorie = new(25, "Kcal", "Kcal", new() { "Kilocalorie" }, UnitOfEnergy.Kilocalorie, UnitTypes.Energy);
		public static UnitCalculatorsEnum WattHour = new(26, "Watt Hour", "Wh", new() { }, UnitOfEnergy.Watt_Hour, UnitTypes.Energy);
		public static UnitCalculatorsEnum Kilowatt_Hour = new(27, "Kilowatt Hour", "kWh", new() { }, UnitOfEnergy.Kilowatt_Hour, UnitTypes.Energy);
		public static UnitCalculatorsEnum Electronvolt = new(28, nameof(Electronvolt), "eV", new() { }, UnitOfEnergy.Electronvolt, UnitTypes.Energy);
		public static UnitCalculatorsEnum BritishThermalUnit = new(29, "British Thermal Unit", "BTU", new() { }, UnitOfEnergy.British_Thermal_Unit, UnitTypes.Energy);
		public static UnitCalculatorsEnum USTherm = new(30, "US Therm", "US Therm", new() { }, UnitOfEnergy.US_Therm, UnitTypes.Energy);
		public static UnitCalculatorsEnum FootPound = new(31, "Foot Pound", "ft⋅lb", new() { }, UnitOfEnergy.Foot_Pound, UnitTypes.Energy);

		// Length
		public static UnitCalculatorsEnum Kilometre = new(32, nameof(Kilometre), "km", new() { "Kilometer" }, UnitOfLength.Kilometre, UnitTypes.Length);
		public static UnitCalculatorsEnum Metre = new(33, nameof(Metre), "m", new() { "Meter" }, UnitOfLength.Metre, UnitTypes.Length);
		public static UnitCalculatorsEnum Centimetre = new(34, nameof(Centimetre), "cm", new() { "Centimeter" }, UnitOfLength.Centimetre, UnitTypes.Length);
		public static UnitCalculatorsEnum Millimetre = new(35, nameof(Millimetre), "mm", new() { "Millimeter" }, UnitOfLength.Millimetre, UnitTypes.Length);
		public static UnitCalculatorsEnum Mile = new(36, nameof(Mile), "mi", new() { }, UnitOfLength.Mile, UnitTypes.Length);
		public static UnitCalculatorsEnum Yard = new(37, nameof(Yard), "yd", new() { }, UnitOfLength.Yard, UnitTypes.Length);
		public static UnitCalculatorsEnum Foot = new(38, nameof(Foot), "ft", new() { "Feet" }, UnitOfLength.Foot, UnitTypes.Length);
		public static UnitCalculatorsEnum Inch = new(39, nameof(Inch), "in", new() { }, UnitOfLength.Inch, UnitTypes.Length);

		// Mass
		public static UnitCalculatorsEnum Kilogram = new(40, nameof(Kilogram), "kg", new() { }, UnitOfMass.Kilogram, UnitTypes.Mass);
		public static UnitCalculatorsEnum Stone = new(41, nameof(Stone), "st", new() { }, UnitOfMass.Stone, UnitTypes.Mass);
		public static UnitCalculatorsEnum Pound = new(42, nameof(Pound), "lbs", new() { }, UnitOfMass.Pound, UnitTypes.Mass);
		public static UnitCalculatorsEnum Tonne = new(43, nameof(Tonne), "t", new() { }, UnitOfMass.Tonne, UnitTypes.Mass);
		public static UnitCalculatorsEnum Gram = new(44, nameof(Gram), "g", new() { }, UnitOfMass.Gram, UnitTypes.Mass);
		public static UnitCalculatorsEnum Ounce = new(45, nameof(Ounce), "oz", new() { }, UnitOfMass.Ounce, UnitTypes.Mass);

		// Time
		public static UnitCalculatorsEnum Nanosecond = new(46, nameof(Nanosecond), "ns", new() { }, UnitOfTime.Nanosecond, UnitTypes.Time);
		public static UnitCalculatorsEnum Microsecond = new(47, nameof(Microsecond), "μs", new() { }, UnitOfTime.Microsecond, UnitTypes.Time);
		public static UnitCalculatorsEnum Millisecond = new(48, nameof(Millisecond), "ms", new() { }, UnitOfTime.Millisecond, UnitTypes.Time);
		public static UnitCalculatorsEnum Second = new(49, nameof(Second), "s", new() { }, UnitOfTime.Second, UnitTypes.Time);
		public static UnitCalculatorsEnum Minute = new(50, nameof(Minute), "m", new() { }, UnitOfTime.Minute, UnitTypes.Time);
		public static UnitCalculatorsEnum Hour = new(51, nameof(Hour), "h", new() { }, UnitOfTime.Hour, UnitTypes.Time);
		public static UnitCalculatorsEnum Day = new(52, nameof(Day), "d", new() { }, UnitOfTime.Day, UnitTypes.Time);
		public static UnitCalculatorsEnum Week = new(53, nameof(Week), "w", new() { }, UnitOfTime.Week, UnitTypes.Time);
		public static UnitCalculatorsEnum Month = new(54, nameof(Month), "m", new() { }, UnitOfTime.Month, UnitTypes.Time);
		public static UnitCalculatorsEnum Year = new(55, nameof(Year), "year", new() { }, UnitOfTime.Year, UnitTypes.Time);
		public static UnitCalculatorsEnum Decade = new(56, nameof(Decade), nameof(Decade), new() { }, UnitOfTime.Decade, UnitTypes.Time);
		public static UnitCalculatorsEnum Century = new(57, nameof(Century), nameof(Century), new() { }, UnitOfTime.Century, UnitTypes.Time);

		public UnitCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitTypes unitType) : base(id, name, abbreviation, aliases, unit, unitType)
		{
		}

		public static UnitCalculatorsEnum? MatchFromUri(string term)
		{
			term = term.ToLower();

			return
				typeof(UnitCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitCalculatorsEnum))
				.Select(x => (UnitCalculatorsEnum)x.GetValue(null))
				.First(x =>
					x.UriName.ToLower() == term
				);

		}

		public static List<UnitCalculatorsEnum> Search(string searchTerm)
		{
			return
				typeof(UnitCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitCalculatorsEnum))
				.Select(x => (UnitCalculatorsEnum)x.GetValue(null))
				.Where(x =>
					x.Name.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
					x.Abbreviation.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
					x.Aliases.Any(x => x.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
				)
				.OrderBy(x => x.UnitType)
				.ThenBy(x => x.Name)
				.ToList();
		}
	}
}
