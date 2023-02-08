using System.Globalization;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class ToTitleCaseBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("ToTitleCase", typeof(string)) { Label = "Text", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Text", Type = CalculatorResultType.TextArea },
		};
		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;
			string res = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString);

			results.Add(new(res) { Label = "Text", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
