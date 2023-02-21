using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Maths
{
	public partial class RandomNumberGeneratorBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Min", typeof(string)) { StartInputGroupText = "Min" },
			new("Max", typeof(string)) { StartInputGroupText = "Max" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { StartInputGroupText = "R =" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? min = inputs[0].InputDouble;
			double? max = inputs[1].InputDouble;

			if (min.HasValue && max.HasValue)
			{
				if (min.Value > 0 && max.Value > 0)
				{
					Random r = new Random();

					int vMin = (int)min.Value;
					int vMax = (int)max.Value;

					double calc = r.Next(vMin, vMax);
					results.Add(new(calc.ToString("0")) { StartInputGroupText = "R =" });
				}
				else
				{
					results.Add(new("Enter a number higher than 0"));
				}
			}
			else
			{
				results.Add(new("Please enter 2 numbers"));
			}

			return results;
		}
	}
}
