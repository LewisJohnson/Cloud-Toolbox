using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class InchToCmBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Number", typeof(string)) { EndInputGroupText = "in" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "cm" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null)
			{
				var res = ((double)(input * 2.54)).ToString("#.##");
				results.Add(new(res) { Label = "cm" });
			}

			return results;
		}
	}
}
