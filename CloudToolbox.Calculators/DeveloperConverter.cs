using System.Text;
using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators
{
	public class DeveloperConverter : IConverter<string>
	{
		private (DeveleoperCalculatorDirection, DeveloperCalculatorType) calculator;

		public DeveloperConverter((DeveleoperCalculatorDirection, DeveloperCalculatorType) cal)
		{
			calculator = cal;
		}

		public string Convert(string val) => calculator switch
		{

			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Hexadecimal) => FromHex(val),
			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Hexadecimal) => System.Convert.ToHexString(Encoding.UTF8.GetBytes(val)),

			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Base64) => Encoding.UTF8.GetString(System.Convert.FromBase64String(val)),
			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Base64) => string.Join(" ", Encoding.ASCII.GetBytes(val).Select(byt => System.Convert.ToString(byt, 2).PadLeft(8, '0'))),

			(DeveleoperCalculatorDirection.From, DeveloperCalculatorType.Binary) => FromBinary(val),
			(DeveleoperCalculatorDirection.To, DeveloperCalculatorType.Binary) => string.Join(" ", Encoding.ASCII.GetBytes(val).Select(byt => System.Convert.ToString(byt, 2).PadLeft(8, '0'))),
			_ => string.Empty,
		};

		private string FromHex(string val)
		{
			byte[] hexArray = System.Convert.FromHexString(val);
			return Encoding.UTF8.GetString(hexArray, 0, hexArray.Length);
		}

		private string FromBinary(string val)
		{
			var str = val.Replace(" ", "");

			var sb = new StringBuilder();

			while (str.Length > 0)
			{
				string block = str.Substring(0, 8);
				str = str.Substring(8);
				int value = 0;

				foreach (int x in block)
				{
					int temp = x - 48;
					value = value << 1 | temp;
				}

				sb.Append(System.Convert.ToChar(value));

			}

			return sb.ToString();
		}
	}
}
