using CloudToolbox.Data;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class CalculatorCollectionBase : ComponentBase
	{
		[Parameter]
		public RenderFragment? Description { get; set; }

		[Parameter]
		public Area Area { get; set; }
		public List<Calculator> FilteredCalculators { get; set; }

		public string FilterText { get; set; }
		private bool hasSearched = false;

		public CalculatorCollectionBase()
		{
			FilterText = string.Empty;
		}

		protected override void OnInitialized()
		{
			FilteredCalculators = Area.Calculators;
		}

		protected void FilterCalculators()
		{
			if (!string.IsNullOrEmpty(FilterText))
			{
				var filterTextLower = FilterText.ToLower().Trim();

				hasSearched = true;
				FilteredCalculators = Area.Calculators
					.Where(x => (x.DisplayName.ToLower().Contains(filterTextLower) || string.Join(" ", x.Aliases).ToLower().Contains(filterTextLower)))
					.OrderBy(x => x.DisplayName)
					.ToList();
			}
			else
			{
				if (hasSearched)
				{
					FilteredCalculators = Area.Calculators;
					InvokeAsync(StateHasChanged);
				}
			}
		}
	}
}
