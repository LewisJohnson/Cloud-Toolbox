using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Services;
using CloudToolbox.Services.Data;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class UnitsInsightPanel : ComponentBase
	{
		private readonly Dictionary<string, Insight?> insights;
		private bool hasInsightsLoaded;

		[Inject]
		public InsightsService InsightsService { get; set; }

		[Parameter]
		public List<UnitCalculatorsEnum> UnitCalculators { get; set; }

		public UnitsInsightPanel()
		{
			UnitCalculators = new List<UnitCalculatorsEnum>();
			insights = new Dictionary<string, Insight?>();
		}

		protected override async Task OnInitializedAsync()
		{
			await Parallel.ForEachAsync(UnitCalculators, async (unit, t) =>
			{
				insights.Add(unit.Name, await InsightsService.SearchAsync(unit.Name));
			});

			hasInsightsLoaded = true;
		}

	}
}
