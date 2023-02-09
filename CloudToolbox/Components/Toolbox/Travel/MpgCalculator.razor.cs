using CloudToolbox.Calculators;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Travel
{
	public partial class MpgCalculatorBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Price", typeof(string)) { StartInputGroupText = " ", EndInputGroupText = "pence/Litre", InputDouble = 150 },
			new("TotalSpent", typeof(string)) { StartInputGroupText = "£", EndInputGroupText = "spent", InputDouble = 35 },
			new("Miles", typeof(string)) { StartInputGroupText = " ", EndInputGroupText = "mi", InputDouble = 150 },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "mpg" },
			new CalculatorResult(null) { EndInputGroupText = "imp (gal)" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? price = inputs[0].InputDouble;
			double? totalSpent = inputs[1].InputDouble;
			double? miles = inputs[2].InputDouble;

			if (price.HasValue && totalSpent.HasValue && miles.HasValue)
			{
				string mpg = TravelCalculators.Mpg(price.Value, totalSpent.Value, miles.Value).ToString("0.##");
				string gal = TravelCalculators.ImperialGallonsUsed(price.Value, totalSpent.Value).ToString("0.##");

				results.Add(new(mpg) { EndInputGroupText = "mpg" });
				results.Add(new(gal) { EndInputGroupText = "imp (gal)" });
			}

			return results;
		}
	}
}
