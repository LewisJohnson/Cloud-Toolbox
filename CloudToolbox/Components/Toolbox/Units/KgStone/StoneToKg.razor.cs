using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class StoneToKgBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Number", typeof(string)) { EndInputGroupText = "st" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "kg" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null)
			{
				var res = ((double)(input * 6.35)).ToString("#.##");
				results.Add(new(res) { Label = "kg" });
			}

			return results;
		}
	}
}
