using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators
{
	public class DeveloperConverter : IDeveloperConverter
	{
		private (DeveleoperCalculatorDirection, DeveloperCalculatorType) calculator;

		public DeveloperConverter((DeveleoperCalculatorDirection, DeveloperCalculatorType) cal)
		{
			calculator = cal;
		}

		public string Convert(string val) => calculator switch
		{

			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Hexadecimal) => val,
			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Hexadecimal) => val,

			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Base64) => val,
			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Base64) => val,

			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Binary) => val,
			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Binary) => val,
			_ => string.Empty,
		};
	}
}
