using CloudToolbox.Common.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static CloudToolbox.Components.Shared.Breadcrumb;

namespace CloudToolbox.Components.Shared
{
	public partial class SimpleCalculatorContainerBase : ComponentBase
	{
		[Parameter]
		public RenderFragment Header { get; set; }

		[Parameter]
		public RenderFragment Calculator { get; set; }

		[Parameter]
		public CalculatorCollection Collection { get; set; }

		public List<BreadcrumbLink> BreadcrumbLinks { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }

		private string currentUrl;

		protected override void OnParametersSet()
		{
			BreadcrumbLinks = new List<BreadcrumbLink>();
			currentUrl = NavigationManager.Uri;
			var myUrl = currentUrl.Replace(NavigationManager.BaseUri, "");

			BreadcrumbLinks.Add(new BreadcrumbLink
			{
				Address = NavigationManager.BaseUri,
				IsActive = NavigationManager.Uri == NavigationManager.BaseUri,
				OrderIndex = 1,
				Title = "Home"
			});

			var path = myUrl.Split('/');
			var count = 1;

			foreach (var link in path)
			{
				if (string.IsNullOrWhiteSpace(link))
				{
					continue;
				}

				count++;
				var lastLink = BreadcrumbLinks.Last();

				BreadcrumbLinks.Add(new BreadcrumbLink
				{
					Address = $"{lastLink.Address}{link}/",
					IsActive = link == path.Last(),
					OrderIndex = count,
					Title = BreadcrumbTitle(link)
				});
			}

			base.OnParametersSet();
		}

		public static string BreadcrumbTitle(string val)
		{
			val = string.Join("", val.Select(ch => (char.IsUpper(ch) ? " " : "") + ch));
			val = val.Replace('-', ' ');
			val = val.Replace('_', ' ');

			return val;
		}
	}
}
