using System;
using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Enums.Units;


namespace CloudToolbox.Components.Toolbox.Units
{
	public static class UnitCalc<TEnum> where TEnum : Enum
	{
		//public static string? GetUnitShorthand(TEnum val) => default(TEnum) switch
		//{
		//	UnitOfLength => Shorthands.UNIT_OF_LENGTH[(UnitOfLength)(object)val],
		//	UnitOfMass => Shorthands.UNIT_OF_MASS[(UnitOfMass)(object)val],
		//	UnitOfSpeed => Shorthands.UNIT_OF_SPEED[(UnitOfSpeed)(object)val],
		//	_ => null,
		//};

		//public static string? GetUnitFullname(TEnum val) => default(TEnum) switch
		//{
		//	UnitOfLength => Fullnames.UNIT_OF_LENGTH[(UnitOfLength)(object)val],
		//	UnitOfMass => Fullnames.UNIT_OF_MASS[(UnitOfMass)(object)val],
		//	UnitOfSpeed => Fullnames.UNIT_OF_SPEED[(UnitOfSpeed)(object)val],
		//	_ => null,
		//};
	}
}
