﻿using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class MphToKmhBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("Number", typeof(string)) { EndInputGroupText = "mi/h" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "km/h" },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null)
			{
				var res = ((double)(input * 1.609344)).ToString("#.##");
				results.Add(new(res) { Label = "km/h" });
			}

			return results;
		}
	}
}
