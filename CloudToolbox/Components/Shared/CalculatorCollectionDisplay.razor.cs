using CloudToolbox.Common.Data;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class CalculatorCollectionDisplayBase : ComponentBase
	{
		[Parameter]
		public RenderFragment? Description { get; set; }

		[Parameter]
		public CalculatorCollection Collection { get; set; }
		public List<DisplayCalculator> FilteredCalculators { get; set; }

		public string FilterText { get; set; }
		private bool hasSearched = false;

		public CalculatorCollectionDisplayBase()
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
				hasSearched = true;

				var filterTextTrimmed = FilterText.Trim();
				FilteredCalculators = Collection.Search(filterTextTrimmed);
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
