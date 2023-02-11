using System.IO;
using System.Text;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.CodeGenerator
{
	//public static class CalculatorCollectionPropertiesGenerator
	//{
	//	public static StringBuilder GenerateProps<TEnum>(string area) where TEnum : struct, Enum
	//	{
	//		StringBuilder sb = new StringBuilder();

	//		var name = typeof(TEnum).Name;
	//		sb.AppendLine($"// {area} - {name}");

	//		var values = Enum.GetValues<TEnum>();

	//		foreach (var from in values)
	//		{
	//			string fromStr = Enum.GetName(from);

	//			foreach (var to in values)
	//			{
	//				string toStr = Enum.GetName(to);

	//				if (from.Equals(to))
	//				{
	//					sb.Append(Environment.NewLine);
	//				}
	//				else
	//				{
	//					string FromShorthand;
	//					string ToShorthand;

	//					if (typeof(TEnum) == typeof(UnitOfLength))
	//					{
	//						FromShorthand = Shorthands.UNIT_OF_LENGTH[(UnitOfLength)(object)from];
	//						ToShorthand = Shorthands.UNIT_OF_LENGTH[(UnitOfLength)(object)to];
	//					}
	//					else if (typeof(TEnum) == typeof(UnitOfMass))
	//					{
	//						FromShorthand = Shorthands.UNIT_OF_MASS[(UnitOfMass)(object)from];
	//						ToShorthand = Shorthands.UNIT_OF_MASS[(UnitOfMass)(object)to];
	//					}
	//					else if (typeof(TEnum) == typeof(UnitOfSpeed))
	//					{
	//						FromShorthand = Shorthands.UNIT_OF_SPEED[(UnitOfSpeed)(object)from];
	//						ToShorthand = Shorthands.UNIT_OF_SPEED[(UnitOfSpeed)(object)to];
	//					}
	//					else
	//					{
	//						throw new NotSupportedException();
	//					}
	//					var alises = $"Aliases = new List<string>() {{{{ \"{FromShorthand} to {ToShorthand}\" }}, {{ \"{ToShorthand} to {FromShorthand}\" }}}}";

	//					var r = $"public static ResultDisplayCalculator {from}To{to} = new(Area) {{ DisplayName = \"{from} to {to}\", Uri = Routes.{area.ToUpper()}_{fromStr.ToUpper()}_TO_{toStr.ToUpper()}, {alises}}};"; ;
	//					sb.AppendLine(r);
	//				}
	//			}
	//		}

	//		return sb;
	//	}


	//	public static void GenerateAllCalculatorProps()
	//	{
	//		StringBuilder sb = new StringBuilder();

	//		sb.AppendLine("#region GENERATED CALCULATORS");
	//		sb.AppendLine("// GENERATED CALCULATORS");
	//		sb.AppendLine("// -- DO NOT MODIFY MANUALLY --");
	//		sb.Append(Environment.NewLine);

	//		sb.Append(GenerateProps<UnitOfLength>("Units"));
	//		sb.Append(GenerateProps<UnitOfMass>("Units"));
	//		sb.Append(GenerateProps<UnitOfSpeed>("Units"));

	//		sb.AppendLine("#endregion");

	//		var path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "GeneratedCode", "CalculatorCollection");
	//		Directory.CreateDirectory(path);

	//		var outputPath = Path.Combine(path, "Units.txt");
	//		File.WriteAllText(outputPath, sb.ToString());
	//		Console.WriteLine($"Generated routes to {outputPath}");
	//	}
	//}
}
