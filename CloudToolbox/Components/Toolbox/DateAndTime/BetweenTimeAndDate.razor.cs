using System;
using Microsoft.AspNetCore.Components;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Types;

namespace CloudToolbox.Components.Toolbox.DateAndTime
{
	public partial class BetweenTimeAndDateBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("StartDate", typeof(DateTime)) { StartInputGroupText = "Start Date", InputDateTime = DateTime.Now },
			new("StartTime", typeof(TimeOnly)) { StartInputGroupText = "Start Time", InputTimeOnly = new TimeOnly(6,0,0) },

			new("EndDate", typeof(DateTime)) { StartInputGroupText = "End Date", InputDateTime = DateTime.Now.AddDays(7) },
			new("EndTime", typeof(TimeOnly)) { StartInputGroupText = "End Time", InputTimeOnly = new TimeOnly(18,0,0) },

			new("Include End Date", typeof(Checkbox)) { EndInputGroupText = "Include End Date" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "days" },
			new CalculatorResult(null) { EndInputGroupText = "hours" },
			new CalculatorResult(null) { EndInputGroupText = "minutes"},
			new CalculatorResult(null) { EndInputGroupText = "seconds"},
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			var startDate = inputs[0].InputDateTime.GetValueOrDefault();
			var startTime = inputs[1].InputTimeOnly.GetValueOrDefault();

			var endDate = inputs[2].InputDateTime.GetValueOrDefault();
			var endTime = inputs[3].InputTimeOnly.GetValueOrDefault();

			var includeEndDate = inputs[4].InputBool;

			startDate = startDate.Add(startTime.ToTimeSpan());
			endDate = endDate.Add(endTime.ToTimeSpan());

			TimeSpan ts = endDate - startDate;

			if (includeEndDate)
			{
				ts = ts.Add(new TimeSpan(24, 0, 0));
			}

			results.Add(new(ts.TotalDays.ToString("#.###")) { EndInputGroupText = "days" });
			results.Add(new(ts.TotalHours.ToString("#.##")) { EndInputGroupText = "hours" });
			results.Add(new(ts.TotalMinutes.ToString("#")) { EndInputGroupText = "minutes" });
			results.Add(new(ts.TotalSeconds.ToString("#")) { EndInputGroupText = "seconds" });

			return results;
		}
	}
}
