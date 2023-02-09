﻿using CloudToolbox.Calculators;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class LitresToGallonsBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Number", typeof(string)) { EndInputGroupText = "litres" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "gal (imp)" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null)
			{
				string res = UnitCalculators.LitreToImperialGallon(input.Value).ToString("#.##");
				results.Add(new(res) { EndInputGroupText = "gal (imp)" });
			}

			return results;
		}
	}
}
