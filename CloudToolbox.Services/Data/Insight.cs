using System.Text.Json.Serialization;

namespace CloudToolbox.Services.Data
{
	public record Insight(
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("lastRevision")] string LastRevision,
		[property: JsonPropertyName("url")] string ExternalUrl,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("spellings")] InsightSpellings? Spellings
	);
}
