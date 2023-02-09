namespace CloudToolbox.Common.Routes
{
	public static class Routes
	{
		// AREAS
		public const string AREA_DATE_AND_TIME = "/Toolbox/DateAndTime";
		public const string AREA_MATHS = "/Toolbox/Maths";
		public const string AREA_TEXT = "/Toolbox/Text";
		public const string AREA_TRAVEL = "/Toolbox/Travel";
		public const string AREA_UNITS = "/Toolbox/Units";
		public const string AREA_DEVELOPER = "/Toolbox/Developer";

		// DATE & TIME
		public const string DATE_AND_TIME_DURATION_BETWEEN_DATES = "/Toolbox/DateAndTime/Between-Dates";
		public const string DATE_AND_TIME_DURATION_BETWEEN_TIMES = "/Toolbox/DateAndTime/Between-Times";
		public const string DATE_AND_TIME_DURATION_BETWEEN_TIME_AND_DATE = "/Toolbox/DateAndTime/Between-Time-and-Date";

		// TEXT
		public const string TEXT_TO_LOWER_CASE = "/Toolbox/Text/To-Lower-Case";
		public const string TEXT_TO_UPPER_CASE = "/Toolbox/Text/To-Upper-Case";
		public const string TEXT_TO_TITLE_CASE = "/Toolbox/Text/To-Title-Case";

		// TRAVEL
		public const string TRAVEL_MPG_CALCULATOR = "/Toolbox/Travel/Mpg-Calculator";
		public const string TRAVEL_KML_CALCULATOR = "/Toolbox/Travel/Kml-Calculator";
		public const string TRAVEL_FUEL_REQUIRED = "/Toolbox/Travel/Fuel-Required";
		public const string TRAVEL_JOURNEY_COST = "/Toolbox/Travel/Journey-Cost";

		// MATHS
		public const string MATHS_PERCENTAGE_CALCULATOR = "/Toolbox/Maths/Percentage-Calculator";
		public const string MATHS_TIMES_TABLE = "/Toolbox/Maths/Times-Table";
		public const string MATHS_TIMES_TABLE_GRID = "/Toolbox/Maths/Times-Table-grid";
		public const string MATHS_DIVISION_TABLE = "/Toolbox/Maths/Division-Table";

		// DEVELOPER
		public const string DEVELOPER_TO_BASE64 = "/Toolbox/Developer/To-Base64";
		public const string DEVELOPER_FROM_BASE64 = "/Toolbox/Developer/From-Base64";
		public const string DEVELOPER_TO_HEX = "/Toolbox/Developer/To-Hex";
		public const string DEVELOPER_FROM_HEX = "/Toolbox/Developer/From-Hex";
		public const string DEVELOPER_TO_BINARY = "/Toolbox/Developer/To-Binary";
		public const string DEVELOPER_FROM_BINARY = "/Toolbox/Developer/From-Binary";

		#region GENERATED ROUTES
		// GENERATED ROUTES
		// -- DO NOT MODIFY MANUALLY --

		// Units
		// Units - UnitOfLength

		public const string UNITS_KILOMETRE_TO_METRE = "/Toolbox/Units/Kilometre-to-Metre";
		public const string UNITS_KILOMETRE_TO_CENTIMETRE = "/Toolbox/Units/Kilometre-to-Centimetre";
		public const string UNITS_KILOMETRE_TO_MILLIMETRE = "/Toolbox/Units/Kilometre-to-Millimetre";
		public const string UNITS_KILOMETRE_TO_MILE = "/Toolbox/Units/Kilometre-to-Mile";
		public const string UNITS_KILOMETRE_TO_YARD = "/Toolbox/Units/Kilometre-to-Yard";
		public const string UNITS_KILOMETRE_TO_FOOT = "/Toolbox/Units/Kilometre-to-Foot";
		public const string UNITS_KILOMETRE_TO_INCH = "/Toolbox/Units/Kilometre-to-Inch";
		public const string UNITS_METRE_TO_KILOMETRE = "/Toolbox/Units/Metre-to-Kilometre";

		public const string UNITS_METRE_TO_CENTIMETRE = "/Toolbox/Units/Metre-to-Centimetre";
		public const string UNITS_METRE_TO_MILLIMETRE = "/Toolbox/Units/Metre-to-Millimetre";
		public const string UNITS_METRE_TO_MILE = "/Toolbox/Units/Metre-to-Mile";
		public const string UNITS_METRE_TO_YARD = "/Toolbox/Units/Metre-to-Yard";
		public const string UNITS_METRE_TO_FOOT = "/Toolbox/Units/Metre-to-Foot";
		public const string UNITS_METRE_TO_INCH = "/Toolbox/Units/Metre-to-Inch";
		public const string UNITS_CENTIMETRE_TO_KILOMETRE = "/Toolbox/Units/Centimetre-to-Kilometre";
		public const string UNITS_CENTIMETRE_TO_METRE = "/Toolbox/Units/Centimetre-to-Metre";

		public const string UNITS_CENTIMETRE_TO_MILLIMETRE = "/Toolbox/Units/Centimetre-to-Millimetre";
		public const string UNITS_CENTIMETRE_TO_MILE = "/Toolbox/Units/Centimetre-to-Mile";
		public const string UNITS_CENTIMETRE_TO_YARD = "/Toolbox/Units/Centimetre-to-Yard";
		public const string UNITS_CENTIMETRE_TO_FOOT = "/Toolbox/Units/Centimetre-to-Foot";
		public const string UNITS_CENTIMETRE_TO_INCH = "/Toolbox/Units/Centimetre-to-Inch";
		public const string UNITS_MILLIMETRE_TO_KILOMETRE = "/Toolbox/Units/Millimetre-to-Kilometre";
		public const string UNITS_MILLIMETRE_TO_METRE = "/Toolbox/Units/Millimetre-to-Metre";
		public const string UNITS_MILLIMETRE_TO_CENTIMETRE = "/Toolbox/Units/Millimetre-to-Centimetre";

		public const string UNITS_MILLIMETRE_TO_MILE = "/Toolbox/Units/Millimetre-to-Mile";
		public const string UNITS_MILLIMETRE_TO_YARD = "/Toolbox/Units/Millimetre-to-Yard";
		public const string UNITS_MILLIMETRE_TO_FOOT = "/Toolbox/Units/Millimetre-to-Foot";
		public const string UNITS_MILLIMETRE_TO_INCH = "/Toolbox/Units/Millimetre-to-Inch";
		public const string UNITS_MILE_TO_KILOMETRE = "/Toolbox/Units/Mile-to-Kilometre";
		public const string UNITS_MILE_TO_METRE = "/Toolbox/Units/Mile-to-Metre";
		public const string UNITS_MILE_TO_CENTIMETRE = "/Toolbox/Units/Mile-to-Centimetre";
		public const string UNITS_MILE_TO_MILLIMETRE = "/Toolbox/Units/Mile-to-Millimetre";

		public const string UNITS_MILE_TO_YARD = "/Toolbox/Units/Mile-to-Yard";
		public const string UNITS_MILE_TO_FOOT = "/Toolbox/Units/Mile-to-Foot";
		public const string UNITS_MILE_TO_INCH = "/Toolbox/Units/Mile-to-Inch";
		public const string UNITS_YARD_TO_KILOMETRE = "/Toolbox/Units/Yard-to-Kilometre";
		public const string UNITS_YARD_TO_METRE = "/Toolbox/Units/Yard-to-Metre";
		public const string UNITS_YARD_TO_CENTIMETRE = "/Toolbox/Units/Yard-to-Centimetre";
		public const string UNITS_YARD_TO_MILLIMETRE = "/Toolbox/Units/Yard-to-Millimetre";
		public const string UNITS_YARD_TO_MILE = "/Toolbox/Units/Yard-to-Mile";

		public const string UNITS_YARD_TO_FOOT = "/Toolbox/Units/Yard-to-Foot";
		public const string UNITS_YARD_TO_INCH = "/Toolbox/Units/Yard-to-Inch";
		public const string UNITS_FOOT_TO_KILOMETRE = "/Toolbox/Units/Foot-to-Kilometre";
		public const string UNITS_FOOT_TO_METRE = "/Toolbox/Units/Foot-to-Metre";
		public const string UNITS_FOOT_TO_CENTIMETRE = "/Toolbox/Units/Foot-to-Centimetre";
		public const string UNITS_FOOT_TO_MILLIMETRE = "/Toolbox/Units/Foot-to-Millimetre";
		public const string UNITS_FOOT_TO_MILE = "/Toolbox/Units/Foot-to-Mile";
		public const string UNITS_FOOT_TO_YARD = "/Toolbox/Units/Foot-to-Yard";

		public const string UNITS_FOOT_TO_INCH = "/Toolbox/Units/Foot-to-Inch";
		public const string UNITS_INCH_TO_KILOMETRE = "/Toolbox/Units/Inch-to-Kilometre";
		public const string UNITS_INCH_TO_METRE = "/Toolbox/Units/Inch-to-Metre";
		public const string UNITS_INCH_TO_CENTIMETRE = "/Toolbox/Units/Inch-to-Centimetre";
		public const string UNITS_INCH_TO_MILLIMETRE = "/Toolbox/Units/Inch-to-Millimetre";
		public const string UNITS_INCH_TO_MILE = "/Toolbox/Units/Inch-to-Mile";
		public const string UNITS_INCH_TO_YARD = "/Toolbox/Units/Inch-to-Yard";
		public const string UNITS_INCH_TO_FOOT = "/Toolbox/Units/Inch-to-Foot";

		// Units - UnitOfMass

		public const string UNITS_KILOGRAM_TO_STONE = "/Toolbox/Units/Kilogram-to-Stone";
		public const string UNITS_KILOGRAM_TO_POUND = "/Toolbox/Units/Kilogram-to-Pound";
		public const string UNITS_KILOGRAM_TO_TONNE = "/Toolbox/Units/Kilogram-to-Tonne";
		public const string UNITS_KILOGRAM_TO_GRAM = "/Toolbox/Units/Kilogram-to-Gram";
		public const string UNITS_KILOGRAM_TO_OUNCE = "/Toolbox/Units/Kilogram-to-Ounce";
		public const string UNITS_STONE_TO_KILOGRAM = "/Toolbox/Units/Stone-to-Kilogram";

		public const string UNITS_STONE_TO_POUND = "/Toolbox/Units/Stone-to-Pound";
		public const string UNITS_STONE_TO_TONNE = "/Toolbox/Units/Stone-to-Tonne";
		public const string UNITS_STONE_TO_GRAM = "/Toolbox/Units/Stone-to-Gram";
		public const string UNITS_STONE_TO_OUNCE = "/Toolbox/Units/Stone-to-Ounce";
		public const string UNITS_POUND_TO_KILOGRAM = "/Toolbox/Units/Pound-to-Kilogram";
		public const string UNITS_POUND_TO_STONE = "/Toolbox/Units/Pound-to-Stone";

		public const string UNITS_POUND_TO_TONNE = "/Toolbox/Units/Pound-to-Tonne";
		public const string UNITS_POUND_TO_GRAM = "/Toolbox/Units/Pound-to-Gram";
		public const string UNITS_POUND_TO_OUNCE = "/Toolbox/Units/Pound-to-Ounce";
		public const string UNITS_TONNE_TO_KILOGRAM = "/Toolbox/Units/Tonne-to-Kilogram";
		public const string UNITS_TONNE_TO_STONE = "/Toolbox/Units/Tonne-to-Stone";
		public const string UNITS_TONNE_TO_POUND = "/Toolbox/Units/Tonne-to-Pound";

		public const string UNITS_TONNE_TO_GRAM = "/Toolbox/Units/Tonne-to-Gram";
		public const string UNITS_TONNE_TO_OUNCE = "/Toolbox/Units/Tonne-to-Ounce";
		public const string UNITS_GRAM_TO_KILOGRAM = "/Toolbox/Units/Gram-to-Kilogram";
		public const string UNITS_GRAM_TO_STONE = "/Toolbox/Units/Gram-to-Stone";
		public const string UNITS_GRAM_TO_POUND = "/Toolbox/Units/Gram-to-Pound";
		public const string UNITS_GRAM_TO_TONNE = "/Toolbox/Units/Gram-to-Tonne";

		public const string UNITS_GRAM_TO_OUNCE = "/Toolbox/Units/Gram-to-Ounce";
		public const string UNITS_OUNCE_TO_KILOGRAM = "/Toolbox/Units/Ounce-to-Kilogram";
		public const string UNITS_OUNCE_TO_STONE = "/Toolbox/Units/Ounce-to-Stone";
		public const string UNITS_OUNCE_TO_POUND = "/Toolbox/Units/Ounce-to-Pound";
		public const string UNITS_OUNCE_TO_TONNE = "/Toolbox/Units/Ounce-to-Tonne";
		public const string UNITS_OUNCE_TO_GRAM = "/Toolbox/Units/Ounce-to-Gram";

		// Units - UnitOfSpeed

		public const string UNITS_MILE_PER_HOUR_TO_KILOMETRE_PER_HOUR = "/Toolbox/Units/Mile-Per-Hour-to-Kilometre-Per-Hour";
		public const string UNITS_MILE_PER_HOUR_TO_FOOT_PER_SECOND = "/Toolbox/Units/Mile-Per-Hour-to-Foot-Per-Second";
		public const string UNITS_MILE_PER_HOUR_TO_METRE_PER_SECOND = "/Toolbox/Units/Mile-Per-Hour-to-Metre-Per-Second";
		public const string UNITS_MILE_PER_HOUR_TO_KNOT = "/Toolbox/Units/Mile-Per-Hour-to-Knot";
		public const string UNITS_KILOMETRE_PER_HOUR_TO_MILE_PER_HOUR = "/Toolbox/Units/Kilometre-Per-Hour-to-Mile-Per-Hour";

		public const string UNITS_KILOMETRE_PER_HOUR_TO_FOOT_PER_SECOND = "/Toolbox/Units/Kilometre-Per-Hour-to-Foot-Per-Second";
		public const string UNITS_KILOMETRE_PER_HOUR_TO_METRE_PER_SECOND = "/Toolbox/Units/Kilometre-Per-Hour-to-Metre-Per-Second";
		public const string UNITS_KILOMETRE_PER_HOUR_TO_KNOT = "/Toolbox/Units/Kilometre-Per-Hour-to-Knot";
		public const string UNITS_FOOT_PER_SECOND_TO_MILE_PER_HOUR = "/Toolbox/Units/Foot-Per-Second-to-Mile-Per-Hour";
		public const string UNITS_FOOT_PER_SECOND_TO_KILOMETRE_PER_HOUR = "/Toolbox/Units/Foot-Per-Second-to-Kilometre-Per-Hour";

		public const string UNITS_FOOT_PER_SECOND_TO_METRE_PER_SECOND = "/Toolbox/Units/Foot-Per-Second-to-Metre-Per-Second";
		public const string UNITS_FOOT_PER_SECOND_TO_KNOT = "/Toolbox/Units/Foot-Per-Second-to-Knot";
		public const string UNITS_METRE_PER_SECOND_TO_MILE_PER_HOUR = "/Toolbox/Units/Metre-Per-Second-to-Mile-Per-Hour";
		public const string UNITS_METRE_PER_SECOND_TO_KILOMETRE_PER_HOUR = "/Toolbox/Units/Metre-Per-Second-to-Kilometre-Per-Hour";
		public const string UNITS_METRE_PER_SECOND_TO_FOOT_PER_SECOND = "/Toolbox/Units/Metre-Per-Second-to-Foot-Per-Second";

		public const string UNITS_METRE_PER_SECOND_TO_KNOT = "/Toolbox/Units/Metre-Per-Second-to-Knot";
		public const string UNITS_KNOT_TO_MILE_PER_HOUR = "/Toolbox/Units/Knot-to-Mile-Per-Hour";
		public const string UNITS_KNOT_TO_KILOMETRE_PER_HOUR = "/Toolbox/Units/Knot-to-Kilometre-Per-Hour";
		public const string UNITS_KNOT_TO_FOOT_PER_SECOND = "/Toolbox/Units/Knot-to-Foot-Per-Second";
		public const string UNITS_KNOT_TO_METRE_PER_SECOND = "/Toolbox/Units/Knot-to-Metre-Per-Second";
		#endregion

	}
}
