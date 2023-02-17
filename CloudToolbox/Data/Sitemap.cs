using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CloudToolbox.Data
{
	public class Sitemap
	{
		private static string baseUrl = "https://cloudtoolbox.co.uk";
		private static string toolboxUrl = "https://cloudtoolbox.co.uk/Toolbox";
		private static string dt = DateTime.Now.ToString("yy-MM-dd");
		public static async Task Generate(HttpContext context)
		{
			await context.Response.WriteAsync("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			await context.Response.WriteAsync("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

			WriteUrlXml(context, baseUrl);
			WriteUrlXml(context, toolboxUrl);

			var fields = typeof(Routes).GetFields();

			foreach (var finfo in fields)
			{
				string value = (string)finfo.GetValue(null);
				WriteUrlXml(context, $"{baseUrl}{value}");
			}

			// In routes
			//WriteCollections(context);

			WriteTextCalcs(context);
			WriteDevCalcs(context);
			WriteUnitCalcs(context);

			await context.Response.WriteAsync("</urlset>");
		}


		private static async void WriteCollections(HttpContext context)
		{
			var collections = (new CalculatorCollectionService()).GetCollections();

			foreach (var col in collections)
			{
				var uri = $"{toolboxUrl}/{col.Name}";

				WriteUrlXml(context, uri);
			}
		}

		private static async void WriteTextCalcs(HttpContext context)
		{
			var textCalcs = Enumeration.GetAll<TextCalculatorsEnum>();

			foreach (TextCalculatorsEnum calc in textCalcs)
			{
				var uri = $"{toolboxUrl}/Text/To-{calc.UriName}";
				WriteUrlXml(context, uri);
			}
		}

		private static async void WriteDevCalcs(HttpContext context)
		{
			var devCalcs = Enumeration.GetAll<DeveloperCalculatorsEnum>();

			foreach (DeveloperCalculatorsEnum calc in devCalcs)
			{
				for (int i = 0; i < 2; i++)
				{
					string dir = i == 0 ? "To" : "From";
					var uri = $"{toolboxUrl}/Developer/{dir}-{calc.UriName}";
					WriteUrlXml(context, uri);
				}
			}
		}


		private static async void WriteUnitCalcs(HttpContext context)
		{
			var units = Enumeration.GetAll<UnitCalculatorsEnum>();
			foreach (var (from, to) in units.SelectMany(from => units.Where(to => from != to).Select(to => (from, to))))
			{
				var uri = $"{toolboxUrl}/Units/{from.UriName}-to-{to.UriName}";
				WriteUrlXml(context, uri);
			}
		}

		private static async void WriteUrlXml(HttpContext context, string url)
		{
			await context.Response.WriteAsync("<url>");
			await context.Response.WriteAsync($"<loc>{url}</loc>");
			await context.Response.WriteAsync($"<lastmod>{dt}</lastmod>");
			await context.Response.WriteAsync($"<changefreq>monthly</changefreq>");
			await context.Response.WriteAsync("</url>");
		}
	}
}
