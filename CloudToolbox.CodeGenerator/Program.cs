﻿using System.Text;
using CloudToolbox.CodeGenerator;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

static void UnitConverterGenerator<TEnum>() where TEnum : struct, Enum
{
	Console.WriteLine(" ");

	var name = typeof(TEnum).Name;
	var values = Enum.GetValues<TEnum>();

	foreach (var from in values)
	{
		foreach (var to in values)
		{
			if (!from.Equals(to))
				Console.WriteLine($"({name}.{from}, {name}.{to}) => val * 1,");
		}
	}
}


//RouteGenerator.GenerateAllCalculators();
//UnitOfXConverterGenerator.GenerateAllCalculators();
//CalculatorCollectionPropertiesGenerator.GenerateAllCalculatorProps();

//UnitConverterGenerator<UnitOfLength>();
//UnitConverterGenerator<UnitOfMass>();
//UnitConverterGenerator<UnitOfSpeed>();
UnitConverterGenerator<UnitOfDataTranser>();
Console.WriteLine(" ");
