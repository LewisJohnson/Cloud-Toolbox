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

		// UNITS
		public const string UNITS_KG_TO_STONE = "/Toolbox/Units/Kg-to-Stone";
		public const string UNITS_STONE_TO_KG = "/Toolbox/Units/Stone-to-Kg";
		public const string UNITS_MPH_TO_KMH = "/Toolbox/Units/Mph-to-Kmh";
		public const string UNITS_KMH_TO_MPH = "/Toolbox/Units/Kmh-to-Mph";
		public const string UNITS_INCH_TO_CM = "/Toolbox/Units/Inch-to-Cm";
		public const string UNITS_CM_TO_INCH = "/Toolbox/Units/Cm-to-Inch";
		public const string UNITS_GALLON_TO_LITRE = "/Toolbox/Units/Gallon-to-Litre";
		public const string UNITS_LITRE_TO_GALLON = "/Toolbox/Units/Litre-to-Gallon";

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
	}
}
