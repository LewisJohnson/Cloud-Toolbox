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
		public Common.Data.CalculatorCollection Collection { get; set; }
	}
}
