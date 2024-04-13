namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPublicCollectionRevision
{
	[JsonPropertyName("collectionChangelog")]
	public NexusGraphPublicCollectionChangelog? CollectionChangelog { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("overallRating")]
	public string OverallRating { get; set; }

	[JsonPropertyName("overallRatingCount")]
	public int OverallRatingCount { get; set; }

	[JsonPropertyName("revisionNumber")]
	public int RevisionNumber { get; set; }

	[JsonPropertyName("revisionStatus")]
	public string RevisionStatus { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}