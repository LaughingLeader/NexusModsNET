namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphRetractionReason
{
	[JsonPropertyName("collectionRevisionId")]
	public int CollectionRevisionId { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("reason")]
	public string Reason { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}