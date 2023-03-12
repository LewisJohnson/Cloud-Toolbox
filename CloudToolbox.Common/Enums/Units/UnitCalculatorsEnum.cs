using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums.Units
{
	public class UnitCalculatorsEnum : UnitEnumeration
	{

		// Area
		public static UnitCalculatorsEnum SquareKilometer = new(1, "Square Kilometre", "km²", new() { "square kilometer" }, UnitOfArea.Square_Kilometre, UnitOf.Area, UnitSystem.SI_Derived | UnitSystem.Metric);
		public static UnitCalculatorsEnum SquareMeter = new(2, "Square Metre", "m²", new() { }, UnitOfArea.Square_Metre, UnitOf.Area, UnitSystem.SI | UnitSystem.Metric);
		public static UnitCalculatorsEnum SquareMile = new(3, "Square Mile", "mi²", new() { "sq mi" }, UnitOfArea.Square_Mile, UnitOf.Area, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum SquareYard = new(4, "Square Yard", "sq yd", new() { "sq yard" }, UnitOfArea.Square_Yard, UnitOf.Area, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum SquareFoot = new(5, "Square Foot", "ft²", new() { "sq. ft", "sf" }, UnitOfArea.Square_Foot, UnitOf.Area, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum SquareInch = new(6, "Square Inch", "sq inch", new() { }, UnitOfArea.Square_Inch, UnitOf.Area, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum Hectare = new(7, "Hectare", "ha", new() { }, UnitOfArea.Hectare, UnitOf.Area, UnitSystem.Metric);
		public static UnitCalculatorsEnum Acre = new(8, "Acre", "acre", new() { "ac" }, UnitOfArea.Acre, UnitOf.Area, UnitSystem.Imperial | UnitSystem.Customary);

		// Data Transfer
		public static UnitCalculatorsEnum BitPerSecond = new(9, "Bit Per Second", "bit/s", new() { }, UnitOfDataTranser.Bit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);

		public static UnitCalculatorsEnum KilobitPerSecond = new(10, "Kilobit Per Second", "kb/s", new() { "kbit/s", "kbps" }, UnitOfDataTranser.Kilobit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum KilobytePerSecond = new(11, "Kilobyte Per Second", "KB/s", new() { "kBps" }, UnitOfDataTranser.Kilobyte_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum KibibitPerSecond = new(12, "Kibibit Per Second", "Kibit/s", new() { }, UnitOfDataTranser.Kibibit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);

		public static UnitCalculatorsEnum MegabitPerSecond = new(13, "Megabit Per Second", "Mbit/s", new() { "Mbps" }, UnitOfDataTranser.Megabit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum MegabytePerSecond = new(14, "Megabyte Per Second", "MB/s", new() { "MBps" }, UnitOfDataTranser.Megabyte_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum MebibitPerSecond = new(15, "Mebibit Per Second", "Mibit/s", new() { }, UnitOfDataTranser.Mebibit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);

		public static UnitCalculatorsEnum GigabitPerSecond = new(16, "Gigabit Per Second", "Gbit/s", new() { "Gbps" }, UnitOfDataTranser.Gigabit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum GigabytePerSecond = new(17, "Gigabyte Per Second", "GB/s", new() { "GBps" }, UnitOfDataTranser.Gigabyte_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum GibibitPerSecond = new(18, "Gibibit Per Second", "Gibit/s", new() { }, UnitOfDataTranser.Gibibit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);

		public static UnitCalculatorsEnum TerabitPerSecond = new(19, "Terabit Per Second", "Tbit/s", new() { "Tbps" }, UnitOfDataTranser.Terabit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum TerabytePerSecond = new(20, "Terabyte Per Second", "TB/s", new() { "TBps" }, UnitOfDataTranser.Terabyte_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);
		public static UnitCalculatorsEnum TebibitPerSecond = new(21, "Tebibit Per Second", "Tibit/s", new() { }, UnitOfDataTranser.Tebibit_Per_Second, UnitOf.Data_Transfer, UnitSystem.None);

		// Energy
		public static UnitCalculatorsEnum Joule = new(22, "Joule", "J", new() { }, UnitOfEnergy.Joule, UnitOf.Energy, UnitSystem.SI);
		public static UnitCalculatorsEnum Kilojoule = new(23, "Kilojoule", "KJ", new() { }, UnitOfEnergy.Kilojoule, UnitOf.Energy, UnitSystem.SI_Derived);
		public static UnitCalculatorsEnum Gramcalorie = new(24, "Calorie", "Cal", new() { "Gramcalorie" }, UnitOfEnergy.Gramcalorie, UnitOf.Energy, UnitSystem.None);
		public static UnitCalculatorsEnum Kilocalorie = new(25, "Kcal", "Kcal", new() { "Kilocalorie" }, UnitOfEnergy.Kilocalorie, UnitOf.Energy, UnitSystem.None);
		public static UnitCalculatorsEnum WattHour = new(26, "Watt-hour", "Wh", new() { }, UnitOfEnergy.Watt_Hour, UnitOf.Energy, UnitSystem.Metric);
		public static UnitCalculatorsEnum Kilowatt_Hour = new(27, "Kilowatt-hour", "kW h", new() { }, UnitOfEnergy.Kilowatt_Hour, UnitOf.Energy, UnitSystem.Metric);
		public static UnitCalculatorsEnum Electronvolt = new(28, "Electronvolt", "eV", new() { "electron-volt", "electron volt" }, UnitOfEnergy.Electronvolt, UnitOf.Energy, UnitSystem.None);
		public static UnitCalculatorsEnum BritishThermalUnit = new(29, "British Thermal Unit", "BTU", new() { }, UnitOfEnergy.British_Thermal_Unit, UnitOf.Energy, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum USTherm = new(30, "US Therm", "thm", new() { }, UnitOfEnergy.US_Therm, UnitOf.Energy, UnitSystem.Customary);
		public static UnitCalculatorsEnum FootPound = new(31, "Foot-pound", "ft⋅lb", new() { }, UnitOfEnergy.Foot_Pound, UnitOf.Energy, UnitSystem.Imperial | UnitSystem.Customary);

		// Length
		public static UnitCalculatorsEnum Kilometre = new(32, nameof(Kilometre), "km", new() { "Kilometer" }, UnitOfLength.Kilometre, UnitOf.Length, UnitSystem.SI);
		public static UnitCalculatorsEnum Metre = new(33, nameof(Metre), "m", new() { "Meter" }, UnitOfLength.Metre, UnitOf.Length, UnitSystem.SI);
		public static UnitCalculatorsEnum Centimetre = new(34, nameof(Centimetre), "cm", new() { "Centimeter" }, UnitOfLength.Centimetre, UnitOf.Length, UnitSystem.SI);
		public static UnitCalculatorsEnum Millimetre = new(35, nameof(Millimetre), "mm", new() { "Millimeter" }, UnitOfLength.Millimetre, UnitOf.Length, UnitSystem.SI);
		public static UnitCalculatorsEnum Mile = new(36, nameof(Mile), "mi", new() { }, UnitOfLength.Mile, UnitOf.Length, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum Yard = new(37, nameof(Yard), "yd", new() { }, UnitOfLength.Yard, UnitOf.Length, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum Foot = new(38, nameof(Foot), "ft", new() { "Feet" }, UnitOfLength.Foot, UnitOf.Length, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum Inch = new(39, nameof(Inch), "in", new() { }, UnitOfLength.Inch, UnitOf.Length, UnitSystem.Imperial | UnitSystem.Customary);

		// Mass
		public static UnitCalculatorsEnum Kilogram = new(40, nameof(Kilogram), "kg", new() { "kilogramme" }, UnitOfMass.Kilogram, UnitOf.Mass, UnitSystem.SI);
		public static UnitCalculatorsEnum Stone = new(41, nameof(Stone), "st", new() { }, UnitOfMass.Stone, UnitOf.Mass, UnitSystem.Imperial);
		public static UnitCalculatorsEnum Pound = new(42, nameof(Pound), "lb", new() { "pound-mass" }, UnitOfMass.Pound, UnitOf.Mass, UnitSystem.Imperial | UnitSystem.Customary);
		public static UnitCalculatorsEnum Tonne = new(43, nameof(Tonne), "t", new() { "ton", "metric ton" }, UnitOfMass.Tonne, UnitOf.Mass, UnitSystem.Metric);
		public static UnitCalculatorsEnum Gram = new(44, nameof(Gram), "g", new() { "gramme" }, UnitOfMass.Gram, UnitOf.Mass, UnitSystem.SI);
		public static UnitCalculatorsEnum Ounce = new(45, nameof(Ounce), "oz", new() { }, UnitOfMass.Ounce, UnitOf.Mass, UnitSystem.Imperial | UnitSystem.Customary);

		// Time
		public static UnitCalculatorsEnum Nanosecond = new(46, nameof(Nanosecond), "ns", new() { }, UnitOfTime.Nanosecond, UnitOf.Time, UnitSystem.SI);
		public static UnitCalculatorsEnum Microsecond = new(47, nameof(Microsecond), "μs", new() { }, UnitOfTime.Microsecond, UnitOf.Time, UnitSystem.SI);
		public static UnitCalculatorsEnum Millisecond = new(48, nameof(Millisecond), "ms", new() { }, UnitOfTime.Millisecond, UnitOf.Time, UnitSystem.SI);
		public static UnitCalculatorsEnum Second = new(49, nameof(Second), "s", new() { }, UnitOfTime.Second, UnitOf.Time, UnitSystem.SI);
		public static UnitCalculatorsEnum Minute = new(50, nameof(Minute), "min", new() { }, UnitOfTime.Minute, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Hour = new(51, nameof(Hour), "h", new() { "hr" }, UnitOfTime.Hour, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Day = new(52, nameof(Day), "d", new() { }, UnitOfTime.Day, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Week = new(53, nameof(Week), "w", new() { }, UnitOfTime.Week, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Month = new(54, nameof(Month), "m", new() { }, UnitOfTime.Month, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Year = new(55, nameof(Year), "year", new() { }, UnitOfTime.Year, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Decade = new(56, nameof(Decade), nameof(Decade), new() { }, UnitOfTime.Decade, UnitOf.Time, UnitSystem.None);
		public static UnitCalculatorsEnum Century = new(57, nameof(Century), nameof(Century), new() { }, UnitOfTime.Century, UnitOf.Time, UnitSystem.None);

		public UnitCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem) : base(id, name, abbreviation, aliases, unit, unitOf, unitSystem)
		{
		}

		public static UnitCalculatorsEnum? MatchFromUri(string term)
		{
			term = term.ToLower();

			return
				typeof(UnitCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitCalculatorsEnum))
				.Select(x => x.GetValue(null) as UnitCalculatorsEnum)
				.FirstOrDefault(x =>
					x.UriName.ToLower() == term
				);
		}

		public static List<UnitCalculatorsEnum> Search(string searchTerm)
		{
			return
				typeof(UnitCalculatorsEnum)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitCalculatorsEnum))
				.Select(x => x.GetValue(null) as UnitCalculatorsEnum)
				.Where(x =>
					x.Name.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
					x.Abbreviation.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
					x.Aliases.Any(x => x.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
				)
				.OrderBy(x => x.UnitOf)
				.ThenBy(x => x.Name)
				.ToList();
		}
	}
}
