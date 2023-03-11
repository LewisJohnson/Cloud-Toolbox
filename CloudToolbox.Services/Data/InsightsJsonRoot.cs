using System.Text.Json.Serialization;

namespace CloudToolbox.Services.Data
{
	public record InsightsJsonRoot(
		[property: JsonPropertyName("product")] string Product,
		[property: JsonPropertyName("version")] double Version,
		[property: JsonPropertyName("lastRevision")] string LastRevision,
		[property: JsonPropertyName("insights")] IReadOnlyList<Insight> Insights
	);
}
