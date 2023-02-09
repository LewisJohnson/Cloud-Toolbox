using CloudToolbox.Calculators;
using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Travel
{
	public partial class FuelRequiredBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Miles", typeof(string)) { EndInputGroupText = "miles", InputDouble = 100 },
			new("Mpg", typeof(string)) { EndInputGroupText = "mpg", InputDouble = 35 }
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "litres" },
			new CalculatorResult(null) { EndInputGroupText = "gal (imp)" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? miles = inputs[0].InputDouble;
			double? mpg = inputs[1].InputDouble;

			if (miles.HasValue && mpg.HasValue)
			{
				double req = TravelCalculators.FuelRequired(miles.Value, mpg.Value);

				string gal = req.ToString("0.##");
				string litres = UnitCalculators.ImperialGallonToLitre(req).ToString("0.##");

				results.Add(new(litres) { EndInputGroupText = "litres" });
				results.Add(new(gal) { EndInputGroupText = "gal (imp)" });
			}

			return results;
		}
	}
}
