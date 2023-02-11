using CloudToolbox.Common.Data;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class CalculatorCollectionBase : ComponentBase
	{
		[Parameter]
		public RenderFragment? Description { get; set; }

		[Parameter]
		public Common.Data.CalculatorCollection Collection { get; set; }
		public List<DisplayCalculator> FilteredCalculators { get; set; }

		public string FilterText { get; set; }
		private bool hasSearched = false;

		public CalculatorCollectionBase()
		{
			FilterText = string.Empty;
		}

		protected override void OnInitialized()
		{
			FilteredCalculators = Collection.Calculators;
		}

		protected void FilterCalculators()
		{
			if (!string.IsNullOrEmpty(FilterText))
			{
				var filterTextLower = FilterText.ToLower().Trim();

				hasSearched = true;
				FilteredCalculators = Collection.Calculators
					.Where(x => (x.DisplayName.ToLower().Contains(filterTextLower) || string.Join(" ", x.Aliases).ToLower().Contains(filterTextLower)))
					.OrderBy(x => x.DisplayName)
					.ToList();
			}
			else
			{
				if (hasSearched)
				{
					FilteredCalculators = Collection.Calculators;
					InvokeAsync(StateHasChanged);
				}
			}
		}
	}
}
