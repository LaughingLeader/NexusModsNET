namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPublicCollectionChangelog
{
	[JsonPropertyName("collectionRevisionId")]
	public int CollectionRevisionId { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("revisionNumber")]
	public int RevisionNumber { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}