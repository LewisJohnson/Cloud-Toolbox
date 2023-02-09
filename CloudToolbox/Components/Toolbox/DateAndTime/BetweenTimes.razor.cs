using System;
using Microsoft.AspNetCore.Components;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Types;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class BetweenTimesBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("StartTime", typeof(TimeOnly)) { StartInputGroupText = "Start Time", InputTimeOnly = new TimeOnly(6,0,0) },
			new("EndTime", typeof(TimeOnly)) { StartInputGroupText = "End Time", InputTimeOnly = new TimeOnly(18,0,0) },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "% of the day" },
			new CalculatorResult(null) { EndInputGroupText = "hours" },
			new CalculatorResult(null) { EndInputGroupText = "minutes"},
			new CalculatorResult(null) { EndInputGroupText = "seconds"},
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			TimeOnly startDate = inputs[0].InputTimeOnly.GetValueOrDefault();
			TimeOnly endDate = inputs[1].InputTimeOnly.GetValueOrDefault();

			TimeSpan ts = endDate - startDate;
			
			results.Add(new((ts.TotalDays * 100).ToString("0.##")) { EndInputGroupText = "% of the day" });
			results.Add(new(ts.TotalHours.ToString("0.##")) { EndInputGroupText = "hours" });
			results.Add(new(ts.TotalMinutes.ToString()) { EndInputGroupText = "minutes" });
			results.Add(new(ts.TotalSeconds.ToString()) { EndInputGroupText = "seconds" });

			return results;
		}
	}
}
