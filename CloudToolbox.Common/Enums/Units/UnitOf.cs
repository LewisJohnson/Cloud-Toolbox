using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums.Units
{
	public class UnitOf : UnitEnumeration
	{

		// Area
		public static UnitOf SquareKilometer = new(26, "Square Kilometer", "oz", new() { }, UnitOfArea.Square_Kilometer, UnitTypes.Area);
		public static UnitOf SquareMeter = new(26, "Square Meter", "oz", new() { }, UnitOfArea.Square_Meter, UnitTypes.Area);
		public static UnitOf SquareMile = new(26, "Square Mile", "oz", new() { }, UnitOfArea.Square_Mile, UnitTypes.Area);
		public static UnitOf SquareYard = new(26, "Square Yard", "oz", new() { }, UnitOfArea.Square_Yard, UnitTypes.Area);
		public static UnitOf SquareFoot = new(26, "Square Foot", "oz", new() { }, UnitOfArea.Square_Foot, UnitTypes.Area);
		public static UnitOf SquareInch = new(26, "Square Inch", "oz", new() { }, UnitOfArea.Square_Inch, UnitTypes.Area);
		public static UnitOf Hectare = new(26, "Hectare", "oz", new() { }, UnitOfArea.Hectare, UnitTypes.Area);
		public static UnitOf Acre = new(26, "Acre", "oz", new() { }, UnitOfArea.Acre, UnitTypes.Area);

		// Data Transfer
		public static UnitOf BitPerSecond = new(26, "Bit Per Second", "Mbps", new() { }, UnitOfDataTranser.Bit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf KilobitPerSecond = new(26, "Kilobit Per Second", "kb/s", new() { }, UnitOfDataTranser.Kilobit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf KilobytePerSecond = new(26, "Kilobyte Per Second", "kB/s", new() { }, UnitOfDataTranser.Kilobyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf KibibitPerSecond = new(26, "Kibibit Per Second", "Kibibit", new() { }, UnitOfDataTranser.Kibibit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf MegabitPerSecond = new(26, "Megabit Per Second", "Megabit", new() { }, UnitOfDataTranser.Megabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf MegabytePerSecond = new(26, "Megabyte Per Second", "Megabyte", new() { }, UnitOfDataTranser.Megabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf MebibitPerSecond = new(26, "Mebibit Per Second", "Mebibit", new() { }, UnitOfDataTranser.Mebibit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf GigabitPerSecond = new(26, "Gigabit Per Second", "Gigabit", new() { }, UnitOfDataTranser.Gigabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf GigabytePerSecond = new(26, "Gigabyte Per Second", "Gigabyte", new() { }, UnitOfDataTranser.Gigabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf GibibitPerSecond = new(26, "Gibibit Per Second", "Gibibit", new() { }, UnitOfDataTranser.Gibibit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf TerabitPerSecond = new(26, "Terabit Per Second", "Terabit", new() { }, UnitOfDataTranser.Terabit_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf TerabytePerSecond = new(26, "Terabyte Per Second", "Terabyte", new() { }, UnitOfDataTranser.Terabyte_Per_Second, UnitTypes.DataTransfer);
		public static UnitOf TebibitPerSecond = new(26, "Tebibit Per Second", "Tebibit", new() { }, UnitOfDataTranser.Tebibit_Per_Second, UnitTypes.DataTransfer);

		// Energy
		public static UnitOf Joule = new(1, nameof(Joule), "oz", new() { }, UnitOfEnergy.Joule, UnitTypes.Energy);
		public static UnitOf Kilojoule = new(1, nameof(Kilojoule), "oz", new() { }, UnitOfEnergy.Kilojoule, UnitTypes.Energy);
		public static UnitOf Gramcalorie = new(1, nameof(Gramcalorie), "oz", new() { }, UnitOfEnergy.Gramcalorie, UnitTypes.Energy);
		public static UnitOf Kilocalorie = new(1, nameof(Kilocalorie), "oz", new() { }, UnitOfEnergy.Kilocalorie, UnitTypes.Energy);
		public static UnitOf WattHour = new(1, "Watt Hour", "oz", new() { }, UnitOfEnergy.WattHour, UnitTypes.Energy);
		public static UnitOf Kilowatt_Hour = new(1, "Kilowatt Hour", "oz", new() { }, UnitOfEnergy.Kilowatt_Hour, UnitTypes.Energy);
		public static UnitOf Electronvolt = new(1, nameof(Electronvolt), "oz", new() { }, UnitOfEnergy.Electronvolt, UnitTypes.Energy);
		public static UnitOf BritishThermalUnit = new(1, "British Thermal Unit", "oz", new() { }, UnitOfEnergy.British_Thermal_Unit, UnitTypes.Energy);
		public static UnitOf USTherm = new(1, "US Therm", "oz", new() { }, UnitOfEnergy.US_Therm, UnitTypes.Energy);
		public static UnitOf FootPound = new(1, "Foot Pound", "oz", new() { }, UnitOfEnergy.Foot_Pound, UnitTypes.Energy);

		// Length
		public static UnitOf Kilometre = new(1, nameof(Kilometre), "km", new() { "Kilometer" }, UnitOfLength.Kilometre, UnitTypes.Length);
		public static UnitOf Metre = new(2, nameof(Metre), "m", new() { "Meter" }, UnitOfLength.Metre, UnitTypes.Length);
		public static UnitOf Centimetre = new(3, nameof(Centimetre), "cm", new() { "Centimeter" }, UnitOfLength.Centimetre, UnitTypes.Length);
		public static UnitOf Millimetre = new(4, nameof(Millimetre), "mm", new() { "Millimeter" }, UnitOfLength.Millimetre, UnitTypes.Length);
		public static UnitOf Mile = new(5, nameof(Mile), "mi", new() { }, UnitOfLength.Mile, UnitTypes.Length);
		public static UnitOf Yard = new(6, nameof(Yard), "yd", new() { }, UnitOfLength.Yard, UnitTypes.Length);
		public static UnitOf Foot = new(7, nameof(Foot), "ft", new() { "Feet" }, UnitOfLength.Foot, UnitTypes.Length);
		public static UnitOf Inch = new(8, nameof(Inch), "in", new() { }, UnitOfLength.Inch, UnitTypes.Length);

		// Mass
		public static UnitOf Kilogram = new(21, nameof(Kilogram), "kg", new() { }, UnitOfMass.Kilogram, UnitTypes.Mass);
		public static UnitOf Stone = new(22, nameof(Stone), "st", new() { }, UnitOfMass.Stone, UnitTypes.Mass);
		public static UnitOf Pound = new(23, nameof(Pound), "lbs", new() { }, UnitOfMass.Pound, UnitTypes.Mass);
		public static UnitOf Tonne = new(24, nameof(Tonne), "t", new() { }, UnitOfMass.Tonne, UnitTypes.Mass);
		public static UnitOf Gram = new(25, nameof(Gram), "g", new() { }, UnitOfMass.Gram, UnitTypes.Mass);
		public static UnitOf Ounce = new(26, nameof(Ounce), "oz", new() { }, UnitOfMass.Ounce, UnitTypes.Mass);

		// Time
		public static UnitOf Nanosecond = new(1, nameof(Nanosecond), nameof(Nanosecond), new() { }, UnitOfTime.Nanosecond, UnitTypes.Time);
		public static UnitOf Microsecond = new(1, nameof(Microsecond), nameof(Microsecond), new() { }, UnitOfTime.Microsecond, UnitTypes.Time);
		public static UnitOf Millisecond = new(1, nameof(Millisecond), nameof(Millisecond), new() { }, UnitOfTime.Millisecond, UnitTypes.Time);
		public static UnitOf Second = new(1, nameof(Second), nameof(Second), new() { }, UnitOfTime.Second, UnitTypes.Time);
		public static UnitOf Minute = new(1, nameof(Minute), nameof(Minute), new() { }, UnitOfTime.Minute, UnitTypes.Time);
		public static UnitOf Hour = new(1, nameof(Hour), nameof(Hour), new() { }, UnitOfTime.Hour, UnitTypes.Time);
		public static UnitOf Day = new(1, nameof(Day), nameof(Day), new() { }, UnitOfTime.Day, UnitTypes.Time);
		public static UnitOf Week = new(1, nameof(Week), nameof(Week), new() { }, UnitOfTime.Week, UnitTypes.Time);
		public static UnitOf Month = new(1, nameof(Month), nameof(Month), new() { }, UnitOfTime.Month, UnitTypes.Time);
		public static UnitOf CalendarYear = new(1, nameof(CalendarYear), nameof(CalendarYear), new() { }, UnitOfTime.Year, UnitTypes.Time);
		public static UnitOf Decade = new(1, nameof(Decade), nameof(Decade), new() { }, UnitOfTime.Decade, UnitTypes.Time);
		public static UnitOf Century = new(1, nameof(Century), nameof(Century), new() { }, UnitOfTime.Century, UnitTypes.Time);

		public UnitOf(int id, string name, string abbreviation, List<string> aliases, object unit, UnitTypes unitType) : base(id, name, abbreviation, aliases, unit, unitType)
		{
		}

		public static UnitOf? Match(string term)
		{
			term = term.ToLower();

			return
				typeof(UnitOf)
				.GetFields(BindingFlags.Static | BindingFlags.Public)
				.Where(x => x.FieldType == typeof(UnitOf))
				.Select(x => (UnitOf)x.GetValue(null))
				.First(x =>
					x.UriName.ToLower() == term
				);

		}
	}
}
