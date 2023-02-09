using System.Text;
using CloudToolbox.Common.Enums;

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


static StringBuilder GenerateEnumRoutes<TEnum>(string area) where TEnum : struct, Enum
{
	StringBuilder sb = new StringBuilder();

	var name = typeof(TEnum).Name;
	sb.AppendLine($"// {area} - {name}");

	var values = Enum.GetValues<TEnum>();

	foreach (var from in values)
	{
		string fromStr = Enum.GetName(from);

		foreach (var to in values)
		{
			string toStr = Enum.GetName(to);

			if (from.Equals(to))
			{
				sb.Append(Environment.NewLine);
			}
			else
			{
				sb.AppendLine($"public const string {area.ToUpper()}_{fromStr.ToUpper()}_TO_{toStr.ToUpper()} = \"/Toolbox/{area}/{fromStr.Replace("_", "-")}-to-{toStr.Replace("_", "-")}\";");
			} 
		}
	}

	return sb;
}

static void GenerateAllRoutes()
{
	StringBuilder sb = new StringBuilder();

	sb.AppendLine("#region GENERATED ROUTES");
	sb.AppendLine("// GENERATED ROUTES");
	sb.AppendLine("// -- DO NOT MODIFY MANUALLY --");
	sb.Append(Environment.NewLine);
	sb.AppendLine($"// Units");

	sb.Append(GenerateEnumRoutes<UnitOfLength>("Units"));
	sb.Append(GenerateEnumRoutes<UnitOfMass>("Units"));
	sb.Append(GenerateEnumRoutes<UnitOfSpeed>("Units"));

	sb.AppendLine("#endregion")

	File.WriteAllText("Routes.txt", sb.ToString());
	Console.WriteLine("Generated routes to Routes.txt");
}

GenerateAllRoutes();

//UnitConverterGenerator<UnitOfLength>();
//UnitConverterGenerator<UnitOfMass>();
//UnitConverterGenerator<UnitOfSpeed>();
