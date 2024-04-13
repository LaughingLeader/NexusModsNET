namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionRevisionMetadata
{
	[JsonPropertyName("downloadedAt")]
	public DateTimeOffset DownloadedAt { get; set; }

	[JsonPropertyName("ratingValue")]
	public NexusGraphRatingOptions? RatingValue { get; set; }
}