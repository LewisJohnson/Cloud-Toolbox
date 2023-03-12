using System.Text;
using CloudToolbox.Calculators.Unit;
using CloudToolbox.Calculators;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;
using CloudToolbox.Common.Data;

namespace CloudToolbox.Components.Toolbox.Maths
{
	public partial class PercentageCalculatorBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Percentage", typeof(string)) { StartInputGroupText = "What is", EndInputGroupText = "%" },
			new("Total", typeof(string)) { StartInputGroupText = "of" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "%" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? percentage = inputs[0].InputDouble;
			double? totalNumber = inputs[1].InputDouble;

			if (percentage.HasValue && totalNumber.HasValue)
			{
				if (totalNumber.Value == 0)
				{
					results.Add(new("Enter a number higher than 0"));
				}
				else
				{

					double calc = (percentage.Value * totalNumber.Value) / 100;
					results.Add(new(calc.ToString(Constants.FRONTEND_NUMBER_FORMAT)) { EndInputGroupText = "%" });
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
