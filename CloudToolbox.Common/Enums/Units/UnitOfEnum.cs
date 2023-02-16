using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums.Units
{
	public class UnitOfEnum : UnitEnumeration
	{

		// Area
		public static UnitOfEnum SquareKilometer = new(1, "Square Kilometre", "km²", new() { "Square Kilometer" }, UnitOfArea.Square_Kilometre, UnitTypes.Area);
		public static UnitOfEnum SquareMeter = new(2, "Square Metre", "m²", new() { "Square Meter" }, UnitOfArea.Square_Metre, UnitTypes.Area);
		public static UnitOfEnum SquareMile = new(3, "Square Mile", "sq mi", new() { "mi²" }, UnitOfArea.Square_Mile, UnitTypes.Area);
		public static UnitOfEnum SquareYard = new(4, "Square Yard", "sq yard", new() { }, UnitOfArea.Square_Yard, UnitTypes.Area);
		public static UnitOfEnum SquareFoot = new(5, "Square Foot", "sq. ft", new() { "sq. ft", "sf" }, UnitOfArea.Square_Foot, UnitTypes.Area);
		public static UnitOfEnum SquareInch = new(6, "Square Inch", "sq inch", new() { }, UnitOfArea.Square_Inch, UnitTypes.Area);
		public static UnitOfEnum Hectare = new(7, nameof(Hectare), "ha", new() { }, UnitOfArea.Hectare, UnitTypes.Area);
		public static UnitOfEnum Acre = new(8, nameof(Acre), "acre", new() { "ac" }, UnitOfArea.Acre, UnitTypes.Area);

		// Data Transfer
		public static UnitOfEnum BitPerSecond = new(9, "Bit Per Second", "bit/s", new() { }, UnitOfDataTranser.Bit_Per_Second, UnitTypes.DataTransfer);

		public static UnitOfEnum KilobitPerSecond = new(10, "Kilobit Per Second", "kb/s", new() { "kbit/s", "kbps" }, UnitOfDataTranser.Kilobit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum KilobytePerSecond = new(11, "Kilobyte Per Second", "KB/s", new() { "kBps" }, UnitOfDataTranser.Kilobyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum KibibitPerSecond = new(12, "Kibibit Per Second", "Kibit/s", new() { }, UnitOfDataTranser.Kibibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitOfEnum MegabitPerSecond = new(13, "Megabit Per Second", "Mbit/s", new() { "Mbit/s", "Mbps" }, UnitOfDataTranser.Megabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum MegabytePerSecond = new(14, "Megabyte Per Second", "MB/s", new() { "MBps" }, UnitOfDataTranser.Megabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum MebibitPerSecond = new(15, "Mebibit Per Second", "Mibit/s", new() { }, UnitOfDataTranser.Mebibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitOfEnum GigabitPerSecond = new(16, "Gigabit Per Second", "Gbit/s", new() { "Gbit/s", "Gbps" }, UnitOfDataTranser.Gigabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum GigabytePerSecond = new(17, "Gigabyte Per Second", "GB/s", new() { "GBps" }, UnitOfDataTranser.Gigabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum GibibitPerSecond = new(18, "Gibibit Per Second", "Gibit/s", new() { }, UnitOfDataTranser.Gibibit_Per_Second, UnitTypes.DataTransfer);

		public static UnitOfEnum TerabitPerSecond = new(19, "Terabit Per Second", "Tbit/s", new() { "Tbit/s", "Tbps" }, UnitOfDataTranser.Terabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum TerabytePerSecond = new(20, "Terabyte Per Second", "TB/s", new() { "TBps" }, UnitOfDataTranser.Terabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOfEnum TebibitPerSecond = new(21, "Tebibit Per Second", "Tibit/s", new() { }, UnitOfDataTranser.Tebibit_Per_Second, UnitTypes.DataTransfer);

		// Energy
		public static UnitOfEnum Joule = new(22, nameof(Joule), "J", new() { }, UnitOfEnergy.Joule, UnitTypes.Energy);
		public static UnitOfEnum Kilojoule = new(23, nameof(Kilojoule), "KJ", new() { }, UnitOfEnergy.Kilojoule, UnitTypes.Energy);
		public static UnitOfEnum Gramcalorie = new(24, nameof(Gramcalorie), "GramCal", new() { }, UnitOfEnergy.Gramcalorie, UnitTypes.Energy);
		public static UnitOfEnum Kilocalorie = new(25, nameof(Kilocalorie), "KiloCal", new() { }, UnitOfEnergy.Kilocalorie, UnitTypes.Energy);
		public static UnitOfEnum WattHour = new(26, "Watt Hour", "Wh", new() { }, UnitOfEnergy.Watt_Hour, UnitTypes.Energy);
		public static UnitOfEnum Kilowatt_Hour = new(27, "Kilowatt Hour", "kWh", new() { }, UnitOfEnergy.Kilowatt_Hour, UnitTypes.Energy);
		public static UnitOfEnum Electronvolt = new(28, nameof(Electronvolt), "eV", new() { }, UnitOfEnergy.Electronvolt, UnitTypes.Energy);
		public static UnitOfEnum BritishThermalUnit = new(29, "British Thermal Unit", "BTU", new() { }, UnitOfEnergy.British_Thermal_Unit, UnitTypes.Energy);
		public static UnitOfEnum USTherm = new(30, "US Therm", "US Therm", new() { }, UnitOfEnergy.US_Therm, UnitTypes.Energy);
		public static UnitOfEnum FootPound = new(31, "Foot Pound", "ft⋅lb", new() { }, UnitOfEnergy.Foot_Pound, UnitTypes.Energy);

		// Length
		public static UnitOfEnum Kilometre = new(32, nameof(Kilometre), "km", new() { "Kilometer" }, UnitOfLength.Kilometre, UnitTypes.Length);
		public static UnitOfEnum Metre = new(33, nameof(Metre), "m", new() { "Meter" }, UnitOfLength.Metre, UnitTypes.Length);
		public static UnitOfEnum Centimetre = new(34, nameof(Centimetre), "cm", new() { "Centimeter" }, UnitOfLength.Centimetre, UnitTypes.Length);
		public static UnitOfEnum Millimetre = new(35, nameof(Millimetre), "mm", new() { "Millimeter" }, UnitOfLength.Millimetre, UnitTypes.Length);
		public static UnitOfEnum Mile = new(36, nameof(Mile), "mi", new() { }, UnitOfLength.Mile, UnitTypes.Length);
		public static UnitOfEnum Yard = new(37, nameof(Yard), "yd", new() { }, UnitOfLength.Yard, UnitTypes.Length);
		public static UnitOfEnum Foot = new(38, nameof(Foot), "ft", new() { "Feet" }, UnitOfLength.Foot, UnitTypes.Length);
		public static UnitOfEnum Inch = new(39, nameof(Inch), "in", new() { }, UnitOfLength.Inch, UnitTypes.Length);

		// Mass
		public static UnitOfEnum Kilogram = new(40, nameof(Kilogram), "kg", new() { }, UnitOfMass.Kilogram, UnitTypes.Mass);
		public static UnitOfEnum Stone = new(41, nameof(Stone), "st", new() { }, UnitOfMass.Stone, UnitTypes.Mass);
		public static UnitOfEnum Pound = new(42, nameof(Pound), "lbs", new() { }, UnitOfMass.Pound, UnitTypes.Mass);
		public static UnitOfEnum Tonne = new(43, nameof(Tonne), "t", new() { }, UnitOfMass.Tonne, UnitTypes.Mass);
		public static UnitOfEnum Gram = new(44, nameof(Gram), "g", new() { }, UnitOfMass.Gram, UnitTypes.Mass);
		public static UnitOfEnum Ounce = new(45, nameof(Ounce), "oz", new() { }, UnitOfMass.Ounce, UnitTypes.Mass);

		// Time
		public static UnitOfEnum Nanosecond = new(46, nameof(Nanosecond), "ns", new() { }, UnitOfTime.Nanosecond, UnitTypes.Time);
		public static UnitOfEnum Microsecond = new(47, nameof(Microsecond), "μs", new() { }, UnitOfTime.Microsecond, UnitTypes.Time);
		public static UnitOfEnum Millisecond = new(48, nameof(Millisecond), "ms", new() { }, UnitOfTime.Millisecond, UnitTypes.Time);
		public static UnitOfEnum Second = new(49, nameof(Second), "s", new() { }, UnitOfTime.Second, UnitTypes.Time);
		public static UnitOfEnum Minute = new(50, nameof(Minute), "m", new() { }, UnitOfTime.Minute, UnitTypes.Time);
		public static UnitOfEnum Hour = new(51, nameof(Hour), "h", new() { }, UnitOfTime.Hour, UnitTypes.Time);
		public static UnitOfEnum Day = new(52, nameof(Day), "d", new() { }, UnitOfTime.Day, UnitTypes.Time);
		public static UnitOfEnum Week = new(53, nameof(Week), "w", new() { }, UnitOfTime.Week, UnitTypes.Time);
		public static UnitOfEnum Month = new(54, nameof(Month), "m", new() { }, UnitOfTime.Month, UnitTypes.Time);
		public static UnitOfEnum Year = new(55, nameof(Year), "year", new() { }, UnitOfTime.Year, UnitTypes.Time);
		public static UnitOfEnum Decade = new(56, nameof(Decade), nameof(Decade), new() { }, UnitOfTime.Decade, UnitTypes.Time);
		public static UnitOfEnum Century = new(57, nameof(Century), nameof(Century), new() { }, UnitOfTime.Century, UnitTypes.Time);

		public UnitOfEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitTypes unitType) : base(id, name, abbreviation, aliases, unit, unitType)
		{
		}

		public static UnitOfEnum? Match(string term)
		{
			term = term.ToLower();

			return
				typeof(UnitOfEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitOfEnum))
				.Select(x => (UnitOfEnum)x.GetValue(null))
				.First(x =>
					x.UriName.ToLower() == term
				);

		}
	}
}
