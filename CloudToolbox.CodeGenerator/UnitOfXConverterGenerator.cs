using System.Text;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.CodeGenerator
{
	public static class UnitOfXConverterGenerator
	{
		public static void GenerateCalculator<TEnum>(string subArea) where TEnum : struct, Enum
		{
			var values = Enum.GetValues<TEnum>();

			foreach (var from in values)
			{
				foreach (var to in values)
				{
					if (!from.Equals(to))
						GenerateFile(subArea, from, to);
				}
			}
		}

		private static void GenerateFile<TEnum>(string subArea, TEnum from, TEnum to) where TEnum : struct, Enum
		{
			string templatePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Templates");
			string razorFilePath = Path.Combine(templatePath, "UnitCalculator.txt");
			string cSharpFilePath = Path.Combine(templatePath, "UnitCalculatorBase.txt");

			string razorFile = File.ReadAllText(razorFilePath);
			string cSharpFile = File.ReadAllText(cSharpFilePath);

			string razorFileContent = ReplacePlaceholder(razorFile, from, to);
			string csharpFileContent = ReplacePlaceholder(cSharpFile, from, to);

			string outputPath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "CloudToolbox", "Components", "Toolbox", "Units", subArea);
			Directory.CreateDirectory(outputPath);

			string baseFileName = $"{from}To{to}";
			string razorOutputFile = Path.Combine(outputPath, $"{baseFileName}.razor");
			string csharpoutputFile = Path.Combine(outputPath, $"{baseFileName}.razor.cs");

			File.WriteAllText(razorOutputFile, razorFileContent);
			File.WriteAllText(csharpoutputFile, csharpFileContent);
		}

		private static string ReplacePlaceholder<TEnum>(string fileContents, TEnum from, TEnum to) where TEnum : struct, Enum
		{
			string FromShorthand;
			string ToShorthand;

			if (typeof(TEnum) == typeof(UnitOfLength))
			{
				FromShorthand = Shorthands.UNIT_OF_LENGTH[(UnitOfLength)(object)from];
				ToShorthand = Shorthands.UNIT_OF_LENGTH[(UnitOfLength)(object)to];
			}
			else if(typeof(TEnum) == typeof(UnitOfMass))
			{
				FromShorthand = Shorthands.UNIT_OF_MASS[(UnitOfMass)(object)from];
				ToShorthand = Shorthands.UNIT_OF_MASS[(UnitOfMass)(object)to];
			}
			else if (typeof(TEnum) == typeof(UnitOfSpeed))
			{
				FromShorthand = Shorthands.UNIT_OF_SPEED[(UnitOfSpeed)(object)from];
				ToShorthand = Shorthands.UNIT_OF_SPEED[(UnitOfSpeed)(object)to];
			}
			else
			{
				throw new NotSupportedException();
			}

			var unitEnumName = typeof(TEnum).Name;
			string fromStr = Enum.GetName(from);
			string toStr = Enum.GetName(to);

			return fileContents
				.Replace("#{FROM}", fromStr)
				.Replace("#{FROM_UPPER}", fromStr.ToUpper())
				.Replace("#{FROM_SHORT_HAND}", FromShorthand)
				.Replace("#{TO}", toStr)
				.Replace("#{TO_UPPER}", toStr.ToUpper())
				.Replace("#{TO_SHORT_HAND}", ToShorthand)
				.Replace("#{UNIT_ENUM}", unitEnumName)
				.Replace("#{UNIT_ENUM_UPPER}", unitEnumName.ToUpper());
		}

		public static void GenerateAllCalculators()
		{
			GenerateCalculator<UnitOfLength>("Length");
			GenerateCalculator<UnitOfMass>("Mass");
			GenerateCalculator<UnitOfSpeed>("Speed");

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"---- Unit calculators generated ----");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}


//#{FROM}
//#{FROM_UPPER}
//#{FROM_SHORT_HAND}
//#{TO}
//#{TO_UPPER}
//#{TO_SHORT_HAND}
//#{UNIT_ENUM}
//#{UNIT_ENUM_UPPER}
