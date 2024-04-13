namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserMonthlyReportEntry
{
	[JsonPropertyName("game")]
	public NexusGraphGame? Game { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("mod")]
	public NexusGraphMod? Mod { get; set; }

	[JsonPropertyName("modCount")]
	public int ModCount { get; set; }

	[JsonPropertyName("modId")]
	public int ModId { get; set; }

	[JsonPropertyName("modValue")]
	public int ModValue { get; set; }

	[JsonPropertyName("month")]
	public int Month { get; set; }

	[JsonPropertyName("ratio")]
	public float Ratio { get; set; }

	[JsonPropertyName("reportId")]
	public int ReportId { get; set; }

	[JsonPropertyName("status")]
	public int Status { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }

	[JsonPropertyName("year")]
	public int Year { get; set; }
}