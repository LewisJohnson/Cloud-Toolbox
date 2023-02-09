using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class ToBase64Base : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("ToBinary", typeof(string)) { Label = "Text", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Base64", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;
			string res = string.Join(" ", Encoding.ASCII.GetBytes(inputString).Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));

			results.Add(new(res) { Label = "Base64", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
