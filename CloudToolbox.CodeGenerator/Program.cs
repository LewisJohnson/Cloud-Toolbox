using System.Text;
using CloudToolbox.CodeGenerator;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Services;

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


static void CssGenerator()
{
	var service = new CalculatorCollectionService();

	Console.WriteLine(":root {");
	foreach (var col in service.GetCollections())
	{
		Console.WriteLine($"--collection-accent-colour-{col.Name}: {col.CssAccentColour};");
		Console.WriteLine($"--collection-calc-header-colour-{col.Name}: {col.CssCalulatorHeaderBackgroundColour};");
		Console.WriteLine($"--collection-panel-colour-{col.Name}: {col.CssCalulatorPanelColour};");
		Console.WriteLine($"--collection-header-colour-{col.Name}: {col.CssHeaderBackgroundColour};");
	}
	Console.WriteLine("}");
	Console.WriteLine("");

	foreach (var col in service.GetCollections())
	{
		Console.WriteLine($".card.homepage.{col.Name} {{border: 1px solid var(--collection-accent-colour-{col.Name}); }}");
		Console.WriteLine($".card.homepage.{col.Name}:hover {{background: 1px solid var(--collection-header-colour-{col.Name}); }}");
		Console.WriteLine("");
	}
}

//RouteGenerator.GenerateAllCalculators();
//UnitOfXConverterGenerator.GenerateAllCalculators();
//CalculatorCollectionPropertiesGenerator.GenerateAllCalculatorProps();

//UnitConverterGenerator<UnitOfLength>();
//UnitConverterGenerator<UnitOfMass>();
//UnitConverterGenerator<UnitOfSpeed>();
//UnitConverterGenerator<UnitOfDataTranser>();
//Console.WriteLine(" ");

CssGenerator();



