using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class FromBinaryBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("FromBinary", typeof(string)) { Label = "Binary", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Text", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;

			var str = inputString.Replace(" ", "");

			StringBuilder sb = new StringBuilder();

			while (str.Length > 0)
			{
				string block = str.Substring(0, 8);
				str = str.Substring(8);
				int value = 0;

				foreach (int x in block)
				{
					int temp = x - 48;
					value = (value << 1) | temp;
				}

				sb.Append(Convert.ToChar(value));
			}

			results.Add(new(sb.ToString()) { Label = "Text", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
