namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionMetadata
{
	[JsonPropertyName("downloadedAt")]
	public DateTimeOffset DownloadedAt { get; set; }

	[JsonPropertyName("endorsementValue")]
	public int EndorsementValue { get; set; }

	[JsonPropertyName("latestDownloadedRevisionNumber")]
	public int LatestDownloadedRevisionNumber { get; set; }
}