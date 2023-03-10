namespace CloudToolbox.Common.Enums.Units
{
	[Flags]
	public enum UnitSystem
	{
		None = 0,
		SI = 1,
		SI_Derived = 2,
		Metric = 4,
		Imperial = 8,
		Customary = 16,
	}
}
