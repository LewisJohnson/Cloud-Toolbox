using System.IO;
using System.Text;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.CodeGenerator
{
	//public static class RouteGenerator
	//{
	//	public static StringBuilder GenerateEnumRoutes<TEnum>(string area) where TEnum : struct, Enum
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
	//					sb.AppendLine(GetUnitCalculatorRoute(fromStr, toStr));
	//				}
	//			}
	//		}

	//		return sb;
	//	}

	//	public static string GetUnitCalculatorRoute(string from, string to, string area = "Units")
	//	{
	//		return $"public const string {area.ToUpper()}_{from.ToUpper()}_TO_{to.ToUpper()} = \"/Toolbox/{area}/{from.Replace("_", "-")}-to-{to.Replace("_", "-")}\";";
	//	}

	//	public static void GenerateAllRoutes()
	//	{
	//		StringBuilder sb = new StringBuilder();

	//		sb.AppendLine("#region GENERATED ROUTES");
	//		sb.AppendLine("// GENERATED ROUTES");
	//		sb.AppendLine("// -- DO NOT MODIFY MANUALLY --");
	//		sb.Append(Environment.NewLine);
	//		sb.AppendLine($"// Units");

	//		sb.Append(GenerateEnumRoutes<UnitOfLength>("Units"));
	//		sb.Append(GenerateEnumRoutes<UnitOfMass>("Units"));
	//		sb.Append(GenerateEnumRoutes<UnitOfSpeed>("Units"));

	//		sb.AppendLine("#endregion");

	//		var path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "GeneratedCode", "Routes");
	//		Directory.CreateDirectory(path);

	//		var outputPath = Path.Combine(path, "Routes.txt");
	//		File.WriteAllText(outputPath, sb.ToString());
	//		Console.WriteLine($"Generated routes to {outputPath}");
	//	}
	//}
}
