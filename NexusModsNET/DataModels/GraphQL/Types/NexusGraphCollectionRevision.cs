namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionRevision
{
	[JsonPropertyName("adultContent")]
	public bool AdultContent { get; set; }

	[JsonPropertyName("assetsSizeBytes")]
	public long AssetsSizeBytes { get; set; }

	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("collectionChangelog")]
	public NexusGraphCollectionChangelog? CollectionChangelog { get; set; }

	[JsonPropertyName("collectionId")]
	public int CollectionId { get; set; }

	[JsonPropertyName("collectionSchema")]
	public NexusGraphCollectionSchema CollectionSchema { get; set; }

	[JsonPropertyName("collectionSchemaId")]
	public int CollectionSchemaId { get; set; }

	[JsonPropertyName("contentPreviewLink")]
	public string ContentPreviewLink { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("downloadLink")]
	public string DownloadLink { get; set; }

	[JsonPropertyName("externalResources")]
	public NexusGraphExternalResource[] ExternalResources { get; set; }

	[JsonPropertyName("gameVersions")]
	public NexusGraphGameVersion[] GameVersions { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("installationInfo")]
	public string InstallationInfo { get; set; }

	[JsonPropertyName("latest")]
	public bool Latest { get; set; }

	[JsonPropertyName("metadata")]
	public NexusGraphCollectionRevisionMetadata? Metadata { get; set; }

	[JsonPropertyName("modAuthors")]
	public NexusGraphUserConnection ModAuthors { get; set; }

	[JsonPropertyName("modCount")]
	public int ModCount { get; set; }

	[JsonPropertyName("modFiles")]
	public NexusGraphCollectionRevisionMod[] ModFiles { get; set; }

	[JsonPropertyName("overallRating")]
	public string OverallRating { get; set; }

	[JsonPropertyName("overallRatingCount")]
	public int OverallRatingCount { get; set; }

	[JsonPropertyName("retractionReason")]
	public NexusGraphRetractionReason? RetractionReason { get; set; }

	[JsonPropertyName("revisionNumber")]
	public int RevisionNumber { get; set; }

	[JsonPropertyName("revisionStatus")]
	public string RevisionStatus { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("totalDownloads")]
	public int TotalDownloads { get; set; }

	[JsonPropertyName("totalSize")]
	public long TotalSize { get; set; }

	[JsonPropertyName("uniqueDownloads")]
	public int UniqueDownloads { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}