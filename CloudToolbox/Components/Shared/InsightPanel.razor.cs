using CloudToolbox.Common.Data;
using CloudToolbox.Services;
using CloudToolbox.Services.Data;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class InsightPanel : ComponentBase
	{
		private Insight? insight;
		private bool hasInsightsLoaded;
		private bool hideInsight;
		[Inject]
		public InsightsService InsightsService { get; set; }

		[Parameter]
		public Enumeration? CalculatorEnum { get; set; }

		public InsightPanel()
		{
		}

		protected override async Task OnInitializedAsync()
		{
			if (CalculatorEnum != null)
			{
				insight = await InsightsService.SearchAsync(CalculatorEnum.Name);
				hasInsightsLoaded = true;
			}
			else
			{
				hideInsight = true;
			}
		}
	}
}
