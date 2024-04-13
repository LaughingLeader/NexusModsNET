namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModerationReason
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("reason")]
	public string Reason { get; set; }

	[JsonPropertyName("resolution")]
	public string Resolution { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}