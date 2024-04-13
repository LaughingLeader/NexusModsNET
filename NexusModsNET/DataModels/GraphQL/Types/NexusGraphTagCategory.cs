namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphTagCategory
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("tags")]
	public NexusGraphTag[] Tags { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}