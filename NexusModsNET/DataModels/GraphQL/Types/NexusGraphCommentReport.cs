namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentReport
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("reason")]
	public string Reason { get; set; }

	[JsonPropertyName("reporter")]
	public NexusGraphUser Reporter { get; set; }

	[JsonPropertyName("status")]
	public NexusGraphCommentReportStatus Status { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}