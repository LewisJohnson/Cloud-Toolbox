using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Helpers
{
	public static class UnitHelper
	{
		public static string GetUnitOfCssIcon(UnitOf unitOf)
		{
			return unitOf switch
			{
				UnitOf.Area => "bi-box",
				UnitOf.Data_Transfer => "bi-hdd-network",
				UnitOf.Energy => "bi-lightning",
				UnitOf.Length => "bi-rulers",
				UnitOf.Mass => "bi-chevron-bar-down",
				UnitOf.Speed => "bi-speedometer",
				UnitOf.Time => "bi-clock",
				_ => string.Empty,
			};
		}

		public static string GetUnitOfDisplayName(UnitOf unitOf)
		{
			return unitOf switch
			{
				UnitOf.Area => "Area",
				UnitOf.Data_Transfer => "Data Transfer",
				UnitOf.Energy => "Energy",
				UnitOf.Length => "Length",
				UnitOf.Mass => "Mass",
				UnitOf.Speed => "Speed",
				UnitOf.Time => "Date & Time",
				_ => string.Empty,
			};
		}
	}
}
