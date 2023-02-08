using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class SimpleCalculatorContainerBase : ComponentBase
	{
		[Parameter]
		public RenderFragment Header { get; set; }

		[Parameter]
		public RenderFragment Calculator { get; set; }

		[Parameter]
		public string PanelColour { get; set; }

		[Parameter]
		public string HeaderColour { get; set; }

	}
}
