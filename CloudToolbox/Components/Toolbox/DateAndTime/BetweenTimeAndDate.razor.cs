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
			new("StartDate", typeof(DateTime)) { StartInputGroupText = "Start Date" },
			new("StartTime", typeof(TimeOnly)) { StartInputGroupText = "Start Time" },

			new("EndDate", typeof(DateTime)) { StartInputGroupText = "End Date" },
			new("EndTime", typeof(TimeOnly)) { StartInputGroupText = "End Time" },

			new("Include End Date", typeof(Checkbox)) { EndInputGroupText = "Include End Date" },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { EndInputGroupText = "days" },
			new CalculatorResult(null) { EndInputGroupText = "hours" },
			new CalculatorResult(null) { EndInputGroupText = "minutes"},
			new CalculatorResult(null) { EndInputGroupText = "seconds"},
		};


		public BetweenTimeAndDateBase()
		{

		}

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			var startDate = inputs[0].InputDateTime.GetValueOrDefault();
			var startTime = inputs[1].InputTimeOnly.GetValueOrDefault();

			var endDate = inputs[2].InputDateTime.GetValueOrDefault();
			var endTime = inputs[3].InputTimeOnly.GetValueOrDefault();

			var includeEndDate = inputs[4].InputBool;

			startDate.Add(startTime.ToTimeSpan());
			endDate.Add(endTime.ToTimeSpan());

			TimeSpan ts = endDate - startDate;

			if (includeEndDate)
			{
				ts = ts.Add(new TimeSpan(24, 0, 0));
			}

			results.Add(new(ts.TotalDays.ToString("#.##")) { EndInputGroupText = "days" });
			results.Add(new(ts.TotalHours.ToString("#.##")) { EndInputGroupText = "hours" });
			results.Add(new(ts.TotalMinutes.ToString()) { EndInputGroupText = "minutes" });
			results.Add(new(ts.TotalSeconds.ToString()) { EndInputGroupText = "seconds" });

			return results;
		}
	}
}
