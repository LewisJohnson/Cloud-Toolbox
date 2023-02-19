using CloudToolbox.Common.Data;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class NavMenuBase : ComponentBase
	{
		[Inject]
		public CalculatorCollectionService CollectionService { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }


		protected List<DisplayCalculator> Calculators { get; set; } = new();
		protected List<DisplayCalculator> FilteredCalculators { get; set; } = new();
		protected List<DisplayCalculator> GlobalSearchCalculators { get; set; } = new();

		protected string GlobalSearchText { get; set; } = string.Empty;
		protected string FilterText { get; set; } = string.Empty;

		protected bool collapseNavMenu = true;
		protected bool hasSearched = false;
		protected bool hasGlobalSearched = false;
		protected string? NavMenuCssClass => collapseNavMenu ? "collapsed" : null;

		protected override void OnInitialized()
		{
			Calculators = CollectionService.GetCollections().SelectMany(x => x.Calculators).ToList();
			FilteredCalculators = Calculators;
			GlobalSearchCalculators = new List<DisplayCalculator>();
		}

		protected void ToggleNavMenu()
		{
			collapseNavMenu = !collapseNavMenu;

			GlobalSearchCalculators = new List<DisplayCalculator>();
			GlobalSearchText = string.Empty;
		}

		protected void CloseGlobalSearchMenu()
		{
			GlobalSearchCalculators = new List<DisplayCalculator>();
			GlobalSearchText = string.Empty;
			collapseNavMenu = true;
		}

		protected void GlobalSearch()
		{
			collapseNavMenu = true;

			if (!string.IsNullOrWhiteSpace(GlobalSearchText))
			{
				hasGlobalSearched = true;
				GlobalSearchCalculators = Calculators
				.Where(x =>
					x.DisplayName.Contains(GlobalSearchText, StringComparison.InvariantCultureIgnoreCase) ||
					x.Abbreviation.Contains(GlobalSearchText, StringComparison.InvariantCultureIgnoreCase) ||
					x.Aliases.Any(x => x.Contains(GlobalSearchText, StringComparison.InvariantCultureIgnoreCase))
				)
				.OrderBy(x => x.DisplayName)
				.Take(5)
				.ToList();
			}
			else
			{
				if (hasGlobalSearched)
				{
					GlobalSearchCalculators = new List<DisplayCalculator>();
					InvokeAsync(StateHasChanged);
				}
			}
		}

		protected void FilterMenuItems()
		{
			GlobalSearchText = string.Empty;

			if (FilterText != null && FilterText.Length > 0)
			{
				hasSearched = true;
				FilteredCalculators = Calculators.Where(x => x.DisplayName.ToLower().Contains(FilterText.ToLower())).ToList();
			}
			else
			{
				if (hasSearched)
				{
					FilteredCalculators = Calculators;
					InvokeAsync(StateHasChanged);
				}
			}
		}
	}
}
