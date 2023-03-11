using System.Reflection;
using System.Text.Json;
using CloudToolbox.Services.Data;

namespace CloudToolbox.Services
{
	public class InsightsService
	{
		private Dictionary<string, Insight> insightsCache;

		public InsightsService()
		{
		}


		public async Task<Insight?> SearchAsync(string searchTerm)
		{
			searchTerm = searchTerm.Trim().ToLower();

			if (insightsCache == null)
			{
				InsightsJsonRoot? insightsData = await LoadJsonFile("CloudToolbox.Services.Data.InsightsData.json");

				if (insightsData == null)
				{
					return null;
				}

				insightsCache = insightsData.Insights.ToDictionary(x => x.Name.Trim().ToLower(), x => x);
			}

			if (insightsCache.TryGetValue(searchTerm, out Insight? value))
			{
				return value;
			}

			return null;
		}

		public static async Task<InsightsJsonRoot?> LoadJsonFile(string fullFilename)
		{
			using (Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fullFilename))
			{
				if (stream != null)
				{
					return await JsonSerializer.DeserializeAsync<InsightsJsonRoot>(stream);
				}
			}

			return default;
		}
	}
}

