using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class ToHexBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("ToHex", typeof(string)) { Label = "Text", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Hexadecimal", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;

			results.Add(new(Convert.ToHexString(Encoding.UTF8.GetBytes(inputString))) { Label = "Hexadecimal", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
