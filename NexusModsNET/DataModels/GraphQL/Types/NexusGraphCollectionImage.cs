namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionImage : INexusGraphGloballyIdentifiable, INexusGraphReorderable
{
	[JsonPropertyName("altText")]
	public string AltText { get; set; }

	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("globalId")]
	public string GlobalId { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("imageType")]
	public NexusGraphImageTypes ImageType { get; set; }

	[JsonPropertyName("order")]
	public string Order { get; set; }

	[JsonPropertyName("revision")]
	public NexusGraphCollectionRevision? Revision { get; set; }

	[JsonPropertyName("thumbnailUrl")]
	public string ThumbnailUrl { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }
}