using System.Reflection;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Common.Enums.Units
{
	public class UnitCalculatorsEnum : UnitEnumeration
	{

		// Area
		public static UnitCalculatorsEnum SquareKilometer = new(1,
			"Square Kilometre",
			"Square Kilometer",
			"Square Kilometres",
			"km²",
			new() { "square kilometer" },
			UnitOfArea.Square_Kilometre,
			UnitOf.Area,
			UnitSystem.SI_Derived | UnitSystem.Metric,
			"Square kilometre or square kilometer, is a multiple of the square metre, the SI unit of area or surface area."
		);

		public static UnitCalculatorsEnum SquareMeter = new(2,
			"Square Metre",
			"square meter",
			"square metres",
			"m²",
			null,
			UnitOfArea.Square_Metre,
			UnitOf.Area,
			UnitSystem.SI | UnitSystem.Metric,
			"The square metre or square meter is the unit of are. It is the area of a square with sides one metre in length."
		);

		public static UnitCalculatorsEnum SquareMile = new(3,
			"Square Mile",
			null,
			"square miles",
			"mi²"
			, new() { "sq mi" },
			UnitOfArea.Square_Mile,
			UnitOf.Area,
			UnitSystem.Imperial | UnitSystem.Customary,
			"The square mile is a unit of area. One square mile is an area equal to the area of a square with sides of length one mile."
		);

		public static UnitCalculatorsEnum SquareYard = new(4,
			"Square Yard",
			null,
			"square yards",
			"sq yd",
			new() { "sq yard" },
			UnitOfArea.Square_Yard,
			UnitOf.Area,
			UnitSystem.Imperial | UnitSystem.Customary,
			@"The square yard is a unit of area. It is in widespread use in most of the English-speaking world, particularly the United States, United Kingdom, Canada and other regions.
It is defined as the area of a square with sides of one yard (three feet, thirty-six inches, 0.9144 metres) in length."
		);

		public static UnitCalculatorsEnum SquareFoot = new(5,
			"Square Foot",
			null,
			"square feet",
			"ft²",
			new() { "sq. ft", "sf" },
			UnitOfArea.Square_Foot,
			UnitOf.Area,
			UnitSystem.Imperial | UnitSystem.Customary,
			@"The square foot is a unit of area, used mainly in the United States and partially in Canada, the United Kingdom and other regions.
It is defined as the area of a square with sides of 1 foot."
		);

		public static UnitCalculatorsEnum SquareInch = new(6,
			"Square Inch",
			null,
			"square inches",
			"sq inch",
			new() { },
			UnitOfArea.Square_Inch,
			UnitOf.Area,
			UnitSystem.Imperial | UnitSystem.Customary,
			"A square inch is a unit of area, equal to the area of a square with sides of one inch."
		);

		public static UnitCalculatorsEnum Hectare = new(7,
			"Hectare",
			null,
			"hectares",
			"ha",
			new() { },
			UnitOfArea.Hectare,
			UnitOf.Area,
			UnitSystem.Metric,
			@"The hectare is a metric unit of area equal to a square with 100-metre sides (1 hm²), or 10,000 m², and is primarily used in the measurement of land.
There are 100 hectares in one square kilometre. An acre is about 0.405 hectares and one hectare contains about 2.47 acres."
		);

		public static UnitCalculatorsEnum Acre = new(8,
			"Acre",
			null,
			"acres",
			"acre",
			new() { "ac" },
			UnitOfArea.Acre,
			UnitOf.Area,
			UnitSystem.Imperial | UnitSystem.Customary,
			@"The acre is a unit of land area.
It is traditionally defined as the area of one chain by one furlong (66 by 660 feet), which is exactly equal to 10 square chains, 1⁄640 of a square mile, 4,840 square yards, or 43,560 square feet, and approximately 4,047 m2, or about 40% of a hectare.
Based upon the international yard and pound agreement of 1959, an acre may be declared as exactly 4,046.8564224 square metres."
		);


		// Data Transfer
		public static UnitCalculatorsEnum BitPerSecond = new(9, "Bit Per Second", "bit/s", new() { }, UnitOfDataTranser.Bit_Per_Second, UnitOf.DataTransfer);

		public static UnitCalculatorsEnum KilobitPerSecond = new(10, "Kilobit Per Second", "kb/s", new() { "kbit/s", "kbps" }, UnitOfDataTranser.Kilobit_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum KilobytePerSecond = new(11, "Kilobyte Per Second", "KB/s", new() { "kBps" }, UnitOfDataTranser.Kilobyte_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum KibibitPerSecond = new(12, "Kibibit Per Second", "Kibit/s", new() { }, UnitOfDataTranser.Kibibit_Per_Second, UnitOf.DataTransfer);

		public static UnitCalculatorsEnum MegabitPerSecond = new(13, "Megabit Per Second", "Mbit/s", new() { "Mbit/s", "Mbps" }, UnitOfDataTranser.Megabit_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum MegabytePerSecond = new(14, "Megabyte Per Second", "MB/s", new() { "MBps" }, UnitOfDataTranser.Megabyte_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum MebibitPerSecond = new(15, "Mebibit Per Second", "Mibit/s", new() { }, UnitOfDataTranser.Mebibit_Per_Second, UnitOf.DataTransfer);

		public static UnitCalculatorsEnum GigabitPerSecond = new(16, "Gigabit Per Second", "Gbit/s", new() { "Gbit/s", "Gbps" }, UnitOfDataTranser.Gigabit_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum GigabytePerSecond = new(17, "Gigabyte Per Second", "GB/s", new() { "GBps" }, UnitOfDataTranser.Gigabyte_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum GibibitPerSecond = new(18, "Gibibit Per Second", "Gibit/s", new() { }, UnitOfDataTranser.Gibibit_Per_Second, UnitOf.DataTransfer);

		public static UnitCalculatorsEnum TerabitPerSecond = new(19, "Terabit Per Second", "Tbit/s", new() { "Tbit/s", "Tbps" }, UnitOfDataTranser.Terabit_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum TerabytePerSecond = new(20, "Terabyte Per Second", "TB/s", new() { "TBps" }, UnitOfDataTranser.Terabyte_Per_Second, UnitOf.DataTransfer);
		public static UnitCalculatorsEnum TebibitPerSecond = new(21, "Tebibit Per Second", "Tibit/s", new() { }, UnitOfDataTranser.Tebibit_Per_Second, UnitOf.DataTransfer);

		// Energy
		public static UnitCalculatorsEnum Joule = new(22,
			"Joule",
			null,
			"Joules",
			"J",
			new() { },
			UnitOfEnergy.Joule,
			UnitOf.Energy,
			UnitSystem.SI,
			@"The joule is the unit of energy.
It is equal to the amount of work done when a force of 1 newton displaces a mass through a distance of 1 metre in the direction of the force applied.
It is also the energy dissipated as heat when an electric current of one ampere passes through a resistance of one ohm for one second.
It is named after the English physicist James Prescott Joule."
);

		public static UnitCalculatorsEnum Kilojoule = new(23,
			"Kilojoule",
			null,
			"Kilojoule",
			"KJ",
			new() { },
			UnitOfEnergy.Kilojoule,
			UnitOf.Energy,
			UnitSystem.SI_Derived,
			@"Nutritional food labels in most countries express energy in kilojoules.
One square metre of the Earth receives about 1.4 kilojoules of solar radiation every second in full daylight.
A human in a sprint has approximately 3 kJ of kinetic energy, while a cheetah in a 122 km/h (76 mph) sprint has approximately 20 kJ.
One watt-hour of electricity is 3.6 kilojoules."
);

		public static UnitCalculatorsEnum Gramcalorie = new(24,
			"Calorie",
			null,
			"Calories",
			"Cal",
			new() { "Gramcalorie" },
			UnitOfEnergy.Gramcalorie,
			UnitOf.Energy,
			UnitSystem.None,
			@"The calorie is a unit of energy that originated from the obsolete caloric theory of heat.
For historical reasons, two main definitions of ""calorie"" are in wide use.
The large calorie, food calorie, dietary calorie, or kilogram calorie was originally defined as the amount of heat needed to raise the temperature of one kilogram of water by one degree Celsius (or one kelvin).
The small calorie or gram calorie was defined as the amount of heat needed to cause the same increase in one gram of water.
Thus, 1 large calorie is equal to 1000 small calories."
);

		public static UnitCalculatorsEnum Kilocalorie = new(25,
			"Kcal",
			null,
			null,
			"Kcal",
			new() { "Kilocalorie" },
			UnitOfEnergy.Kilocalorie,
			UnitOf.Energy,
			UnitSystem.None,
			@"On nutrition facts labels in the European Union, energy is expressed in both kilojoules and kilocalories.
In the United States and Canada, labels use ""Calories"", referring to the large unit.
In the United States, most nutritionists prefer the unit kilocalorie to the unit kilojoules, whereas most physiologists prefer to use kilojoules. In the majority of other countries, nutritionists prefer the kilojoule to the kilocalorie.");

		public static UnitCalculatorsEnum WattHour = new(26,
			"Watt-hour",
			null,
			"Watt-hours",
			"Wh",
			new() { },
			UnitOfEnergy.Watt_Hour,
			UnitOf.Energy,
			UnitSystem.Metric,
			"A watt-hour is a unit of energy: one watt of power for one hour.");

		public static UnitCalculatorsEnum Kilowatt_Hour = new(27,
			"Kilowatt-hour",
			null,
			"Kilowatt-hours",
			"kW h",
			new() { },
			UnitOfEnergy.Kilowatt_Hour,
			UnitOf.Energy,
			UnitSystem.Metric,
			@"A kilowatt-hour is a unit of energy: one kilowatt of power for one hour.
Kilowatt-hours are a common billing unit for electrical energy delivered to consumers by electric utilities."
);

		public static UnitCalculatorsEnum Electronvolt = new(28,
			"Electronvolt",
			null,
			"Electronvolts",
			"eV",
			new() { "electron-volt", "electron volt" },
			UnitOfEnergy.Electronvolt,
			UnitOf.Energy,
			UnitSystem.None,
			@"An electronvolt is the measure of an amount of kinetic energy gained by a single electron accelerating from rest through an electric potential difference of one volt in vacuum.
When used as a unit of energy, the numerical value of 1 eV in joules is equivalent to the numerical value of the charge of an electron in coulombs."
);

		public static UnitCalculatorsEnum BritishThermalUnit = new(29,
			"British Thermal Unit",
			null,
			null,
			"BTU",
			new() { },
			UnitOfEnergy.British_Thermal_Unit,
			UnitOf.Energy,
			UnitSystem.Imperial | UnitSystem.Customary,
			@"The British thermal unit is a measure of heat, which is measured in units of energy.
It is defined as the amount of heat required to raise the temperature of one pound of water by one degree Fahrenheit."
);

		public static UnitCalculatorsEnum USTherm = new(30,
			"US Therm",
			"thm",
			new() { },
			UnitOfEnergy.US_Therm,
			UnitOf.Energy,
			UnitSystem.Customary,
			@"The therm is a unit of heat energy equal to 100,000 British thermal units, and approximately 105 megajoules and 29 kilowatt-hours.
One therm is the energy content of approximately 100 cubic feet of natural gas at standard temperature and pressure.
However, the BTU is not standardised worldwide, with slightly different values in the EU, UK, and USA, meaning that the energy content of the therm also varies by territory."
);

		public static UnitCalculatorsEnum FootPound = new(31,
			"Foot-pound",
			"ft⋅lb",
			new() { },
			UnitOfEnergy.Foot_Pound,
			UnitOf.Energy,
			UnitSystem.Imperial | UnitSystem.Customary,
			@"The foot-pound force is a unit of work or energy in the engineering and gravitational systems in United States customary and imperial units of measure.
It is the energy transferred upon applying a force of one pound-force (lbf) through a linear displacement of one foot.
");

		// Length
		public static UnitCalculatorsEnum Kilometre = new(32, nameof(Kilometre), "km", new() { "Kilometer" }, UnitOfLength.Kilometre, UnitOf.Length);
		public static UnitCalculatorsEnum Metre = new(33, nameof(Metre), "m", new() { "Meter" }, UnitOfLength.Metre, UnitOf.Length);
		public static UnitCalculatorsEnum Centimetre = new(34, nameof(Centimetre), "cm", new() { "Centimeter" }, UnitOfLength.Centimetre, UnitOf.Length);
		public static UnitCalculatorsEnum Millimetre = new(35, nameof(Millimetre), "mm", new() { "Millimeter" }, UnitOfLength.Millimetre, UnitOf.Length);
		public static UnitCalculatorsEnum Mile = new(36, nameof(Mile), "mi", new() { }, UnitOfLength.Mile, UnitOf.Length);
		public static UnitCalculatorsEnum Yard = new(37, nameof(Yard), "yd", new() { }, UnitOfLength.Yard, UnitOf.Length);
		public static UnitCalculatorsEnum Foot = new(38, nameof(Foot), "ft", new() { "Feet" }, UnitOfLength.Foot, UnitOf.Length);
		public static UnitCalculatorsEnum Inch = new(39, nameof(Inch), "in", new() { }, UnitOfLength.Inch, UnitOf.Length);

		// Mass
		public static UnitCalculatorsEnum Kilogram = new(40, nameof(Kilogram), "kg", new() { }, UnitOfMass.Kilogram, UnitOf.Mass);
		public static UnitCalculatorsEnum Stone = new(41, nameof(Stone), "st", new() { }, UnitOfMass.Stone, UnitOf.Mass);
		public static UnitCalculatorsEnum Pound = new(42, nameof(Pound), "lbs", new() { }, UnitOfMass.Pound, UnitOf.Mass);
		public static UnitCalculatorsEnum Tonne = new(43, nameof(Tonne), "t", new() { }, UnitOfMass.Tonne, UnitOf.Mass);
		public static UnitCalculatorsEnum Gram = new(44, nameof(Gram), "g", new() { }, UnitOfMass.Gram, UnitOf.Mass);
		public static UnitCalculatorsEnum Ounce = new(45, nameof(Ounce), "oz", new() { }, UnitOfMass.Ounce, UnitOf.Mass);

		// Time
		public static UnitCalculatorsEnum Nanosecond = new(46, nameof(Nanosecond), "ns", new() { }, UnitOfTime.Nanosecond, UnitOf.Time);
		public static UnitCalculatorsEnum Microsecond = new(47, nameof(Microsecond), "μs", new() { }, UnitOfTime.Microsecond, UnitOf.Time);
		public static UnitCalculatorsEnum Millisecond = new(48, nameof(Millisecond), "ms", new() { }, UnitOfTime.Millisecond, UnitOf.Time);
		public static UnitCalculatorsEnum Second = new(49, nameof(Second), "s", new() { }, UnitOfTime.Second, UnitOf.Time);
		public static UnitCalculatorsEnum Minute = new(50, nameof(Minute), "m", new() { }, UnitOfTime.Minute, UnitOf.Time);
		public static UnitCalculatorsEnum Hour = new(51, nameof(Hour), "h", new() { }, UnitOfTime.Hour, UnitOf.Time);
		public static UnitCalculatorsEnum Day = new(52, nameof(Day), "d", new() { }, UnitOfTime.Day, UnitOf.Time);
		public static UnitCalculatorsEnum Week = new(53, nameof(Week), "w", new() { }, UnitOfTime.Week, UnitOf.Time);
		public static UnitCalculatorsEnum Month = new(54, nameof(Month), "m", new() { }, UnitOfTime.Month, UnitOf.Time);
		public static UnitCalculatorsEnum Year = new(55, nameof(Year), "year", new() { }, UnitOfTime.Year, UnitOf.Time);
		public static UnitCalculatorsEnum Decade = new(56, nameof(Decade), nameof(Decade), new() { }, UnitOfTime.Decade, UnitOf.Time);
		public static UnitCalculatorsEnum Century = new(57, nameof(Century), nameof(Century), new() { }, UnitOfTime.Century, UnitOf.Time);

		public UnitCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf) : base(id, name, abbreviation, aliases, unit, unitOf)
		{
		}


		public UnitCalculatorsEnum(int id, string name, string? americanEnglishSpelling, string? plural, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem, string insightText) : base(id, name, americanEnglishSpelling, plural, abbreviation, aliases, unit, unitOf, unitSystem, insightText)
		{
		}

		public UnitCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem, string insightText) : base(id, name, abbreviation, aliases, unit, unitOf, unitSystem, insightText, null)
		{
		}

		public UnitCalculatorsEnum(int id, string name, string abbreviation, List<string> aliases, object unit, UnitOf unitOf, UnitSystem unitSystem, string insightText, string insightLinkOverride) : base(id, name, abbreviation, aliases, unit, unitOf, unitSystem, insightText, insightLinkOverride)
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
