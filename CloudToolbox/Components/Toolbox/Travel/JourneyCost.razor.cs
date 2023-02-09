using CloudToolbox.Calculators;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Travel
{
	public partial class JourneyCostBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Miles", typeof(string)) { EndInputGroupText = "miles", InputDouble = 100 },
			new("Mpg", typeof(string)) { EndInputGroupText = "mpg", InputDouble = 35 },
			new("Price", typeof(string)) { EndInputGroupText = "pence/Litre", InputDouble = 150 },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { StartInputGroupText = "£" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? miles = inputs[0].InputDouble;
			double? mpg = inputs[1].InputDouble;
			double? pencePerLitre = inputs[2].InputDouble;

			if (miles.HasValue && mpg.HasValue && pencePerLitre.HasValue)
			{
				string res = TravelCalculators.JourneyCost(miles.Value, mpg.Value, pencePerLitre.Value).ToString("0.##");
				results.Add(new(res) { StartInputGroupText = "£" });
			}

			return results;
		}
	}
}
