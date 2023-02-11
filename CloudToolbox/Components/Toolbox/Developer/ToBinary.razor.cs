using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Developer
{
	public partial class ToBinaryBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("ToBinary", typeof(string)) { Label = "Text", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Binary", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;
			string res = string.Join(" ", Encoding.ASCII.GetBytes(inputString).Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));

			results.Add(new(res) { Label = "Binary", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
