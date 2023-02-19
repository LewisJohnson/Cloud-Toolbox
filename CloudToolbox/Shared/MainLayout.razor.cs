using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class MainLayoutBase : LayoutComponentBase
	{
		public bool NotFound;

		[Inject]
		public NotFoundService NotFoundService { get; set; }

		public MainLayoutBase()
		{

		}

		protected override void OnInitialized() => NotFoundService.OnNotFound += SetNotFound;

		private void SetNotFound()
		{
			NotFound = true;
			StateHasChanged();
		}
	}
}
