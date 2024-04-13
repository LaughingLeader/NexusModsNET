namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserMonthlySummaryEntry
{
	[JsonPropertyName("modCount")]
	public int ModCount { get; set; }

	[JsonPropertyName("modValue")]
	public int ModValue { get; set; }

	[JsonPropertyName("month")]
	public int Month { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }

	[JsonPropertyName("year")]
	public int Year { get; set; }
}