using System.Text.Json.Serialization;

namespace CloudToolbox.Services.Data
{
	public record InsightSpellings(
		[property: JsonPropertyName("usa")] string? AmericanEnglish,
		[property: JsonPropertyName("plural")] string? Plural
	);

}
