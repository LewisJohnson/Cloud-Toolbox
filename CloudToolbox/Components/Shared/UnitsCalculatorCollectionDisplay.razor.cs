using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class UnitsCalculatorCollectionDisplayBase : ComponentBase
	{
		[Parameter]
		public RenderFragment? Description { get; set; }

		[Parameter]
		public CalculatorCollection Collection { get; set; }

		public List<UnitCalculatorsEnum> FilteredUnits { get; set; }

		public string FilterText { get; set; }
		private bool hasSearched = false;

		public UnitsCalculatorCollectionDisplayBase()
		{
			FilterText = string.Empty;
		}

		protected override void OnInitialized()
		{
			FilteredUnits = DefaultUnitCalculators();
		}

		protected void FilterCalculators()
		{
			if (!string.IsNullOrEmpty(FilterText))
			{
				hasSearched = true;

				var filterTextTrimmed = FilterText.Trim();
				FilteredUnits = UnitCalculatorsEnum.Search(filterTextTrimmed);
			}
			else
			{
				if (hasSearched)
				{
					FilteredUnits = DefaultUnitCalculators();
					InvokeAsync(StateHasChanged);
				}
			}
		}

		public List<UnitCalculatorsEnum> DefaultUnitCalculators()
		{
			return Enumeration.GetAll<UnitCalculatorsEnum>()
				.OrderBy(x => x.UnitOf)
				.ThenBy(x => x.Name)
				.ToList();
		}
	}
}
