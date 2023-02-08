using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class FromBase64Base : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("FromBase64", typeof(string)) { Label = "Base64", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Text", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;
			var res = Encoding.UTF8.GetString(Convert.FromBase64String(inputString));

			results.Add(new(res) { Label = "Text", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
