using System.Globalization;
using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums;

namespace CloudToolbox.Calculators
{
	public class TextConverter : IConverter<string>
	{
		private TextCalculatorType calculator;

		public TextConverter(TextCalculatorType cal)
		{
			calculator = cal;
		}

		public string Convert(string val) => calculator switch
		{
			TextCalculatorType.Lower_Case => val.ToLower(),
			TextCalculatorType.Upper_Case => val.ToUpper(),
			TextCalculatorType.Title_Case => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(val),
			TextCalculatorType.Random_Case => ToRandomCase(val),
			_ => string.Empty,
		};

		private string ToRandomCase(string val)
		{
			var res = "";
			Random r = new Random();

			foreach (var letter in val)
			{
				if (r.Next(0, 2) == 0)
				{
					res += letter.ToString().ToLower();
				}
				else
				{

					res += letter.ToString().ToUpper();
				}
			}

			return res;
		}
	}
}
