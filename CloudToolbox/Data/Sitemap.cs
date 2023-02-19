using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Data
{
	public static class Sitemap
	{
		private static string sitemapCache = string.Empty;
		private static int sitemapCacheTimeoutInHours = 24 * 7;
		private static DateTime sitemapLastUpdated = DateTime.MinValue;

		private static readonly string baseUrl = "https://cloudtoolbox.co.uk";
		private static readonly string toolboxUrl = $"{baseUrl}/Toolbox";

		public static async Task Generate(HttpContext context)
		{
			StringWriter resSw = new();

			if (sitemapLastUpdated.AddHours(sitemapCacheTimeoutInHours) <= DateTime.Now || sitemapCache == null)
			{

				await resSw.WriteLineAsync("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
				await resSw.WriteLineAsync($"<!-- Cache date:  {DateTime.Now:g} -->");
				await resSw.WriteLineAsync($"<!-- Next update: {DateTime.Now.AddHours(sitemapCacheTimeoutInHours):g} -->");

				await resSw.WriteLineAsync("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

				foreach (var fieldInfo in typeof(Routes).GetFields())
				{
					string? value = (string?)fieldInfo.GetValue(null);

					if (value != null)
					{
						await WriteUrlXml(resSw, $"{baseUrl}{value}");
					}
				}

				await WriteTextCalcs(resSw);
				await WriteDevCalcs(resSw);
				await WriteUnitCalcs(resSw);
				await resSw.WriteLineAsync("</urlset>");
				// Finish writing

				sitemapLastUpdated = DateTime.Now;
				sitemapCache = resSw.ToString();
			}

			await context.Response.WriteAsync(sitemapCache);
		}

		private static async Task WriteTextCalcs(StringWriter resSw)
		{
			var textCalcs = Enumeration.GetAll<TextCalculatorsEnum>();

			foreach (TextCalculatorsEnum calc in textCalcs)
			{
				var uri = $"{toolboxUrl}/Text/To-{calc.UriName}";
				await WriteUrlXml(resSw, uri);
			}
		}

		private static async Task WriteDevCalcs(StringWriter resSw)
		{
			var devCalcs = Enumeration.GetAll<DeveloperCalculatorsEnum>();

			foreach (DeveloperCalculatorsEnum calc in devCalcs)
			{
				for (int i = 0; i < 2; i++)
				{
					string dir = i == 0 ? "To" : "From";
					var uri = $"{toolboxUrl}/Developer/{dir}-{calc.UriName}";
					await WriteUrlXml(resSw, uri);
				}
			}
		}

		private static async Task WriteUnitCalcs(StringWriter resSw)
		{
			var units = Enumeration.GetAll<UnitCalculatorsEnum>();
			foreach (var (from, to) in units.SelectMany(from => units.Where(to => from != to).Select(to => (from, to))))
			{
				if (to.UnitType == from.UnitType)
				{
					var uri = $"{toolboxUrl}/Units/{from.UriName}-to-{to.UriName}";
					await WriteUrlXml(resSw, uri);
				}
			}
		}

		private static async Task WriteUrlXml(StringWriter resSw, string url)
		{
			await resSw.WriteLineAsync("<url>");
			await resSw.WriteLineAsync($"<loc>{url}</loc>");
			await resSw.WriteLineAsync("</url>");
		}
	}
}
